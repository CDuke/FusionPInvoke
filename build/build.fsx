#r @"../tools/FAKE/tools/FakeLib.dll"
open Fake
open System.Xml

// Properties
let buildDir = "./bin/"
let packageBuildDir = "./nuget_bin"

// files
let slnReferences = !!"./src/FusionPInvoke.sln"

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
// Copy all the package files into a package folder
    //CopyFiles packagingDir allPackageFiles

    NuGet (fun p -> 
        {p with
            OutputPath = buildDir
            WorkingDir = buildDir})
            "./src/FusionPInvoke.nuspec"
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