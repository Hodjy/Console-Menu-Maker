namespace Ex04.Menus.Interfaces
{
    using System.Collections.Generic;

    public class Menu : ConsoleItem
    {
        List<ConsoleItem> m_MenuList;

        public Menu(string i_MenuName) : base(i_MenuName)
        {
            m_MenuList = new List<ConsoleItem>();
        }

        protected override void Run()
        {
            bool isMenuRunning = true;
            int  userInput = -1;

            while (isMenuRunning)
            {
                showMenu(); // always show 0. Exit
                userInput = getValidInputAsInt();
                if (userInput == 0)
                {
                    break;
                }

                chooseFromList(userInput);
            }
        }

        private void showMenu()
        {

        }

        public Menu MakeSubMenu(string i_MenuName)
        {
            Menu subMenu = new Menu(i_MenuName);

            m_MenuList.Add(subMenu);

            return subMenu;
        }

        public void MakeActivator(IMenuListener i_Listener, string i_ActivatorName, int i_MethodIndex)
        {
            MethodActivator newActivator = new MethodActivator(i_Listener, i_ActivatorName, i_MethodIndex);

            m_MenuList.Add(newActivator);
        }
    }
}
