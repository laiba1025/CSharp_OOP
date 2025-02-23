For Grade 3 
Long time ago in a galaxy far-far away there was a war between the Galactic Empire and the Separatists. The goal is to simulate the battles between these two forces. 

<br>We can create battles with the place (planet name), an attacker ship, and a defender ship. We also register the party of the attacker. Later, other ships may join the battle. We can initiate the battle where every attacker attacks an alive defender, then the defenders do a counterattack. We can get the result of a battle. A battle is won by a party if every enemy is destroyed. We also return the number of alive ships from a given party. The number of total destroyed ships can be calculated, too. 

<br>When a ship wants to join a battle, it has to be checked if there is enough space for that ship at the battle’s place. For every planet, a maximum capacity is given which cannot be overnumbered by any party. 

<br>Each ship has a damage, a shield, and an armor value. The ship is alive as long as it’s armor value is greater than zero. When a ship attacks another one, it decreases the attacked ship’s shield first. If the shield is less than the attacker’s damage value, the remaining is substracted from the attacked ship’s armor. There are 3 types of ships: Corvette, Star cruiser, and Star destroyer. If a Corvette attacks 
a Star destroyer, its damage value is three times greater. If a Star cruiser attacks a Corvette, its damage value is twice greater. The Star destroyer has a reactor power value which boosts its damage value. If it attacks a Star cruiser, its damage value is even more: twice greater. 

<br>An UML class diagram is given, which solves the given task, implement it! The diagram is attached in vector graphic format, too. Note that this plan does not satisfy the SOLID principles of OOP. 

![image](https://github.com/user-attachments/assets/abcf6aed-5bfd-4704-a2f8-f98d5815f606)
