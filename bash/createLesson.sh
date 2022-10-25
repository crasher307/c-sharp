# createLesson.sh <homePath> <lessonNumber>

fl="$1/lesson$2"
flw="$fl/work"
flh="$fl/homework"

if ! [ -d $fl ]; then
	mkdir $fl
	! [ -d $flw ] && mkdir $flw
	! [ -d $flh ] && mkdir $flh
fi

if [ -d $flw ] & [ -d $flh ]; then
	echo "Lesson $2 created!"
else
	echo "ERROR: Lesson $2 not created!"
fi