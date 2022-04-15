using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{

    //Nel mio pc avevo un Database Persone con nome cognome e età ma è stato cancellato
    
    internal class RepositoryAdo
    {
        const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Persone;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Utente GetUtente(string nome, string cognome, int eta)
        {
            //creo un utente
            Utente user = null;
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from Utente where Nome = @n and Cognome = @c and Eta = @e";

                command.Parameters.AddWithValue("@n", nome);
                command.Parameters.AddWithValue("@c", cognome);
                command.Parameters.AddWithValue("@e", eta);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var name = (string)reader["Nome"];
                    var surName = (string)reader["Cognome"];
                    var anni = (int)reader["Eta"];

                    user = new Utente(name, surName, anni);
                }


                if (user == null)
                {
                    //lancio una mia Eccezione Personalizzata 
                    throw new UtenteNonTrovatoException("\n\nL'utente cercato non è presente nel DB.\n\n")
                    {
                        Utente = user,

                    };
                }

                return user;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Problemi con DB. Dettagli: \n {ex.Message}");
                return user;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                
            }

        }

    }
}
