using System;
using System.Text.RegularExpressions;
public static class ValidationMethods
{
    public static void CheckIfStringIsNullOrEmpty(string parameter, string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException(parameter + " cannot be null or an empty string.");
        }
    }

    public static void CheckIfStringIsEmpty(string parameter, string value)
    {
        if (value == string.Empty)
        {
            throw new ArgumentException(parameter + " cannot be an empty string.");
        }
    }

    public static void CheckIfIdIsValid(string value)
    {
        if (!Regex.IsMatch(value, @"^[0-9]{10}$"))
        {
            throw new ArgumentException("Not a valid ID. The ID parameter should consist of 10 digits.");
        }
    }

    public static void CheckIfEmailIsValid(string email)
    {
        try
        {
            var parsedEmail = new System.Net.Mail.MailAddress(email);
        }
        catch
        {
            throw new ArgumentException("The email address must be in valid format.");
        }
    }

    public static void CheckIfNumIsZeroOrNegative(string parameter, decimal value)
    {
        if (value <= 0)
        {
            throw new ArgumentException(parameter + " cannot be zero or a negative number.");
        }
    }
}
