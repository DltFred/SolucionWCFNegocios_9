using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;

namespace WCFNegocios_9
{
    public class Service1 : IService1
    {
        string cadena = @"Server=localhost;Database=master;Trusted_Connection=True;";
        public string Actualizar(Cliente reg)
        {
            String mensaje = "";
            SqlConnection cn = new SqlConnection(cadena);
            using (SqlCommand cmd = new SqlCommand("sp_update_cliente", cn))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@cod", reg.idcliente);
                    cmd.Parameters.AddWithValue("@nombre", reg.nombrecia);
                    cmd.Parameters.AddWithValue("@dir", reg.direccion);
                    cmd.Parameters.AddWithValue("@idpais", reg.idpais);
                    cmd.Parameters.AddWithValue("@fono", reg.telefono);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    mensaje = "Cliente actualizado";
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                }
                finally
                {
                    cn.Close();
                }


            }
            return mensaje;
        }

        public string Agregar(Cliente reg)
        {
            String mensaje = "";
            SqlConnection cn = new SqlConnection(cadena);
            using (SqlCommand cmd = new SqlCommand("sp_add_cliente", cn))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cod", reg.idcliente);
                    cmd.Parameters.AddWithValue("@nombre", reg.nombrecia);
                    cmd.Parameters.AddWithValue("@dir", reg.direccion);
                    cmd.Parameters.AddWithValue("@idpais", reg.idpais);
                    cmd.Parameters.AddWithValue("@fono", reg.telefono);
                    cn.Open();//abrir antes de ejecutar
                    cmd.ExecuteNonQuery();
                    mensaje = "Cliente registrado";
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                }
                finally
                {
                    cn.Close();
                }
            }
            return mensaje;
        }

        public Cliente Buscar(string id)
        {
            Cliente reg = null;
            using (SqlConnection con = new SqlConnection(cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_search_cliente", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cod", id);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        reg = new Cliente()
                        {
                            idcliente = dr.GetString(0),
                            nombrecia = dr.GetString(1),
                            direccion = dr.GetString(2),
                            idpais = dr.GetString(3),
                            telefono = dr.GetString(4)
                        };
                    }
                    dr.Close();
                    con.Close();
                }
            }
            return reg;
        }

        public List<Cliente> clientes()
        {
            List<Cliente> listado = new List<Cliente>();
            using (SqlConnection con = new SqlConnection(cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_clientes", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Cliente reg = new Cliente()
                        {
                            idcliente = dr.GetString(0),
                            nombrecia = dr.GetString(1),
                            direccion = dr.GetString(2),
                            idpais = dr.GetString(3),
                            telefono = dr.GetString(4)
                        };
                        listado.Add(reg);
                    }
                    dr.Close();
                    con.Close();
                }
            }
            return listado;
        }

        public List<Pais> paises()
        {
            List<Pais> temp = new List<Pais>();
            using (SqlConnection cnx = new SqlConnection(cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_paises", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnx.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Pais reg = new Pais()
                        {
                            idpais = dr.GetString(0),
                            nombrepais = dr.GetString(1)
                        };
                        temp.Add(reg);
                    }
                    dr.Close();
                    cnx.Close();
                }
            }
            return temp;
        }
    }
}
