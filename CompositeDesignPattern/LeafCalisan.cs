using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
   public class LeafCalisan:Sirket
    {
        public LeafCalisan(SirketÜnvan.Ünvan sirketÜnvan, string Name) : base(sirketÜnvan, Name) { }
        public override int RaporVer()
        {
            return 25;
        }
    }
}
