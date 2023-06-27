using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud
{
    public class PessoaRepository
    {
       public static List<Pessoa> PessoasList = new List<Pessoa>();
        public void Add(Pessoa pessoa){
            PessoasList.Add(pessoa);
        }

        public void Show(){
            if(PessoasList == null){
                System.Console.WriteLine("\nNenhum usuário cadastrado!");
            }
            foreach(var p in PessoasList){
                Console.WriteLine($"\nNome: {p.Nome} | Telefone: {p.Telefone}\n");
            }
        }

        public void Edit(string userNome){
            string user = userNome;
            var userFound = PessoasList.Where(p => p.Nome.Equals(user)).FirstOrDefault();
            
            if(userFound != null){
                System.Console.WriteLine($"\nNome: {userFound.Nome} \nTelefone: {userFound.Telefone}");

                System.Console.WriteLine("\nDigite o novo nome:");
                string nome = Console.ReadLine()!;
                if(nome == null){
                    System.Console.WriteLine("\nNome não alterado!");
                }else{
                    userFound.Nome = nome;
                }
                System.Console.WriteLine("\nDigite o novo telefone:");
                Nullable<long> telefone = Convert.ToInt64(Console.ReadLine());
                if(telefone.HasValue){
                    System.Console.WriteLine("\nTelefone não alterado!");
                }             
            }else{
                System.Console.WriteLine("\nCliente não cadastrado!");
            }
        }

        public void Remove(string userNome){
            string user = userNome;
            var userFound = PessoasList.Where(p => p.Nome.Equals(user)).FirstOrDefault();

            if(userFound != null){
                PessoasList.Remove(userFound);
                System.Console.WriteLine("\nUsuário removido!");
            }else{
                System.Console.WriteLine("\nNenhum usuário encontrado!");
            }
        }

    }
}