#
#Input: gitScript.ps1 C:\Tools\source\path sourceName.sln
#
function gitScript
{
    param{
        [parameter(Mandatory=$true)]
        [String] $path,
        
        [parameter(Mandatory=$true)]
        [String] $name,

        [parameter(Mandatory=$false)]
        [String] $pull = $false
                
    }
    $defaultLocation = "C:\Users\mbednarova\source\repos\UITestingConsole\UITestingConsole"
    if(!(Test-Path $srcPath)){
        throw "Path does not exists"
    }

    #Programový pull, musí být přepnuté na správnou branch
    if($pull){
        Set-Location $path
        Invoke-Expression -Command "git pull"
        if(! $?){
            Write-Host "Pull failed"
        }
    }

    #Programový build
    Set-Location "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7"
    Invoke-Expression -Command "devenv.com $path\$name /Clean"
    if(! $?){
        Write-Host "Something went wrong with cleaning solution"
    }

    Invoke-Expression -Command "devenv.com $path\$name /Build"
    if(! $?){
        throw "Build failed"
    }

    Set-Location $defaultLocation
}
