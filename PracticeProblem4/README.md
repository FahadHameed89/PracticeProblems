# PracticeProblem4
Write a program that will take in a 4 digit integer and calculate the sum of its digits without ever converting the integer to a string.

# Status

Solved. 

# Q. Write a program that will take in a 4 digit integer and calculate the sum of its digits without ever converting the integer to a string.
- To solve, need to collect 4 digit integer in a integer and then divide by 10 and add the remainder to a new variable called totalSum. 
- Repeat the divide by 10 function 3 times in total, adding the remainder each time. 
- Ex. Integer 5438 -> Divide by 10 = 543 Remainder 8 -> Store remainder to totalSum variable (8) 
- 543 -> Divide by 10 = 54 Remainder 3 -> Store remainder to totalSum variable (11)
- 54 -> Divide by 10 = 5 Remainder 4 -> Store remainder to totalSum variable (15)
- 5 -> Divide by 10 = 0 Remainder 5 -> Store remainder to totalSum variable (20)
- This solution should work for any number of integers, but how to make it 4 digits only?
