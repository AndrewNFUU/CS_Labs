using System;
using System.Collections;

namespace lab13_collection
{
    public class DStringCollection : IEnumerable
    {
        private Queue decimalStringQueue;

        public DStringCollection()
        {
            decimalStringQueue = new Queue();
        }

        public void AddToQueue(object value)
        {
            decimalStringQueue.Enqueue(value);
        }

        public void FillQueue(int numberOfElements)
        {
            Random random = new Random();

            for (int i = 0; i < numberOfElements; i++)
            {
                int randomNumber = random.Next(1, 33);
                AddToQueue(randomNumber);
            }
        }

        public object RemoveFromQueue()
        {
            if (decimalStringQueue.Count > 0)
            {
                return decimalStringQueue.Dequeue();
            }
            else
            {
                throw new InvalidOperationException("Queue is empty");
            }
        }

        public void Clear()
        {
            decimalStringQueue.Clear();
        }

        public int Count() => decimalStringQueue.Count;

        public IEnumerator GetEnumerator() => 
            decimalStringQueue.GetEnumerator();
    }
}
