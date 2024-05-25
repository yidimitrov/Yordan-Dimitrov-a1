Task 1. To write a console application - an invoice calculator.
Input parameters: monthly fee, number of SMS sent, number of MMS sent, minutes to 
A1 outside the included in the package, minutes to Telenor outside the included in the package, minutes to 
Vivacom outside the included in the package, minutes in roaming, MB used in the country outside 
included in the package used MB in the EU outside included in the package used MB outside the EU 
other than included in the package, other fees, discounts.
The total amount due S is calculated according to the following rules:
 the monthly fee is added
 the number of SMS multiplied by the fee for one SMS is added. If the text messages sent are more
less than 50, each is charged BGN 0.18 if they are between 50 and 100 - BGN 0.16 if they are over 100 - 
BGN 0.11 each
 the number of MMCs multiplied by the fee for one MMC is added. If the MMS messages sent are more
less than 50, each is charged BGN 0.25 if they are between 50 and 100 - BGN 0.23 if they are over 100 - 
BGN 0.18 each
 the minutes outside those included in the package are added multiplied by their fee, such as:
o minutes to A1 are charged at BGN 0.03.
o minutes to other operators are charged at BGN 0.09.
o Roaming minutes are charged at BGN 0.15
 MBs used beyond those included in the package are added multiplied by their fee, such as:
o MBs in the country are charged BGN 0.02.
o MBs in the EU are charged at BGN 0.05.
o MBs outside the EU are charged BGN 0.20.
 other fees are added
 discounts are deducted
Example:
 monthly fee: 9.99
 number of sent SMS: 2
 number of MMS sent: 0
 minutes to A1 other than those included in the package: 15
 minutes to Telenor other than those included in the package: 6
 minutes to Vivacom other than those included in the package: 32
 Roaming minutes: 0
 MBs used in the country other than those included in the package: 0
 MBs used in the EU other than those included in the package: 0
 MBs used outside the EU other than those included in the package: 0
 other fees: 1.99
 discounts: 1.50
 Result: 14.71

Task 2. To write a console application that pours the data from the oers.csv file to 
are inserted into a database in a table with the same name and columns

 Task 3. You need to implement code that simulates a zoo. 
  The zoo contains animals. The animals in the zoo are of 3 different species: 
 monkeys, lions, elephants.    Each animal has a health value (health points), 
 represented by points ranging from 0 to 100.
  There must be a method that simulates the "starvation" of animals.    Hunger decreases 
 animal health.    When this method is called, for each animal in the zoo it 
 generates a random value between 0 and 20 that is used to reduce health  
 of this animal.
  There must be a method to simulate animal feeding.   When this one is called 
 method, a random value between 5 and 25 is generated for each of the three types. Then 
 The health of each animal in the zoo is increased by the value generated for it 
 species.
  Each species has a specific death condition. The monkey dies when its health 
 points fall below 40. The lion dies when its health points drop below 50. The elephant does not 
 can walk until he has less than 70 health. If the elephant cannot walk, 
 when his health needs to be reduced (no matter how much), he dies.
  There should be a method that returns the number of animals still alive in the zoo.
  The zoo starts with 5 animals for each species.    Each animal starts with 100 points for 
 health.
