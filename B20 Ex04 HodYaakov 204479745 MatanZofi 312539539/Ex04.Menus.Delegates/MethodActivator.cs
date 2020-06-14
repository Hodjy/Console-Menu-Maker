namespace Ex04.Menus.Delegates
{
    using System;

    public delegate void Activator();

    internal class MethodActivator : ConsoleItem
    {
        public event Activator MethodClicked;

        public MethodActivator(string i_Name)
            : base(i_Name)
        {
        }

        internal override void Run()
        {
            Console.Clear();
            OnMethodClicked();
            pressToContinue();
        }

        private void pressToContinue()
        {
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
        }

        protected virtual void OnMethodClicked()
        {
            MethodClicked.Invoke();
        }
    }
}
