namespace Ex04.Menus.Interfaces
{
    using System;

    internal class MethodActivator : ConsoleItem
    {
        IMenuListener m_Activator;
        int m_MethodIndex;

        public MethodActivator(IMenuListener Listener, string i_Name, int i_Index) 
            : base(i_Name) 
        {
            m_Activator = Listener;
            m_MethodIndex = i_Index;
        }

        internal override void Run()
        {
            Console.Clear();
            m_Activator.ActivateMethod(m_MethodIndex);
            pressToContinue();
        }

        private void pressToContinue()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
    }
}
