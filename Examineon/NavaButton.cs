using System;
using System.Collections.Generic;

namespace Examineon
{
    public class NavaButton<T>
    {
        private List<T> items;
        private int currentIndex;

        public NavaButton(List<T> items)
        {
            this.items = items ?? new List<T>();
            this.currentIndex = 0;
        }

        public T GetCurrent()
        {
            if (items.Count == 0) return default;
            return items[currentIndex];
        }

        public T MoveNext()
        {
            if (items.Count == 0) return default;

            currentIndex++;
            if (currentIndex >= items.Count)
                currentIndex = 0; // wrap to start

            return items[currentIndex];
        }

        public T MovePrevious()
        {
            if (items.Count == 0) return default;

            currentIndex--;
            if (currentIndex < 0)
                currentIndex = items.Count - 1; // wrap to end

            return items[currentIndex];
        }

        public int GetCurrentIndex()
        {
            return currentIndex;
        }

        public int Count => items.Count;
    }
}
