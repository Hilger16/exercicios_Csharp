// EXERCÍCIO 2 
/* Elaborar um programa que leia o valor de um jantar. 
Calcule e informe o valor da taxa do garçom (10%) e o valor total 
a ser pago. */
// EXEMPLO: 
// Valor do jantar: R$80,00
// Taxa do garçom: R$8,00
// Total a pagar: R$88,00
// ---------------------------------------------------------------

using static System.Console;
internal class Program
{
    public static void Main(string[] args)
    {
        double valor_jantar = 80.0;
        double taxa_garcom = 10.0 / 100.0;
        double total = valor_jantar + (taxa_garcom * valor_jantar);

        
        Console.WriteLine($"O valor do Jantar é: R$ {valor_jantar},00");
        Console.WriteLine($"A taxa do garçom é: R$ {(taxa_garcom * 1) * valor_jantar},00");
        Console.WriteLine($"O valor total é: R$ {total},00");
    }
}