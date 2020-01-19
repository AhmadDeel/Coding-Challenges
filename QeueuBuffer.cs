using System;

namespace BufferImplementation
{
    /// <summary>
    /// This class implements a genetic buffer using circular queue.
    /// </summary>
    /// <typeparam name="T">buffer data type</typeparam>
    class QeueuBuffer<T>
    {
        private T[] buffer;
        private int front;
        private int rear;
        private int max;
        private int count;
        public QeueuBuffer(int size)
        {
            buffer = new T[size];
            front = 0;
            rear = -1;
            max = size;
            count = 0;
        }
        public int Size() => count;
        /// <summary>
        /// Inserts new data into the buffer; if buffer is full it removes existing elements based on FIFO.
        /// </summary>
        /// <param name="data">Data to be inserted</param>
        public void insertNewData(T data)
        {
            if (count == max)
                delete();
            insert(data);
        }
        /// <summary>
        /// Inserts data array into the buffer; if buffer is full it removes existing elements based of FIFO.
        /// </summary>
        /// <param name="data">array of data</param>
        public void insertNewData(T[] data)
        {
            for (int i = 0; i < data.Length; i++)
                insertNewData(data[i]);
        }
        /// <summary>
        /// Inserts new element into buffer based on FIFO.
        /// </summary>
        /// <param name="item">data</param>
        private void insert(T item)
        {
            if (count == max)
                return;
            rear = (rear + 1) % max;
            buffer[rear] = item;
            count++;
        }
        /// <summary>
        /// Deletes buffer element based on FIFO.
        /// </summary>
        /// <returns></returns>
        private T delete()
        {
            if (count == 0)
                return default;
            front = (front + 1) % max;
            count--;
            return buffer[front];
        }
        /// <summary>
        /// Returns an array containing all buffer elements; first element is in index 0.
        /// </summary>
        /// <returns>buffer data</returns>
        public T[] getBufferValues()
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
        /// Prints all buffer elements.
        /// </summary>
        public void printBuffer()
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
