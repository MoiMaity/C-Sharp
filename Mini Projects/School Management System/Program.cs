// See https://aka.ms/new-console-template for more information
using System;

interface IStudent
{
    void CalcTotal();
    void CalcAvg();
    void CalcGrade();
    void PrintMarksheet();
}

class Student : IStudent
{
    private int Rno;
    private string Name;
    private int Subject1;
    private int Subject2;
    private int Subject3;
    private int Total;
    private double Average;
    private string Grade;

    public Student(int rno, string name, int sub1, int sub2, int sub3)
    {
        this.Rno = rno;
        this.Name = name;
        this.Subject1 = sub1;
        this.Subject2 = sub2;
        this.Subject3 = sub3;
    }

    public void CalcTotal()
    {
        Total = Subject1 + Subject2 + Subject3;
    }

    public void CalcAvg()
    {
        Average = Total / 3;
    }

    public void CalcGrade()
    {
        if(Average >= 80.0)
        {
            Grade = "A";
        }
        else if(Average >= 60.0)
        {
            Grade = "B";
        }
        else if(Average >= 40.0)
        {
            Grade = "C";
        }
        else
        {
            Grade = "F";
        }
    }

    public void PrintMarksheet()
    {
        Console.WriteLine("Roll No :"+Rno);
        Console.WriteLine("Name :"+Name);
        Console.WriteLine("Subject 1 :"+Subject1);
        Console.WriteLine("Subject 2 :"+Subject2);
        Console.WriteLine("Subject 3 :"+Subject3);
        Console.WriteLine("Total Marks :"+Total);
        Console.WriteLine("Average :"+Average);
        Console.WriteLine("Grade :"+Grade);
    }

}

class Program
{
    static void Main()
    {
        int rollno = int.Parse(Console.ReadLine());
        string name = Console.ReadLine();
        int subject1 = int.Parse(Console.ReadLine());
        int subject2 = int.Parse(Console.ReadLine());
        int subject3 = int.Parse(Console.ReadLine());

        Student s = new Student(rollno, name, subject1, subject2, subject3);

        

        s.CalcTotal();
        s.CalcAvg();
        s.CalcGrade();
        s.PrintMarksheet();
    }
}
