using System;
using System.Collections.Generic;
using System.Text;

public class Customer : ICloneable, IComparable<Customer>
{
    private string firstName;
    private string middleName;
    private string lastName;
    private string id;
    List<Payment> payments;
    private string permanentAddress;
    private string mobilePhone;
    private string email;
    private CustomerType customerType;

    public Customer(
        string firstName,
        string middleName,
        string lastName,
        string id,
        List<Payment> payments,
        string permanentAddress = null,
        string mobilePhone = null,
        string email = null)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.Id = id;
        this.PermanentAddress = permanentAddress;
        this.MobilePhone = mobilePhone;
        this.Email = email;
        this.Payments = payments;
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

    public string MiddleName
    {
        get
        {
            return this.middleName;
        }

        set
        {
            ValidationMethods.CheckIfStringIsNullOrEmpty("Middle Name", value);
            this.middleName = value;
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

    public string Id
    {
        get
        {
            return this.id;
        }

        set
        {
            ValidationMethods.CheckIfIdIsValid(value);
            this.id = value;
        }
    }

    public string PermanentAddress
    {
        get
        {
            return this.permanentAddress;
        }

        set
        {
            ValidationMethods.CheckIfStringIsEmpty("Permanent Address", value);
            this.permanentAddress = value;
        }
    }

    public string MobilePhone
    {
        get
        {
            return this.mobilePhone;
        }

        set
        {
            ValidationMethods.CheckIfStringIsEmpty("Mobile Phone", value);
            this.mobilePhone = value;
        }
    }

    public string Email
    {
        get
        { return this.email; }

        set
        {
            if (value != null)
            {
                ValidationMethods.CheckIfEmailIsValid(value);
            }
            this.email = value;
        }
    }

    public List<Payment> Payments
    {
        get
        {
            return this.payments;
        }

        private set
        {
            if (value == null)
            {
                throw new ArgumentNullException("A customer must have a list of at least one payment.");
            }
            this.payments = value;
        }
    }

    public CustomerType CustomerType
    {
        get
        {
            return this.customerType;
        }

        set
        {
            this.customerType = value;
        }
    }

    public override bool Equals(object param)
    {
        Customer customer = param as Customer;
        if (customer == null)
        {
            return false;
        }

        return this.Id == customer.Id;
    }

    public static bool operator ==(Customer firstCustomer, Customer secondCustomer)
    {
        //return firstCustomer.Equals(secondCustomer);
        return Object.Equals(firstCustomer, secondCustomer);
    }

    public static bool operator !=(Customer firstCustomer, Customer secondCustomer)
    {
        //return !firstCustomer.Equals(secondCustomer);
        return !Object.Equals(firstCustomer, secondCustomer);
    }

    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }

    public void SetCustomerType()
    {
        if (this.Payments.Count == 1)
        {
            this.CustomerType = CustomerType.OneTime;
        }
        else if (this.Payments.Count > 1)
        {
            this.CustomerType = CustomerType.Regular;
        }
        else if (this.Payments.Count >= 10)
        {
            this.CustomerType = CustomerType.Golden;
        }
        else if (this.Payments.Count >= 20)
        {
            this.CustomerType = CustomerType.Diamond;
        }
    }

    public void AddPayment(Payment payment)
    {
        this.Payments.Add(payment);
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendLine("Name: " + this.FirstName + " " + this.MiddleName + " " + this.LastName);
        result.AppendLine("ID: " + this.Id);
        result.AppendLine("Permanent Address: " + (this.PermanentAddress ?? "N/A"));
        result.AppendLine("Mobile Phone: " + (this.MobilePhone ?? "N/A"));
        result.AppendLine("Email: " + (this.Email ?? "N/A"));
        result.AppendLine("Payments:");
        foreach (var payment in this.Payments)
        {
            result.AppendLine("\t-" + payment.ToString());
        }
        return result.ToString();
    }

    public object Clone()
    {
        Customer clone = new Customer(this.FirstName, this.MiddleName, this.LastName,
            this.Id, new List<Payment>(), this.PermanentAddress, this.Email, this.MobilePhone);
        foreach (var payment in this.Payments)
        {
            clone.AddPayment(payment);
        }

        return clone;
    }

    public int CompareTo(Customer other)
    {
        string thisFullName = this.FirstName + " " + this.MiddleName + " " + this.LastName;
        string otherFullName = other.FirstName + " " + other.MiddleName + " " + other.LastName;
        if (thisFullName.CompareTo(otherFullName) == 0)
        {
            return this.Id.CompareTo(other.Id);
        }

        return thisFullName.CompareTo(otherFullName);
    }
}