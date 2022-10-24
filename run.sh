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

folderDefault=`pwd`
folderFunc="$folderDefault/func"
folderProject="$folderDefault/lesson$lessonNumber/$projectType/pr$projectNumber"

clear
# Запуск проекта
if ! [ -d $folderProject ]
then

	echo "Folder '$folderProject' not exists"

else

	cd $folderFunc && echo -e "Folder:" `pwd`
	echo "--- Build functions ---"
	clear && dotnet build

	cd $folderProject && echo -e "Folder:" `pwd`
	echo "--- Run project ---"
	clear && dotnet run

fi