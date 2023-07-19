for (int i=1; i<=n; i++)
{
    a = n % i;
    if (a == 0)
    {
        if ( i != n) {
            b = b + i;
            if (b == n)
            {
                Debug.Log(n + " là số hoàn thiện");
            }
        }
    }
}