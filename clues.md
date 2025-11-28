# Clues

There are two dimensions to this problem. 

Firstly how to rank a particular hand (“Flush” or “Two Pairs” etc).

Secondly how to compare hands and determine which will win. 

A very easy way to get going with this Kata is just to concentrate on the first dimension, and write lots of code that can successfully assign a rank to all the different kinds of hand.

 This is all well and good, but I think you’ll find some refactoring in order when you come to tackle the second dimension. My recommendation is to write just enough code to identify one or two ranks, then start working on comparing hands. You can fill in the details of all the different ranks when you have a basic structure that can both rank and compare hands.

One interesting aspect of this Kata is the OO design that you come up with. What classes do you need? What responsibilities do they have? Have you removed all duplication?
Another interesting aspect which you may or may not want to go into, is how you express the rules of Poker.