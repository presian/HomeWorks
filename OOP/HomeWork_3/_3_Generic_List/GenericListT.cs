using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Generic_List
{
    [Version(0,11)]
    public class GenericList<T> where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;
        private  T[] elements;
        private int count = 0;
        public GenericList(int capacity = DefaultCapacity)
        {
            elements = new T[capacity];
        }

        public int Count
        {
            get { return this.count; }
        }

        public void Add(T element)
        {
            elements[count] = element;
            count++;
            if (count == elements.Length)
            {
                T[] temp1 = new T[elements.Length * 2];
                for (int i = 0; i < elements.Length; i++)
                {
                    temp1[i] = elements[i];
                }
                elements = temp1;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < count && index >= 0)
                {
                    T result = elements[index];
                    return result;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("index","The index of element cannot be smaller than 0 and bigger than " + count + "!");
                }
            }
        }

        public void RemoveAtIndex(int index)
        {
            if (index>0&&index<elements.Length)
            {
                T[] temp = new T[elements.Length-1];
                int a = 0;
                for (int i = 0; i < elements.Length; i++)
                {
                    if (i!=index)
                    {
                        temp[a] = elements[i];
                        a++;
                    }
                }

                elements = temp;
                count--;
            }
            else
            {
                throw new ArgumentOutOfRangeException("index", "The index of element cannot be smaller than 0 and bigger than " + count + "!");
            }
        }

        public void Insert(int position, T value)
        {
            if (position<=count&&position>=0)
            {
                T[] temp = new T[elements.Length+1];
                if (position==elements.Length)
                {
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if (i<elements.Length)
                        {
                            temp[i] = elements[i];
                        }
                        else
                        {
                            temp[i] = value;
                        }
                    }
                }

                for (int i = 0; i < temp.Length; i++)
                {
                    if (i<position)
                    {
                        temp[i] = elements[i];
                    } 
                    else if (i==position)
                    {
                        temp[i] = value;
                    }
                    else
                    {
                        temp[i] = elements[i - 1];
                    }
                }

                elements = temp;
                count++;
                if (count==elements.Length)
                {
                    T[] temp1 = new T[temp.Length*2];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        temp1[i] = temp[i];
                    }
                    elements = temp1;
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("index", "The index of element cannot be smaller than 0 and bigger than " + count + "!");
            }
        }

        public void Clear()
        {
            T[] temp = new T[elements.Length];
            elements = temp;
        }

        // If cannot find element with same value return -1;
        public int IndexFinder(T value)
        {
            int count = 0;
            int index = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].Equals(value))
                {
                    count++;
                    index = i;
                    break;
                }
            }
            if (count==0)
            {
                return -1;
            }
            else
            {
                return index;
            }
        }

        public bool IsContainValue(T value)
        {
            int counter = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].Equals(value))
                {
                    counter++;
                    break;
                }
            }
            if (counter==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string PrintingList()
        {
            string output = "{";
            for (int i = 0; i < count; i++)
            {
                if (i==0)
                {
                    output = output + elements[0];
                }
                else
                {
                    output = output + ", " + elements[i];
                }
            }

            output = output + "}";
            return output;
        }

        public T Min ()
        {
            if (count<1)
            {
                throw new InvalidOperationException("The list is empty!");
            }
            else
            {
                T min = elements[0];
                for (int i = 0; i < count; i++)
                {
                    if (elements[i].CompareTo(min) < 0)
                    {
                        min = elements[i];
                    }
                }

                return min;
            } 
        }

        public T Max()
        {
            if (count<1)
            {
                throw new InvalidOperationException("The list is empty!");
            }
            else
            {
                T max = elements[0];
                foreach (T element in elements)
                {
                    if (element.CompareTo(max) > 0)
                    {
                        max = element;
                    }
                }

                return max;
            }
        }
    }

    
}
