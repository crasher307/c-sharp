### Переменные ##############################
home=`pwd`
#############################################

# Установка типа проекта
while [ -z $projectType ]; do
	clear
	read -p "Is work project (y/n): " isWorkProject
	if   [ $isWorkProject == "y" ]; then projectType="work"
	elif [ $isWorkProject == "n" ]; then projectType="homework"
	fi
done

# Установка номера урока
while [ -z $lessonNumber ]; do
	clear
	read -p "Enter lesson number: " lessonNumber
	if [ -z $lessonNumber ]; then clear
	else

		folderLesson="lesson$lessonNumber"
		# Создание папки с уроком
		while ! [ -d $folderLesson ]; do
			clear
			echo "Folder '$folderLesson' not found" && read -p "Create folder $folderLesson (y/n): " createLesson
			if   [ $createLesson == "y" ]; then sh $home/bash/createLesson.sh $home $lessonNumber
			elif [ $createLesson == "n" ]; then unset lessonNumber && break
			fi
		done

	fi
done

#############################################
while true; do
	clear
	read -p "Enter project number: " projectNumber
	if [ -z $projectNumber ]; then clear
	else

		folderProject="$folderLesson/$projectType/pr$projectNumber"
		if ! [ -d $folderProject ]; then
		### CREATE PROJECT ##################
			# Создание и настройка папки с проектом
			while ! [ -d $folderProject ]; do
				clear
				echo "Folder '$folderProject' not found" && read -p "Create project $projectNumber (y/n): " createProject
				if   [ $createProject == "y" ]; then sh $home/bash/createProject.sh $home $lessonNumber $projectType $projectNumber
				elif [ $createProject == "n" ]; then break
				fi
			done
		#####################################
		fi
		if [ -d $folderProject ]; then
			# Запуск проекта
			sh $home/bash/runProject.sh $home $lessonNumber $projectType $projectNumber
		fi

	fi
done
#############################################

# Текст    | Фон      | Цвет
# \033[30m | \033[40m - black
# \033[31m | \033[41m - red
# \033[32m | \033[42m - green
# \033[33m | \033[43m - yellow
# \033[34m | \033[44m - blue
# \033[35m | \033[45m - purple
# \033[36m | \033[46m - white-blue
# \033[37m | \033[47m - gray
# \033[0m - сбросить