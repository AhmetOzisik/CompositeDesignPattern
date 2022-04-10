using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public abstract class SirketComposite:Sirket
    {
        public SirketComposite(SirketÜnvan.Ünvan sirketÜnvan,string Name) : base(sirketÜnvan, Name) { }
        public abstract void AddSirketCalisan(Sirket sirket);
        public abstract void DeleteSirketCalisan(Sirket sirket);
    }
}
