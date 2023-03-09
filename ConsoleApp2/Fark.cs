using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Demo
    {
        public void Test() {
        Hayvan h = new Hayvan();
            h.BeslenmeTürü = BeslenmeTip.Ot; //h.BeslenmeTürü = "Ot"; (enum ı tanımlamazsak bu şekilde)
        }
    }

    public enum BeslenmeTip
    {
        Ot,
        Et
    }


    public class Hayvan
    {
        //public string BeslenmeTürü; //public int BeslenmeTürü (sadece string olmasına gerek yok int da girebiliriz)
        public BeslenmeTip BeslenmeTürü;
    } 
    public abstract class Kedigiller:Hayvan
    {
        public bool Tirmanma = true;
        public void Girla() //Diğerlerine implement ediyo
        {
            Console.WriteLine("Gırrrr");
        }
        public abstract void Ses();
    }
    public class Aslan : Kedigiller
    {
        public override void Ses() //Diğerlerine implement etmiyor o yüzden alttakilere implement etmek gerekiyor
        {
            throw new NotImplementedException();
        }
    }
    public class Kedi : Kedigiller
    {
        public override void Ses()
        {
            throw new NotImplementedException();
        }
    }
}

