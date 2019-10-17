using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> dArr = new DynamicArray<int>();
            dArr.Add(10);
            dArr.Add(15);
            dArr.Add(26);
            dArr.Add(12);
            dArr.Add(56);
            Console.WriteLine("Before");
            for (int j = 0; j < dArr.Length; j++)
            {
                Console.WriteLine(dArr[j]);
            }
            dArr.RemoveAt(2);
            dArr.InsertAt(3, 99);
            Console.WriteLine("After");
            for(int j=0;j<dArr.Length;j++)
            {
                Console.WriteLine(dArr[j]);
            }
        }
    }

    public class DynamicArray<T>
    {
        private static int length = 0;
        private static int size = 1;
        private static T[] arr = new T[size];
        public int Length
        {
            get
            {
                return length;
            }
        }

        private void GrowSize()
        {
            T[] newArr = new T[size * 2];
            for (int i = 0; i < size; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
            size = size * 2;
        }

        public void Add(T ele)
        {
            if (length == size)
            {
                GrowSize();
            }
            arr[length] = ele;
            length++;
        }

        public T this[int index]
        {
            get
            {
                return arr[index];
            }
        }

        public void InsertAt(int index,T ele)
        {
            if(index>=0)
            {
                if(length==size)
                {
                    GrowSize();
                }
                for(int j=length-1;j>=index;j--)
                {
                    arr[j+1] = arr[j];
                }
                arr[index] = ele;
                length++;
            }
        }

        public void RemoveAt(int index)
        {  
            if(size>0)
            {
            for(int i  = index;i<size-1;i++)
            {
                arr[i] = arr[i + 1];
            }
            length--;
            }
        }

    }
}
