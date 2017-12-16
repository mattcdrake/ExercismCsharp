using System;
using System.Linq;
using System.Collections.Generic;

public class School
{
    private List<Student> s_list = new List<Student>();

    public void Add(string student, int grade)
    {
        s_list.Add(new Student(student, grade));
    }

    public IEnumerable<string> Roster()
    {
        IEnumerable<string> output = from Student in s_list
                                     orderby Student.grade, Student.name
                                     select Student.name;
        return output;
    }

    public IEnumerable<string> Grade(int grade)
    {
        IEnumerable<string> output = from Student in s_list
                                     where Student.grade == grade
                                     orderby Student.name
                                     select Student.name;
        return output;
    }
}

public class Student
{
    public string name { get; set; }
    public int grade { get; set; }

    public Student(string name, int grade)
    {
        this.name = name;
        this.grade = grade;
    }
}