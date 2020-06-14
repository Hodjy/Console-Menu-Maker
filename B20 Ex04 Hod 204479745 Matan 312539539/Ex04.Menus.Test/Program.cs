namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;
    using Ex04.Menus.Delegates;

    class Program
    {
        public static void Main()
        {
            runAllMenus();
        }

        private static void runAllMenus()
        {
            runInterfaceMenu();
            runDelegateMenu();
        }

        private static void runInterfaceMenu()
        {
            Interfaces.Menu mainMenu = new Interfaces.Menu("Main Menu");
            MethodsCollection methodsCollectionItem = new MethodsCollection();
            Interfaces.Menu versionsAndDigits = mainMenu.MakeSubMenu("Versions and Digits");
            Interfaces.Menu showDateOrTime = mainMenu.MakeSubMenu("Show Date/Time");

            versionsAndDigits.MakeActivator(methodsCollectionItem, "Count Capitals", 1);
            versionsAndDigits.MakeActivator(methodsCollectionItem, "Show Version", 2);
            showDateOrTime.MakeActivator(methodsCollectionItem, "Show Time", 3);
            showDateOrTime.MakeActivator(methodsCollectionItem, "Show Date", 4);
            mainMenu.Show();
        }

        private static void runDelegateMenu()
        {
            Delegates.Menu mainMenu = new Delegates.Menu("Main Menu");
            MethodsCollection methodsCollectionItem = new MethodsCollection();
            Delegates.Menu versionsAndDigits = mainMenu.MakeSubMenu("Versions and Digits");
            Delegates.Menu showDateOrTime = mainMenu.MakeSubMenu("Show Date/Time");

            versionsAndDigits.MakeActivator("Count Capitals", methodsCollectionItem.CountCapitals);
            versionsAndDigits.MakeActivator("Show Version", methodsCollectionItem.ShowVersion);
            showDateOrTime.MakeActivator("Show Time", methodsCollectionItem.ShowTime);
            showDateOrTime.MakeActivator("Show Date", methodsCollectionItem.ShowDate);
            mainMenu.Show();
        }
    }
}