# runProject.sh <homePath> <lessonNumber> <projectType: "work"|"homework"> <projectNumber>

fp="$1/lesson$2/$3/pr$4"
ff="$1/func"

if [ -d $fp ] & [ -d $ff ]; then
	cd $ff && dotnet build && clear
	echo -e "\033[32m[ --------------------- START --------------------- ] \033[33m($3, lesson $2, project $4)\033[0m\n"
	cd $fp && dotnet run
	echo -e "\n\033[31m[ ---------------------- END ---------------------- ]\033[0m"
	read -s -n 1 -p "Press any key to continue ..."
else
	echo "ERROR: Project $4 not started!"
fi

# color    | bg
# \033[30m | \033[40m - black
# \033[31m | \033[41m - red
# \033[32m | \033[42m - green
# \033[33m | \033[43m - yellow
# \033[34m | \033[44m - blue
# \033[35m | \033[45m - purple
# \033[36m | \033[46m - white-blue
# \033[37m | \033[47m - gray
# \033[0m - clear