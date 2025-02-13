### Tourist EXCELLENT
A tourist guide may be working at each wonder. Depending on his talkativeness, the expected time spent at the wonder is modified. 
Answer the following questions in addition: 
1. How many cathedrals are there in a district? 
2. Give the district where the most time may be spent. 
3. Does every district have a cathedral?
![image](https://github.com/user-attachments/assets/811c7a69-922d-4c6d-9873-6c9935fba2dd)

The program should write out the answer for the 2nd and 3rd questions after the answers of the satisfactory level, but in a new line. The structure of the file is the same, there is a slight difference in the data of the wonders only:
<br>districtName wonderCount 
<br>type coordX coordY interestLevel yearOfBuild n 
<br>type coordX coordY interestLevel yearOfBuild y guideName guideTalkativeness 
<br>…

The initial data means the same as in the satisfactory level. Afterwards, for each wonder, if there is an ‘n’ character, it means that there is not any guide for that wonder. If there is a ‘y’ character, it means that there is a guide whose attributes are stored in the guideName and guideTalkativeness values.
