
//Thread Safe Queue yarating
//- bunda Enqueue, Dequeue methodlari threadlar uchun safe bo'lsin

using ThreadSafe_HT1_N41;

var queue = new SafeQueue<int>();

var tasks = new List<Task>()
{
    new (() => queue.Enqueue(5).AsTask().Wait()),
    new (() => queue.Enqueue(35).AsTask().Wait()),
    new (() => queue.Enqueue(14).AsTask().Wait()),
    new (() => queue.Enqueue(46).AsTask().Wait())
};

Parallel.ForEach(tasks, task => task.Start());
await Task.WhenAll(tasks);

queue.Display();
Console.WriteLine();
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue()); 

