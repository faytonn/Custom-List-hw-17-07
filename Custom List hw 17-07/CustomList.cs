using System.Collections;

namespace Custom_List_hw_17_07
{
    public class CustomList<T> : IEnumerable<T>
    {

        private T[] Lists;
        public CustomList()
        {
            Lists = new T[0];
        }

        public T this[int index]
        {
            get
              => Lists[Lists.Length - 1 - index];
            set
              => Lists[Lists.Length - 1 - index] = value;
        }

        public void Add(T item)
        {
            Array.Resize(ref Lists, Lists.Length + 1);
            Lists[^1] = item;
        }

        public T? Find(T item)
        {
            foreach (var t in Lists)
            {
                if (t.Equals(item))
                {
                    return t;
                }
            }
            return default(T);
        }

        public CustomList<T> FindAll(Predicate<T> find)
        {
            CustomList<T> list = new CustomList<T>();
            foreach (var t in Lists)
            {
                if (find(t))
                {
                    list.Add(t);
                }
            }
            return list;
        }

        public void Remove(T item)
        {
            for (int i = 0; i < Lists.Length; i++)
            {
                if (item.Equals(Lists[i]))
                {
                    for (int j = i; j < Lists.Length - 1; j++)
                    {
                        Lists[j] = Lists[j + 1];
                    }
                }
            }
            Array.Resize(ref Lists, Lists.Length - 1);
        }

        public int RemoveAll(Predicate<T> remove)
        {
            int removeCount = 0;
            for (int i = 0; i < Lists.Length; i++)
            {
                if (remove(Lists[i]))
                {
                    for(int j = i; j < Lists.Length - 1; j++)
                    {
                        Lists[j] = Lists[j + 1];
                    }
                    Lists[Lists.Length - 1] = default(T);
                    removeCount++;
                }
            }
            return removeCount;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Lists.Length - 1; i >= 0; i--)
            {
                yield return Lists[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = Lists.Length - 1; i >= 0; i--)
            {
                yield return Lists[i];
            }
        }
    }
}
