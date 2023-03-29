// // declarando variáveis
// string nome = "Kauã";
// int idade = 17;

// Console.WriteLine("A idade do " + nome + " é " + idade + " anos");




// // tipo de dados
// int quantidade = 10;
// double preco = 4.99D;
// float altura = 1.80f;
// bool careca = true;
// string texto = "Hello, world";
// char letra = 'C';





// Crie um programa para calcular o IMC de uma pessoa

string nome = "Carlos";
float peso = 89.9f;
float altura = 1.80f;

// processamento
float imc = peso / (altura * altura);

Console.WriteLine("O IMC de " + nome + " é " + Math.Round(imc,2));
