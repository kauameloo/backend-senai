// Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:


// "Telefonou para a vítima?"

// "Esteve no local do crime?"

// "Mora perto da vítima?"

// "Devia para a vítima?"

// "Já trabalhou com a vítima?"


// O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como “Culpado“. Caso contrário, ele será classificado como "Inocente“.

Console.WriteLine($"Telefonou para vítima? ");
string p1 = (Console.ReadLine()!.ToUpper());

Console.WriteLine($"Esteve no local do crime? ");
string p2 = (Console.ReadLine()!.ToUpper());

Console.WriteLine($"Mora perto da vítima? ");
string p3 = (Console.ReadLine()!.ToUpper());

Console.WriteLine($"Devia para a vítima? ");
string p4 = (Console.ReadLine()!.ToUpper());

Console.WriteLine($"Já trabalhou com a vítima? ");
string p5 = (Console.ReadLine()!.ToUpper());







