# Task
![Not So EasySemester](https://github.com/user-attachments/assets/f1d87ae8-03cf-435e-974e-764ac1b8b348)
### Database of a university is stored in a text file. One line of the file consists of the semester, the neptun code of the professor, and how many class hours the professor has spent with teaching in that semester. The file is ordered by semester, and you can suppose that it is not empty.

**A sample file:**
<br> 19/20/2 gfhdjs 10
<br> 20/21/1 gfhdjs 16
<br> 20/21/1 jd63ks 18
<br> 20/21/1 hfls45 12
<br> 20/21/2 gfhdjs 10
<br> 20/21/2 jkdl4k 12
<br> 21/22/1 gfhdjs 12

For grade 3 After the professor with neptun code gfhdjs teaching more than 15 hours in a semester, how many times has he (gfhdjs) taught less than 12 hours? You have to define a method for reading from the file and you have to create an algorithm which is based on the general algorithm of the algorithmic patterns.
<br> **In the sample file, the answer is 1.**

For grade 5: Which was the easiest semester (with the least teaching hours in total)? You have to create a class with methods first(), next(), current(), and end() for enumerating the semesters with their teaching hours in total. Other public methods cannot be created for this class.
<br> **In the sample file the output is 19/20/2.**


Requirements for both levels: You cannot store multiple lines of the file and you can open the file only once.
For grade 5 you have to create a custom enumerator class with operations First, Next,
Current, and End to process the content of the file. All the algorithms have to be algorithmic
pattern-based as it was taught on the labs.
