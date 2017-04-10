using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTelefonia.Entities
{
    class Venta
    {
        private int com;
        List<string>_celulares = new List<string> { "IPhone 6", "Samsung Galaxy 7 Edge", "Huawei P9" };
        public Venta(int com)
        {
            this.com = com; 
        }

        public string ProdVen()
        {
            return _celulares[com].ToString();
        }
        public string tipPago(int tp)
        {
            TipoPago _Pago = new TipoPago(tp);
            return _Pago.selPago;
        }
        public string contrato(int con)
        {
            Contrato _con = new Contrato(con);
            return _con.selCon();
        }
        public string CenAtn(string numero)
        {
            CentroAtencion _Cen = new CentroAtencion(numero);
            return _Cen.localizado;
        }
    }
}
