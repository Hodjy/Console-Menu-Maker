namespace Ex04.Menus.Interfaces
{
    class MethodActivator : ConsoleItem
    {
        IMenuListener m_Activator;
        int m_MethodIndex;

        public MethodActivator(IMenuListener Listener, string i_Name, int i_Index) 
            : base(i_Name) 
        {
            m_MethodIndex = i_Index;
            m_Activator = Listener;
        }

        protected override void Run()
        {
            m_Activator.ActivateMethod(m_MethodIndex);
        }
    }
}
