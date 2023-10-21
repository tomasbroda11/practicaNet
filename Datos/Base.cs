using System.Data.SqlClient;
using Entidades;

namespace Broda.Datos
{
    public class Base
    {
        protected SqlConnection Connection;
        private const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\tomas\\OneDrive\\Documentos\\Facultad\\Parciales PC .NET 2020\\Net.DB.Docentes.mdf\";Integrated Security=True;Connect Timeout=30";
        public Base() 
        {
           
            Connection = new SqlConnection(ConnectionString);
        }
        public void AbrirConexion()
        {
            if (Connection.State != System.Data.ConnectionState.Open)
            {
                Connection.Open();
            }
        }
        public void CerrarConexion()
        {
            if (Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
        }
    }
}