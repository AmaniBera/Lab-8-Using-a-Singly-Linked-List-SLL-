using Lab_8_Using_a_Singly_Linked_List__SLL_;
using System.Xml.Linq;

namespace SLL_Unit_Test
{
    [TestFixture]
    public class SSL_Test
    {
        private SinglyLinkedList sLinkedListTest;
        [SetUp]
        public void Setup()
        {
            sLinkedListTest = new SinglyLinkedList();
            Console.WriteLine("Setup: SinglyLinkedList initialized.");
        }

        [Test]
        public void AddFirstTest()
        {
            sLinkedListTest.AddFirst(sLinkedListTest, "Jane Doe");
            sLinkedListTest.AddFirst(sLinkedListTest, "John Smith");

            Assert.AreEqual("John Smith", sLinkedListTest.GetValue(0));
            Assert.AreEqual(2, sLinkedListTest.ListSize());
        }
        [Test]
        public void AddLastTest()
        {
            sLinkedListTest.AddLast(sLinkedListTest, "Joe Blow");

            Assert.AreEqual(1, actual: sLinkedListTest.ListSize());
        }
        [Test]
        public void RemoveFirstTest()
        {
            string[] names = { "Joe Blow", "Joe Schmoe", "John Smith", "Jane Doe", "Bob Bobberson", "Sam Sammerson", "Dave Daverson" };
            foreach (var name in names)
            {
                sLinkedListTest.AddLast(sLinkedListTest, name);
                Console.WriteLine(name);
            }

            
            sLinkedListTest.RemoveFirst(sLinkedListTest);
            Console.WriteLine("After RemoveFirst:");

            
            Node temp = sLinkedListTest.head;
            while (temp.next != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }

            Assert.AreEqual(names.Length - 1, sLinkedListTest.ListSize());
            Assert.AreEqual("Joe Schmoe", sLinkedListTest.GetValue(0));
        }
        [Test]
        public void RemoveLastTest() 
        {
            string[] names = { "Joe Blow", "Joe Schmoe", "John Smith", "Jane Doe", "Bob Bobberson", "Sam Sammerson", "Dave Daverson" };
            foreach (var name in names)
            {
                sLinkedListTest.AddLast(sLinkedListTest, name);
            }
            sLinkedListTest.RemoveLast(sLinkedListTest);

            Assert.AreEqual(names.Length - 1, sLinkedListTest.ListSize());
            Assert.AreEqual("Sam Sammerson", sLinkedListTest.GetValue(sLinkedListTest.ListSize() - 1));
        }
        [Test]
        public void GetValueTest()
        {
            sLinkedListTest.AddLast(sLinkedListTest, "Joe Blow");
            sLinkedListTest.AddLast(sLinkedListTest, "Joe Schmoe");

            Assert.AreEqual("Joe Blow", sLinkedListTest.GetValue(0));
            Assert.That(sLinkedListTest.GetValue(1), Is.EqualTo("Joe Schmoe"));
            Console.WriteLine("GetValueTest passed: Correct values retrieved.");
        }

        [Test]
        public void SizeTest()
        {
            Assert.AreEqual(0, sLinkedListTest.ListSize());
            Console.WriteLine("SizeTest passed: Size is 0 as expected.");
        }

    }
}