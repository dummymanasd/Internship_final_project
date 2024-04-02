using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Security.Policy;
using System.IO;
using System.Data;

namespace Internship2024
{
    public class Internship2024DB: IDisposable
    {
        SqlConnection _connection;
        SqlTransaction _transaction;

        public Internship2024DB()
        {
            InitConnection();
        }

       
        protected void InitConnection()
        {
            try
            {
                _connection = CreateConnection();
                _connection.Open();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        protected SqlConnection CreateConnection()
        {
            string srvString = "";
            string dbString = "";
            //string userName = "";
            //string password = "";
            System.Xml.XmlDocument xmlConfig = new XmlDocument();
            string tempDirectoryPath = Directory.GetCurrentDirectory();
            xmlConfig.Load(tempDirectoryPath + @"\OutputFiles\XMLFiles\App.config");
            XmlNodeList xmlNode = xmlConfig.SelectNodes("Home/ConnValue");
            foreach (XmlNode xmlN in xmlNode)
            {
                srvString = xmlN.ChildNodes[0].FirstChild.Value;
                dbString = xmlN.ChildNodes[1].FirstChild.Value;
                //userName = xmlN.ChildNodes[2].FirstChild.Value;
                //password = xmlN.ChildNodes[3].FirstChild.Value;
            }

            //return new SqlConnection("Initial Catalog=" + dbString + ";Data Source=" + srvString +
            //  ";user id= "  + ";password = ");

            string connectionString = $"Initial Catalog={dbString};Data Source={srvString};Integrated Security=True;";

            return new SqlConnection(connectionString);

        }

        public SqlParameter AddParameter(SqlCommand cmd, string paramName,
            DbType dbType, object value)
        {
            SqlParameter parameter = cmd.CreateParameter();
            parameter.ParameterName = CreateCollectionParameterName(paramName);
            parameter.DbType = dbType;
            parameter.Value = null == value ? DBNull.Value : value;
            cmd.Parameters.Add(parameter);
            return parameter;
        }

        public string CreateCollectionParameterName(string baseParamName)
        {
            return "@" + baseParamName;
        }

        public SqlCommand CreateCommand(string sqlText)
        {
            return CreateCommand(sqlText, false);
        }
        public SqlCommand CreateCommand(string sqlText, bool procedure)
        {
            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = sqlText;
            cmd.Transaction = _transaction;
            if (procedure)
                cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        private void CheckTransactionState(bool mustBeOpen)
        {
            if (mustBeOpen)
            {
                if (null == _transaction)
                    throw new InvalidOperationException("Transaction is not open.");
            }
            else
            {
                if (null != _transaction)
                    throw new InvalidOperationException("Transaction is already open.");
            }
        }
       

        protected internal SqlDataReader ExecuteReader(SqlCommand command)
        {
            return command.ExecuteReader();
        }
        public SqlConnection Connection
        {
            get { return _connection; }
        }

        public SqlTransaction BeginTransaction()
        {
            CheckTransactionState(false);
            _transaction = _connection.BeginTransaction();
            return _transaction;
        }

        public void CommitTransaction()
        {
            CheckTransactionState(true);
            _transaction.Commit();
            _transaction = null;
        }

        public void RollbackTransaction()
        {
            CheckTransactionState(true);
            _transaction.Rollback();
            _transaction = null;
        }

        public void Close()
        {
            if (null != _connection)
                _connection.Close();
        }

        public void Dispose()
        {
            Close();
            if (null != _connection)
                _connection.Dispose();
        }
        
        public int ExecuteNonQuery(SqlCommand cmd)
        {
            return cmd.ExecuteNonQuery();
        }

    }
}
