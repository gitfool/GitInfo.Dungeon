for ($i = 1; $i –le 10; $i++)
{
    Write-Output "`n**************************************************"
    Write-Output "Build #$i"
    Get-ChildItem -Path . -File -Include *GitHead.cache,*GitInfo.cache,*GitIsDirty.cache -Recurse | Remove-Item -Force -Verbose
    dotnet build-server shutdown
    dotnet tool restore && dotnet cake --verbosity=verbose
    if ($LASTEXITCODE -ne 0)
    {
        exit $LASTEXITCODE
    }
}
