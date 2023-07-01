/*/Урок 3. Big O Notation
чем отличается массив от списка?
массивы - это коллекция данных, которая может хранить в себе элементы одного типа данных
в то время как список может хранить в себе несколько типов данных
но! списки медленней работают
*/

/*//o(n)
int n = 5;
int[] array = new int[n];
for (int i = 0; i < n; i++)
array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("[" + string.Join(", ", array) + "]");
// функция Join выводит все элементы массива через какой-то разделитель, в данном случае - через пробел
int summa = 0;
for (int i = 0; i < n; i++)

summa += array[i];
System.Console.WriteLine(summa);
*/

/*//O(n^2)
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        System.Console.Write(i * j);
        System.Console.Write("\t");
    }
    System.Console.WriteLine();
}
*/

/*//O(n^2 / 2)
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        if (i + j <= n)
        {
            matrix[i, j] = i * j;
            matrix[j, i] = i * j;
        }
        System.Console.WriteLine();
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < 0; j++)
    {
        System.Console.Write(matrix[i, j]);
        System.Console.Write(" ");
    }
    System.Console.WriteLine();
}
*/