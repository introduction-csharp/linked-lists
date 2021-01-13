using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample.Lib
{
    public class IntegerLinkedList
    {
        IntegerNode _head;

        public IntegerLinkedList(int n)
        {
            _head = new IntegerNode(n, null);
        }

        public IntegerLinkedList()
        {
            _head = null;
        }

        public int Count {
            get
            {
                if (_head == null) return 0;
                return _head.Count;
            }
        }
        public int Sum {
            get
            {
                if (_head == null) return 0;
                return _head.Sum;
            }
        }

        public void Append(int v)
        {
            if (_head == null)
                _head = new IntegerNode(v, null);
            else
                _head.Add(v);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    class IntegerNode
    {
        int _value;
        IntegerNode _next;

        public int Value {  get { return _value; } }

        public int Count {  
            get {
                if (_next == null)
                    return 1;
                return 1 + _next.Count;
            } 
        }
        public int Sum
        {
            get
            {
                if (_next == null)
                    return _value;
                return _value + _next.Sum;
            }
        }

        public IntegerNode Next {  
            get { return _next; }
            set { _next = value; }
        }

        public IntegerNode(int v, IntegerNode n)
        {
            _value = v;
            _next = n;
        }

        public void Add(int v)
        {
            if (_next == null)
                _next = new IntegerNode(v, null);
            else
                _next.Add(v);
        }
    }
}
