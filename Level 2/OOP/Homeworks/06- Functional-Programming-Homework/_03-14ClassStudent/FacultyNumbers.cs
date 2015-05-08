using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class FacultyNumbers
{
    private static List<string> usedFacultyNumbers = new List<string>();

    public static void CreateNewFacultyNumber(string facultyNumber)
    {
        CheckIfFacultyNumberIsValid(facultyNumber);
        CheckIfFacultyNumberIsTaken(facultyNumber);
        usedFacultyNumbers.Add(facultyNumber);
    }

    public static List<string> GetUsedFacultyNumbers()
    {
        return usedFacultyNumbers;
    }

    public static void CheckIfFacultyNumberIsValid(string facultyNumber)
    {
        if (!Regex.IsMatch(facultyNumber, "^[0-9]{6}$"))
        {
            throw new FormatException("A faculty number must be a string of exactly 6 digits.");
        }
    }

    public static void CheckIfFacultyNumberIsTaken(string facultyNumber)
    {
        if (usedFacultyNumbers.Contains(facultyNumber))
        {
            throw new ArgumentException("This faculty number is already used.");
        }
    }
}