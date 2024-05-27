namespace StudentManagerV3.Entities;

public class Student
{
    public string _name { get; set; }
    public string _id { get; set; }
    public int _yob { get; set; }
    public double _gpa { get; set; }

    public Student(string name, string id, int yob, double gpa)
    {
        _name = name;
        _id = id;
        _yob = yob;
        _gpa = gpa;
    }

    public override string ToString()
    {
        return $"{nameof(_name)}: {_name}, {nameof(_id)}: {_id}, {nameof(_yob)}: {_yob}, {nameof(_gpa)}: {_gpa}";
    }
}