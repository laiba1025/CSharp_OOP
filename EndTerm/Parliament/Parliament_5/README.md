### Grade 5
Extend the solution with the following things: 
##### Excellent 
a) Create a method which calculates how many congressmen have abstained al least twice. 
<br> b) The parliament rejects those draft laws that has all the votes but are invalid. Create a method which deletes the rejected draft laws. 
<br> c) The congressmen can enter and leave any party. Create the necessary methods based on the plan. 
<br> Decide if there was any draft law for which every member of a given party has abstained. Consider only those parties which have at least one member.   
The plan:

![image](https://github.com/user-attachments/assets/6313c077-03bd-4035-99d9-ce97f816fc4b)

https://drive.google.com/file/d/1YKgBW7GYZkhKp0ttsRj3V1DY_msz4ud8/view

#### Input: 
The first line stores the name of the congressmen. 
<br> The second line stores the name of the parties. 
<br> The third line has the info which congressmen have entered which party. 
<br> The fourth line has the info which congressmen have left their party. 
<br>   Finally, the draft laws come the same way as in the satisfactory task. 
#### Sample input: 
John Smith Jane Smith Damien Stayne Johannes Hartl 
<br> Reds Blues 
<br> Johannes Hartl Blues Damien Stayne Blues John Smith Reds 
<br> John Smith 
<br> Normal NORM12 2022.01.34 abst abst yes abst 
<br> Constitutional ABC123 2022.02.01 yes yes no yes 
<br> Cardinal ABC124 2022.02.02 yes abst no yes 
<br> Constitutional ABC234 2022.02.05 yes abst yes no 
<br> Normal NORM13 2022.03.01 no no no no 
#### Output: 
First line of the output should contain the IDs of the valid laws with whitespace at the end, or the none word. 
<br> The 2nd line should contain the answer of question a) after doing the voting. 
<br> The 3rd line should contain the answer of question b) with whitespace at the end after running the Reject() method. If there is no valid law left, the none word should be printed. 
<br> The 4th line should contain the answer for question d) (yes/no) 
#### Sample output: 
NORM12 ABC123  
1 
<br> NORM12 ABC123 ABC124 ABC234 
<br> no
