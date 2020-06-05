namespace Ex04.Menus.Interfaces
{
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
            m_Activator.ActivateMethod(m_MethodIndex);
        }
    }
}
