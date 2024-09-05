using System;

class Alburan_Lab_Exer1
{
    static void Main()
    {
        // for the uniqueness lang po kaya may greeting
        Console.WriteLine(" Hello! Welcome to Apol's Store ");
        Console.WriteLine();


        Console.Write("Enter the number of apples you want to purchase: "); // user inputted kung ilan yung apples na bibilhin
        string inputapple = Console.ReadLine(); // yung user inputted bale ire-read siya as string
        int numapple = Convert.ToInt32(inputapple); // then dito naman yung kanina na user inputted kinonvert siya into integer kasi bawal naman yung isa't kalahating apple lang yung bibilhin

        
        double price = 32.50;  // so ayun nga po, nag assume na 32.50 pesos ang price ng per piece ng apple and ginawang double para ma-include yung .50 niya kasi kung integer nilagay magiging 32 lang babasahin

        double total = numapple * price; // dito sa part na 'to, yung calculation ng kung magkano yung magiging total ng pinamili ng customer

        
        int convertPrice = (int)total; // dito naman kinonvert ang total price into integer para walang butal dun sa converted price

        // print out ng price at converted price
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"The total price of {numapple} apples is {total:F2}.");
        Console.WriteLine();
        Console.WriteLine($"The value of the converted price is {convertPrice}.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Thank you for purchasing! Please come again.");
    }
}
