using System.Collections;

Console.WriteLine("Bem-vindo ao sistema! Cadastre os usuários:");

IList usuarios = new ArrayList();
IList senhas = new ArrayList();

Console.Write("Usuário: ");
string usuario = Console.ReadLine();
Console.Write("Senha (entre 4 e 8 caracteres): ");
string senha = Console.ReadLine();

while(senha.Length < 4 || senha.Length > 8)
{
    Console.Write("A senha deve conter entre 4 e 8 caracteres. Informe a senha: ");
    senha = Console.ReadLine();
}

usuarios.Add(usuario);
senhas.Add(senha);

Console.Write("Pretende seguir cadastrando usuários (S ou N)? ");
string continua = Console.ReadLine();

while (continua.ToUpper() != "N")
{
    Console.Write("Usuário: ");
    usuario = Console.ReadLine();
    Console.Write("Senha (entre 4 e 8 caracteres): ");
    senha = Console.ReadLine();

    while (senha.Length < 4 || senha.Length > 8)
    {
        Console.Write("A senha deve conter entre 4 e 8 caracteres. Informe a senha: ");
        senha = Console.ReadLine();
    }

    usuarios.Add(usuario);
    senhas.Add(senha);

    Console.Write("Pretende seguir cadastrando usuários (S ou N)?");
    continua = Console.ReadLine();
}

Console.WriteLine("Pré cadastro realizado com sucesso! Agora acesse o sistema:");

for (int j = 0; j < 3; j++)
{
    Console.Write("Informe seu usuário: ");
    usuario = Console.ReadLine();
    Console.Write("Informe sua senha: ");
    senha = Console.ReadLine();

    Console.WriteLine(usuarios.Count);

    for (int i = 0; i < usuarios.Count; i++)
    {
        if (usuarios.Contains(usuario) && senhas.Contains(senha))
        {
            Console.WriteLine("\nLogin realizado com sucesso!");
            return;
        }
    }

    Console.WriteLine($"Usuário ou senha inválidos, tente novamente (você tem {2-j} tentativas restantes).\n");
}

Console.WriteLine("Você excedeu o número de tentativas, por isso o programa está sendo encerrado");
