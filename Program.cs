String nome,sobrenome,cor;
int idade;

Console.WriteLine("Olá, Tudo bem? Qual o seu nome?");
 nome =Console.ReadLine();
Console.WriteLine("Qual o seu sobrenome?");
 sobrenome =Console.ReadLine();
Console.WriteLine("Qual a sua idade?");
 idade =int.Parse(Console.ReadLine());
Console.WriteLine("Qual a sua cor favorita?");
 cor =Console.ReadLine();


Console.WriteLine($"Nome: {nome} \nSobrenome: {sobrenome} \nIdade: {idade} \nCor Favorita: {cor}" );


