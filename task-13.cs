float b = Mathf.Sqrt(n);
for (int i = 1;i<=b;i++)
{
    if ( i * i == n)
    {
        Debug.Log(n + " là số chính phương");
    }
    else
    {
        Debug.Log(n + " không phải là số chính phương");
    }
}