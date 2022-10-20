namespace CollectionGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuNavigation = 0;
            PartOneStack myStack = new PartOneStack();
            PartTwoList myList = new PartTwoList();
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("#0. Exit program");
                    Console.WriteLine("Part #1. Stack");
                    Console.WriteLine("Part #2. List");
                    Console.Write("Choose part of assignment: ");
                    try
                    {
                        menuNavigation = Convert.ToInt32(Console.ReadLine());
                        if (menuNavigation >= 0 && menuNavigation <= 2)
                        {
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        // do nothing
                    }
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Only accepts number 0 - 2");
                    Console.ResetColor();
                }
                if (menuNavigation == 1)
                {
                    myStack.RunProgram();
                }
                else if (menuNavigation == 2)
                {
                    myList.RunProgram();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("exit program, any key..");
            Console.ReadKey();
        }
        public static void loadingScene()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Threading.Thread.Sleep(200);
            Console.Write("-");
            System.Threading.Thread.Sleep(200);
            Console.Write("-");
            System.Threading.Thread.Sleep(200);
            Console.Write("-");
            System.Threading.Thread.Sleep(200);
            Console.Write("-");
            System.Threading.Thread.Sleep(200);
            Console.Write("-\n");
            System.Threading.Thread.Sleep(200);
            Console.ResetColor();
        }
    }
}