using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenIvy.DSA
{
    public class Stack
    {
        public int[] store = new int[10];
        public int count = 0;
        public void Push(int a)
        {
            if (count<10)
            {
                store[count] = a;
                count++;
            }
            
        }

        public int Pop()
        {
            int ret = 0;
            // todo: change this
            if (count>=0)
            {
                count--;
                ret = store[count];
                store[count] = 0;
                
            }
            return ret;
        }

        public string GetValues()
        {
            var str = string.Join(",", store);
            return str;
        }
    }

    public class UserDefinedStack
    {
        private int[] _store;
        public int[] Store
        {
            get { return _store; }
            //set { _store = value; }
        }
        private int _count = 0;
        public int Count
        {
            get { return _count; }
        }
        
        public UserDefinedStack(int length)
        {
            _store = new int[length];
        }
        public void Push(int a)
        {
            if (_count < _store.Length)
            {
                _store[_count] = a;
                _count++;
            }

        }

        public int Pop()
        {
            int ret = 0;
            // todo: change this
            if (_count >= 0)
            {
                _count--;
                ret = _store[_count];
                _store[_count] = 0;

            }
            return ret;
        }

        public string GetValues()
        {
            var str = string.Join(",", _store);
            return str;
        }
    }

}
