using System;


interface Calculator{

    public int add(int a,int b);
    public int sub(int a,int b);
    public int multiply(int a,int b);

    public int divide(int a,int b);


}

public class CalculatorM{
   

   public  int add(int a,int b){
    return a+b;
   }
   public  int sub(int a,int b){
    return a-b;
   }
   public  int multiply(int a,int b){
    return a*b;
   }
   public  int divide(int a,int b){
    return a/b;
   }
//    public void add(a,b){
//     return a+b;
//    }
    public static void Main(string []args){
   int a=10;
   int b=20;
        CalculatorM cl = new CalculatorM();
        System.Console.WriteLine("addition of num" +cl.add(a,b));
        System.Console.WriteLine("subraction of num" +cl.sub(a,b));
        System.Console.WriteLine("multiplication of num" +  cl.multiply(a,b));
        System.Console.WriteLine("division of num" +cl.divide(a,b));

    }
}