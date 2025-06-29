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
    public class CD_Producto
    {
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "Select ID_PRODUCTOS, CODIGO_PRODUCTO, NOMBRE_PRODUCTO, EXISTENCIA, NOMBRE_PROVEEDOR, ESTADO from PRODUCTOS";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Producto()
                            {
                                idProducto = Convert.ToInt32(dr["ID_PRODUCTOS"]),
                                Codigo = dr["CODIGO_PRODUCTO"].ToString(),
                                NombreProducto = dr["NOMBRE_PRODUCTO"].ToString(),
                                Existencia = Convert.ToInt32(dr["EXISTENCIA"]),
                                Proveedor = dr["NOMBRE_PROVEEDOR"].ToString(),
                                Estado = Convert.ToBoolean(dr["ESTADO"])



                            });
                        }


                    }



                }
                catch (Exception ex)
                {
                    lista = new List<Producto>();
                }


            }

            return lista;

        }


    }
}
