﻿using System;
using System.Collections.Generic;
using System.Text;

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
}
