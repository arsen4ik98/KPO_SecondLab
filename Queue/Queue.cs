using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Queue
{
    public class Queue : IQueue
    {
        private int[]Que = new int[10];
        private int count = 0;
        
        public int Pop()
        {
            if (Que.Length == 0)
            {
                throw new Exception("massive is empty");
            }
            else
            {
                int savedElement = Que[0];
                for (int i = 0; i < Que.Length -1; i++)
                {
                    Que[i] = Que[i + 1];
                }
                count--;
                return savedElement;
            }
            
        } 

        public void Push(int take)
        {
            if (Que.Length == count)
            {
                Array.Resize(ref Que, Que.Length * 2);
                Que[count] = take;
                count++;
            }
            else
            {
                Que[count] = take;
                count++;
            }
        }

        bool IQueue.IsEmpty()
        {
            throw new System.NotImplementedException();
        }

        int IQueue.TakeTop()
        {
            throw new System.NotImplementedException();
        }
        /*public T TakeTop()
        {
            
        }*/
    }
}