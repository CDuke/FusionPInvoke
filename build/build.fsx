#r @"../tools/FAKE/tools/FakeLib.dll"
open Fake
open System.Xml

// Properties
let buildDir = "./bin/"

// files
let slnReferences = !!"./src/FusionPInvoke.sln"
let nuspecFile = "./src/FusionPInvoke.nuspec"

// Targets
Target "Clean" (fun _ ->
    CleanDir buildDir
)

Target "RestorePackages" (fun _ ->
    !! "./**/packages.config"
    |> Seq.iter (fun id -> (RestorePackage (fun p -> {p with OutputPath = "./lib"}) id))
)

Target "BuildApp" (fun _ ->
    slnReferences
        |> MSBuildRelease  buildDir "Build"
        |> Log "AppBuild-Output: "
)

Target "CreatePackage" (fun _ ->
    let properties = ReadFileAsString nuspecFile |> getNuspecProperties
    NuGet (fun p -> 
        {p with
            Version = properties.Version
            OutputPath = buildDir
            WorkingDir = buildDir})
            nuspecFile
)

Target "All" DoNothing


// Dependencies
"Clean"
    ==> "RestorePackages"
    ==> "BuildApp"
    ==>  "CreatePackage"
    ==> "All"

// start build
RunTargetOrDefault "All"