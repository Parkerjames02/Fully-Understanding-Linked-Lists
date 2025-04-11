using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullyUnderstandingLinkedLists.LinkedList
{
    // This class is for the linked list data structure that is made up of node
    // objects that are made from the node class. This class is where all of the 
    // functions for the linked list data structure are defined. Functions that are
    // used for inserting and deleting nodes and displaying node data will be defined
    // here.
    public class LinkedList
    {
        // This public node variable called "First" will be used to keep track of the
        // first node in the linked list. The question mark means that it can either
        // hold onto the first node of the linked list or be null. This variable can
        // be set and received.
        public Node? First { get; set; }

        // This function is used to insert a new node with new data into the linked
        // list. The data that is entered is passed through the function and is set
        // to the data variable of the new node. The next variable of the node is set
        // to the previous first node and this new node is set as the first node.
        public void InsertFirst(int data)
        {
            // This line is responsible for creating a new node. This will be the new
            // first node of the linked list.
            Node newNode = new Node();
            // This line is responsible for assigning the data that is passed into
            // the function as the data variable of the new node.
            newNode.Data = data;
            // This line is responsible for assigning the previous first node of the
            // linked list as the pointer of this new first node.
            newNode.Next = First;
            // This line is responsible for assigning the "First" node variable of the
            // linked list class as the new node that was created.
            First = newNode;
        }

        // This function is used to delete the first node of the linked list. We can't
        // actually delete the first node of the linked list so we are just going to
        // make the second node of the linked list the new first node so that the old
        // first node of the linked list isn't used logically. There is also a "temp"
        // node variable that is created to preserve and return the old first node
        // that was deleted.
        public Node DeleteFirst()
        {
            // This line is responsible for creating the "temp" node variable. This
            // node is created and used to preserve the first node that was deleted
            // from the linked list. The end of this function will then return this
            // node variable to the console so that the user knows what node was
            // deleted from the linked list logically.
            Node temp = First;
            // This line is responsible for making the second node of the linked list
            // the new first node. By making the second node of the linked list the
            // new first node we can essentially delete the old first node logically
            // so that it is no longer associated with the linked list.
            First = First.Next;
            // This line is responsible for returning the "temp" node variable to the
            // console so that the user can be aware of the node that was deleted
            // from the linked list.
            return temp;
        }

        // This function is used to insert a new node at the end of the linked list.
        // This means that this new node will be the new last node of the linked list
        // and the pointer of this new last node will be null. The old last node of
        // the linked list will now point to this new last node of the linked list.
        // The variable that is passed into the function is set as the data of the node.
        public void InsertLast(int data)
        {
            // This line is responsible for creating a node variable called "current"
            // and setting it to the first node in the variable. This variable will
            // be used for the while loop to check the current node in the linked list
            // and then set the variable "current" to the next node in the linked list
            // and repeat.
            Node current = First;
            // This while loop is used to iterate through the nodes of the linked list.
            // It will start with the current node (which will always be equal to the
            // first node of the linked list) and this while loop will continue to
            // iterate until the pointer variable is equal to null. In other words,
            // this while loop will continue to iterate through the entire linked
            // list until the current variable is equal to the last node of the linked
            // list.
            while (current.Next != null)
            {
                // This line means that with every iteration of this while loop the
                // "current" variable that is checked for being set to null will be
                // equal to the node that is next in the linked list.
                current = current.Next;
            }
            // This line is responsible for creating a new node. This node will be the
            // new last node of the linked list.
            Node newNode = new Node();
            // This line is responsible for setting the data variable of the new last
            // node of the linked list to the data that is passed into the function.
            newNode.Data = data;
            // This line is responsible for setting the pointer or "next" variable of 
            // the old last node in the linked to the new last node of the linked list.
            current.Next = newNode;
        }

        // This function is used to display the data of all of the nodes in the linked
        // list in order starting with the first node in the linked list. When the
        // loop is done all of the data in the linked list will be displayed to the 
        // console.
        public void DisplayFirst()
        {
            // This line is responsible for letting the user know that the function is
            // running and that the while loop is currently iterating through the 
            // linked list. The time that it takes for the function to complete
            // depends on the length of the linked list.
            Console.WriteLine("Iterating through list...");
            // This line is responsible for creating a node variable called "current"
            // and setting it equal to the first node in the variable. This variable
            // will be used for the while loop to check the current node in the linked
            // list and then set the variable "current" to the next node in the linked
            // list and repeat.
            Node current = First;
            // This while loop is used to iterate through the nodes of the linked list.
            // It will start with the current node (which will always be equal to the
            // first node of the linked list) and this while loop will continue to
            // iterate until the pointer variable is equal to null. In other words,
            // this while loop will continue to iterate through the entire linked
            // list until the current variable is equal to the last node of the linked
            // list.
            while (current != null)
            {
                // This line is responsible for taking the current node of the linked
                // list and displaying the data of that node. This "DisplayNode()"
                // function is defined in the Node.cs file in the Node class.
                current.DisplayNode();
                // This line is responsible for taking the current node variable and
                // setting it equal to the next node in the linked list.
                current = current.Next;
            }
        }
    }
}
