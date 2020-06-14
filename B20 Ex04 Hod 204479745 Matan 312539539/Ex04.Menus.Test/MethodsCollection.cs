namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;
    using System;

    public class MethodsCollection : IMenuListener
    {
        public void CountCapitals()
        {
            int capitalCount = 0;
            string userInput = null;

            Console.WriteLine("Please enter a sentence in English.");
            userInput = Console.ReadLine();
            foreach (char letter in userInput)
            {
                if (char.IsUpper(letter))
                {
                    capitalCount++;
                }
            }

            Console.WriteLine("There are {0} upper case letters in that sentence.", capitalCount);
        }

        public void ShowVersion()
        {
            Console.WriteLine("Version: 20.2.4.30620");
        }

        public void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToString("T"));
        }

        public void ShowDate()
        {
            Console.WriteLine(DateTime.Today.ToString("d"));
        }

        void IMenuListener.ActivateMethod(int i_Index)
        {
            switch (i_Index)
            {
                case 1:
                    CountCapitals();
                    break;
                case 2:
                    ShowVersion();
                    break;
                case 3:
                    ShowTime();
                    break;
                case 4:
                    ShowDate();
                    break;
            }
        }
    }
}