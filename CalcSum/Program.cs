try
{
    Console.Write("enter first num - ");
    double num1 = double.Parse(Console.ReadLine());
    Console.Write("enter second num - ");
    double num2 = double.Parse(Console.ReadLine());
    Console.WriteLine("{1}+{2}={0}", num1 + num2, num1, num2);
}
catch
{
    Console.WriteLine("One of the numers are incorrect");
}