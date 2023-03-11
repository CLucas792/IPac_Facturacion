using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class FacturaDB
    {
        string cadena = "server=localhost;user=root; database=mifactura; password=0801";

        public bool Guardar(Factura factura, List<DetalleFactura> detalles)
        {
            bool inserto = false;
            int idFactura = 0;
            try
            {
                StringBuilder sqlFactura = new StringBuilder();
                sqlFactura.Append("INSERT INTO factura VALUES (@Fecha, @IdCliente, @CodigoUsuario, @Isv, @Descuento, @SubTotal, @Total); ");
                sqlFactura.Append(" SELECT LAST_INSERT_ID(); ");

                StringBuilder sqlDetalle = new StringBuilder();
                sqlDetalle.Append(" INSERT INTO detallefactura(@IdFactura, @CodigoProducto, @Precio, @Cantidad, @Total); ");

                StringBuilder sqlExistencia = new StringBuilder();
                sqlExistencia.Append("UPDATE producto SET Existencia = Existencia - @Cantidad WHERE Codigo = @Codigo; ");

            }
            catch (System.Exception)
            {


            }

            return inserto;
        }
    }
}
