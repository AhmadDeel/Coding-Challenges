using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufferImplementation
{
    class LinearQueue<T>
    {
        private T[] buffer;
        private int front;
        private int rear;
        private int max;

        public LinearQueue(int size)
        {
            buffer = new T[size];
            front = 0;
            rear = -1;
            max = size;
        }
        public void insert(T item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            buffer[++rear] = item;
        }
        public T delete()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return default;
            }
            else
            {
                Console.WriteLine("deleted element is: " + buffer[front]);
                return buffer[front++];
            }
        }
        public T[] getBuffer()
        {
            if (front == rear + 1)
                return Array.Empty<T>();
            else
            {
                T[] result = new T[rear - front];
                for (int i = front; i <= rear; i++)
                    result[i - front] = buffer[i];
                return result;
            }
        }
        public void printQueue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            for (int i = front; i <= rear; i++)
                Console.WriteLine("Item[" + (i + 1) + "]: " + buffer[i]);
        }
    }
}
