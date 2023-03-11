using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{


    public class ClienteBD

    {
        string cadena = "server=localhost;user=root; database=mifactura; password=0801";

        public Cliente DevolverClientePorIdentidad(string identidad)
        {
            Cliente cliente = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM cliente WHERE IdCliente = @Identidad");


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            cliente = new Cliente();
                            cliente.IdCliente = identidad;
                            cliente.Nombre = dr["Nombre"].ToString();
                            cliente.Telefono = dr["Telefono"].ToString();
                            cliente.Correo = dr["Correo"].ToString();
                            cliente.Direccion = dr["Direccion"].ToString();
                            cliente.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"].ToString());
                            cliente.EstaActivo = Convert.ToBoolean(dr["EstaActivo"].ToString());
                        }
                    }

                }
            }
            catch
            {

            }

            return cliente;
        }



        public DataTable DevolverClientes()
        {
            DataTable datatable = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM cliente");


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


        public bool Insertar(Cliente cliente)
        {
            bool inserto = false;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO cliente VALUES");
                sql.Append("(@IdCliente, @Nombre, @Telefono, @Correo, @Direccion,@FechaNacimiento,@EstaActivo)");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@IdCliente", MySqlDbType.VarChar, 25).Value = cliente.IdCliente;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = cliente.Nombre;
                        comando.Parameters.Add("@Telefono", MySqlDbType.VarChar, 15).Value = cliente.Telefono;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = cliente.Correo;
                        comando.Parameters.Add("@FechaNacimiento", MySqlDbType.DateTime).Value = cliente.FechaNacimiento;
                        comando.Parameters.Add("@Direccion", MySqlDbType.VarChar, 100).Value = cliente.Direccion;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = cliente.EstaActivo;

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

        public bool Editar(Cliente cliente)
        {
            bool edito = false;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE cliente SET ");
                sql.Append(" Nombre = @Nombre, Telefono = @Telefono, Correo = @Correo, Direccion = @Direccion, FechaNacimiento = @FechaNacimiento, EstaActivo = @EstaActivo");
                sql.Append(" WHERE IdCliente = @IdCliente;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.Parameters.Add("@IdCliente", MySqlDbType.VarChar, 25).Value = cliente.IdCliente;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = cliente.Nombre;
                        comando.Parameters.Add("@Telefono", MySqlDbType.VarChar, 15).Value = cliente.Telefono;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = cliente.Correo;
                        comando.Parameters.Add("@FechaNacimiento", MySqlDbType.DateTime).Value = cliente.FechaNacimiento;
                        comando.Parameters.Add("@Direccion", MySqlDbType.VarChar, 100).Value = cliente.Direccion;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = cliente.EstaActivo;

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

        public bool Eliminar(string Identidad)
        {
            bool elimino = false;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM cliente ");
                sql.Append(" WHERE IdCliente = @IdCliente ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@IdCliente", MySqlDbType.VarChar, 25).Value = Identidad;
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


    }
}
