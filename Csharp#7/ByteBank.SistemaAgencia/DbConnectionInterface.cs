namespace ByteBank.SistemaAgencia
{
    /// <summary>
    /// Inteface como abstração e aplicação do DIP
    /// Dependece Inversion Principle
    /// Serve para ser uma abstração para gerar conexões de vários tipos de bancos
    /// </summary>
    interface DbConnectionInterface
    {
        void connect();

    }
    /// <summary>
    /// Classe para conexão de banco de dados MYSQL implementa DbConnectionInterface
    /// </summary>
    class MySqlConnection : DbConnectionInterface
    {
        public void connect()
        {

        }
    }
    /// <summary>
    /// Classe para conexão de Banco de dados Oracle implementa DbConnectionInterface
    /// </summary>
    class OracleConnection : DbConnectionInterface
    {

        public void connect()
        {

        }

    }


    class PasswordReminder
    {
        private DbConnectionInterface dbConnection;
        public void construct(DbConnectionInterface DBConnection)
        {
            this.dbConnection = DBConnection;
        }
    }

}
