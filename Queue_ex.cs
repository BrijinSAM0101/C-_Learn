using System;
using System.Collections;

class Items{
    public static void Main(string []args){
        Queue qo=new Queue();
        qo.Enqueue("sam");
        qo.Enqueue(1234);
        qo.Enqueue('G');
        qo.Enqueue(true);
        qo.Enqueue(89.4);

        qo.Dequeue();

        System.Console.WriteLine(qo.Count);

        foreach (var va in qo){
            Console.WriteLine(va);
        }
    }
}