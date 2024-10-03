using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_trang40
{
    class Stack
    {
        private int top; 
        private int[] s; 


        public bool empty()
        {
            return (top == -1);
        }

        public bool full()
        {
            return (top >= s.Length - 1);
        }


        public Stack()
        {
            s = new int[20];
            top = -1;
        }


        public void push(int x)
        {
            if (!full())
            {
                top++;
                s[top] = x;
            }
            else
            {
                Console.WriteLine("Stack đầy");
            }
        }

        public int pop()
        {
            if (empty())
            {
                Console.WriteLine("Stack rỗng");
                return -1; 
            }
            else
            {
                return s[top--];
            }
        }
    }

    class doiso : Stack
    {
        private int n;


        public void nhap()
        {
            Console.Write("Nhap vao so can đoi: ");
            n = Convert.ToInt32(Console.ReadLine());
        }


        public void doi()
        {
            int d;
            while (n > 0)
            {
                d = n % 2; 
                push(d);   
                n = n / 2;  
            }
        }

        public void hien()
        {
            Console.Write("So nhi phan la: ");
            while (!empty())
            {
                Console.Write(pop()); 
            }
            Console.WriteLine();
        }
    }

    class tester
    {
        static void Main()
        {
            doiso d = new doiso();
            d.nhap(); 
            d.doi();  
            d.hien(); 
            Console.ReadKey();
        }
    }
}
