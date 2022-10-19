
   //Show Char Method
    Console.Write("Please enter Your Message: ");
    string message = Console.ReadLine();


    Console.Write("Please enter the character index you want to see: ");
    int index = int.Parse(Console.ReadLine());
    ShowCharacter(message, index);
    //End of Show Char

    
    CalculateRetail();


    //Celsius Converter

    Console.Write("\n\nPlease enter a temperature in Farenheit: ");
    double farenheit = double.Parse(Console.ReadLine());


    Console.Write("Please enter the number of times you want to iterate the program: ");
    int iterations = int.Parse(Console.ReadLine());


    for (int i = 0; i <= iterations; i++)
    {
        Celsius(farenheit);
        farenheit++;
    }

    //End of Celsius Converter


    //Prime Numbers
    PrimeNumber();


#region Show Character
//Method made to show the character at a specificed length



static void ShowCharacter(String message, int index)
{
    char indexedChar = message[index - 1];
    //subtracts one since the count begins at 0, this lets the counting be natural
    Console.WriteLine($"The message's character at position: {index} is: {indexedChar}");

}
#endregion


#region Retail Price
//Retail price
//Wholesale cost and markup % for retail price.



static void CalculateRetail()
{
    Console.Write("\n\nEnter the wholesale price of the item: ");
    double wholesalePrice = double.Parse(Console.ReadLine());

    Console.Write("Enter the Percent Markup for the item i.e. (100 for 100%): ");
    double markUpPct = double.Parse(Console.ReadLine());
    markUpPct = 1 + (markUpPct / 100);

    double retailPrice = wholesalePrice * markUpPct;
    Console.WriteLine($"The retail price of the item is {Math.Round(retailPrice, 2)}");
}
#endregion


#region Temperature Table



static void Celsius(double farenheit)
{
    // uses 5/9(F-32) to find the C temperature
    //make a loop returning C temps from 80-100 F

    double celsius = (farenheit - 32);
    celsius = Math.Round(celsius * 5 / 9, 2);
    //I don't know why 5/9 doesnt work when its in the declaration part of C, but it is,
    //and for some reason it works perfectly fine in the Rounding stage, whatever...
    Console.WriteLine($"{farenheit}F is {celsius} C");


}
#endregion


#region Prime Numbers
//PRIME NUMBERS (oh boy)
//Write a method that takes ints and returns a True or a False if it is prime



static void PrimeNumber()
{
    Console.WriteLine("\n\nenter an integer greater than or equal to 2");
    int primeTest = int.Parse(Console.ReadLine());
    int flag = 0;
    for (int i = 2; i <= primeTest / 2; i++)
    {
        if (primeTest % i == 0)
        {
            flag = 1; break;
        }
    }
    if (flag == 1)
        Console.WriteLine("False (not prime)");
    else
        Console.WriteLine("True (prime)");
}
#endregion