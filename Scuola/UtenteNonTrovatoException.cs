using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{
    internal class UtenteNonTrovatoException:Exception
    {
        public Utente Utente { get; set; }
      

        public UtenteNonTrovatoException()
        {

        }
        public UtenteNonTrovatoException(string messaggio) : base(messaggio)
        {

        }

        protected UtenteNonTrovatoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }

}

