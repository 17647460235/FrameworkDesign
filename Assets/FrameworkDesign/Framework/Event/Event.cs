using System;

namespace FrameworkDesign
{
    public class Event<T> where T: Event<T>
    {
        public static Action mOnEvent;

        public static void Register(Action action)
        {
            mOnEvent += action;
        }

        public static void Unregister(Action action)
        {
            mOnEvent -= action;
        }

        public static void Trigger()
        {
            mOnEvent?.Invoke();
        }
    }
}