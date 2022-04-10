using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public abstract class Sirket
    {
        protected SirketÜnvan.Ünvan _sirketÜnvan;
        public string _name;
        public Sirket(SirketÜnvan.Ünvan sirketÜnvan,string Name)
        {
            _sirketÜnvan = sirketÜnvan;
            _name = Name;
        }
        public abstract int RaporVer();
    }
}
