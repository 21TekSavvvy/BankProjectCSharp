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
            System.Console.WriteLine("To Do: Main menu here");
        }
    }
}