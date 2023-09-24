using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafe_HT1_N41
{
    public class SafeQueue<TItem>
    {
        private List<TItem> _items;
        private readonly object _lock = new object();

        public SafeQueue()
        {
            _items = new List<TItem>();
        }
        
        public void Display()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
        public async ValueTask Enqueue(TItem item)
        {
            lock(_lock)
            {
                if (item == null)
                    throw new ArgumentException("hello");
                _items.Add(item);
            }
        }
        
        public TItem Dequeue()
        {
            lock(_lock)
            {
                var found = _items.FirstOrDefault();
                
               if(found is null)
                    throw new ArgumentNullException(nameof(found) + "this thing is not found");
                
                _items.Remove(found);
                return found;
            }
        }
    }
}
