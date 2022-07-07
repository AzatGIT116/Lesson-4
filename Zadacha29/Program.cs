// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
    Random myRan = new Random();
        for (int i = 0; i < array.Length; i++)
            array[i] = myRan.Next(0, 50);
            Console.WriteLine("[{0}]", string.Join(", ", array));
        
      


