namespace StudentManagerV2.Entities;

public class Student
{
    private string _id;
    private string _name;
    private double _gpa;
    private int _yob;

    public Student()
    {
    }
    
    public Student(string id, string name)
    {
        _id = id;
        _name = name;
    }
    // Phễu, đổ data từ ngoài vào trong
    // Ctrl . -> Generate constructor
    public Student(string id, string name, double gpa, int yob)
    {
        _id = id;
        _name = name;
        _gpa = gpa;
        _yob = yob;
    }

    public override string ToString() => $"{_id} | {_name} | {_yob} | {_gpa}";

    public void SetYob(int yob) => _yob = yob;

    public void SetGpa(double gpa) => _gpa = gpa;
    
    
    
    
    
    
}