/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisConstructor
{
    public class Employee
    {
        public string fname;
        public string lname;
        public int age;
        public Employee(string fn, string ln, int ag)//contructor
        {
            this.fname = fn;//this is a refrence variable
            this.lname = ln;
            this.age = ag;
        }
        public static void Main()
        {
            Employee oEmployee = new Employee("Raj", "singh", 23);
            oEmployee.DisplayMessage();
            Console.ReadLine();
        }
        public void DisplayMessage()
        {
            Console.WriteLine(this.fname+" "+this.lname+" "+this.age);
        }
    }
}*/

/*using System;

    public class Employee
    {
        public string fname;
        public string lname;
        public int age;
        public Employee()//default contructor
        {

    }
    public Employee(string fn, string ln, int ag)//parametrize contructor
    {
        Employee e1 = new Employee();
        e1.fname = fn; //e1 is not able to taking the address of fname
        e1.lname = ln; // e1 is lost the data
        e1.age = ag;

    }
    public static void Main()
        {
        Employee e1 = new Employee("Raj","Kumar", 43 );
        e1.DisplayMessage();
        Console.ReadLine();
            }
        public void DisplayMessage()
        {
        Employee e1 = new Employee();
        Console.WriteLine(e1.fname+" "+e1.lname+" "+e1.age);
        }
    }
    */
/*using System;

public class Employee
{
    public string fname;
    public string lname;
    public int age;
    public Employee()//default contructor
    {

    }
    public Employee(string fn, string ln, int ag)//parametrize contructor
    {
        Employee e1 = new Employee();
        this.fname = fn; 
        this.lname = ln; // this is use to refer current class object
        this.age = ag;

    }
    public static void Main()
    {
        Employee e1 = new Employee("Raj", "Kumar", 43);
        e1.DisplayMessage();
        Console.ReadLine();
    }
    public void DisplayMessage()
    {
        Employee e1 = new Employee();
        Console.WriteLine(this.fname + " " + this.lname + " " + this.age);
    }
}
*/
// this is use to access method to access variable to access constructor
/*using System;

public class Employee
{
    public string fname;
    public string lname;
    public int age;
    public Employee()//default contructor
    {

    }
    public Employee(string fn, string ln, int ag)//parametrize contructor
    {
        Employee e1 = new Employee();
        this.fname = fn; 
        this.lname = ln; 
        this.age = ag;

    }
    public static void Main()
    {
        Employee e1 = new Employee("Raj", "Kumar", 43);
        e1.DisplayMessage();
        Console.ReadLine();
    }
    public void DisplayMessage()
    {
        this.GetData();
        Employee e1 = new Employee();
        Console.WriteLine(this.fname + " " + this.lname + " " + this.age);
    }
    public void GetData()
    {
        Console.WriteLine("I am from getdata method");
    }
}*/
