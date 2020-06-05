namespace Ex04.Menus.Interfaces
{
    using System;
    using System.Collections.Generic;

    public class Menu : ConsoleItem
    {
        private List<ConsoleItem> m_MenuList;

        public Menu(string i_MenuName) : base(i_MenuName)
        {
            m_MenuList = new List<ConsoleItem>();
        }

        internal override void Run()
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

        private int getValidInputAsInt()
        {
            string userInput = null;
            int userConvertedInput = 0;
            bool isInputValid = false;

            while (!isInputValid)
            {
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out userConvertedInput)
                    && (userConvertedInput < m_MenuList.Count)) // < or <= need to check
                {
                    isInputValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            }

            return userConvertedInput;
        }

        private void chooseFromList(int i_UserInput)
        {
            m_MenuList[i_UserInput].Run();
            /*
            if (m_MenuList[i_UserInput] is Menu)
            {
                (m_MenuList[i_UserInput] as Menu).Run();
            }
            else if (m_MenuList[i_UserInput] is MethodActivator)
            {
                (m_MenuList[i_UserInput] as MethodActivator).Run();
            }
            */
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
