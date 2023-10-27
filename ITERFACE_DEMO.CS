using System;

interface myinter1{
    public void function1();

}
interface myinter2{

    public void function2();
}

class india : myinter1,myinter2
{
    public void function1(){
        System.Console.WriteLine("hello form fun1");
    }
     public void function2(){
        System.Console.WriteLine("hello form fun2");
    }
}

class Mainc{
    public static void Main(String[] args){
        india i =new india();
        i.function1();
        i.function2();
    }
}

