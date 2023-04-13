//faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto


//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda

using System.Globalization;

static float fImposto(float renda)
{
    float imposto;
    if (renda <= 1500)
    {
        imposto = 0;
    }
    else if (renda > 1500 && renda <= 3500)
    {
        imposto = renda * 0.2f;
    }
    else if (renda > 3500 && renda <= 6000)
    {
        imposto = renda * 0.25f;
    }
    else
    {
        imposto = renda * 0.35f;
    }
    return imposto;
}

Console.WriteLine($"Informe sua renda: ");
float rendaInformada = float.Parse(Console.ReadLine()!);


if (fImposto(rendaInformada) == 0)
{
    Console.WriteLine($"Você está isento de pagar imposto");
}
else
{
    Console.WriteLine($"Você precisa pagar {fImposto(rendaInformada).ToString("C", new CultureInfo("pt-BR"))} de imposto.");
}