using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bai5
{
    public class Queue
    {
        private int[] a;   
        private int n;     
        private int top;   
        
        public Queue(int n)
        {
            this.n = n;
            top = 0;
            a = new int[n];
        }

        
        public bool isEmpty()
        {
            return top == 0;
        }

        
        public bool isFull()
        {
            return top == n;
        }

        
        public void push(int ptu)
        {
            if (!isFull())
            {
                a[top++] = ptu;  
            }
            else
            {
                Console.WriteLine("Queue đã đầy. Không thể thêm phần tử.");
            }
        }

        
        public int pop()
        {
            if (!isEmpty())
            {
                int removed = a[0];  
                for (int i = 1; i < top; i++)  
                {
                    a[i - 1] = a[i];
                }
                top--;  
                return removed;
            }
            else
            {
                Console.WriteLine("Queue rỗng. Không thể lấy phần tử.");
                return -1;  
            }
        }

        
        public void display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue rỗng.");
            }
            else
            {
                Console.WriteLine("Các phần tử trong Queue:");
                for (int i = 0; i < top; i++)
                {
                    Console.Write(a[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập độ dài tối đa của Queue: ");
            int maxLength = int.Parse(Console.ReadLine());
            Queue q = new Queue(maxLength);

            while (true)
            {
                Console.WriteLine("Nhập phần tử để thêm vào queue (hoặc nhập 0 để dừng): ");
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    break;
                }

                q.push(input);
            }

            Console.WriteLine("Các phần tử trong Queue:");
            q.display();
        }
    }
}
