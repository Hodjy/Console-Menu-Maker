namespace Ex04.Menus.Interfaces
{
    using System;

    internal class MethodActivator : ConsoleItem
    {
        private IMenuListener m_Activator;
        private int m_MethodIndex;

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
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
        }
    }
}
