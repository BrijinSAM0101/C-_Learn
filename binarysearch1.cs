using System;

class bb{
    public static int BinarySearch(int[] b,int key){

        int min=0;
        int max=b.Length-1;
        

        while(min<=max){

            int mid=(min+max)/2;
            
            if(key==b[mid]){
                return ++mid;
            }
            
            else if(key<b[mid]){
               max=mid-1;
            }
            
            else {
               min=mid+1;
            }
        }
        return -1;
    }
    public static void Main(String[] args){
        
        int []b={12,22,23,34,45,56,};
        int index= BinarySearch(b,45);

        System.Console.WriteLine("the element  is present in index "+index);

    }
}