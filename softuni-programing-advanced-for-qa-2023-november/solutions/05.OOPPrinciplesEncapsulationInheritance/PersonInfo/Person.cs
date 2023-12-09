using System;

namespace PersonInfo;

public class Person
{
    private string _fistName;
    private string _lastName;
    private int _age;

    private const int NAME_MIN_LENGTH = 3;

    public Person(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public string FirstName
    {
        get { return this._fistName; }
        private set
        {
            if (value.Length < NAME_MIN_LENGTH)
            {
                throw new ArgumentException($"First name cannot contain fewer than {NAME_MIN_LENGTH} symbols!");
            }

            this._fistName = value;
        }
    }

    public string LastName
    {
        get { return this._lastName; }
        private set
        {
            if (value.Length < NAME_MIN_LENGTH)
            {
                throw new ArgumentException($"Last name cannot contain fewer than {NAME_MIN_LENGTH} symbols!");
            }

            this._lastName = value;
        }
    }

    public int Age
    {
        get { return this._age; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }

            this._age = value;
        }
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
    }
}
