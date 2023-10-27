using System;
using System.Collections;

class Democl{

    static void Main(string[] args){
        Stack st=new Stack();
        st.Push(1);
        st.Push(21.23f);
        st.Push('B');
        st.Push("sam");


        foreach(var i in st){
            Console.WriteLine(i);
        }
    }
}