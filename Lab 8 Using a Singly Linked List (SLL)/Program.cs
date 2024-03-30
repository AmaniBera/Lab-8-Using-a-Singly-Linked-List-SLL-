namespace Lab_8_Using_a_Singly_Linked_List__SLL_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating the List
            SinglyLinkedList sLinkedListTest = new SinglyLinkedList();

            //Adding the Names
            sLinkedListTest.AddLast(sLinkedListTest, "John Smith");
            sLinkedListTest.AddFirst(sLinkedListTest, "Joe Schmoe");
            sLinkedListTest.AddFirst(sLinkedListTest, "Joe Blow");
            sLinkedListTest.AddLast(sLinkedListTest, "Jane Doe");
            sLinkedListTest.AddLast(sLinkedListTest, "Bob Bobberson");
            sLinkedListTest.AddLast(sLinkedListTest, "Sam Sammerson");
            sLinkedListTest.AddLast(sLinkedListTest, "Dave Daverson");

            //Removing the first and the Last
            sLinkedListTest.RemoveFirst(sLinkedListTest);
            sLinkedListTest.RemoveLast(sLinkedListTest);

            //Get the value by it's index
            sLinkedListTest.GetValue(5);

            //Getting the size of the list
            sLinkedListTest.ListSize();
        }
    }
}
