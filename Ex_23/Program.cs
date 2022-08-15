/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());
void cubeData(int[] cube)
{
    int count = 1;
    int length = cube.Length;
    while(count < length)
    {
        cube[count] = Convert.ToInt32(Math.Pow(count, 3));
        count++;
    }
}
void printArr(int[] coll)
{
    int count = coll.Length;
    int i = 1;
    while(i < count)
    {
        Console.Write(coll[i] + " ");
        i++;
    }
}
int[] arr = new int[cube + 1];
cubeData(arr);
printArr(arr);