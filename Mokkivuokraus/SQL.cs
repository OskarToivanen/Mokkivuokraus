using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace Mokkivuokraus
{
    // Luokkaa voidaan kutsua, joka helpottaa kun käytössä on monta formia
    // Tuodaan parametrinä SQL- lause, jonka avulla tieto lisätään tietokantaan
    class SQL
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;Password=Ruutti;");
        MySqlCommand command;

        public void AvaaYhteys()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void SuljeYhteys()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public string SuoritaKysely(string query)
        {
            try
            {
                AvaaYhteys();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    // MessageBox.Show("Kysely suoritettu");
                    return "Kysely suoritettu";
                }
                else
                {
                    //MessageBox.Show("Kyselyä ei suoritettu");
                    return "Kyselyä ei suoritettu";
                }

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return e.Message;

            }
            finally
            {
                SuljeYhteys();
            }
        }
    }
}
