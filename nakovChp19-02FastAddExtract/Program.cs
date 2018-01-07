using System;
using System.Collections.Generic;

//Implement a data structure, which can quickly do the following two
//operations: add an element and extract the smallest element. The
//structure should accept adding duplicated elements.

namespace MyStruct
{
    class FastAddExtract<T>
        where T : IComparable
    {
        private List<T> elem;
        private T minElem;
        public FastAddExtract(T value)
        {
            this.elem = new List<T>();
            this.minElem = value;
        }

        public void Add(T element)
        {
            this.elem.Add(element);
            if (minElem.CompareTo(element) == 1)
            {
                this.minElem = element;
            }
        }

        public T MinElement
        {
            get
            {
                return this.minElem;
            }
        }
    }

    public class FastOperTest
    {
        public static void Main(string[] args)
        {
            FastAddExtract<int> testList = new FastAddExtract<int>(44);
            testList.Add(258);
            testList.Add(259);
            testList.Add(35);
            Console.WriteLine(testList.MinElement);
            FastAddExtract<string> myList2 = new FastAddExtract<string>("testPiece");
            myList2.Add("jkl");
            myList2.Add("jukilop");
            Console.WriteLine(myList2.MinElement);
        }
    }
}