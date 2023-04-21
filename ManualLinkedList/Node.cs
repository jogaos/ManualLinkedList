using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualLinkedList
{
    internal class Node
    {
        private String value;
        private Node next;

        public Node (String value)
        {
            this.value = value;
            this.next = null;
        }

        public String getValue(){ return this.value; }

        public Node getNext(){ return this.next; }

        public void setValue (String value){ this.value = value; }

        public void setNext (Node next){ this.next = next; }

    }
}
