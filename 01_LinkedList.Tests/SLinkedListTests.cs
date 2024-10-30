

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
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");


            var node = list.Find("4");

            node.Value.Should().Be("4");
        }

        [Fact]
        public void Find_WhenNoMatch_ReturnsNull() 
        {
            SLinkedList list = new SLinkedList();

            var node = list.Find("1");

            node.Should().BeNull();
        }

        [Fact]
        public void Delete_WhenThereIsOneElement()
        {
            SLinkedList list = new SLinkedList();
            list.Add("1");


            list.Delete(list.Find("1"));

            list.Values().Should().BeEmpty();
        }

        [Fact]
        public void Delete_MiddleElement()
        {
            SLinkedList list = new SLinkedList();
            list.Add("1");
            list.Add("2");
            list.Add("3");


            list.Delete(list.Find("2"));

            list.Values().Should().BeEquivalentTo(["1", "3"]);
        }
        [Fact]
        public void Delete_LastElement()
        {
            SLinkedList list = new SLinkedList();
            list.Add("1");
            list.Add("2");
            list.Add("3");


            list.Delete(list.Find("3"));

            list.Values().Should().BeEquivalentTo(["1", "2"]);
        }
        [Fact]
        public void Delete_FirstElement()
        {
            SLinkedList list = new SLinkedList();
            list.Add("1");
            list.Add("2");
            list.Add("3");


            list.Delete(list.Find("1"));

            list.Values().Should().BeEquivalentTo(["2", "3"]);
        }

        [Fact]
        public void TestAddAfterDeleting_InTheMiddle()
        {
            // Arrange
            SLinkedList list = new SLinkedList();
            list.Add("1");
            list.Add("2");
            list.Add("3");


            list.Delete(list.Find("2"));

            // Act
            list.Add("5");

            // Assert
            list.Values().Should().BeEquivalentTo(["1", "3", "5"]);
        }

        [Fact]
        public void TestAddAfterDeleting_Last()
        {
            // Arrange
            SLinkedList list = new SLinkedList();
            list.Add("1");
            list.Add("2");
            list.Add("3");

            list.Delete(list.Find("3"));

            // Act
            list.Add("5");

            // Assert
            list.Values().Should().BeEquivalentTo(["1", "2", "5"]);
        }

        [Fact]
        public void TestAddAfterDeleting_First()
        {
            // Arrange
            SLinkedList list = new SLinkedList();
            list.Add("1");
            list.Add("2");
            list.Add("3");

            list.Delete(list.Find("1"));

            // Act
            list.Add("5");

            // Assert
            list.Values().Should().BeEquivalentTo(["2", "3", "5"]);
        }

        [Fact]
        public void TestAddAfterDeleting_FirstAndOnly()
        {
            // Arrange
            SLinkedList list = new SLinkedList();
            list.Add("1");

            list.Delete(list.Find("1"));

            // Act
            list.Add("5");

            // Assert
            list.Values().Should().BeEquivalentTo(["5"]);
        }
    }
}