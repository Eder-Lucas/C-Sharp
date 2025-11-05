namespace Interfaces
{
    internal class Program
    {
        //Interface - o "contrato" que todo animal deve seguir
        internal interface IAnimal
        {
            //todo animal terá no mínimo essas especificações
            string Nome { get; set; }
            void Comer();
            void EmitirSom();
        }

        //Classe abstrata - define a base para os comportamentos dos animais
        internal abstract class Animal : IAnimal
        {
            //Comportamentos comuns
            public string Nome { get; set; }

            public virtual void Comer()
            {
                Console.WriteLine($"{Nome} está comendo...");
            }

            //Cada animal tem um som diferente
            public abstract void EmitirSom();
        }

        //Classe concreta - implementa os comportamentos e adicionam seus próprios
        internal class Cachorro : Animal
        {
            //atributo Nome e método Comer() já são herdados 

            //Som único do cachorro
            public override void EmitirSom()
            {
                Console.WriteLine($"{Nome} diz: Au Au!");
            }

            //Comportamento adícional único também
            public void AbanarRabo()
            {
                Console.WriteLine($"{Nome} está abanando o rabo");
            }
        }

        internal class Gato : Animal
        {
            //Som único dos gatos
            public override void EmitirSom()
            {
                Console.WriteLine($"{Nome} diz: Miau!");
            }
        }

        static void Main(string[] args)
        {
            //Gerando um objeto pela classe concreta cachorro
            Cachorro doguinho = new Cachorro { Nome = "Piper" };
            doguinho.Comer(); //herdado de Animal
            doguinho.EmitirSom(); //sobrescrito em Cachorro
            doguinho.AbanarRabo(); //exclusivo do Cachorro

            /* gerando por interface
                IAnimal doguinho = new Cachorro();
                doguinho.AbanarRabo <-- ERRO, interface não define isso
             */

            Console.WriteLine();

            //gerando pela interface o objeto gato
            IAnimal gato = new Gato { Nome = "Esnifete" };
            gato.Comer(); //herdado e permitido pela interface
            gato.EmitirSom(); //sobrescrito para a sua necessidade em Gato

        }
    }
}
