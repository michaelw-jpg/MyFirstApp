//Namn : Michael Wortel, Klass: .Net 2024 

namespace MyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 7;
            
            //checking for the value in the variable number, IF number is higher then 10 it will run the if statement
            if (number > 10)
                Console.WriteLine("Talet är stort");
            // as long as number isent higher then 10 the program will execute the else statement
            else
                Console.WriteLine("Oj.Lågt tal!");

            // asking user for his name which will be stored in the string variable name after which we return the variable
            // with "Hej name!
            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();
            Console.WriteLine("Hej " + name + "!");

            // a loop that compares the variable i with number as long as i is less or equal then number it will loop
            // this means that our last loop will be when i equals number
            //note that we add 1 to i every loop by writing i++ we do this directly in the for statement.
            //by doing it this way we can reduce our code inside the loop to 1 row. which also means we do not have to add a {}
            //inside our loop, if we can keep our code to 1 row inside a statement IF/else/for we do not have to add a {}
           
            
            for (int i = 0; i <= number; i++)
                Console.WriteLine(i);

        }
    }
}
