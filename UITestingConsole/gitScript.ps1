#
#Input: gitScript.ps1 C:\Tools\source\path sourceName.sln
#
$path = $args[0]
$name = $args[1]
$pull = $args[2]

$defaultLocation = "C:\Users\mbednarova\source\repos\UITestingConsole\UITestingConsole"
if(!(Test-Path $path)){
	throw "Path does not exists"
}

#Programový pull, musí být přepnuté na správnou branch
if($pull -eq $True){
	Set-Location $path
       	Invoke-Expression -Command "git pull"
       	if(! $?){
           	Write-Host "Pull failed"
	}
}

#Programový build
Set-Location "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE"
Invoke-Expression -Command ".\devenv.com $path\$name /Clean"
if(! $?){
        Write-Host "Something went wrong with cleaning solution"
}
Invoke-Expression -Command ".\devenv.com $path\$name /Build"
if(! $?){
	throw "Build failed"
}
#Set-Location $defaultLocation