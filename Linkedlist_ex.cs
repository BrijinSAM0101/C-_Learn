using System;

using System.Collections;

class Node{
     public int data;
     public Node next;
}

class Linkedlist{
    

    public Node head;

   public  LinkedList(){
    head=null;
   }

    public static void Main(string []args){
        Linkedlist l = new Linkedlist();


         Node first=new Node();
         first.data=432;
         first.next=null;
         ll.head=first;
         

         Node second=new Node();
         second.data=432;
         second.next=null;
          first .next=second;


         Node third=new Node();
         third.data=432;
         third.next=null;
         second .next=third;

          Node fourth=new Node();
         fourth.data=432;
         fourth.next=null;
         third .next=fourth;

         Node fifth=new Node();
         fifth.data=432;
         fifth.next=null;
         fourth .next=fifth;


    }
}