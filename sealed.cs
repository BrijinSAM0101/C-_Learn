using System;

sealed class A{
public void function1(){
    System.Console.WriteLine("function1() is invoked");
}

}
class B 
{    
public void function2(){
    System.Console.WriteLine("function2() is invoked");
}
}
class Mtclaa{
    public static void Main(String[] args) {
          B bb=new B();
          bb.function2();
         
    }
}