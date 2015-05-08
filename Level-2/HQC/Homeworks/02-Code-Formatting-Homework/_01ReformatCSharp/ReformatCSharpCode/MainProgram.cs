using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MainProgram
{
    static void Main(string[] args)
    {
        /* Enter the following commands, pressing enter after each one: 
         * 
         * ADDEVENT 2009/02/26 18:37:58 |first event|button pressed
         * ADDEVENT 2009/02/26 18:38:58 |second event|mouse clicked
         * LISTEVENTS 2009/02/26 18:37:58 |events|
         * DELETEEVENTS second event
         * LISTEVENTS 2009/02/26 18:37:58 |events|
         * EXIT
         */

        try
        {
            while (Utils.ExecuteNextCommand())
            {
            }
            Console.WriteLine(Messages.GetOutput());
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine(
                "Please stick to the suggested format! Restart the program and copy-paste the commands from above!");
        }

    }
}