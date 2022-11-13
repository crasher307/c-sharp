# createProject.sh <homePath> <lessonNumber> <projectType: "work"|"homework"> <projectNumber>

ft="$1/lesson$2/$3"
fp="$ft/pr$4"

if [ -d $ft ] & ! [ -d $fp ]; then
	mkdir $fp && cd $fp
	{
		dotnet new console
		printf "using func;\n\n// Задача #\n\n// -------------------------------------------------------------------\n\nrw.echo(\"New project created!\");\n\n// -------------------------------------------------------------------" > Program.cs
		dotnet add reference "../../../func/func.csproj"
	} &> create.log && rm create.log
	echo "Project $4 created!"
else
	echo "ERROR: Project $4 not created!"
fi