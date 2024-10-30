using FluentAssertions.Equivalency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_LinkedList;

namespace _01_LinkedList.Tests
{
    public class NodeTests
    {
        [Fact]
        public void TestNewNode_CanGetValue ()
        {
            const string value = "value";
            var node = new SNode(value);

            node.Value.Should().Be(value);
        }

        [Fact]
        public void TestNewNode_CanGetNext()
        {
            var node2 = new SNode("value1");
            var node1 = new SNode("value2", node2);

            node1.Next.Should().Be(node2);
        }
    }
}
