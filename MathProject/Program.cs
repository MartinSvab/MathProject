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
                    int.TryParse(itemNumberB, out itemNumber);
                }

                //Entering Number Of Items


            }

        }
    }
}