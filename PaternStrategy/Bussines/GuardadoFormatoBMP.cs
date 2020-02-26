using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternStrategy.Bussines.Strategy
{
    public class GuardadoFormatoBMP : IGuardadoFormato
    {
        public string GuardarFormato(string _cNomrbre)
        {
            return string.Format("Se ha guardado la imagen {0}.{1}", _cNomrbre, "BMP");
        }
    }
}
