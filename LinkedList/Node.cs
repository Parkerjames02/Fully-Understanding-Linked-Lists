using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullyUnderstandingLinkedLists.LinkedList
{
    // This node class will be used to create the nodes that make up the linked list.
    // Nodes can be seen as objects that come to make the data structure called a
    // linked list. All nodes in the the linked list hold data (in this case an
    // integer) and a pointer that points to the next node in the linked list. These
    // pointers are how all of the nodes in the linked list connects to one another.
    // The last node of the link list will always have a Next variable that is null.
    public class Node
    {
        // This public integer variable called "Data" is the variable that stores the
        // data for each node. It has get and set properties so that the value in the
        // variable can be set and received.
        public int Data { get; set; }

        // This public node variable called "Next" is the variable that points to the
        // next node in the linked list. The ? at the end of Node just means that
        // that variable can either be set to a reference to the next node or null. We
        // do this because the last nodes pointer will always be null and we want
        // the program to know that it is intended. This variable can also be set
        // and received.
        public Node? Next { get; set; }

        // This public void function simply displays the data variable to the
        // console. This function will be used in another function that will be
        // defined in the linked list class (LinkedList.cs file).
        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }
    }
}
