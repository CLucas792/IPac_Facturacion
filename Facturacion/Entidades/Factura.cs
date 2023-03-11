using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Identidad { get; set; }
        public string CodigoUsuario { get; set; }
        public decimal ISV { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }

        public Factura()
        {
        }

        public Factura(int id, DateTime fecha, string identidad, string codigoUsuario, decimal iSV, decimal subtotal, decimal total)
        {
            Id = id;
            Fecha = fecha;
            Identidad = identidad;
            CodigoUsuario = codigoUsuario;
            ISV = iSV;
            Subtotal = subtotal;
            Total = total;
        }
    }
}
