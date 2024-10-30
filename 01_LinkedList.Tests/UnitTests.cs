

namespace _01_LinkedList.Tests
{
    public class UnitTests
    {
        [Fact()]
        public void SLinkedList_Values_Test_retuns_empty()
        {
            SLinkedList list = new SLinkedList();

            //string[] expected = {};

            list.Values().Should().BeEmpty();
        }
        //[Fact()]
        //public void SLinkedList_Values_Test_retuns_empty()
        //{
        //    SLinkedList list = new SLinkedList();

        //    //list.Add("1");
        //    //list.Add("2");
        //    //list.Add("3");

        //    string[] expected = { "1", "2", "3" };

        //    list.Values().Should().Be(expected);
        //}
    }
}