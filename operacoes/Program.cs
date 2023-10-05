// EXERCÍCIO 1
// Faça as 4 operações básica com base nos números 2 e 4:
// Ao final de cada operação imprima na tela no seguinte formato: 
// Soma: 2 + 4 = x
// Subtração : 2 - 4 = x
// Divisão: 2 / 4 = x
// Multiplicação: 2 * 4 = x
// ---------------------------------------------------------------

int num1 = 2;
int num2 = 4;

int soma = num1 + num2;
int sub = num1 - num2;
int div = num1 / num2;
int mult = num1 * num2;

Console.WriteLine($"Soma: 2 + 4 = {soma}");
Console.WriteLine($"Subtração: 2 - 4 = {sub}");
Console.WriteLine($"Divisão: 2 - 4 = {div}");
Console.WriteLine($"Multiplicação: 2 - 4 = {mult}");