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
            Console.WriteLine(DateTime.Now.TimeOfDay);
        }

        public void ShowDate()
        {
            Console.WriteLine(DateTime.Now.Date);
        }

        void IMenuListener.ActivateMethod(int i_Index)
        {
        }
    }
}
