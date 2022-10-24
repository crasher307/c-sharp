# Установка типа проекта
while [ -z $projectType ]
do

	clear
	read -p "Is work project (y/n): " isWorkProject
	
	if [ $isWorkProject == "y" ]
	then
		projectType="work"
	elif [ $isWorkProject == "n" ]
	then
		projectType="homework"
	fi

done

# Установка номера урока и проекта
while [ -z $lessonNumber ] | [ -z $projectNumber ]
do

	clear
	read -p "Enter \"<lesson number> <project number>\": " lessonNumber projectNumber

done

folderLesson="lesson$lessonNumber"
folderProject="lesson$lessonNumber/$projectType/pr$projectNumber"

# Создание папки с уроком
if ! [ -d $folderLesson ]
then
	while ! [ -d $folderLesson ]
	do

		clear
		echo "Folder '$folderLesson' not found"
		read -p "Create folder $folderLesson (y/n): " createLesson
		if [ $createLesson == "y" ]
		then
			mkdir "$folderLesson" && echo "Create folder '$folderLesson'"
			mkdir "$folderLesson/work" && echo "Create folder '$folderLesson/work'"
			mkdir "$folderLesson/homework" && echo "Create folder '$folderLesson/homework'"
		elif [ $createLesson == "n" ]
		then
			break
		fi

	done
fi

# Создание и настройка папки с проектом
if [ -d $folderLesson ]
then

	clear
	if [ -d $folderProject ]
	then
		echo "Folder '$folderProject' already exists"
	else
		mkdir "$folderProject" && echo "Create folder '$folderProject'"
		cd $folderProject && echo -e "Folder:" `pwd`
		dotnet new console
		printf "using func;\n\nvar rd = new Read();\n\nrd.echo(\"New project created!\");" > Program.cs
		dotnet add reference "../../../func/func.csproj"
		dotnet run
	fi

fi