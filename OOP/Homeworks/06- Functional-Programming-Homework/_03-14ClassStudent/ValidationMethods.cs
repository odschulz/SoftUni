using System;

public class ValidationMethods
{
    public static void CheckIfStringIsNullOrEmpty(string parameter, string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentNullException(
                string.Format("The parameter {0} cannot be null or an empty string!", parameter));
        }
    }

    public static void CheckIfNumberIsZero(string parameter, byte value)
    {
        if (value == 0)
        {
            throw new ArgumentOutOfRangeException(
                string.Format("Parameter {0} cannot be zero!", value));
        }
    }

    public static void CheckIfNumberIsZeroOrNegative(string parameter, int value)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(
                string.Format("Parameter {0} cannot be zero or a negative number!", value));
        }
    }

    public static void CheckIfEmailIsValid(string email)
    {
        if (string.IsNullOrEmpty(email))
        {
            throw new ArgumentNullException("The email cannot be an empty string or null.");
        }

        try
        {
            var parsedEmail = new System.Net.Mail.MailAddress(email);
        }
        catch
        {
            throw new ArgumentException("The email address must be in valid format.");
        }
    }

    public static void CheckIfStudentMarkIsValid(int mark)
    {
        if (mark < 2 || mark > 6)
        {
            throw new ArgumentOutOfRangeException("Invalid student mark. Student marks should be integers between 2 and 6");
        }
    }
}