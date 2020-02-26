using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternStrategy.Bussines.Strategy
{
    public class GuardadoFormatoStrategy
    {
        IGuardadoFormato svrGuardadoFormato;
        public GuardadoFormatoStrategy() { }
        public GuardadoFormatoStrategy(IGuardadoFormato _svrGuardadoFormato)
        {
            this.svrGuardadoFormato = _svrGuardadoFormato;
        }

        public void SetStrategy(IGuardadoFormato _svrGuardadoFormato)
        {
            this.svrGuardadoFormato = _svrGuardadoFormato;
        }

        public string GuardaFormato(string _cNombre)
        {
            return this.svrGuardadoFormato.GuardarFormato(_cNombre);
        }
    }
}
