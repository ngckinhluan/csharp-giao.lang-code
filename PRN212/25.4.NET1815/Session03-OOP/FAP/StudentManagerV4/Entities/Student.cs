namespace StudentManagerV4.Entities;

public class Student
{
    public string _id { get; set; }
    public string _name { get; set; }
    public int  _yob { get; set; }
    public double _gpa { get; set; }

    public Student()
    {
    }
    public Student(string id, string name)
    {
        _id = id;
        _name = name;
    }
}