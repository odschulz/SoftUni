using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Event : IComparable
{
    private DateTime date;
    private string title;
    private string location;

    public Event(DateTime date, string title, string location)
    {
        this.Date = date;
        this.Title = title;
        this.Location = location;
    }

    public DateTime Date
    {
        get
        {
            return this.date;
        }
        set
        {
            this.date = value;
        }
    }
    public string Title
    {
        get
        {
            return this.title;
        }
        set
        {
            this.title = value;
        }
    }
    public string Location
    {
        get
        {
            return this.location;
        }
        set
        {
            this.location = value;
        }
    }

    public int CompareTo(object obj)
    {
        Event secondEvent = obj as Event;
        int byDate = this.date.CompareTo(secondEvent.Date);
        int byTitle = this.title.CompareTo(secondEvent.Title);
        int byLocation = this.location.CompareTo(secondEvent.Location);
        if (byDate == 0)
        {
            if (byTitle == 0)
            {
                return byLocation;
            }
            else
            {
                return byTitle;
            }
        }
        else
        {
            return byDate;
        }
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.Append(date.ToString("yyyy-MM-ddTHH:mm:ss"));
        output.Append(" | " + title);
        if (!String.IsNullOrEmpty(location))
        {
            output.Append(" | " + location);
        }

        return output.ToString();
    }
}
