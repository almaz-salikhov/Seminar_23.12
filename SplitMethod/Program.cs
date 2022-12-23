Console.WriteLine("Введите элементы через пробел: ");
int[] arr2 = Console.ReadLine()
            .Split(',')
            .Select(Int32.Parse)
            .Where(e => e % 2 == 0)
            .ToArray();

string[] arr3 = Console.ReadLine().Split(',');
