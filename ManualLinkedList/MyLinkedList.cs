using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualLinkedList
{
    internal class MyLinkedList
    {
        private String name;
        private Node head;

        public MyLinkedList(string name)
        {
            this.name = name;
            this.head = null;
        }

        public String getName()
        {
            return this.name;
        }

        public Node getHead()
        {
            return this.head;
        }

        public void setName(String name){ this.name = name; }

        public void setHead(Node head) { this.head = head; }    

        public bool IsListEmpty()
        {
            return this.head == null;
        }

        public void Add(Node node)
        {
            if (IsListEmpty())
            {
                this.head = node;
            }else
            {
                Node last = this.head;

                while(last.getNext() != null)
                {
                    last = last.getNext();
                }

                last.setNext(node);
            }
        }

        public void Print()
        {
            Console.WriteLine(this.name);

            Node actual = this.head;

            while(actual != null)
            {
                Console.WriteLine(actual.getValue());
                actual = actual.getNext();
            }
        }
    }
}
