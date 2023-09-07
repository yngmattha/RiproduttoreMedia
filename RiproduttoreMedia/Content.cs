using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiproduttoreMedia
{
    internal abstract class Content
    {
        public string _nome { get; set; }
        public int _durata { get; set; }
        public string _autore { get; set; }
        public string _tipologia { get; set; }

        

    }
}
