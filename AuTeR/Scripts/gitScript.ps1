$path = $args[0]
$name = $args[1]
$pull = $args[2]

if(!(Test-Path $path)){
	throw "Path does not exists"
}

#Programovy pull, musi­ byt prepnuto na spravnou branch
if($pull -eq $True){
	Set-Location $path
       	$output3 = Invoke-Expression -Command "git pull" 2>&1
       	if($output3 -match 'failed'){
           	throw "Pull failed"
	}
}

#ProgramovÃ½ build
Set-Location "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE"
$output1 = Invoke-Expression -Command ".\devenv.com $path\$name /Clean" 2>&1

if($output1 -match '0 failed'){
    Write-Host $output1   
}else{
    throw "Clean failed"
}

$output2 = Invoke-Expression -Command ".\devenv.com $path\$name /Build" 2>&1
if($output2 -match '0 failed'){
	Write-Host $output2
}else{
    throw "Build failed"
}