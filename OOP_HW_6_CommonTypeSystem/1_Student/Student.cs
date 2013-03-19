using System;

public class Student : ICloneable, IComparable<Student>
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public ulong SSN { get; set; }
    public string Address { get; set; }
    public string MobilePhone { get; set; }
    public string Email { get; set; }
    public byte Course { get; set; }
    public University University { get; set; }
    public Faculty Faculty { get; set; }
    public Speciality Speciality { get; set; }

    public Student(string firstName, string middleName, string lastName,
        ulong ssn, string address, string mobilePhone, string email, byte course,
        University university, Faculty faculty, Speciality speciality)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        SSN = ssn;
        Address = address;
        MobilePhone = mobilePhone;
        Email = email;
        Course = course;
        University = university;
        Faculty = faculty;
        Speciality = speciality;
    }

    public override bool Equals(object obj)
    {
        Student s = obj as Student;
        if (s == null)
        {
            return false;
        }

        if (!object.Equals(this.FirstName, s.FirstName) || 
            !object.Equals(this.MiddleName, s.MiddleName) ||
            !object.Equals(this.LastName, s.LastName) ||
            !object.Equals(this.Address, s.Address) ||
            !object.Equals(this.SSN, s.SSN) ||
            !object.Equals(this.MobilePhone, s.MobilePhone) ||
            !object.Equals(this.Email, s.Email) ||
            this.Course != s.Course || this.University != s.University ||
            this.Faculty != s.Faculty || this.Speciality != s.Speciality)
        {
            return false;
        }

        return true;
    }

    public static bool operator ==(Student first, Student second)
    {
        return Student.Equals(first, second);
    }

    public static bool operator !=(Student first, Student second)
    {
        return !(Student.Equals(first, second));
    }

    public override string ToString()
    {
        return string.Format("First name: {0}\nMiddle name: {1}\nLast name: {2}" +
            "\nAddress: {3}\nSSN: {4}\nMobile phone: {5}\nEmail: {6}\nCourse course: {7}" +
            "\nUniversity: {8}\nFaculty: {9}\nSpeciality: {10}",
            FirstName, MiddleName, LastName, Address, SSN, MobilePhone, Email, Course,
            University, Faculty, Speciality);
    }

    public override int GetHashCode()
    {
        return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode() ^
            Address.GetHashCode() ^ SSN.GetHashCode() ^ Email.GetHashCode() ^
            MobilePhone.GetHashCode() ^ Course.GetHashCode() ^ University.GetHashCode() ^
            Faculty.GetHashCode() ^ Speciality.GetHashCode();
    }

    public object Clone()
    {
        return new Student(this.FirstName, this.MiddleName, this.LastName,
            this.SSN, this.Address, this.MobilePhone, this.Email, this.Course, this.University,
            this.Faculty, this.Speciality);
    }

    public int CompareTo(Student other)
    {
        string thisFullName = this.FirstName + " " + this.MiddleName + " " + this.LastName;
        string otherFullName = other.FirstName + " " + other.MiddleName + " " + other.LastName;

        int compareNames = string.Compare(thisFullName, otherFullName, StringComparison.InvariantCulture);

        if (compareNames != 0)
        {
            return compareNames;
        }
        else
        {
            return this.SSN.CompareTo(other.SSN);
        }
    }
}
