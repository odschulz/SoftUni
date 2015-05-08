using System;

public class Student
{
    private string name;
    private byte age;
    private PropertyChangedEventArgs eventArgs;

    public Student(string name, byte age)
    {
        this.Name = name;
        this.Age = age;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The Name parameter cannot be null or an empty string!");
            }

            this.OnPropertyChanged("Name", this.name, value);
            this.name = value;
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
            if (value == 0)
            {
                throw new ArgumentOutOfRangeException("The Age parameter cannot be zero!");
            }

            this.OnPropertyChanged("Age", this.age, value);
            this.age = value;
        }
    }

    protected virtual void OnPropertyChanged(string name, object oldValue, object newValue)
    {
        if (this.PropertyChanged != null)
        {
            if (this.eventArgs == null)
            {
                this.eventArgs = new PropertyChangedEventArgs(name, oldValue, newValue);
            }
            else
            {
                this.eventArgs.PropertyName = name;
                this.eventArgs.OldValue = oldValue;
                this.eventArgs.NewValue = newValue;
            }

            this.PropertyChanged(this, this.eventArgs);
        }
    }
}
