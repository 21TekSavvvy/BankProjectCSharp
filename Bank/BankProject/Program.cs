class Bank
{
    static void Main ()
    {
        Bank bank = new Bank ();
        bank.login();
        System.Console.WriteLine ("Thank you Visit Again");
        System.Console.ReadKey ();
    }

    public void login()
    {
        System.Console.WriteLine("*******************Bank******************");
        System.Console.WriteLine("::Login Page::");

        string userName = null, password = null;

        System.Console.Write("Username: ");
        userName = System.Console.ReadLine();

        if (userName != "")
        {
            System.Console.Write("Password: ");
            password = System.Console.ReadLine();
        }

        if (userName == "system" && password == "manager")
        {
            menu();
        }
        else
        {
            System.Console.WriteLine("Invalid username or password!");
        }
    }
    public void menu()
    {
        int choice = -1;
        do
        {
        
            System.Console.WriteLine("\n:::Main menu:::");
            System.Console.WriteLine("1. Customers");
            System.Console.WriteLine("2. Accounts");
            System.Console.WriteLine("3. Funds Transfers");
            System.Console.WriteLine("4. Funds Transfers statement");
            System.Console.WriteLine("5. Account Statement");
            System.Console.WriteLine("0. Exit");

            System.Console.Write("Enter choice: ");
            choice =int.Parse(System.Console.ReadLine ());

                switch (choice)
                {
                    case 1: //Customer menu
                        break;
                    case 2: // Accounts menu
                        break;
                    case 3:  // funds transfer
                        break;
                    case 4: //funds transfer statement
                        break;
                    case 5: // account statement
                        break;
                } 

        } while (choice != 0);
    }
}