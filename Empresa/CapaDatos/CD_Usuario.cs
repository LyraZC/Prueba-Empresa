using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Usuario
    {
        /*Funcion para consultar los usuarios de la base de datos*/
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "Select ID_USUARIOS, NOMBRE_DE_USUARIO, CONTRASEÑA, NOMBRE, APELLIDO, CORREO, TELEFONO, ESTADO from USUARIOS";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                idUsuario = Convert.ToInt32(dr["ID_USUARIOS"]),
                                NombreUsuario = dr["NOMBRE_DE_USUARIO"].ToString(),
                                Contraseña = dr["CONTRASEÑA"].ToString(),
                                Nombre = dr["NOMBRE"].ToString(),
                                Apellido = dr["APELLIDO"].ToString(),
                                Correo = dr["CORREO"].ToString(),
                                Telefono = dr["TELEFONO"].ToString(),
                                Estado = Convert.ToBoolean(dr["ESTADO"])



                            });
                        }


                    }



                }catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }


            }

            return lista;

        }

        public Usuario Crear(Usuario usuario)
        {
            Usuario usuarioCreado = new Usuario();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"INSERT INTO USUARIOS 
                             (NOMBRE_DE_USUARIO, CONTRASEÑA, NOMBRE, APELLIDO, CORREO, TELEFONO)
                             
                             VALUES (@NombreUsuario, @Contrasena, @Nombre, @Apellido, @Correo, @Telefono)";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@Contrasena", usuario.Contraseña);
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    

                    conexion.Open();

                    // Obtener el ID generado por la base de datos
                    object idGenerado = cmd.ExecuteScalar();

                    if (idGenerado != null)
                    {
                        usuarioCreado = usuario;
                        usuarioCreado.idUsuario = Convert.ToInt32(idGenerado);
                    }
                    else
                    {
                        throw new Exception("No se pudo crear el usuario.");
                    }
                }
                catch (Exception ex)
                {
                    usuarioCreado = new Usuario();
                }
            }

            return usuarioCreado;
        }


    }
}
