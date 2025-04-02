// See https://aka.ms/new-console-template for more information
using System.Globalization;

//Variaveis
double largura;
double comprimento, area, valormetro, valorterreno;

//Entrada
largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
valormetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Calculo
area = largura * comprimento;
valorterreno = area * valormetro;

//Saida
Console.WriteLine("AREA - " + area.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine("PRECO = " + valorterreno.ToString("F2", CultureInfo.InvariantCulture));
