# Создание папки с уроком - "createLesson.sh <git_dir> <lesson_number>"

### Получаемые параметры ####################
home=$1 # Корневая папка `pwd`
lessonNumber=$2 # Номер урока
### Переменные ##############################
folderLesson="lesson$lessonNumber"
folderLessonWork="$folderLesson/work"
folderLessonHome="$folderLesson/homework"
#############################################

echo -e "\n--- Create lesson $lessonNumber ---"

! [ -d $folderLesson ] && mkdir $home/$folderLesson && echo "Folder '$folderLesson/' created!" # Создание папки урока
! [ -d $folderLessonWork ] && mkdir $home/$folderLessonWork && echo "Folder '$folderLessonWork/' created!" # Создание папки с работами во время семинара
! [ -d $folderLessonHome ] && mkdir $home/$folderLessonHome && echo "Folder '$folderLessonHome/' created!" # Создание папки с домашними работами