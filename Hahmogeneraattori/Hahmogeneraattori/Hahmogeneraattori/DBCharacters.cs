using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hahmogeneraattori
{
    static class DBCharacters
    {
        public static DataTable GetAllAutosFromMysqlDt()
        {
            try
            {
                // Get character data and returns it as a DataTable
                DataTable dt = new DataTable();
                using (MySqlConnection conn = new MySqlConnection(GetConnectionString()))
                {
                    string sql = "SELECT CharacterID, CharName, CharRace, CharClass, CharStr, CharDex, CharCon, CharInt, CharWis, CharCha FROM Characters";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch
            {

                throw;
            }
        }
        public static List<Character> GetAllAutosFromMysql()
        {
            try
            {
                // metodi palauttaa listan auto-olioita joiden tiedot haettu Mysql:stä
                List<Character> chars = new List<Character>();
                //luodaan yhteys tietokantaan
                string connStr = GetConnectionString();
                string sql = "SELECT CharacterID, CharName, CharRace, CharClass, CharStr, CharDex, CharCon, CharInt, CharWis, CharCha FROM Characters";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            Character character = new Character();
                            character.CharacterID = rdr.GetInt16(0);
                            character.CharName = rdr.GetString(1);
                            character.CharRace = rdr.GetString(2);
                            character.CharClass = rdr.GetString(3);
                            character.CharStr = rdr.GetInt16(4);
                            character.CharDex = rdr.GetInt16(5);
                            character.CharCon = rdr.GetInt16(6);
                            character.CharInt = rdr.GetInt16(7);
                            character.CharWis = rdr.GetInt16(8);
                            character.CharCha = rdr.GetInt16(9);
                            chars.Add(character);

                        }
                    }
                }
                //palautus
                return chars;
            }
            catch
            {

                throw;
            }


        }
        private static string GetConnectionString()
        {
            // Tietokannan kirjautumistiedot
            string palvelin = "mysql.labranet.jamk.fi";
            string tietokanta = "K9105_3";
            string tunnus = "K9105";
            string pw = "QyfaBqBoJjYPmAXHv4LokkIf82B0EWs7";
            return string.Format("Data source={0};Initial catalog={1};user={2};password={3}", palvelin, tietokanta, tunnus, pw);
        }

    }
    public class Character
    {
        public int CharacterID { get; set; }
        public string CharName { get; set; }
        public string CharRace { get; set; }
        public string CharClass { get; set; }
        public int CharStr { get; set; }
        public int CharDex { get; set; }
        public int CharCon { get; set; }
        public int CharInt { get; set; }
        public int CharWis { get; set; }
        public int CharCha { get; set; }


    }
}


