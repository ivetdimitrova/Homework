using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxTask
{
    public class Box<T>
    {
        private Stack<T> data;

        public Box()
        {
            this.data = new Stack<T>();
        }

        public int Count => this.data.Count;

        public void Add(T item)
        => this.data.Push(item);

        public void Remove()
        => this.data.Pop();

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (T item in this.data)
            {
                result.AppendLine($"{item.GetType().FullName}: {item}");
            }

            return result.ToString();
        }
    }
}
