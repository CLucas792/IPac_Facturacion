﻿using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;

namespace Datos
{
    public class UsuarioDB
    {
        string cadena = "server=localhost;user=root; database=mifactura; password=0801";

        public Usuario Autenticar(Login login)
        {
            Usuario user = null;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM usuarios WHERE CodigoUsuario = @CodigoUsuario AND Contraseña = @Contraseña;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = login.CodigoUsuario;
                        comando.Parameters.Add("@Contraseña", MySqlDbType.VarChar, 80).Value = login.Contraseña;

                        MySqlDataReader dr = comando.ExecuteReader();

                        if (dr.Read())
                        {
                            user = new Usuario();

                            user.CodigoUsuario = dr["CodigoUsuario"].ToString();
                            user.Nombre = dr["Nombre"].ToString();
                            user.Contraseña = dr["Contraseña"].ToString();
                            user.EstadoActivo = Convert.ToBoolean(dr["EstaActivo"]);
                            user.Correo = dr["Correo"].ToString();
                            user.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                            user.Rol = dr["Rol"].ToString();
                            if (dr["Foto"].GetType() != typeof(DBNull))
                            {
                                user.Foto = (byte[])dr["Foto"];
                            }


                        }
                    }

                }

            }
            catch (System.Exception ex)
            {

            }
            return user;
        }

        public bool Insertar(Usuario user)
        {
            bool inserto = false;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO usuarios VALUES");
                sql.Append("(@CodigoUsuario, @Nombre, @Contraseña, @Correo, @FechaCreacion,@Rol,@Foto,@EstaActivo)");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = user.CodigoUsuario;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 45).Value = user.Nombre;
                        comando.Parameters.Add("@Contraseña", MySqlDbType.VarChar, 80).Value = user.Contraseña;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = user.Correo;
                        comando.Parameters.Add("@FechaCreacion", MySqlDbType.DateTime).Value = DateTime.Now;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 20).Value = user.Rol;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = user.Foto;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = user.EstadoActivo;

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

        public bool Editar(Usuario user)
        {
            bool edito = false;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE usuarios SET ");
                sql.Append(" Nombre = @Nombre, Contraseña = @Contraseña, Correo = @Correo,Rol = @Rol,Foto = @Foto,EstaActivo = @EstaActivo");
                sql.Append(" WHERE CodigoUsuario = @CodigoUsuario;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = user.CodigoUsuario;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 45).Value = user.Nombre;
                        comando.Parameters.Add("@Contraseña", MySqlDbType.VarChar, 80).Value = user.Contraseña;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = user.Correo;
                        comando.Parameters.Add("@FechaCreacion", MySqlDbType.DateTime).Value = DateTime.Now;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 20).Value = user.Rol;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = user.Foto;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = user.EstadoActivo;

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

        public bool Eliminar(string CodigoUsuario)
        {
            bool elimino = false;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM usuarios ");
                sql.Append(" WHERE CodigoUsuario = @CodigoUsuario ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = CodigoUsuario;
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

        public DataTable DevolverUsuario()
        {
            DataTable datatable = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM usuarios");


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

        public byte[] DevolverImagen(string CodigoUsuario)
        {
            byte[] imagen = new byte[0];
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT Foto FROM usuarios WHERE CodigoUsuario = @CodigoUsuario; ");


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = CodigoUsuario;
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


    }
}
