#### For Grade 5 
Model a race of Spartan Race Hungary. The task for grade 3 is extended: there are competitors who can register for the race. A competitor has an ID, a name, and a gender. The race results stored differently: not only the competitor ID is stored, but a reference to the concrete competitor. Only those competitors can participate in the race and have race results who have previously registered for the race. It is possible that a registered competitor does not have any result because of injury or sickness. The new and modified questions to answer: 
1. Define the winner of a category for a given gender. 
2. Decide if a competitor has won in a given category in his/her gender. 
An UML class diagram is given, which solves the given task, implement it! The diagram is attached in vector graphic format, too. Note that this plan does not satisfy the SOLID principles of OOP.

![image](https://github.com/user-attachments/assets/b62763f6-7909-4ec2-9ee4-38e17d80f8e7)

Parts to modify: Competitor class and its relations, Competition class’s Register(), Score(), and Winner() methods, Result class’s constructor and Comp() getter. 

