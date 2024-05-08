// Starter Code from Starter Modules
using System;

public class Program
{
    static void Main(string[] args)
    {
        // Intro Message to be displayed on the applications start
        Console.WriteLine("This is a restock tool!");
        // Inventory Variables for the stock of each item and the value that will trigger a restock
        //Declares the soda stock variable and sets the item equal to 100
        int sodaStock = 100;
        //Declares the soda restock variable and sets the item equal to 40
        int sodaReStock = 40;
        //Declares the chip stock variable and sets the item equal to 40
        int chipStock = 40;
        //Declares the chip restock variable and sets the item equal to 20
        int chipReStock = 20;
        //Declares the candy stock variable and sets the item equal to 60
        int candyStock = 60;
        //Declares the candy restock variable and sets the item equal to 40
        int candyReStock = 40;

        //runs the ProcessItem method for each item
        //calls the Inventory variables and runs the ProcessItem method on them using the values entered by the user and the values for "Starting Inventory" and Restock Value
        sodaStock = ProcessItem("Soda", sodaStock, sodaReStock);
        chipStock = ProcessItem("Chips", chipStock, chipReStock);
        candyStock = ProcessItem("Candy", candyStock, candyReStock);

        // Message to be displayed to the user after entering the ending inventory for each item
        Console.WriteLine("Thanks for telling me the ending inventory");

        //runs the CheckRestock method for each item
        //CheckRestock method on them using the values entered by the user and the values for "Starting Inventory" and Restock Value and alerts the user if they need to restock
        CheckRestock("Soda", sodaStock, sodaReStock);
        CheckRestock("Chips", chipStock, chipReStock);
        CheckRestock("Candy", candyStock, candyReStock);

        //Message to be displayed to the user after all inventory has been checked
        Console.WriteLine("Please restock all inventory (if needed) and run me again tomorrow!");

    }
    // Method to process the item, collects user input of the ending inventory
    //Method is similar to a JavScript funtion, it takes in the item name, current stock, and restock amount and performs actions on them
    //This sends the method the information declared in the Main method and then runs the code within the method ex. itemanem = "Soda", currentStock = 100, restockAmount = 40 in which the methos will then run the code within the method
    static int ProcessItem(string itemName, int currentStock, int restockAmount)
    {
        Console.WriteLine($"How Many {itemName} have you sold today? {currentStock} are in stock today");
        //Declares the "Sold" variable and sets it equal to the value entered by the user
        int sold = int.Parse(Console.ReadLine());
        //Checks if the value entered by the user is greater than the current stock - this is to prevent an error or "negative" stock value which is not possible in inventory situations
        if (sold > currentStock)
        {
            //Message to be displayed to the user if the value entered is greater than the current stock
            Console.WriteLine("You can't sell more than you have in stock!");  
        }
        else
        {
            //takes the current stock and subtracts the amount sold to alert the user of how many are remaining in stock
             currentStock -= sold;
            //Message to be displayed to the user of the remaining stock
            Console.WriteLine($"There are {currentStock} remaining in stock");
        }
        //returns the current stock value to the main method be used in the CheckRestock method
        return currentStock;
    }
    // Method to check the restock, takes the ending inventory entered by the users and checks the value against the restock value and alerts them of restock
    //Method is similar to a JavScript funtion, it takes in the item name, current stock, and restock amount and performs actions on them
    //This sends the method the information declared in the Main method and then runs the code within the method ex. itemanem = "Soda", currentStock = 100, restockAmount = 40 in which the methos will then run the code within the method
    static int CheckRestock(string itemName, int currentStock, int restockAmount)
    {
        //Checks if the current stock is less than or equal to the restock amount
        if (currentStock <= restockAmount)
        {
            //Message to be displayed to the user if the current stock is less than or equal to the restock amount
            Console.WriteLine($"You need to restock {itemName}");
        }
        //returns the current stock value to the main method to be used in other methods
        return currentStock;
    }
}