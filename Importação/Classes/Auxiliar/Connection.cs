using MySql.Data.MySqlClient;
using System;

namespace Importação
{
    static class Connection
    {
        static private string servidor = "localhost";
        static private string bancoDados = "teste";
        static private string usuario = "root";

        static public string strConn = $"server={servidor};User Id={usuario};database={bancoDados}";
    }
}