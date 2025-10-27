using System.Runtime.InteropServices;

namespace Polimorfismo
{
    // 🔹 Class Animal
    internal abstract class Animal
    {
        public string Name { get; set; }

        public virtual void Som()
        {
            Console.WriteLine($"O animalzinho {Name} não consegue se comunicar muito bem!");
        }

        //toda class filha tem que ter
        public abstract void Mover();
    }

    // 🔹 Subclasse 1: Gato
    internal class Gato : Animal
    {
        public override void Som()
        {
            Console.WriteLine($"O gatinho {Name} faz: Miaau!");
        }

        public override void Mover()
        {
            Console.WriteLine("Ele se move: sob 4 patas");
        }
    }

    // 🔹 Subclasse 2: Peixe
    internal class Peixe : Animal
    {
        public override void Som()
        {
            Console.WriteLine($"O peixinho {Name} não consegue falar!");
        }

        public override void Mover()
        {
            Console.WriteLine("Ele se move: nadando pelo mar");
        }
    }
}