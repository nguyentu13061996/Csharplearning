for (int i=1; i<=n; i++)
{
    a = n % i;
    if (a == 0)
    {
        Debug.Log(i);
        b = b + i;
    }
}
Debug.Log(b);
