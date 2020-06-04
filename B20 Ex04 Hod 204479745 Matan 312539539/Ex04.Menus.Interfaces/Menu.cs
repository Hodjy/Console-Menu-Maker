using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    class Menu : IMenuListener
    {
        public Menu(List<IMenuListener> i_List)
        {

        }

        public void Run(int i_Index)
        {
            // start menu operation
        }

        /*
         userchosesomething:
         5
         list[5].Run();
         
         
         --EXE

        list <- menu2 menu3 item1 item4 item7
         
         */
    }
}
