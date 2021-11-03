using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Linked
    {
        internal Node head;//every node is having its head which is the starting of the linked list.
        internal void Add(int data)//this method will add the data.
        {
            Node node = new Node(data);//instance of the node class.
            if(this.head==null)//if the list is empty
            {
                this.head = node;//push the first data in the list.
            }
            else
            {
                Node temp = head;//if there is already data in the list
                while(temp.next!=null)//will check where is the next empty position.
                {
                    temp = temp.next;//reiterating it again
                }
                temp.next = node;
            }
        }
        internal void Display()//method used to display the linked list.
        {
            Node temp = this.head;//inintialize the pointer to head.
            if(temp==null)//if the head is empty then the list is empty.
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            while(temp!= null)//will check till the empty node is found.
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
    }
}
