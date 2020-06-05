namespace Ex04.Menus.Interfaces
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class Menu : ConsoleItem
    {
        private List<ConsoleItem> m_MenuList;
        private string            m_PreviousMenu;

        public Menu(string i_MenuName) : base(i_MenuName)
        {
            m_MenuList = new List<ConsoleItem>();
            m_PreviousMenu = "Exit";
        }

        private Menu(string i_MenuName, string i_PreviousMenu) : base(i_MenuName)
        {
            m_MenuList = new List<ConsoleItem>();
            m_PreviousMenu = i_PreviousMenu;
        }

        public void Show()
        {
            Run();
        }

        internal override void Run()
        {
            bool isMenuRunning = true;
            int  userInput = -1;

            while (isMenuRunning)
            {
                showMenu();
                userInput = getValidInputAsInt();
                if (userInput == 0) // If 0, leave current menu.
                {
                    break;
                }

                chooseFromList(userInput);
            }
        }

        private void showMenu()
        {
            StringBuilder stringToPrint = new StringBuilder();
            int           i = 1;

            Console.Clear();
            stringToPrint.AppendFormat(@"{0}: 

", Name);
            stringToPrint.AppendFormat("0. {0}.", m_PreviousMenu);
            stringToPrint.AppendLine();
            foreach (ConsoleItem item in m_MenuList)
            {
                stringToPrint.AppendFormat("{0}. {1}.", i, item.Name);
                stringToPrint.AppendLine();
                i++;
            }

            Console.WriteLine(stringToPrint);
        }

        private int getValidInputAsInt()
        {
            string userInput = null;
            int    userConvertedInput = 0;
            bool   isInputValid = false, isParseValid = false, isInMenuRange = false;

            while (!isInputValid)
            {
                userInput = Console.ReadLine();
                isParseValid = int.TryParse(userInput, out userConvertedInput);
                if (isParseValid) 
                {
                    isInMenuRange = checkIfInMenuRange(userConvertedInput);
                    if (isInMenuRange)
                    {
                        isInputValid = true;
                    }
                    else
                    {
                        Console.WriteLine("No such option, please try again.");
                    }  
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            }

            return userConvertedInput;
        }

        private bool checkIfInMenuRange(int i_NumberToCheck)
        {
            bool isInRange = false;

            isInRange = (i_NumberToCheck >= 0 && i_NumberToCheck <= m_MenuList.Count);

            return isInRange;
        }

        private void chooseFromList(int i_UserInput)
        {
            m_MenuList[i_UserInput - 1].Run();
        }

        public Menu MakeSubMenu(string i_MenuName)
        {
            Menu subMenu = new Menu(i_MenuName, "Back");

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
