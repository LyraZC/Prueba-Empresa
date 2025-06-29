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
                                //NombreProoducto = Convert.ToInt32(dr["NombreProducto"]),
                                



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

    }
}
