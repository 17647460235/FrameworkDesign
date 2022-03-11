using System;
using UnityEngine.UI;

namespace FrameworkDesign
{
    public class BindableProperty<T> where T : IEquatable<T>
    {
        private T mValue = default(T);

        public T Value
        {
            get => mValue;
            set
            {
                if (value.Equals(mValue)) return;
                mValue = value;
                OnValueChange?.Invoke(value);
            }
        }

        public Action<T> OnValueChange;
    }
}