

namespace _01_LinkedList.Tests
{
    public class SLinkedListTests
    {
        [Fact]
        public void NewListIsEmpty()
        {
            SLinkedList list = new SLinkedList();

            list.Values().Should().BeEmpty();
        }

        [Fact]
        public void CanAddSingle()
        {
            SLinkedList list = new SLinkedList();

            list.Add("1");

            string[] expected = { "1" };

            list.Values().Should().BeEquivalentTo(expected);
        }
    }
}