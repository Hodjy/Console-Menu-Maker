namespace Ex04.Menus.Interfaces
{
    public class ConsoleItem
    {
        string m_Name;

        public ConsoleItem(string i_Name)
        {
            m_Name = i_Name;
        }

        public string Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
            }
        }

        public virtual void Run()
        {

        }
    }
}
