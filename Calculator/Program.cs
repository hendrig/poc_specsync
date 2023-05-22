using Calculator;

Console.WriteLine("Hello, World!");
Console.WriteLine("Digite o primeiro número");
var n1 = Console.ReadLine();
Console.WriteLine("Digite o segundo número");
var n2 = Console.ReadLine();

var sum = Calculator.Calculator.Sum(double.Parse(n1), double.Parse(n2));
Console.WriteLine("Resultado: {0}", sum);
Console.ReadKey();
