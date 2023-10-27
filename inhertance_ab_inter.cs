using System;

// interface Iinterface1
// {
//     public void add();
// }
// interface Iinterface2 : Iinterface1
// {
//     public void multiply();

// }

// class derivedclass: Iinterface2{

//     public void add()
//     {
//         System.Console.WriteLine("add() is invoked");
//     }
//     public void multiply()
//     {
//         System.Console.WriteLine("multiply() is invoked");
//     }

//      public static void Main(string [] args){
//            derivedclass dc=new derivedclass();
//            dc.add();   
//            dc.multiply();
//     }
// }

abstract class Ab1
{
    public abstract void add();
}
abstract class Ab2 : Ab1
{
    public abstract void multiply();

}
class derivedclass:Ab2
{
    public override void add(){
        System.Console.WriteLine("add() is invoked");
    }
    public override void multiply(){
        System.Console.WriteLine("multiply() is invoked");
    }
    
    public static void Main(string[] args){
    derivedclass dc=new derivedclass();
    dc.add();
    dc.multiply();
    }
}