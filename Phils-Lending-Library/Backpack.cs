using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phils_Lending_Library
{
    public class Backpack<T> : IBag<T>
    {
        private List<T> items;

        public Backpack() {
            items = new List<T>();
        }
        public IEnumerator<T> GetEnumerator()
        {

            return GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {

            return GetEnumerator();
        }
        public void Pack(T item)
        {
            if (item != null)
            {
                items.Add(item);
                Console.WriteLine($"Added item.");
            }
        }
        public T Unpack(int index)
        {
            try
            {
                T item = items[index];
                items.RemoveAt(index);
                Console.WriteLine("Removed item.");
                return item;
            }
            catch (Exception)
            {
                Console.WriteLine("Item index was not found!");
            }
            return default(T);

        }
    }
}
