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
            if (this.head == null)//if there is no element in the linked list.
            {
                return null;
            }
            this.head = this.head.next;//increment the head position to point to the next node.
            return this.head;//amd return the head postion.

        }
        internal Node popLast()//method written to remove the last element.
        {
            if(head==null)//if there is no element in the linked list.
            {
                return null;
            }
            if(head.next==null)//if there is only 1 element in the linked list.
            {
                return null;
            }
            Node newNode = head;
            while(newNode.next.next!=null)//loop will iterate till it will find the null node.
            {
                newNode = newNode.next;//it will assign the tail position to the loop position.
            }
            newNode.next = null;//it will assign the tail node position to one node before.
            return head;
        }
        internal Node Search(int number)
        {
            while(this.head!=null)//loop will continue till the tail is found
            {
                if(this.head.data==number)//if the number is found in the list.
                {
                    return this.head;//return the value of found.
                }
                this.head = this.head.next;//pointer set again
            }
            return null;//if the value is not found.
        }
        public void afterElement(Node previous,int data)
        {
            if(previous == null)//if the value entered is 0
            {
                Console.WriteLine("Invalid");
            }
            Node n1 = new Node(data);//alloction of the new node and initialization of it with the data.
            n1.next = previous.next;//the next of new node will be previous node.
            previous.next = n1;//the next of previous node will be new node.
        }
        public void deleteNode(int value)
        {
            Node temp = head, previous = null;//this will store the value of head node.
            if(temp!=null && temp.data==value)//if head is holding the value to be deleted
            {
                head = temp.next;//head will become the next node value.
                return;
            }
            while(temp!=null&&temp.data!=value)//if the linked list is not empty and head is not equal to the value
            {
                previous = temp;//searching for the value and keep track of the previous node
                temp = temp.next;//previou node will become the temp.next.
            }
            if(temp==null)//if the value is not present in the linked list.
            {
                return;
            }
            previous.next = temp.next;//remove the node from linked list.
        }
        internal Node sortLinked(Node head,int count)
        {
            Node currentPosition = head;
            Node previousPosition = currentPosition;
            Node minimumValue = currentPosition;
            Node minimumPreviousValue = minimumValue;
            Node sortedListHead = null;
            Node sortedListTail = sortedListHead;
            for(int i=0;i<count;i++)
            {
                currentPosition = head;
                minimumValue = currentPosition;
                minimumPreviousValue = minimumValue;
            }
            while(currentPosition!=null)
            {
                if(currentPosition.data<minimumValue.data)
                {
                    minimumValue = currentPosition;
                    minimumPreviousValue = previousPosition;
                }
                previousPosition = currentPosition;
                currentPosition = currentPosition.next;
            }
            if(minimumValue==head)
            {
                head = head.next;
            }
            else if(minimumValue.next==null)
            {
                minimumPreviousValue.next = null;
            }
            else
            {
                minimumPreviousValue.next = minimumPreviousValue.next.next;
            }
            if(sortedListHead!=null)
            {
                sortedListTail.next = minimumValue;
            }
            else
            {
                sortedListHead = minimumValue;
                sortedListTail = sortedListHead;
            }
            return sortedListHead; ;
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
