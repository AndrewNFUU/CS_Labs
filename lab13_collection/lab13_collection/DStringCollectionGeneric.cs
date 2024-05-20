using System;
using System.Collections;
using System.Collections.Generic;

namespace lab13_collection
{
    public class DStringCollectionGeneric : IEnumerable<DecimalString>
    {
        private Queue<DecimalString> dStringGenericQueue;

        public DStringCollectionGeneric()
        {
            dStringGenericQueue = new Queue<DecimalString>();
        }

        public void AddToGenericQueue(DecimalString dString)
        {
            dStringGenericQueue.Enqueue(dString);
        }

        public void FillGenericQueue(int numberOfElements)
        {
            Random random = new Random();

            for (int i = 0; i < numberOfElements; i++)
            {
                DecimalString dString = new DecimalString(random.Next(1, 33));
                AddToGenericQueue(dString);
            }
        }

        public DecimalString RemoveFromGenericQueue()
        {
            if (dStringGenericQueue.Count > 0)
            {
                return dStringGenericQueue.Dequeue();
            }
            else
            {
                throw new InvalidOperationException("Generic queue is empty");
            }
        }

        public void Clear()
        {
            dStringGenericQueue.Clear();
        }

        public int Count() => dStringGenericQueue.Count;

        public IEnumerator<DecimalString> GetEnumerator() =>
            dStringGenericQueue.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
