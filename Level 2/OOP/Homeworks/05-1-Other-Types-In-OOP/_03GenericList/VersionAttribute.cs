using System;

[AttributeUsage(
    AttributeTargets.Struct |
    AttributeTargets.Class |
    AttributeTargets.Interface |
    AttributeTargets.Enum |
    AttributeTargets.Method)]
public class VersionAttribute : Attribute
{
    private int major;
    private int minor;

    public VersionAttribute(int major, int minor)
    {
        this.Major = major;
        this.Minor = minor;
    }

    public int Major
    {
        get
        {
            return this.major;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Value cannot be a negative integer!");
            }

            this.major = value;
        }
    }

    public int Minor
    {
        get
        {
            return this.minor;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Value cannot be a negative integer!");
            }

            this.minor = value;
        }
    }

    public override string ToString()
    {
        return this.Major + "." + this.Minor;
    }
}