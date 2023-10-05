/*EXERCÍCIO 3
=========================
Elaborar um programa para uma loja, 
o qual leia o preço de um produto e informe as opções de pagamento da loja. 
Calcule e informe o valor para pagamento à vista com 10% de desconto e o valor em 3x.
EXEMPLO:
Preço: R$60,00
À vista: R$54,00
Ou 3x de: R$20,00
========================= */
double preco = 60.0;
double desconto = 10.0;
int num_parcelas = 3;

Console.WriteLine($"Preço: R${preco},00");
Console.WriteLine($"À vista: R${preco - ((desconto / 100) * preco)},00");
Console.WriteLine($"Ou {num_parcelas}x de: R${preco / num_parcelas}");