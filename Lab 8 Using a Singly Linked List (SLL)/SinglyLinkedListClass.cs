using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_Using_a_Singly_Linked_List__SLL_
{
    public class Node
    {
        public string data;
        public Node next;
        public int index = 0; //Index number to refer back to the value
        public Node(string d) //Initializes the new node with the new data
        {
            data = d;
            next = null;
        }
    }
    public class SinglyLinkedList
    {
        public int count = 0;
        public Node head; //references the first node

        //Adds new node in front
        public void AddFirst(SinglyLinkedList singlyList, string newData)
        {
            Node newNode = new Node(newData);
            newNode.next = singlyList.head;
            singlyList.head = newNode;
            singlyList.head.index = SetIndex(singlyList, singlyList.head.index);//Sets index
            count++;
        }
        //Add new node at the end
        public void AddLast(SinglyLinkedList singlyList, string newData)
        {
            Node newNode = new Node(newData);
            if (singlyList.head == null) //If empty
            {
                singlyList.head = newNode;
                singlyList.head.index = SetIndex(singlyList, singlyList.head.index);
                count++;
                return;
            }
            Node lastNode = GetLastNode(singlyList); //Locates the previous node at the end of the list
            lastNode.next = newNode;
            newNode.index = SetIndex(singlyList, lastNode.index); //Sets index
            count++;
        }
        //Removes the node at the start of the list
        public void RemoveFirst(SinglyLinkedList singlyList)
        {
            if (singlyList.head == null) //If no nodes to remove
            {
                return;
            }

            Node oldValue = singlyList.head;
            singlyList.head = oldValue.next;
            singlyList.count--;


        }
        //Removes the node at the end of the list
        public void RemoveLast(SinglyLinkedList singlyList)
        {
            if (singlyList.head == null) //If no nodes to remove
            {
                return;
            }

            Node current = singlyList.head;
            Node previous = null;

            while (current.next != null)
            {
                previous = current;
                current = current.next;
            }

            if (previous == null)
            {
                singlyList.head = null;
            }
            else
            {
                previous.next = null;
                current = previous.next;
            }
            singlyList.count--;
        }
        //Returns the amount of nodes
        public int ListSize()
        {
            return count;
        }
        //Gets value of node with index
        public string GetValue(int index)
        {
            if (index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.next;
            }
            string Value = current.data;
            return Value;
        }
        // Gets the last node in the list
        public Node GetLastNode(SinglyLinkedList singlyList)
        {
            Node temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        // Sets the index for each node in the list
        public int SetIndex(SinglyLinkedList singlyList, int Index)
        {
            int counter = 0;
            Node temp = singlyList.head;
            while (temp.next != null)
            {
                counter++;
                temp = temp.next;
            }
            Index = counter;
            return Index;
        }
    }

}
