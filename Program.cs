using System;

namespace _09_10_2020_pr_06
{

  public class Person
  {
    private string first_name;
    private string second_name;
    private System.DateTime DateOfBirth;

    public Person(string first_name, string second_name, System.DateTime DateOfBirth)
    {
      this.first_name = first_name;
      this.second_name = second_name;
      this.DateOfBirth = DateOfBirth;
    }

    public Person() { first_name = "John"; second_name = "Smith"; DateOfBirth = new DateTime(1970, 1, 1); }
    public string First_name { get; set; }
    public string Second_name { get; set; }
    public string _DateOfBirth
    {
      get {
        return _DateOfBirth;
      }

      set {
        _DateOfBirth = value;
      }
    }
    public override string ToString()
    {
      return first_name + " " + second_name + ", " + DateOfBirth;
    }

    public virtual string ToShortString()
    {
      return first_name + " " + second_name;
    }
  }
  
  public class Paper
  { 
    public string title { get; set; } 
    public Person author { get; set; }
    public DateTime date_of_pub { get; set; }

    public Paper(string title, Person author, System.DateTime date_of_pub)
    {
      this.title = title;
      this.author = author;
      this.date_of_pub = date_of_pub;
    }

    public Paper() { title = "123"; author = new Person(); date_of_pub = new DateTime(1, 1, 1970); }

    public override string ToString()
    {
      return title + " " + author + ", " + date_of_pub;
    }

  }

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
