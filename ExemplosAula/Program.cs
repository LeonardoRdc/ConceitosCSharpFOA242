// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Informe seu nome:");
string nome = Console.ReadLine();
Console.WriteLine($"Seja bem vindo(a) {nome}");
Console.WriteLine("Informe sua idade:");
int idade = int.Parse(Console.ReadLine());

//De acordo com a idade informada diga se o usuário pode ou não votar

if (idade >= 16) {
    Console.WriteLine("Você pode votar");
}
else {
   Console.WriteLine("Você não pode votar");
}

//Modifique o código para que diferencie o Pode Votar do Deve Votar

if (idade >= 18 && idade < 65)
{
    Console.WriteLine("Você deve votar");
}
else if (idade >= 16 || idade >= 65)
{
    Console.WriteLine("Você pode votar");
}
else
{
    Console.WriteLine("Você não pode votar");
}
