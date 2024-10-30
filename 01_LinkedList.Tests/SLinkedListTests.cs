

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

        [Fact]
        public void CanAddTwo()
        {
            SLinkedList list = new SLinkedList();

            list.Add("1");
            list.Add("2");

            string[] expected = { "1", "2" };

            list.Values().Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void CanAddThree()
        {
            SLinkedList list = new SLinkedList();

            list.Add("1");
            list.Add("2");
            list.Add("3");

            string[] expected = { "1", "2", "3" };

            list.Values().Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Find_WhenMatch_ReturnsMatchingNode()
        {
            SLinkedList list = new SLinkedList();
            list.Add("1");

            var node = list.Find("1");

            node.Should().BeEquivalentTo(new SNode("1"));
        }

        [Fact]
        public void Find_WhenNoMatch_ReturnsNull() 
        {
            SLinkedList list = new SLinkedList();

            var node = list.Find("1");

            node.Should().BeNull();
        }
    }
}