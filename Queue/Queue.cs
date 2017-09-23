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
                
            }
            
        } 

        public void Push(int take)
        {
            if (Que.Length == count)
            {
                Array.Resize(ref Que, Que.Length * 2);
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