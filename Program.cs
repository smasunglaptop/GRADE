using System;

public class Program
{
  public static void Main (string[] args)
  {
    Console.WriteLine("ENTER YOUR MARKS");
    
    int Marks = Convert.ToInt32(Console.ReadLine());

    if(Marks < 33)
    {
      Console.WriteLine("Fail.GPA=0.00");
    }
    else if(Marks > 32 && Marks <= 39)
    {
      Console.WriteLine("D.GPA=1.00");
    }
    else if(Marks > 39 && Marks <= 49)
    {
      Console.WriteLine("C.GPA=2.00");
    }
    else if(Marks > 49 && Marks <= 59)
    {
      Console.WriteLine("B.GPA=3.00");
    }
    else if(Marks > 59 && Marks <= 69)
    {
      Console.WriteLine("A-.GPA=3.50");
    }
    else if(Marks > 69 && Marks <= 79)
    {
      Console.WriteLine("A.GPA=4.00");
    }
    else if(Marks > 79 && Marks <= 100)
    {
      Console.WriteLine("A+.GPA=5.00");
    }
    else
    {
      Console.WriteLine("Invalid input. Marks should be between 0 and 100.");
    }
  }
}
