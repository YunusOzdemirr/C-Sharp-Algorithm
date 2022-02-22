using System;

namespace Algorithms
{
    public class ClassAndAbstract
    {

    }

    abstract class Hayvan
    {
        public void Yuru()
        {
            Console.WriteLine("Yürüyorum");
        }
        public void Dur()
        {
            Console.WriteLine("Durdum");
        }
        public virtual void Naber() { }
    };

    class Kopek : Hayvan
    {
        public int isim { get; set; }
        public override void Naber()
        {
            base.Naber(); ;
        }
    }
}