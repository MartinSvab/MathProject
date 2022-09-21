namespace MathProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = { "Toothpaste", "balls" };
            bool done = false;
            int itemNumber;
            string itemNumberB;
            bool isInt = false;
            string keepShopping;

            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            while (!done)
            {
                    //Entering Number Of Item
                    itemNumber = 0;
                    if (itemNumber < 1 || itemNumber > items.Length)
                    {
                        Console.Write("Enter the number of the item you wish to buy: ");
                        itemNumberB = Console.ReadLine();
                        isInt = int.TryParse(itemNumberB, out itemNumber);
                    }

                //Entering Number Of Items
                    if (isInt)  
                    {
                        Repeater();
                        Console.WriteLine("Would you like to keep shopping or choose how many of the selected item you want to purchase?");
                        Console.WriteLine("");
                        Console.Write("Please answer with \"KS\" to keep shopping or with \"P\" to pay.    ");
                        keepShopping = Console.ReadLine();
                        Repeater();

                        if (keepShopping == "KS")
                        {

                        }
                        else if (keepShopping == "P")
                        {
                        done = false;
                        }
                    }
                    else
                    {
                        Repeater();
                        Console.WriteLine("Error: Invalid Text. Please Try again");
                        Repeater();
                    }

            }

        }

        static void Repeater()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
    }
}