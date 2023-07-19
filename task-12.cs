for (int i=1; i<=n; i++)
{
    a = n % i;
    if (a == 0)
    {
        b++;
        if (b == 2)
        {
            Debug.Log(n + " là số nguyên tố");
        }
    }
}