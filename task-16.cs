float a = 1;
float b = 1;
for (int i = 1; i <= n; i++)
{
    a = i * a;
    b = Mathf.Sqrt(a + Mathf.Sqrt(b));
}
Debug.Log(b);
Debug.Log(a);