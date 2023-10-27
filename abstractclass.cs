using System;

abstract class vehicle{

    public abstract void color();
    public void engine(){
        System.Console.WriteLine("cc of engine is :2000");
    }
}
class car: vehicle
{
     public override void color(){
        System.Console.WriteLine("car is green in color");
     }
}
class mycls{
    public static void Main(String[] args){
        car c=new car();
        c.color();
        c.engine();
         
    }
}