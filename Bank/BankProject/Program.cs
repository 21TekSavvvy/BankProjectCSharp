using Bank.Presentation;


    class Program
    {
        static void Main()
        {
            Program bank = new Program();
            bank.login();
            System.Console.WriteLine("Thank you Visit Again");
            System.Console.ReadKey();
        }

        public void login()
        {
            System.Console.WriteLine("*******************Bank******************");
            System.Console.WriteLine("::Login Page::");

            string userName = null, password = null;

            System.Console.Write("Username: ");
            userName = System.Console.ReadLine();

            // check if username isn't empty
            if (userName != "")
            {
                System.Console.Write("Password: ");
                password = System.Console.ReadLine();
            }

            //temp user and password
            // check if the login info matchs the credentials
            if (userName == "system" && password == "manager")
            {
                menu();
            }
            else
            {
                // Username or Password didn't match
                System.Console.WriteLine("Invalid username or password!");
            }
        }
        public void menu()
        {
            int choice = -1;
            do
            {
                // print out the menu
                System.Console.WriteLine("\n:::Main menu:::");
                System.Console.WriteLine("1. Customers");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Funds Transfers");
                System.Console.WriteLine("4. Funds Transfers statement");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");

                System.Console.Write("Enter choice: ");
                choice = int.Parse(System.Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        customerMenu();//Customer menu
                        break;
                    case 2:
                        accountMenu(); // Accounts menu
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

        public void customerMenu()
        {
            int cChoice = -1;
            do
            {
                //print out menu
                System.Console.WriteLine("\n::::Customers menu::::");
                System.Console.WriteLine("1. Add Customer");
                System.Console.WriteLine("2. Delete Customer");
                System.Console.WriteLine("3. Update Customer");
                System.Console.WriteLine("4. Search Customer");
                System.Console.WriteLine("5. View Customer");
                System.Console.WriteLine("0. Back to the Main Menu");
                System.Console.WriteLine("Enter choice: ");
                cChoice = System.Convert.ToInt32(System.Console.ReadLine());
                switch (cChoice)
                {
                    case 1: CustomerPresentation.AddCustomer(); //Add customer
                        break;
                    case 2: // Delete Customer
                        break;
                    case 3: // Update Customer
                        break;
                    case 4: // Search Customer
                        break;
                    case 5: //view Customer
                        break;
                    default:
                        menu();
                        break;

                }
            } while (cChoice != 0);




        }
        public void accountMenu()
        {
            int aChoice = -1;
            do
            {
                //print out menu
                System.Console.WriteLine("\n::::Account menu::::");
                System.Console.WriteLine("1. Add Account");
                System.Console.WriteLine("2. Delete Account");
                System.Console.WriteLine("3. Update Account");
                System.Console.WriteLine("4. View Account");
                System.Console.WriteLine("0. Back to the Main Menu");
                System.Console.WriteLine("Enter choice: ");
                aChoice = System.Convert.ToInt32(System.Console.ReadLine());
                switch (aChoice)
                {
                    case 1: //Add Account
                        break;
                    case 2: // Delete Account
                        break;
                    case 3: // Update Account
                        break;
                    case 4: // View Account
                        break;
                    default:
                        menu();
                        break;

                }
            } while (aChoice != 0);




        }
    }
