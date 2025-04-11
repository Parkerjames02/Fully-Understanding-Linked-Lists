// Linked Lists

// The Step-By-Step Of Implementing Linked Lists
// 1. Create a Node class for the linked list data structure. Each node will:
//      - Have a variable called "Data" where the data of the node is contained.
//      - Have a variable called "Next" that points to the next node in the linked list.
//      - Define a "DisplayNode" variable to print the data of each node.
// 2. Create a Linked List class to define functions for the nodes. It has:
//      - A variable called "First" which represents the first node of the linked list.
//      - A "InsertFirst" function that is used to:
//              - Create a new node
//              - Set the nodes data variable to the data that was passed into the function.
//              - Set the nodes next variable to the previous first node.
//              - Set this new node as the new first node of the linked list.
//      - A "DeleteFirst" function that is used to:
//              - Create a temporary first node
//              - Assign the second node of the linked list as the new first node.
//              - And return the temp node.
//      - A "InsertLast" function that is used to:
//              - Create a node variable called current to iterate through the linked list and set it equal to the first variable.
//              - Use a while loop to iterate through all the nodes of the linked list.
//              - Create a new node.
//              - Set the nodes data variable to the data that was passed into the function.
//              - Set the pointer of the last node in the linked list to the new node.
//      - A "DisplayList" function that is used to:
//              - Print "Iterating through list..." message to the console.
//              - Create a node variable called current to iterate through the linked list and set it equal to the first variable.
//              - Use a while loop that will run until the null pointer is found.
//              - This loop uses the "DisplayNode" function in the Node class to print the data of the current node.
//              - It then makes the next node in the linked list the current node.
// 3. Create a linked list on the program.cs file and use functions to fill in the linked list.

// This line is used to make sure that I can create a linked list and use functions
// that are defined in the linked list class.
using FullyUnderstandingLinkedLists.LinkedList;

// This line is responsible for creating a new linked list from the linked list
// class. Because this linked list is made from the linked list class I can use
// the functions that are defined in the linked list class to insert, delete,
// and display the data of the nodes in the linked list.
LinkedList linkedList = new LinkedList();
// The lines 49-52 are responsible for inserting a new node with new data into
// the linked list. Integers are passed into this function and that integer
// is the data that will be assigned to the node upon insertion. The first
// node inserted into the list is a node with the integer of "1". Then a new
// node is inserted with the integer of "2" into the front of the linked list
// and it points to the node that has an integer of "2". This cycle continues
// until the linked list starts with the number "4" and ends with "1".
linkedList.InsertFirst(1);
linkedList.InsertFirst(2);
linkedList.InsertFirst(3);
linkedList.InsertFirst(4);

// The lines 60-61  are responsible for deleting the first node of the linked
// list logically. This is done by making the node variable "first" equal to
// the second node in the linked list. This function is called twice so that
// the first two nodes of the linked list that contains the integers "4" and
// "3" are removed from the linked list. The only nodes that remain now are
// "2" and "1".
linkedList.DeleteFirst();
linkedList.DeleteFirst();

// The lines 69-70 are responsible for inserting a new node at the end of the
// linked list. This is done through first iterating through the entirety
// of the linked list to find the last node in the list and then making that
// node point to a new node with the new data. These two new nodes hold the
// integer data of "546" and "3434". The linked list now contains nodes that
// hold "2", "1", "546", and "3434".
linkedList.InsertLast(546);
linkedList.InsertLast(3434);

// This line is responsible for displaying the data of all of the nodes in
// the linked list to the console. It first tells the user that the linked
// list is correctly being iterated through and then prints the data of the
// nodes in order starting with the first node of the linked list. The data
// that is printed to the console is "2", "1", "546", and "3434".
linkedList.DisplayList();