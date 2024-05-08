# Grand Circus Deliverable 1 Task - Restock App

## Description

Write a program that asks how many items have been purchased and determines if each item needs to be restocked. Ask the user how many of each item has been purchased, calculate the remaining stock, and then print whether or not it needs to be restocked.

## Requirements

Soda starts with 100 in stock and will need a restock at 40
Chips starts with 40 in stock and will need a restock at 20
Candy starts with 60 in stock and will need a restock at 40
Each item should have a variable that holds its current stock value and a variable that holds the restock value.
First, ask the user, “How many sodas have been sold today? 100 in stock” Expect the user to enter a number. You’ll need to parse the input and store it in a number variable.
You can now calculate the remaining stock of Soda. If the user enters a number higher than is in that item’s stock, tell the user that is “Too high” and don’t adjust the stock. Print out the remaining stock. Repeat these steps for each of the items in the store until you have gone through all items. 

Now that all of the items have their remaining stock figured out, figure out whether each item needs a restock.  If the remaining stock is less than or equal to the restock value print out which item needs to be restocked. Repeat this process until all items have been checked.

## Example Output

Welcome to the restocking tool.

How many Sodas have been sold today? 100 are in stock
> 50
There are 50 Sodas left

How many Chips have been sold today? 40 are in stock
> 30
There are 10 Chips left

How many Candy have been sold today? 60 are in stock
> 90
That value is too high. Stock not adjusted


Thank you for filling out the values. Here’s what needs to be restocked.
Chips needs to be restocked

Goodbye!


## Grading Criteria

Each item has a stock variable and a restock variable (6 total variables)
Each items stock is successfully displayed in the console
Ask the user to input a number and use that number to adjust soda’s stock. Assume the user will type a valid number.
Ask the user to input a number and use that number to adjust chip’s stock. Assume the user will type a valid number.
Ask the user to input a number and use that number to adjust candy’s stock. Assume the user will type a valid number.
If the user enters a number higher than the current item’s stock, don’t adjust the stock number.
After each input, the remaining stock of the current item is displayed
Each if statement associated with restocked checks if stock is less than or equal to restock
All restock conditions run independently of each other.
Items that need to be restocked display on the console.
