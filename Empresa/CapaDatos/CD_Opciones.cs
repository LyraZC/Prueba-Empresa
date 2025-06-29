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
    public class CD_Opciones
    {
        public List<Opciones> Listar()
        {
            List<Opciones> lista = new List<Opciones>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "Select ID_OPCIONES, NOMBRE_OPCION, ID_PRODUCTO_OPCION from OPCIONES";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Opciones()
                            {
                                idOpcion = Convert.ToInt32(dr["ID_OPCIONES"]),
                                Nombre = dr["NOMBRE_OPCION"].ToString(),
                                idNombreProducto = Convert.ToInt32(dr["ID_PRODUCTO_OPCION"]),
                                
                                



                            });
                        }


                    }



                }
                catch (Exception ex)
                {
                    lista = new List<Opciones>();
                }


            }

            return lista;

        }

        public Opciones Crear(Opciones opciones)
        {
            Opciones opcionCreado = new Opciones();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"INSERT INTO OPCIONES 
                             (NOMBRE_OPCION, ID_PRODUCTO_OPCION)
                             
                             VALUES (@NombreOpcion, @ID_Producto_Opcion)";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@NombreOpcion", opciones.Nombre);
                    cmd.Parameters.AddWithValue("@ID_Producto_Opcion", opciones.idNombreProducto);


                    conexion.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        opcionCreado = new Opciones()
                        {
                            idOpcion = Convert.ToInt32(result),
                            Nombre = opciones.Nombre,
                            idNombreProducto = opciones.idNombreProducto
                        };
                    }
                }
                catch (Exception ex)
                {
                    opcionCreado = new Opciones();
                }
            }

            return opcionCreado;
        }

        public Opciones Editar(int idOpcion, string nuevoNombre)
        {
            Opciones opcionEditada = null;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"UPDATE OPCIONES 
                             SET NOMBRE_OPCION = @nombre 
                             WHERE ID_OPCIONES = @id";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", nuevoNombre);
                    cmd.Parameters.AddWithValue("@id", idOpcion);

                    conexion.Open();
                    int filas = cmd.ExecuteNonQuery();

                    // Si se actualizó con éxito, devolver el objeto actualizado
                    if (filas > 0)
                    {
                        opcionEditada = new Opciones()
                        {
                            idOpcion = idOpcion,
                            Nombre = nuevoNombre
                            
                        };
                    }
                }
                catch
                {
                    opcionEditada = null;
                }
            }

            return opcionEditada;
        }

    }
}
