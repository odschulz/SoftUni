using System;

public class ValidationMethods
{
    public static void CheckIfStringIsNullOrEmpty(string parameter, string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentNullException(
                string.Format("{0} cannot be null or an empty string!", parameter));
        }
    }

    public static void CheckIfNumberIsZero(string parameter, byte value)
    {
        if (value == 0)
        {
            throw new ArgumentOutOfRangeException(
                string.Format("{0} cannot be zero!", parameter));
        }
    }

    public static void CheckIfNumberIsZero(string parameter, ushort value)
    {
        if (value == 0)
        {
            throw new ArgumentOutOfRangeException(
                string.Format("{0} cannot be zero!", parameter));
        }
    }

    public static void CheckIfNumberIsZeroOrNegative(string parameter, int value)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(
                string.Format("{0} cannot be zero or a negative number.", parameter));
        }
    }

    public static void CheckIfNumberIsNegative(string parameter, double value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(
                string.Format("{0} cannot be a negative number.", parameter));
        }
    }

    public static void CheckIfEmailIsValid(string email)
    {
        CheckIfStringIsNullOrEmpty("Email", email);

        try
        {
            var parsedEmail = new System.Net.Mail.MailAddress(email);
        }
        catch
        {
            throw new ArgumentException("The email address must be in valid format.");
        }
    }

    public static void CheckIfExamResultIsValid(ushort result)
    {
        if (result < 0 || result > 400)
        {
            throw new ArgumentOutOfRangeException("Invalid exam result. Exam results should be integers between 0 and 400.");
        }
    }

    public static void CheckIfTeamworkGradeIsValid(double grade)
    {
        if (grade < 0 || grade > 15)
        {
            throw new ArgumentOutOfRangeException("The teamwork grade must be between 0 and 15.");
        }
    }

    public static void CheckNumberOfHomeworksSent(byte homeworksSent)
    {
        if (homeworksSent > 10)
        {
            throw new ArgumentOutOfRangeException(
                "Invalid number of homeworks sent. Maximum number for homeworks for this course is 10.");
        }
    }

    public static void CheckNumberOfAttendances(byte attendances)
    {
        if (attendances > 10)
        {
            throw new ArgumentOutOfRangeException(
                "Invalid number of attendances. Maximum number for attendances for this course is 10.");
        }
    }

    public static void CheckBonusScore(double bonus)
    {
        if (bonus < 0 || bonus > 15)
        {
            throw new ArgumentOutOfRangeException(
                "The bonus value should be between 0 and 15.");
        }
    }
}