# bluefragments-challenge-100

This repos contain a series of level 100 challenges.

To solve one or more challenges, you need to fork the repos to your own GitHub repos, solve the challenges of your preferences and invite https://github.com/blue-challenge-master to the repos.

The challenges should be solved in a language of your preference but either C#, Python or JavaScript is preferred.

If you have any questions or need any help with the challenges, don't hesitate to reach out to challenge@bluefragments.com.

## challenge-101

Create a function that takes an array of numbers and return both the minimum and maximum numbers, in that order.

Examples:  
FindMinMax([1, 2, 3, 4, 5]) ➞ [1, 5]  
FindMinMax([2334454, 5]) ➞ [5, 2334454]  
FindMinMax([1]) ➞ [1, 1]  

## challenge-102

Create a function that accepts a string of a person's first and last name and returns a string with the first and last name swapped.

Examples:  
NameShuffle("Donald Trump") ➞ "Trump Donald"  
NameShuffle("Rosie O'Donnell") ➞ "O'Donnell Rosie"  
NameShuffle("Seymour Butts") ➞ "Butts Seymour"  

## challenge-103

Create a function that returns true if an input string contains only uppercase or only lowercase letters.

Examples:  
SameCase("hello") ➞ true  
SameCase("HELLO") ➞ true  
SameCase("Hello") ➞ false  
SameCase("ketcHUp") ➞ false  

## challenge-104

An isogram is a word that has no duplicate letters. Create a function that takes a string and returns either true or false depending on whether or not it's an "isogram".

Examples:  
IsIsogram("Algorism") ➞ true  
IsIsogram("PasSword") ➞ false  
// Not case sensitive.  
IsIsogram("Consecutive") ➞ false  

## challenge-105

Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string. For example, if you're given 3 as input, your function should return "March", because March is the 3rd month.

Examples:  
MonthName(3) ➞ "March"  
MonthName(12) ➞ "December"   
MonthName(6) ➞ "June"  

## challenge-106

Create a function that takes a string and replaces each letter with its appropriate position in the alphabet. "a" is 1, "b" is 2, "c" is 3, etc, etc.

Examples:  
AlphabetIndex("Wow, does that work?") ➞ "23 15 23 4 15 5 19 20 8 1 20 23 15 18 11"  
AlphabetIndex("The river stole the gods.") ➞ "20 8 5 18 9 22 5 18 19 20 15 12 5 20 8 5 7 15 4 19"  
AlphabetIndex("We have a lot of rain in June.") ➞ "23 5 8 1 22 5 1 12 15 20 15 6 18 1 9 14 9 14 10 21 14 5"  