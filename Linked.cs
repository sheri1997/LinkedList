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
                temp.next = node;//change the next of last node to new node.
            }
        }
        internal Node insertBetween(int position, int data)//method with position and data.
        {
            if(position<1)//if the position is 0.
            {
                Console.WriteLine("Invalid Position");
            }
            if (position == 1)//if the position is 1
            {
                var newNode = new Node(data);//then a new node has to be created
                newNode.next = this.head;//the head node will become the next node.
                head = newNode;//next node will become the head.
            }
            else//if the position is not 1.
            {
                while (position-- != 0)//decrementing the position value till the position is 0.
                {
                    if (position == 1)//when the position will becomee 1
                    {
                        Node node = new Node(data);//the same operation is being repeated as above.
                        node.next = this.head.next;//but the new node is not created.
                        head.next = node;//the existing node is being used 
                        break;
                    }
                    head = head.next;//the new position will be the head.
                }
                if (position != 1)
                {
                    Console.WriteLine("Invalid Position");
                }
            }
            return head;//the head data is beings returned.
        }
        internal Node pop()//Pop Method is written
        {
            if(this.head==null)//if there is no element in the linked list.
            {
                return null;
            }
            this.head = this.head.next;//increment the head position to point to the next node.
            return this.head;//amd return the head postion.
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
