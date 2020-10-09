using System;
using System.Collections.Generic;
using System.Text;

namespace _09_10_2020_pr_06
{
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
}
