namespace MathProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = {"Toothpaste", "balls"};
            bool done = false;
            int itemNumber;
            int itemAmount;
            string itemNumberB;
            string itemAmountB;
            bool itemIsNumber = false;
            

            foreach (string item in items)
            {
                Console.WriteLine(item);
            }


            while (done == false)
            {
                Console.Write("Enter number of item you wish to buy: ");
                itemNumberB = Console.ReadLine();
                while (itemIsNumber == false)
                    if (itemNumberB != "1" || itemNumberB != "2" || itemNumberB != "3" || itemNumberB != "4" || itemNumberB != "5" || itemNumberB != "6" || itemNumberB != "7" || itemNumberB != "8" || itemNumberB != "9" || itemNumberB != "10")
                    {
                        Console.WriteLine("An item not on the selection list has been chosen, please try again: ");
                        itemNumberB = Console.ReadLine();
                    }
                    else
                    {
                        itemIsNumber = true;    
                    }
                    
                Console.Write("Enter number of times you wish to buy specified item: ");
                Console.ReadLine();
            }
        }
    }
}