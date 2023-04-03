// Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:


// "Telefonou para a vítima?"

// "Esteve no local do crime?"

// "Mora perto da vítima?"

// "Devia para a vítima?"

// "Já trabalhou com a vítima?"


// O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como “Culpado“. Caso contrário, ele será classificado como "Inocente“.

int culpa = 0;

Console.WriteLine($"Telefonou para vítima? ");
string r1 = Console.ReadLine()!.ToLower();
if (r1 == "sim")
{
    culpa++;
}

Console.WriteLine($"Esteve no local do crime? ");
string r2 = Console.ReadLine()!.ToLower();
if (r2 == "sim")
{
    culpa+= 1;
}

Console.WriteLine($"Mora perto da vítima? ");
string r3 = Console.ReadLine()!.ToLower();
if (r3 == "sim")
{
    culpa+= 1;
}

Console.WriteLine($"Devia para a vítima? ");
string r4 = Console.ReadLine()!.ToLower();
if (r4 == "sim")
{
    culpa+= 1;
}

Console.WriteLine($"Já trabalhou com a vítima? ");
string r5 = Console.ReadLine()!.ToLower();
if (r5 == "sim")

{
    culpa+= 1;
}
if (culpa < 2)
{
    Console.WriteLine($"Você está classificado como Inocente.");
}
else if (culpa == 2)
{
    Console.WriteLine($"Você está classificado como suspeito.");
}

else if (culpa == 5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Você é o culpado!");
    Console.ResetColor();
}

else
{
    Console.WriteLine($"Você é um cumplice.");
}






