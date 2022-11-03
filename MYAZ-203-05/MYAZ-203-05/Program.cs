using MYAZ_203_05;

MinHeap heap = new MinHeap();
heap.Insert(0);
heap.Insert(5);
heap.Insert(3);
heap.Insert(2);
heap.Insert(1);
heap.Insert(4);
Console.WriteLine($"{heap.Extract()}");
Console.WriteLine($"{heap.Extract()}");
Console.WriteLine($"{heap.Extract()}");
Console.WriteLine($"{heap.Extract()}");
Console.WriteLine($"{heap.Extract()}");
Console.WriteLine($"{heap.Extract()}");