using System;

namespace bai2
{
    public class Stack
    {
        private int[] elements;
        private int top;
        private int maxSize;

        public Stack(int n)
        {
            maxSize = n;
            elements = new int[maxSize];
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == maxSize - 1;
        }

        public void Push(int a)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack da full, khong the them gia tri.");
            }
            else
            {
                elements[++top] = a;
            }
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack khong co gia tri nao.");
                return -1;
            }
            else
            {
                int a = elements[top];
                top--;
                Console.WriteLine("Da lay gia tri " + a + " ra khoi Stack.");
                return a;
            }
        }

        public void OutPut()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack rong.");
            }
            else
            {
                Console.WriteLine("Cac phan tu trong Stack: ");
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine(elements[i]);
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(5);

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            if (stack.IsEmpty())
            {
                Console.WriteLine("Stack dang trong.");
            }

            stack.OutPut();
        }
    }
}