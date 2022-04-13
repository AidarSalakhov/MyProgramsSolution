// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        int[] myArray = { 2, 10, 5, 6, 77, 89 };

        int[] myArray2 = myArray[1..4]; //извлечение из другого массива, результат 2,3

        //int[] myArray2 = myArray[..4]; //извлечение из другого массива с начала, результат 1, 2,3

        Console.WriteLine(myArray[^2]); //получить последний элемент массива с конца

        //Index myIndex = ^2;
        //Console.WriteLine(myArray[myIndex]);

    }


}
