$src_path = $args[0]
$result = Test-Path $src_path
if($result -eq $false){
    throw "Project does not exists"
}
Set-Location $src_path
git pull 