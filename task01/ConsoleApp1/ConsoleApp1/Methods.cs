namespace ConsoleApp1;

public class Methods
{
    public static double CalculateAverage(int[] a)
    {
        int s = 0;
        foreach(int val in a)
        {
            s += val;
        }
        return (double)s/a.Length;
    }

    public static int FindMax(int[] a)
    {
        int mx = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            mx = Math.Max(a[i],mx);
        }

        return mx;
    }
}