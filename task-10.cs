for (int i=1; i<=n; i++)
{
    a = n % i;
    if (a == 0)
    {
       if (i % 2 != 0)
        {
            if (i > b)
            {
                b = i;
            }
            
        }
    }
}
Debug.Log(b);