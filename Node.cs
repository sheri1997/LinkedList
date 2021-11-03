using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        public int data;//this will hold the data of a linked list.
        public Node next;//will hold the pointer position that will hold the data of the next node.
        public Node(int data)//constructor
        {
            this.data = data;
        }
    }
}
