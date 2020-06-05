namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    class Program
    {
        public static void Main()
        {
            
        }

        private void runInterfaceMenu()
        {
            Menu mainMenu = new Menu("MainMenu");
            MethodsCollection methodsCollectionItem = new MethodsCollection();
            Menu versionsAndDigits = mainMenu.MakeSubMenu("Versions and Digits");
            Menu showDateOrTime = mainMenu.MakeSubMenu("Show Date/Time");
            


            versionsAndDigits.MakeActivator(methodsCollectionItem, "Count Capitals", 1);
            versionsAndDigits.MakeActivator(methodsCollectionItem, "Show Version", 2);
            showDateOrTime.MakeActivator(methodsCollectionItem, "Show Time", 3);
            showDateOrTime.MakeActivator(methodsCollectionItem, "Show Date", 4);
            mainMenu.Show();
        }
    }
}
