using Dapper;
using System.Data.SQLite;

namespace CRUD._02_Repositorios.Data;

public static class InicializadorBd
{
    public static void Inicializar()
    {
        using var connection = new SQLiteConnection("Data Source=CRUD.db");

        string commandoSQL = @"   
                 CREATE TABLE IF NOT EXISTS Times(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Nome TEXT NOT NULL,
                 AnoCriacao INTEGER NOT NULL
                );";

        commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS Alunos(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Nome TEXT NOT NULL,
                 Idade INTEGER NOT NULL,
                 Peso REAL NOT NULL
                );";

        commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS Cidades(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Nome TEXT NOT NULL,
                 Qtd_habitantes INTEGER NOT NULL
                );";

        connection.Execute(commandoSQL);
    }

}
