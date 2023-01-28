# Hello Dear
### Here you will find some notes about how to work with:
* Git ~~(maybe GitHub later)~~
* Markdown

## Git
1. First of all you need to add folder to traceable by command **_git init_**
2. Lets add current file to Git by **_Ctrl+S_** (or autosave) and by **_git add ..._** command ( where ... name of your file). It is useful to use **_TAB_** button to rapid fill name of the file needed
3. After you should use command **_git commit -m"your comment"_** to be able to set comment to your point - to your **commit**. *Here you may add any comment to current version - current commit*. **_"-m"_** - just a flag _*"message"*_
4. To check if you initiate tracing launch command  **_git status_** to see files/folder under monitoring
5. To see your versions (commits) launch command  **_git log_**
6. By command  **_git checkout ####_**, whrer #### first four numbers of the needed commit *(needed version of the file)*
7. To go back to main version launch command  **_git checkout master_**
8. To see difference between versions you may launch command **_git diff_** to difference vs previous or **_git diff ####1 ####2_**, where **_####1 and  ####2_** numbers of commits