using System;

namespace BufferImplementation
{
    /// <summary>
    /// this class implements a generic circular queue to manage buffers
    /// </summary>
    /// <typeparam name="T">class data type</typeparam>
    class CircularQueue<T>
    {
        private T[] buffer;
        private int front;
        private int rear;
        private int max;
        private int count;
        public CircularQueue(int size)
        {
            buffer = new T[size];
            front = 0;
            rear = -1;
            max = size;
            count = 0;
        }
        /// <summary>
        /// Insertion of new item into the circular queue
        /// </summary>
        /// <param name="item">item to insert</param>
        public void insert(T item)
        {
            if (count == max)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            rear = (rear + 1) % max;
            buffer[rear] = item;
            count++;
        }
        /// <summary>
        /// deletion of item from circular queue
        /// </summary>
        /// <returns>deleted item</returns>
        public T delete()
        {
            if (count == 0)
            {
                Console.WriteLine("Queue is Empty");
                return default;
            }
            Console.WriteLine($"deleted element is: {buffer[front]}");
            front = (front + 1) % max;
            count--;
            return buffer[front];
        }
        /// <summary>
        /// the raw values of the circular queue as an array!
        /// </summary>
        /// <returns>array of queue data</returns>
        public T[] getBuffer()
        {
            if (count == 0)
                return Array.Empty<T>();
            T[] result = new T[count];
            int i = 0;
            int j = 0;
            for (i = front; j < count;)
            {
                result[j] = buffer[i];
                i = (i + 1) % max;
                j++;
            }
            return result;
        }
        /// <summary>
        /// Prints the circular queue values
        /// </summary>
        public void printQueue()
        {
            int i = 0;
            int j = 0;
            if (count == 0)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            for (i = front; j < count;)
            {
                Console.WriteLine($"Item[{j}]: {buffer[i].ToString()}");
                i = (i + 1) % max;
                j++;
            }
        }
    }
}
