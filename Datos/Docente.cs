using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broda.Datos
{
    public class Docente : Base
    {
        public List<Entidades.Docente> RecuperarTodos()
        {
            List<Entidades.Docente> docentes = new List<Entidades.Docente>();

            using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Docentes", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Entidades.Docente docente = new Entidades.Docente
                            {
                                Id = (int)reader["IdDocente"],
                                ApellidoNombre = reader["ApellidoNombre"].ToString(),
                                Cuil = reader["Cuil"].ToString(),
                                Mail = reader["Email"].ToString(),
                                Salario = (decimal)reader["Salario"],
                                FechaIngreso = (DateTime)reader["FechaIngreso"]
                            };
                            docentes.Add(docente);
                        }
                    }
                }
            }

            return docentes;
        }
        public void Agregar(Entidades.Docente docente)
        {
            using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Docentes (ApellidoYnombre, Cuil, Mail, Salario, FechaIngreso) VALUES (@ApellidoYnombre, @Cuil, @Mail, @Salario, @FechaIngreso)", connection))
                {
                    command.Parameters.AddWithValue("@ApellidoYnombre", docente.ApellidoNombre);
                    command.Parameters.AddWithValue("@Cuil", docente.Cuil);
                    command.Parameters.AddWithValue("@Mail", docente.Mail);
                    command.Parameters.AddWithValue("@Salario", docente.Salario);
                    command.Parameters.AddWithValue("@FechaIngreso", docente.FechaIngreso);

                    command.ExecuteNonQuery();
                }
            }
        }
        public Entidades.Docente RecuperarUno(string cuil)
        {
            List<Entidades.Docente> docentes = RecuperarTodos();

            Entidades.Docente docente = docentes.FirstOrDefault(docente => docente.Cuil == cuil);
            return docente;
        }

    }
}
