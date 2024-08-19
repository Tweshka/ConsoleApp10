using System.Diagnostics;

static void CreateMatrix(int n)
{
    var matrix = new int[n][];

    for (int i = 0; i < n; i++)
    {
        matrix[i] = new int[n];
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i][j] = i + j;
        }
    }
}
static void Estimate(int n)
{
    var timer = new Stopwatch();
    timer.Start();

    for (int i = 0; i < n; i++)
    {
        timer.Restart();

        CreateMatrix(10000);

        timer.Stop();
        Console.WriteLine(timer.ElapsedMilliseconds);
    }
}