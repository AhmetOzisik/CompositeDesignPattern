using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class CompositeCalisan:SirketComposite
    {
        public List<Sirket> sirkets = new List<Sirket>();
        static int toplam=0;
        public CompositeCalisan(SirketÜnvan.Ünvan sirketÜnvan, string Name) : base(sirketÜnvan, Name) { }
        public override void AddSirketCalisan(Sirket sirket)
        {
            sirkets.Add(sirket);
        }
        public override void DeleteSirketCalisan(Sirket sirket)
        {
            sirkets.Remove(sirket);
        }
        
        public override int RaporVer()
        {
            toplam = toplam + 25;
            foreach (Sirket sirket in sirkets)
            {
                toplam = toplam + sirket.RaporVer();
            }
            return toplam;
        }
    }
}
