// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random random = new Random();
int randomNumber = random.Next(0, 1000);

Console.Write("Add leanth -->");
int leanth = Int32.Parse(Console.ReadLine());
Console.Write("Add width -->");
int width = Int32.Parse(Console.ReadLine());

int[,] numbersForSort = new int[leanth, width];


for (int i = 0; i < numbersForSort.GetLength(0); i++)
{
    for (int j = 0; j < numbersForSort.GetLength(1); j++)
    {
        numbersForSort[i, j] = randomNumber;
        randomNumber = random.Next(0, 1000);
    }
}

int max = numbersForSort[0, 0];
int min = numbersForSort[0, 0];

for (int i = 0; i < numbersForSort.GetLength(0); i++)
{
    for (int j = 0; j < numbersForSort.GetLength(1); j++)
    {
        if (numbersForSort[i, j] > max)
        {
            max = numbersForSort[i, j];
        }

        if (numbersForSort[i, j] < min)
        {
            min = numbersForSort[i, j];
        }
    }
}

Console.WriteLine(max + "_" + min);