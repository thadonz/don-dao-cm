param([string]$config="Debug")

if(!(Get-Command dotnet)) {
	"Cannot run dotnet cli... aborting"
	exit
}

"=====Using $config configuration====="

"=====Building solution====="
&dotnet build -c $config ./DonDaoTest.sln
$result = $?

if(!($result)) {
	"Build failed... aborting"
	exit
}

"=====Running Tests====="
&dotnet test -c $config ./DonDaoTest.sln
