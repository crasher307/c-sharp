homePath=`pwd`
projectType="homework"
lessonNumber=$1
projectNumber=$2

folderProject="lesson$lessonNumber/$projectType/pr$projectNumber"

# Run work projects
clear
if ! [ -d $folderProject ]; then
	echo "Folder '$folderProject' not found"
	break
else
	### RUN PROJECT #################
	sh $homePath/bash/runProject.sh $homePath $lessonNumber $projectType $projectNumber
	#################################
fi