# Запуск проекта - "runProject.sh <git_dir> <lesson_number> <work/homework> <project_number>"

#############################################
### !!! Запускать после runProject.sh !!! ###
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

folderFunc="func"
#############################################

if ! [ -d $folderLesson ]; then echo "Folder '$folderLesson/' not exists!" # Проверка существования папки урока
elif ! [ -d $folderProjectType ]; then echo "Folder '$folderProjectType/' not exists!" # Проверка существования папки типа
elif ! [ -d $folderProject ]; then echo "Folder '$folderProject/' not exists!" # Проверка существования папки проекта
else
	echo -e "\n--- Build functions ---"
	cd $home/$folderFunc && dotnet build

	echo -e "\n\n\033[46m Lesson $lessonNumber - $projectType - $projectNumber $ \033[0m\n" # Start project
	cd $home/$folderProject && dotnet run
	echo -e "\033[32m" && read -s -n 1 -p "Press any key to continue ..." && echo -e "\033[0m" # Stop project
fi