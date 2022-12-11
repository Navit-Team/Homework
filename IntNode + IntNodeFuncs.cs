using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            IntNode chain, pos;
            chain = new IntNode(5);
            pos = new IntNode(5, chain);
            while (pos != null)
            {
                max = Math.Max(max, pos.GetValue());
                pos = pos.GetNext();
            }

        }
    }
    public class IntNode
    {
        private int value;
        private IntNode next;
        public IntNode(int value)
        {
            this.value = value;
            this.next = null;
        }
        public IntNode(int value, IntNode next)
        {
            this.value = value;
            this.next = next;
        }
        public int GetValue()
        {
            return this.value;
        }
        public IntNode GetNext()
        {
            return this.next;
        }

        public bool HasNext()
        {
            return (this.next != null);
        }

        public void SetValue(int value)
        {
            this.value = value;
        }
        public void SetNext(IntNode next)
        {
            this.next = next;
        }
        public override string ToString()
        {
            return "VALUE:" + this.value;
        }



    }
    class IntNodeFunc
    {
        public int NodeLength(IntNode n)
        {
            int counter = 0;
            while (n != null)
            {
                counter++;
                n = n.GetNext();
            }
            return counter;
        }
        public int CountVal(IntNode n, int val)
        {
            int counter = 0;

            while (n != null)
            {
                if (n.GetValue() == val)
                {
                    counter++;
                }
                n = n.GetNext();
            }

            return counter;
        }

        public double GetAvg(IntNode n)
        {
            int sum = 0; int counter = 0;
            while (n != null)
            {
                sum += n.GetValue();
                counter++;
                n = n.GetNext();
            }
            return (sum / counter);
        }
        public IntNode GetMaxValuePointer(IntNode n)
        {
            int maxVal = int.MinValue;
            IntNode maxNodeVal = null;

            while (n != null)
            {
                if (n.GetValue() > maxVal)
                {
                    maxVal = n.GetValue();
                    maxNodeVal = n;
                }
            }

            return maxNodeVal;
        }

        public  int GetMaxValue(IntNode n)
        {
            int maxVal = int.MinValue;

            while (n != null)
            {
                if (n.GetValue() > maxVal)
                {
                    maxVal = n.GetValue();
                }
            }
            return maxVal;
        }
    }
}