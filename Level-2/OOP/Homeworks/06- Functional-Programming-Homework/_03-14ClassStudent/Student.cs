using System;
using System.Collections.Generic;
using System.Text;

public class Student
{
    private string firstName;
    private string lastName;
    private byte age;
    private string facultyNumber;
    private string phone;
    private string email;
    private IList<int> marks;
    private byte groupNumber;
    private GroupName groupName;

    public Student(
        string firstName,
        string lastName,
        byte age,
        string facultyNumber,
        string phone,
        string email,
        IList<int> marks,
        byte groupNumber, 
        GroupName groupName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.FacultyNumber = facultyNumber;
        this.Phone = phone;
        this.Email = email;
        this.Marks = marks;
        this.GroupNumber = groupNumber;
        this.GroupName = groupName;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }

        set
        {
            ValidationMethods.CheckIfStringIsNullOrEmpty("First Name", value);
            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }

        set
        {
            ValidationMethods.CheckIfStringIsNullOrEmpty("Last Name", value);
            this.lastName = value;
        }
    }

    public byte Age
    {
        get
        {
            return this.age;
        }

        set
        {
            ValidationMethods.CheckIfNumberIsZero("Age", value);
            this.age = value;
        }
    }

    public string FacultyNumber
    {
        get
        {
            return this.facultyNumber;
        }

        set
        {
            ValidationMethods.CheckIfStringIsNullOrEmpty("Faculty Number", value);
            FacultyNumbers.CreateNewFacultyNumber(value);
            this.facultyNumber = value;
        }
    }

    public string Phone
    {
        get
        {
            return this.phone;
        }

        set
        {
            ValidationMethods.CheckIfStringIsNullOrEmpty("Phone", value);
            this.phone = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }

        set
        {
            ValidationMethods.CheckIfEmailIsValid(value);
            this.email = value;
        }
    }

    public IList<int> Marks
    {
        get
        {
            return this.marks;
        }

        set
        {
            // it is ok to enter an empty list, there is a method for adding marks
            foreach (var mark in value)
            {
                ValidationMethods.CheckIfStudentMarkIsValid(mark);
            }

            this.marks = value;
        }
    }

    public byte GroupNumber
    {
        get
        {
            return this.groupNumber;
        }

        set
        {
            ValidationMethods.CheckIfNumberIsZero("Group Number", value);
            this.groupNumber = value;
        }
    }

    public GroupName GroupName
    {
        get { return this.groupName; }
        set { this.groupName = value; }
    }

    public void AddStudentMark(int mark)
    {
        ValidationMethods.CheckIfStudentMarkIsValid(mark);
        this.Marks.Add(mark);
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendLine("Name: " + this.FirstName + " " + this.LastName);
        result.AppendLine("Age: " + this.Age);
        result.AppendLine("Faculty Number: " + this.FacultyNumber);
        result.AppendLine("Phone: " + this.Phone);
        result.AppendLine("Email: " + this.Email);
        result.AppendLine("Marks: " + (this.Marks != null ? string.Join(", ", this.Marks) : "N/A"));
        result.AppendLine("Group Number: " + this.GroupNumber);

        return result.ToString().Trim();
    }
}