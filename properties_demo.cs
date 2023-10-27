using System;


class Employee
{

    public int id{get;set;}  //auto implemented properties or auto porperties

    public string name{get;set;}
    public string loc="bangalore";

    public string  location{
        get{
            return loc;
        }
    }
    int mbnum;
    public int mobilenumber{
        set{
            mbnum=value;
        }
    }
    string city="mysore";
    public string City{
        get{
          return city;
        }
        set{
           city=value;
        }
    }

}
class A{
     static void Main(string[] args) {
      Employee e1=new Employee();
      e1.id=101;
      e1.name="sam";

      System.Console.WriteLine("employe id 1:"+e1.id);
      System.Console.WriteLine("employe name 1:"+e1.name);
      
      Employee e2=new Employee();
      e2.id=102;
      e2.name="nawin";

      System.Console.WriteLine("employe id 2:"+e2.id);
      System.Console.WriteLine("employe name 2:"+e2.name);

      System.Console.WriteLine("location of employee "+e1.location);
      e1.mobilenumber=973626833;

      System.Console.WriteLine("city of employee : "+e1.City);
      e1.City="chennai";
      System.Console.WriteLine("city of employee  :"+e1.City);
    }
}