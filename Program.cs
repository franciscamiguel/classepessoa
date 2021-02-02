using System;

namespace classepessoa
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Cria um objeto da classe pessoa chamado p1.
            //Inicialmente o objeto é criado sem nenhuma informação.
            // As informações são adicionados pelos métodos set.
            Pessoa p1 = new Pessoa("fRAN mIGUEL", "23769876");
            p1.Nome = "Francisca Miguel";
            p1.Idade = 27;
            p1.Rg = "236.880-85";

            //Vamos exibir os valores na tela.para isso usaremos
            // os métodos get.
            Console.WriteLine("Nome.:" + p1.Nome);
            Console.WriteLine("IDADE...:" + p1.Idade);
            Console.WriteLine("RG" + p1.Rg);

            Console.WriteLine();
            Console.WriteLine();

            //Agora vamos criar um novo objeto p2 com os valores já inicializados.
            Pessoa p2 = new Pessoa("Maria", "33.444-55", 35);

            // Vamos exibir os dados na tela
            Console.WriteLine("Nome.:" + p2.Nome);
            Console.WriteLine("IDADE...:" + p2.Idade);
            Console.WriteLine("RG...:" + p2.Rg);                                                                                                                                                    
        }   
            
    }
}        
            
        
           
    
        
      
    
        
