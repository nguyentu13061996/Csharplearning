float b = 0;
for (int i = 0;i<=n;i++)
{
b = Mathf.Sqrt(i + Mathf.Sqrt(b));
}
Debug.Log(b);