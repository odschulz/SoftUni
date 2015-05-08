using System;

public class PropertyChangedEventArgs : EventArgs
{
    private string propertyName;
    private object oldValue;
    private object newValue;

    public PropertyChangedEventArgs(string propertyName, object oldValue, object newValue)
    {
        this.PropertyName = propertyName;
        this.OldValue = oldValue;
        this.NewValue = newValue;
    }

    public string PropertyName
    {
        get { return this.propertyName; }
        set { this.propertyName = value; }
    }

    public object OldValue
    {
        get { return this.oldValue; }
        set { this.oldValue = value; }
    }

    public object NewValue
    {
        get { return this.newValue; }
        set { this.newValue = value; }
    }
}
