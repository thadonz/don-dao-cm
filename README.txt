Running the Build scripts

Dependencies
Both the bash and Powershell scripts require dotnet Core CLI to run successfully.


bash
./BuildAndTest.sh [-c]

-c {Debug|Release}
Defines the build configuration. The default value is Debug.


Powershell
./BuildAndTest.ps1 [<Debug|Release>]
The first parameter defines the build configuration. The default value is Debug.