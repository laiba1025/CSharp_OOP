### Grade 3
A parliament has a lot of congressmen. The task of the congressmen is to vote for or against draft laws. A draft law can be of 3 types: normal, cardinal, or constitutional. There are different rules to accept these draft laws. After voting, decide which laws are accepted and print their ID to the console!
![image](https://github.com/user-attachments/assets/96aafde8-5d7c-4d9e-b52d-e9a8f498dde1)

#### Input: 
The first line stores the names of the congressmen 
firstName lastName firstName lastName … 
Below that come the draft laws (one law in each line) in the following form 
type ID date votes 
the votes means equal number of votes to the number of congressmen. The abstain means that the congressman has not voted and it does not count into the final result. 
#### Sample input: 
John Smith Jane Smith Damien Stayne Johannes Hartl 
<br> Normal NORM12 2022.01.34 abst abst yes abst 
<br> Constitutional ABC123 2022.02.01 yes yes no yes 
<br> Cardinal ABC124 2022.02.02 yes abst no yes 
<br> Constitutional ABC234 2022.02.05 yes abst yes no 
#### Explanation: 
The 3rd draft law is a cardinal law with ID ABC124 and date 2022.02.01, where Mr. Smith and Mr. Hartl have voted for it, Mr. Stayne has voted against, and Miss Smith has not voted.  
#### Output: 
The valid laws’ ID has to be printed out with whitespace at the end. If there is not any valid law, the none word has to be printed. 
#### Sample output: 
NORM12 ABC123 
