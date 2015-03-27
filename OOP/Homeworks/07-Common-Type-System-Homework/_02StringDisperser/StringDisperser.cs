using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable
{
    private List<string> strings;

    public StringDisperser(params string[] strings)
    {
        this.Strings = strings.ToList();
    }

    public List<string> Strings 
    {
        get
        {
            return this.strings;
        }

        private set
        {
            if (value.Count == 0)
            {
                throw new ArgumentException("Params string[] strings must contain at least one string.");
            }
            this.strings = value;
        } 
    }

    public void AddString(string newString)
    {
        if (string.IsNullOrEmpty(newString))
        {
            throw new ArgumentNullException("An empty string or null cannot be added to the string list.");
        }

        this.Strings.Add(newString);
    }

    public override bool Equals(object obj)
    {
        StringDisperser other = obj as StringDisperser;
        if (other == null)
        {
            return false;
        }

        return this.ToString().Equals(other.ToString());
    }

    public static bool operator ==(StringDisperser thisStringDisperser, StringDisperser otherStringDisperser)
    {
        return Object.Equals(thisStringDisperser, otherStringDisperser);
    }

    public static bool operator !=(StringDisperser thisStringDisperser, StringDisperser otherStringDisperser)
    {
        return !Object.Equals(thisStringDisperser, otherStringDisperser);
    }

    public override int GetHashCode()
    {
        return this.ToString().GetHashCode();
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        foreach (var str in this.Strings)
	    {
		    result.AppendLine(str);
	    }

        return result.ToString().TrimEnd();
    }

    public object Clone()
    {
        StringDisperser clonedStringDIsperser = new StringDisperser((string[])this.Strings.ToArray().Clone());
        return clonedStringDIsperser;
    }

    public int CompareTo(StringDisperser other)
    {
        return this.ToString().CompareTo(other.ToString());
    }

    public IEnumerator GetEnumerator()
    {
        foreach (string str in this.Strings)
        {
            foreach (char ch in str)
            {
                yield return ch;
            }
        }
    }
}
