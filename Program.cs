double Area;
double LadoA;
double LadoB;
double LadoC;
double SP; //semiperímetro

Console.WriteLine("Insira os valores dos lados do triângulo que deseja calcular:");

Console.Write("Digite o lado A:");
LadoA = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o lado B:");
LadoB = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o lado C:");
LadoC = Convert.ToDouble(Console.ReadLine());

SP = (LadoA + LadoB + LadoC) / 2;

Area = Math.Sqrt(SP * (SP - LadoA) * (SP - LadoB) * (SP - LadoC));

Console.Write($" Lado A {LadoA}\n Lado B {LadoB}\n Lado C {LadoC}\n Semiperimetro é: {SP}\n Área é: {Area:N2}");