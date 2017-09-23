using System.Globalization;

namespace Queue
{
    public interface IQueue
    {
        void Push (int take);
        int Pop();
        bool IsEmpty();
        int TakeTop();


    }
}