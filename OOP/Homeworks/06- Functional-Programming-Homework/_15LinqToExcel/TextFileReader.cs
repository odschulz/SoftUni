using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class TextFileReader
{
    private string inputFileName;
    private bool hasHeader;

    public TextFileReader(string inputFileName, bool hasHeader)
    {
        this.InputFileName = inputFileName;
        this.HasHeader = hasHeader;
    }

    public string InputFileName 
    {
        get
        {
            return this.inputFileName;
        }

        set 
        {
            ValidationMethods.CheckIfStringIsNullOrEmpty("Input File Name", value);
            this.inputFileName = value;
        } 
    }

    public bool HasHeader 
    {
        get { return this.hasHeader; }

        set { this.hasHeader = value; }
    }

    public List<string> GetHeaderTitlesFromFile(string splitPattern, string[] titlesToAdd = null)
    {
        if (!this.HasHeader)
        {
            throw new NotImplementedException(
                "The text reader constructor wasn't called with a specified header, thus this method is not applicable.");
        }

        try
        {
            using (StreamReader reader = new StreamReader(this.InputFileName, Encoding.GetEncoding("UTF-8")))
            {
                List<string> headerTitles = new List<string>();
                string line = reader.ReadLine();
                headerTitles = Regex.Split(line, splitPattern).ToList();
                foreach (string title in titlesToAdd)
                {
                    headerTitles.Add(title);
                }

                return headerTitles;
            }
        }
        catch (FileNotFoundException e)
        {
            throw new FileNotFoundException("The file could not be read: " + e.Message);
        }
    }

    public List<Student> GetStudentDataFromFile(string splitPattern)
    {
        try
        {
            using (StreamReader reader = new StreamReader(this.InputFileName, Encoding.GetEncoding("UTF-8")))
            {
                string line;
                List<Student> studentDataCollection = new List<Student>();
                if (this.HasHeader)
                {
                    // skip the first row with the header titles
                    line = reader.ReadLine();
                }

                while ((line = reader.ReadLine()) != null)
                {
                    string[] splitRowData = Regex.Split(line, splitPattern);
                    Student student = Student.CreateNewStudentFromData(splitRowData);
                    studentDataCollection.Add(student);
                }

                return studentDataCollection;
            }
        }
        catch (FileNotFoundException e)
        {
            throw new FileNotFoundException("The file could not be read: " + e.Message);
        }
    }
}