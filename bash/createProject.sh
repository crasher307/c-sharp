# Создание папки с проектом - "createProject.sh <git_dir> <lesson_number> <work/homework> <project_number>"

#############################################
## !!! Запускать после createLesson.sh !!! ##
#############################################

### Получаемые параметры ####################
home=$1 # Корневая папка `pwd`
lessonNumber=$2 # Номер урока
projectType=$3 # Тип работы
projectNumber=$4 # Номер проекта
### Переменные ##############################
folderLesson="lesson$lessonNumber"
folderProjectType="$folderLesson/$projectType"
folderProject="$folderLesson/$projectType/pr$projectNumber"
#############################################

echo -e "\n--- Create project $projectNumber ---"

if ! [ -d $folderLesson ]; then echo "Folder '$folderLesson/' not exists!" # Проверка существования папки урока
elif ! [ -d $folderProjectType ]; then echo "Folder '$folderProjectType/' not exists!" # Проверка существования папки типа
elif [ -d $folderProject ]; then echo "ERROR: Folder '$folderProject/' already exists!" # Проверка существования папки проекта
else
	mkdir $home/$folderProject && echo "Folder '$folderProject/' created!" # Создание папки проекта
	cd $home/$folderProject
	{
		dotnet new console
		printf "using func;\n\nrw.echo(\"New project created!\");" > Program.cs
		dotnet add reference "../../../func/func.csproj"
	} &> create.log && rm create.log
	# dotnet run
fi