namespace Polimorfismo
{
    // 🔹 Classe base: define o comportamento geral
    internal abstract class Notificacao
    {
        public string Destinatario { get; set; }

        //método abstrato — cada tipo é obrigado implementar à sua maneira
        public abstract void Enviar();
    }

    // 🔹 Subclasse 1: e-mail
    internal class Notificacao_email : Notificacao
    {
        public string Assunto { get; set; }

        //método sendo implementado de outra forma
        //override - substitui o método anterior
        public override void Enviar()
        {
            Console.WriteLine($"Enviando e-mail para {Destinatario} || Assunto: {Assunto}");
        }
    }

    // 🔹 Subclasse 2: SMS   
    internal class Notificacao_sms : Notificacao
    {
        public string Telefone { get; set; }

        public override void Enviar()
        {
            Console.WriteLine($"Enviando SMS para {Telefone}: \"Mensagem enviada com sucesso!\"");
        }
    }

    // 🔹 Subclasse 3: push
    internal class Notificacao_push : Notificacao
    {
        public string Dispositivo { get; set; }

        public override void Enviar()
        {
            Console.WriteLine($"Enviando notificação push para {Dispositivo}");
        }
    }

    // 🔹 Programa principal
    internal class program
    {
        static void Main(string[] args)
        {
            // -- POLIMORFISMO --
            //Notificação não pode ser instanciada diretamente, então
            //é criada uma variável "notificacao"
            //que referência qualquer objeto que seja do tipo Entidade ou herde dela 

            Notificacao notificacao;

            //usando a variável para criar um novo objeto do tipo notificação por E-mail
            notificacao = new Notificacao_email
            {
                Destinatario = "C_sharp@Microsoft.com",
                Assunto = "Estudando polimorfismo!"
            };
            notificacao.Enviar(); //chama o método da class

            notificacao = new Notificacao_sms
            {
                Telefone = "+55 13 2710-2025",
            };
            notificacao.Enviar();

            notificacao = new Notificacao_push
            {
                Dispositivo = "Kali Linux - Asus notebook"
            };
            notificacao.Enviar();

            Console.WriteLine("\n Todas as notificações foram enviadas com sucesso!\r\n");

            Console.WriteLine("----------------------------------------------");

            // 🔹 Class animal

            //primeiro animal
            Animal animal1;
            animal1 = new Gato { Name = "Minhoso" };
            animal1.Som();
            animal1.Mover();

            Console.WriteLine("");

            //segundo animal
            Animal animal2;
            animal2 = new Peixe { Name = "Nemo" };
            animal2.Som();
            animal2.Mover();

            Console.WriteLine("----------------------------------------------");

            var tipo = animal1.GetType();//pega o tipo do objeto: Polimorfismo.Gato

            Console.WriteLine($"Nome: {tipo.Name}\n");//mostra só o nome: Gato
            
            //pega toda as propriedades do objeto gato
            Console.WriteLine("Propriedades:");
            foreach (var p in tipo.GetProperties())
            {
                //mostra o nome da propriedade e o valor atribuido a ela
                Console.WriteLine($"  {p.Name} = {p.GetValue(animal1)}\n");
            }
             
            //todos os métodos do Gato
            Console.WriteLine("Métodos:");
            foreach (var m in tipo.GetMethods())
            {
                //mostra o nome do método e onde foi declarado
                Console.WriteLine($"  {m.Name} (Declarado em {m.DeclaringType.Name})");
            }                
        }
    }
}
