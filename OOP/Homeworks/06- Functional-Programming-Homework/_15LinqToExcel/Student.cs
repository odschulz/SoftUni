using System;
using System.Text;

public class Student
{
    private ushort id;
    private string firstName;
    private string lastName;
    private string email;
    private Gender gender;
    private StudentType studentType;
    private ushort examResult;
    private byte homeworksSent;
    private byte homeworksEvaluated;
    private double teamwork;
    private byte attendances;
    private double bonus;
    private double result;

    public Student(
        ushort id,
        string firstName,
        string lastName,
        string email,
        Gender gender,
        StudentType studentType,
        ushort examResult,
        byte homeworksSent,
        byte homeworksEvaluated,
        double teamwork,
        byte attendances,
        double bonus)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Email = email;
        this.Gender = gender;
        this.StudentType = studentType;
        this.ExamResult = examResult;
        this.HomeworksSent = homeworksSent;
        this.HomeworksEvaluated = homeworksEvaluated;
        this.Teamwork = teamwork;
        this.Attendances = attendances;
        this.Bonus = bonus;
        this.Result = this.CalculateResult();
    }

    public ushort Id
    {
        get
        {
            return this.id;
        }

        set
        {
            ValidationMethods.CheckIfNumberIsZero("ID", value);
            this.id = value;
        }
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

    public Gender Gender
    {
        get { return this.gender; }

        set { this.gender = value; }
    }

    public StudentType StudentType
    {
        get { return this.studentType; }

        set { this.studentType = value; }
    }

    public ushort ExamResult
    {
        get
        {
            return this.examResult;
        }

        set
        {
            ValidationMethods.CheckIfExamResultIsValid(value);
            this.examResult = value;
        }
    }

    public byte HomeworksSent
    {
        get
        {
            return this.homeworksSent;
        }

        set
        {
            ValidationMethods.CheckNumberOfHomeworksSent(value);
            this.homeworksSent = value;
        }
    }

    public byte HomeworksEvaluated
    {
        get
        {
            return this.homeworksEvaluated;
        }

        set
        {
            this.homeworksEvaluated = value;
        }
    }

    public double Teamwork
    {
        get 
        { 
            return this.teamwork; 
        }

        set 
        {
            ValidationMethods.CheckIfNumberIsNegative("Teamwork", value);
            this.teamwork = value;
        }
    }

    public byte Attendances
    {
        get 
        { 
            return this.attendances; 
        }

        set 
        {
            ValidationMethods.CheckNumberOfAttendances(value);
            this.attendances = value;
        }
    }

    public double Bonus
    {
        get 
        { 
            return this.bonus; 
        }

        set 
        {
            ValidationMethods.CheckBonusScore(value);
            this.bonus = value;
        }
    }

    public double Result
    {
        get { return this.result; }

        private set { this.result = value; }
    }

    public static Student CreateNewStudentFromData(string[] dataCollection)
    {
        if (dataCollection.Length != 12)
        {
            throw new ArgumentException(
                "The elements from the data collection are not the correct amount for an instance of Student to be created");
        }

        try
        {
            Student student = new Student(
                id: ushort.Parse(dataCollection[0]),
                firstName: dataCollection[1],
                lastName: dataCollection[2],
                email: dataCollection[3],
                gender: (Gender)Enum.Parse(typeof(Gender), dataCollection[4], true),
                studentType: (StudentType)Enum.Parse(typeof(StudentType), dataCollection[5], true),
                examResult: ushort.Parse(dataCollection[6]),
                homeworksSent: byte.Parse(dataCollection[7]),
                homeworksEvaluated: byte.Parse(dataCollection[8]),
                teamwork: double.Parse(dataCollection[9]),
                attendances: byte.Parse(dataCollection[10]),
                bonus: double.Parse(dataCollection[11]));

            return student;
        }
        catch (ArgumentException e)
        {
            throw new ArgumentException("Arguement null or not from requested type." + e);
        }
        catch (FormatException e)
        {
            throw new FormatException("Arguement not in the correct format" + e);
        }
        catch (OverflowException e)
        {
            throw new OverflowException("Arguement outside the range." + e);
        }
    }

    public double CalculateResult()
    {
        double resultScore =
            (this.ExamResult + this.HomeworksSent + this.HomeworksEvaluated +
            this.Teamwork + this.Attendances + this.Bonus) / 5;
        return resultScore;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendLine(this.Id.ToString());
        result.AppendLine(this.FirstName);
        result.AppendLine(this.LastName);
        result.AppendLine(this.Email);
        result.AppendLine(this.Gender.ToString());
        result.AppendLine(this.StudentType.ToString());
        result.AppendLine(this.ExamResult.ToString());
        result.AppendLine(this.HomeworksSent.ToString());
        result.AppendLine(this.HomeworksEvaluated.ToString());
        result.AppendLine(this.Teamwork.ToString("0.#"));
        result.AppendLine(this.Attendances.ToString());
        result.AppendLine(this.Bonus.ToString("0.00"));
        result.AppendLine(this.Result.ToString("0.0##"));

        return result.ToString().Trim();
    }
}