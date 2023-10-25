#load nuget:?package=Cake.Dungeon&prerelease

Build.SetParameters
(
    title: "GitInfo.Dungeon",

    // defaultLog: true,

    runBuildSolutions: true,
    // runUnitTests: true,
    // runNuGetPack: true,

    sourceDirectory: Build.Directories.Root,

    unitTestProjectPatterns: new[] { "Tests/*.csproj" },
    nuGetProjectPatterns: new[] { "Library/*.csproj" },

    buildEmbedAllSources: true,
    unitTestLoggers: new[] { "console;verbosity=detailed", "junit" }
);

Build.Run();
