int dia, mes;
string resposta;

string[] mesMonstro =
{
    "O Zumbi",
    "O Assassino",
    "O Psicopata",
    "O Alienígena",
    "O Carniceiro",
    "O Matador",
    "O Vampiro",
    "O Maluco",
    "O Vingador",
    "O Monstro",
    "O Bruxo",
    "O Demônio",

};

string[] diaMonstro =
{
    "Endiabrado",
    "Radioativo",
    "Endemoniado",
    "Vermelho",
    "Possuído",
    "Macabro",
    "Sombrio",
    "Sem Cabeça",
    "Desconhecido",
    "Inconsciente",
    "Oculto",
    "Esquecido",
    "Lúgubre",
    "Invocado",
    "Caído",
    "Costurado",
    "Amaldiçoado",
    "Anormal",
    "Perturbado",
    "Sanguinário",
    "Tenebroso",
    "Imortal",
    "Ressuscitado",
    "do Pântano",
    "da Encruzilhada",
    "do Porão",
    "do Velho Poço",
    "sem Perdão",
    "do Cemitério",
    "da Meia-Noite",
    "da Lua Cheia"
};

Console.WriteLine("Seja Bem-vindo(a) a Noite do Terror muahahaha 🧛");
Console.Write("Deseja descobrir qual monstro nasceu com você? (S/N): ");
resposta = Console.ReadLine()!.Trim().ToUpper();

if (resposta == "S")
{
    Console.WriteLine("Você nasceu em qual dia? ");
    while (!int.TryParse(Console.ReadLine()!, out dia) || dia < 1 || dia > 31)
    {
        Console.WriteLine("Digite um dia válido muahahaha");
    }

    Console.Write("Em qual mês você nasceu? ");
    while (!int.TryParse(Console.ReadLine()!, out mes) || mes < 1 || mes > 12)
    {
        Console.WriteLine("Digite um mês válido muahahaha");
    }

    Console.WriteLine($"Corra! {mesMonstro[mes - 1]} {diaMonstro[dia - 1]} está atrás de você! 🔪🩸");
}
else
{
    Console.WriteLine("Você escapou dessa vez... 👀");
}

