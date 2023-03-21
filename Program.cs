using System;

//questão 1

Console.WriteLine("Resposta questão 1");
Console.WriteLine();


int indece = 13;
int soma = 0;
int k = 0;

while (k < indece)
{
    k = k + 1;
    soma = soma + k;
}

Console.WriteLine("o resultado da questão i é:" + soma);

Console.WriteLine();
Console.WriteLine($"----------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine();

//questão 2
Console.WriteLine("Resposta questão 2");
Console.WriteLine();


int input = 6;
int a = 0;
int b = 1;
int fib = 0;

while (fib < input)
{
    fib = a + b;
    a = b;
    b = fib;
}

if (fib == input)
{
    Console.WriteLine($"Resposta da questão 2: O valor de INPUT {input} está na sequencia de fibonati");
}
else
{
    Console.WriteLine($"Resposta da questão 2: O valor de INPUT {input} NÃO está na sequencia de fibonati");
}
Console.WriteLine();
Console.WriteLine($"----------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine();

//questão 3

Console.WriteLine("Resposta questão 3");
Console.WriteLine();


object[,] teste = new object[31, 2];
teste[0, 0] = DateOnly.Parse("01/01/2023");
teste[0, 1] = 0.00;

teste[1, 0] = DateOnly.Parse("02/01/2023");
teste[1, 1] = 1525.12;

teste[2, 0] = DateOnly.Parse("03/01/2023");
teste[2, 1] = 1325.97;

teste[3, 0] = DateOnly.Parse("04/01/2023");
teste[3, 1] = 1879.48;

teste[4, 0] = DateOnly.Parse("05/01/2023");
teste[4, 1] = 965.86;

teste[5, 0] = DateOnly.Parse("06/01/2023");
teste[5, 1] = 2140.48;

teste[6, 0] = DateOnly.Parse("07/01/2023");
teste[6, 1] = 0.00;

teste[7, 0] = DateOnly.Parse("08/01/2023");
teste[7, 1] = 0.00;

teste[8, 0] = DateOnly.Parse("09/01/2023");
teste[8, 1] = 1145.15;

teste[9, 0] = DateOnly.Parse("10/01/2023");
teste[9, 1] = 1788.35;

teste[10, 0] = DateOnly.Parse("11/01/2023");
teste[10, 1] = 845.46;

teste[11, 0] = DateOnly.Parse("12/01/2023");
teste[11, 1] = 498.75;

teste[12, 0] = DateOnly.Parse("13/01/2023");
teste[12, 1] = 2489.25;

teste[13, 0] = DateOnly.Parse("14/01/2023");
teste[13, 1] = 0.00;

teste[14, 0] = DateOnly.Parse("15/01/2023");
teste[14, 1] = 0.00;

teste[15, 0] = DateOnly.Parse("16/01/2023");
teste[15, 1] = 495.46;

teste[16, 0] = DateOnly.Parse("17/01/2023");
teste[16, 1] = 478.79;

teste[17, 0] = DateOnly.Parse("18/01/2023");
teste[17, 1] = 1425.67;

teste[18, 0] = DateOnly.Parse("19/01/2023");
teste[18, 1] = 958.05;

teste[19, 0] = DateOnly.Parse("20/01/2023");
teste[19, 1] = 849.10;

teste[20, 0] = DateOnly.Parse("21/01/2023");
teste[20, 1] = 0.00;

teste[21, 0] = DateOnly.Parse("22/01/2023");
teste[21, 1] = 0.00;

teste[22, 0] = DateOnly.Parse("23/01/2023");
teste[22, 1] = 1545.86;

teste[23, 0] = DateOnly.Parse("24/01/2023");
teste[23, 1] = 4854.49;

teste[24, 0] = DateOnly.Parse("25/01/2023");
teste[24, 1] = 1475.40;

teste[25, 0] = DateOnly.Parse("26/01/2023");
teste[25, 1] = 1849.26;

teste[26, 0] = DateOnly.Parse("27/01/2023");
teste[26, 1] = 125.46;

teste[27, 0] = DateOnly.Parse("28/01/2023");
teste[27, 1] = 0.00;

teste[28, 0] = DateOnly.Parse("29/01/2023");
teste[28, 1] = 0.00;

teste[29, 0] = DateOnly.Parse("30/01/2023");
teste[29, 1] = 1495.25;

teste[30, 0] = DateOnly.Parse("31/01/2023");
teste[30, 1] = 859.68;

object[,] maiorValor = new object[1, 2];
maiorValor[0, 0] = DateOnly.Parse("01/01/1900");
maiorValor[0, 1] = 0;

object[,] menorValor = new object[1, 2];
maiorValor[0, 0] = DateOnly.Parse("01/01/1900");
maiorValor[0, 1] = double.MaxValue;

double maior = 0;
double menor = double.MaxValue;
int diasFat = 0;
double media;
double somaFat = 0;
int diasFatMaiorMedia = 0;

for (int i = 0; i < teste.GetLength(0); i++)
{
    double valor = (double)teste[i, 1];

    if (valor >0)
    {
        diasFat++;
        somaFat += valor;

        if (maior < valor)
        {
            maior = valor;
            maiorValor = new object[,] { { teste[i, 0], teste[i, 1] } };
        }

        if (valor < menor)
        {
            menor = valor;
            menorValor = new object[,] { { teste[i, 0], teste[i, 1] } };
        }
    }    
}

media = somaFat / diasFat;

for (int i = 0; i < teste.GetLength(0); i++)
{
    double valor = (double)teste[i, 1];
    if (valor >= media)
    {
        diasFatMaiorMedia++;
    }
}

Console.WriteLine($"Houve faturamento em {diasFat}\nO total de faturamento foi de: R${somaFat.ToString("n2")}\nA média diaria de faturamento foi de: R${media.ToString("n2")}\n" +
    $"O dia que teve o maior faturamento foi: {maiorValor[0, 0]}, com o faturamento de: R${maior.ToString("n2")}\n" +
    $"O dia com o menor faturamento foi: {menorValor[0,0]}, com o faturamento de: R${menor.ToString("n2")}\n" +
    $"De {diasFat} faturados, {diasFatMaiorMedia} Teve o faturamento igual ou acima da média");



Console.WriteLine();
Console.WriteLine($"----------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine();


//quetão 4
Console.WriteLine("Resposta questão 4");
Console.WriteLine();



double SP = 67836.43;
double RJ = 36678.66;
double MG = 29229.88;
double ES = 27165.48;
double Outros = 19849.53;

double total = SP + RJ + MG + ES + Outros;

Console.WriteLine($"SP com o faturamento de R${SP.ToString("n2")} tem o percentual de {(SP / total * 100).ToString("n2")}% de um total de R${total.ToString("n2")} de faturamento");
Console.WriteLine($"RJ com o faturamento de R${RJ.ToString("n2")} tem o percentual de {(RJ / total * 100).ToString("n2")}% de um total de R${total.ToString("n2")} de faturamento");
Console.WriteLine($"MG com o faturamento de R${MG.ToString("n2")} tem o percentual de {(MG / total * 100).ToString("n2")}% de um total de R${total.ToString("n2")} de faturamento");
Console.WriteLine($"ES com o faturamento de R${ES.ToString("n2")} tem o percentual de {(ES / total * 100).ToString("n2")}% de um total de R${total.ToString("n2")} de faturamento");
Console.WriteLine($"OUTROS com o faturamento de R${Outros.ToString("n2")} tem o percentual de {(Outros / total * 100).ToString("n2")}% de um total de R${total.ToString("n2")} de faturamento");

Console.WriteLine();
Console.WriteLine($"----------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine();

//QUESTÃO 5
Console.WriteLine("Resposta questão 5");
Console.WriteLine();


string text = "texto para ser invertido";
string textInvertido = "";

char[] caracter = text.ToCharArray();

foreach (var i in caracter)
{
    textInvertido = textInvertido.Insert(0, $"{i}");
}

Console.WriteLine($"Texto original: {text}, texto Invertido: {textInvertido}");
