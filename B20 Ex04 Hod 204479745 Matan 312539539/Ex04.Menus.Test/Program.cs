namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    class Program
    {
        public static void Main()
        {
            Menu m_MainMenu = new Menu("MainMenu");
            Menu m_VersionsAndDigits = m_MainMenu.MakeSubMenu("Versions and Digits");
            Menu m_ShowDateOrTime = m_MainMenu.MakeSubMenu("Show Date/Time");
            MethodsCollection m_MethodsCollectionItem = new MethodsCollection();

            m_VersionsAndDigits.MakeActivator(m_MethodsCollectionItem, "Count Capitals", 1);
            m_VersionsAndDigits.MakeActivator(m_MethodsCollectionItem, "Show Version", 2);
            m_ShowDateOrTime.MakeActivator(m_MethodsCollectionItem, "Show Time", 3);
            m_ShowDateOrTime.MakeActivator(m_MethodsCollectionItem, "Show Date", 4);
            m_MainMenu.Show();
        }
    }
}
