using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Utils
{
    static EventHolder events = new EventHolder();

    public static bool ExecuteNextCommand()
    {
        string command = Console.ReadLine();
        if (command[0] == 'A')
        {
            AddEvent(command); 
            return true;
        }
        if (command[0] == 'D')
        {
            DeleteEvents(command); 
            return true;
        }


        if (command[0] == 'L')
        {
            ListEvents(command); 
            return true;
        }
        if (command[0] == 'E')
        {
            return false;
        }
        return false;
    }

    private static void ListEvents(string command)
    {
        int pipeIndex = command.IndexOf('|');
        DateTime date = GetDate(command, "ListEvents");
        string countString = command.Substring(pipeIndex + 1);
        int count = countString.Length;
        events.ListEvents(date, count);
    }

    private static void DeleteEvents(string command)
    {
        string title = command.Substring("DeleteEvents".Length + 1);
        events.DeleteEvents(title);
    }

    private static void AddEvent(string command)
    {
        DateTime date; 
        string title; 
        string location;
        GetParameters(command, "AddEvent", out date, out title, out location);

        events.AddEvent(date, title, location);
    }

    private static void GetParameters(string commandForExecution, string commandType,
        out DateTime dateAndTime, out string eventTitle, out string eventLocation)
    {
        dateAndTime = GetDate(commandForExecution, commandType);
        int firstPipeIndex = commandForExecution.IndexOf('|');
        int lastPipeIndex = commandForExecution.LastIndexOf('|');
        if (firstPipeIndex == lastPipeIndex)
        {
            eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
            eventLocation = "";
        }
        else
        {
            eventTitle = commandForExecution.Substring(firstPipeIndex + 1,
                lastPipeIndex - firstPipeIndex - 1).Trim();
            eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
        }
    }
    private static DateTime GetDate(string command, string commandType)
    {
        int startIndex = commandType.Length + 1;
        int endIndex = command.IndexOf("|") - startIndex;
        DateTime date = DateTime.Parse(command.Substring(startIndex, endIndex));
        return date;

    }
}
