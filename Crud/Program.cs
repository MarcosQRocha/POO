using Crud;

int op;
int i = 0;

System.Console.WriteLine("\nPrograma iniciado...");

do{
    System.Console.WriteLine
    (
        "\nDigite o número do que deseja executar: \n\n1- Criar usuário \n2- Consultar lista de usuários \n3- Alterar usuário \n4- Deletar usuário \n0- Sair do programa\n"
    );
    op = Convert.ToInt32(Console.ReadLine());

    switch(op){
        case 1:
            int id = i;
            System.Console.WriteLine("\nDigite seu nome:");
            string inputNome = Console.ReadLine()!; 
            System.Console.WriteLine("\nDigite seu telefone:");
            long inputTelefone = Convert.ToInt64(Console.ReadLine()); 
            Pessoa pessoa = new Pessoa (nome: inputNome, telefone: inputTelefone, id: id);
            PessoaRepository repository = new PessoaRepository();
            repository.Add(pessoa);
            i++;
        break;
        case 2:
            PessoaRepository repository1 = new PessoaRepository();
            System.Console.WriteLine("\nLista de usuários\n");
            repository1.Show();
        break;
        case 3:
            PessoaRepository repository2 = new PessoaRepository();
            System.Console.WriteLine("\nLista de usuários\n");
            repository2.Show();

            System.Console.WriteLine("\nDigite o nome do usuário que deseja alterar:\n");
            string userNome = Console.ReadLine()!;
            repository2.Edit(userNome);
        break;
        case 4:
            PessoaRepository repository3 = new PessoaRepository();
            System.Console.WriteLine("\nLista de usuários\n");
            repository3.Show();

            System.Console.WriteLine("\nDigite o nome do usuário que deseja remover:");
            userNome = Console.ReadLine()!;
            repository3.Remove(userNome);
        break;
    }
}while(op != 0);
    System.Console.WriteLine("\nSistema Encerrado!");


