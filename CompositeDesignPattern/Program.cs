using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositeCalisan compositeCalisan = new CompositeCalisan(SirketÜnvan.Ünvan.GenelMüdür, "Ahmet");
            CompositeCalisan compositeCalisan2 = new CompositeCalisan(SirketÜnvan.Ünvan.Müdür, "Ömer");
            LeafCalisan leafCalisan = new LeafCalisan(SirketÜnvan.Ünvan.İşci, "Bilal");
            compositeCalisan.AddSirketCalisan(compositeCalisan2);
            compositeCalisan2.AddSirketCalisan(leafCalisan);
           
            Console.WriteLine(compositeCalisan.RaporVer());
            Console.ReadLine();

        }
    }
}
