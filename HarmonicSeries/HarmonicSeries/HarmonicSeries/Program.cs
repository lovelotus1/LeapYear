Console.WriteLine("Enter the value N");
int n = int.Parse(Console.ReadLine());
float h = 0;
for (int i = 0; i < n; i++)
{
    h += (float)1 / i;
}
Console.WriteLine(" Nth value of harmoic number is " + "" + h);