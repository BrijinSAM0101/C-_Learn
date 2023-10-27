using System;


class Customer{


   public int custid{get;set;}

   
   public string name{get;set;}
   
   public int salary{get;set;}
   
   public string location{get;set;}
   
   
    // public int id {
    //     set{
    //         custid = value;
    //     }
    //     get{
    //         return custid;
    //     }
    // }
    //  public string Name { 
    //     set{
    //         name = value;
    //     }
    //     get{
    //         return name;
    //     }
        
    //  }
    //   public int Salary { 
    //     get{
    //         return salary;
    //     }
    //     set{
    //         salary = value;
    //     }
    //   }
    //    public   string Location { 
    //     get{
    //         return location;
    //     }
    //     set{
    //          location=value;
    //     }
    //    }
}
class mainCus{
    public static void Main(string []args){

        Customer cust = new Customer();
        cust.name="sam";
        cust.salary=20000;
        cust.location="CHENNAI";
        cust.custid=001;

        System.Console.WriteLine(cust.name);
        System.Console.WriteLine(cust.custid);
        System.Console.WriteLine(cust.salary);
        System.Console.WriteLine(cust.location);
        
    }
}