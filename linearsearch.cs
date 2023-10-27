using System;

namespace ggg
{
    
    class demo22{


    static int Linearsss(int[] number ,int target)
   {
    
    for(int i=0;i<=number.Length;i++){

        if(number[i]==target){
            return i;
        }

      
    }
  return -1;

    }
     static void Main(string[] args){
        
    
        int []number={24,32,2,75,54};

       int index= Linearsss(number ,2);

       System.Console.WriteLine("the number 2 is at index "+index);

    }
}
}