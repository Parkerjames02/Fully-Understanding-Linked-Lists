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