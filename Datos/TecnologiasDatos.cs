using System.Data.SqlClient;
using System.Data;
using PortafolioWeb.Models;

namespace PortafolioWeb.Datos
{
    public class TecnologiasDatos
    {
        public List<TecnologiasModel> Listar()
        {
            List<TecnologiasModel> oLista = new List<TecnologiasModel>();
            var cn = new Conexion();
            using (var conexion = new SqlConnection(cn.getCadenaSql()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Tecnologias", conexion);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new TecnologiasModel()
                        {
                            IdTecnologia = Convert.ToInt32(dr["IdTecnologia"]),
                            Nombre = dr["Nombre"].ToString(),
                            Descripcion = dr["Descripcion"].ToString(),
                            URLImagen = dr["URLImagen"].ToString(),
                        });
                    }
                }
            }
            return oLista;
        }
    }
}
