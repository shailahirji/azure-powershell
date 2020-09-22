$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Expand-AzWvdExtractMsixImage.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Expand-AzWvdExtractMsixImage' { 
    
    It 'Expand' {
        $extract = Expand-AzWvdExtractMsixImage -HostPoolName ryannis-hp 
        -ResourceGroupName ryannis-ukwest 
        -SubscriptionId 292d7caa-a878-4de8-b774-689097666272 
        -Uri 'C:\msix\singlemsix.vhd'
        $extract.PackageAlias | Should -Be 'msixtestname' `
        $extract.ImagePath | Should -Be 'C:\\msix\\singlemsix.vhd' `
        $extract.PackageName | Should -Be 'MsixTest_Name' `
        $extract.PackageFamilyName | Should -Be 'MsixTest_FamilyName' `
        $extract.PackageFullName | Should -Be 'MsixTest_FullName' `
        $extract.DisplayName | Should -Be null `
        $extract.PackageRelativePath | Should -Be 'MsixTest_RelativePackageRoot' `

    }
}
