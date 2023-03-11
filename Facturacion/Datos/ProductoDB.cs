using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;
using System.Data;


namespace Datos
{
    public class ProductoDB
    {
        string cadena = "server=localhost;user=root; database=mifactura; password=0801";

        public bool Insertar(Producto producto)
        {
            bool inserto = false;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO producto VALUES");
                sql.Append("(@Codigo, @Descripcion, @Existencia, @Precio, @Foto, @EstaActivo)");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = producto.Codigo;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 200).Value = producto.Descripcion;
                        comando.Parameters.Add("@Existencia", MySqlDbType.Int32).Value = producto.Existencia;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = producto.Precio;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = producto.Imagen;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = producto.EstaActivo;

                        comando.ExecuteNonQuery();
                        inserto = true;
                    }

                }
            }
            catch
            {

            }
            return inserto;
        }

        public bool Editar(Producto producto)
        {
            bool edito = false;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE producto SET ");
                sql.Append(" Codigo = @Codigo, Descripcion = @Descripcion, Existencia = @Existencia,Precio = @Precio,Foto = @Foto,EstaActivo = @EstaActivo");
                sql.Append(" WHERE Codigo = @Codigo;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = producto.Codigo;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 200).Value = producto.Descripcion;
                        comando.Parameters.Add("@Existencia", MySqlDbType.Int32).Value = producto.Existencia;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = producto.Precio;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = producto.Imagen;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = producto.EstaActivo;

                        comando.ExecuteNonQuery();
                        edito = true;
                    }

                }
            }
            catch (Exception ex)
            {

            }
            return edito;
        }

        public bool Eliminar(string Codigo)
        {
            bool elimino = false;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM producto ");
                sql.Append(" WHERE Codigo = @Codigo ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 50).Value = Codigo;
                        comando.ExecuteNonQuery();
                        elimino = true;
                    }

                }
            }
            catch
            {

            }
            return elimino;
        }

        public DataTable DevolverProductos()
        {
            DataTable datatable = new DataTable();
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM producto");


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        MySqlDataReader dr = comando.ExecuteReader();
                        datatable.Load(dr);

                    }

                }
            }
            catch
            {

            }
            return datatable;
        }

        public byte[] DevolverImagen(string Codigo)
        {
            byte[] imagen = new byte[0];
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT Foto FROM producto WHERE Codigo = @Codigo; ");


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = Codigo;
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            imagen = (byte[])dr["Foto"];
                        }

                    }

                }
            }
            catch
            {

            }
            return imagen;
        }

        public Producto DevolverProductoPorCodigo(string codigo)
        {
            Producto producto = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM producto WHERE Codigo = @Codigo");


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            producto = new Producto();
                            producto.Codigo = codigo;
                            producto.Descripcion = dr["Descripcion"].ToString();
                            producto.Existencia = Convert.ToInt32(dr["Existencia"].ToString());
                            producto.Precio = Convert.ToInt32(dr["Precio"].ToString());
                            producto.EstaActivo = Convert.ToBoolean(dr["EstaActivo"].ToString());
                        }
                    }

                }
            }
            catch
            {

            }
            return producto;
        }

    }
}
