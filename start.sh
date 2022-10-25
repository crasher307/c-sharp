homePath=`pwd`
# Set project type
while [ -z $projectType ]; do
	clear
	read -p "Is work project (y/n): " isWorkProject
	if   [ $isWorkProject == "y" ]; then projectType="work"
	elif [ $isWorkProject == "n" ]; then projectType="homework"
	fi
done
# Set lesson number
while [ -z $lessonNumber ]; do
	clear
	read -p "Enter lesson number: " lessonNumber
	if [ -z $lessonNumber ]; then clear
	else
		folderLesson="lesson$lessonNumber"
		# Create lesson folder
		while ! [ -d $folderLesson ]; do
			clear
			echo "Folder '$folderLesson' not found" && read -p "Create folder $folderLesson (y/n): " createLesson
			if   [ $createLesson == "y" ]; then sh $homePath/bash/createLesson.sh $homePath $lessonNumber
			elif [ $createLesson == "n" ]; then unset lessonNumber && break
			fi
		done
	fi
done
# Run projects
while true; do
	clear
	read -p "Enter project number: " projectNumber
	if [ -z $projectNumber ]; then clear
	else
		folderProject="$folderLesson/$projectType/pr$projectNumber"
		if ! [ -d $folderProject ]; then
			### CREATE PROJECT ##############
			while ! [ -d $folderProject ]; do
				clear
				echo "Folder '$folderProject' not found" && read -p "Create project $projectNumber (y/n): " createProject
				if   [ $createProject == "y" ]; then sh $homePath/bash/createProject.sh $homePath $lessonNumber $projectType $projectNumber
				elif [ $createProject == "n" ]; then break
				fi
			done
			#################################
		fi
		if [ -d $folderProject ]; then
			### RUN PROJECT #################
			sh $homePath/bash/runProject.sh $homePath $lessonNumber $projectType $projectNumber
			#################################
		fi
	fi
done