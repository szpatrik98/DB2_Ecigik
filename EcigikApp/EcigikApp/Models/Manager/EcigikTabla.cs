using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcigikApp.Models.Records;
using Oracle.ManagedDataAccess.Client;

namespace EcigikApp.Models.Manager
{
    class EcigikTabla
    {
        OracleConnection GetOracleConnection()
        {
            OracleConnection oc = new OracleConnection();

            string connectionString = @"Data Source=193.225.33.71;User Id=ORA_S1340;Password=EKE2020;";

            oc.ConnectionString = connectionString;

            return oc;

        }

        public List<Ecigik> Select()
        {
            List<Ecigik> records = new List<Ecigik>();

            OracleConnection oc = new OracleConnection();

            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "Select gy.nev, e.tipus, e.sorszam FROM  ecigik e"
                + "INNER JOIN gyartok gy ON gy.id = e.gyarto_id"
            };

            command.Connection = oc;

            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Ecigik ecigi = new Ecigik();
                ecigi.Sorszam = reader["sorszam"].ToString();
                ecigi.Tipus = reader["tipus"].ToString();
                ecigi.Gyarto = reader["nev"].ToString();

                records.Add(ecigi);
            }

            oc.Close();

            return records;
        }

        public int Delete(Ecigik record)
        {
            OracleConnection oc = new OracleConnection();

            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "DELETE  FROM ecigik WHERE sorszam =:sorszam"
            };

            OracleParameter sorszamParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = ":sorszam",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Sorszam
            };

            command.Parameters.Add(sorszamParameter);

            command.Connection = oc;

            command.Transaction = ot;

            int affectedRows = 0;
            try
            {
                affectedRows = command.ExecuteNonQuery();
                ot.Commit();
            }
            catch (Exception)
            {
                ot.Rollback();
            }

            oc.Close();

            return affectedRows;
        }

        public int Insert(Ecigik record)
        {
            OracleConnection oc = new OracleConnection();

            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "spInsert_ecigik"
            };

            OracleParameter sorszamParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_sorszam",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Sorszam
            };
            command.Parameters.Add(sorszamParameter);

            OracleParameter nevParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_nev",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Nev
            };
            command.Parameters.Add(nevParameter);

            OracleParameter szinParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_szin",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Szin
            };
            command.Parameters.Add(szinParameter);


            OracleParameter gyartoParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_gyarto",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Gyarto
            };
            command.Parameters.Add(gyartoParameter);

            OracleParameter wattParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                ParameterName = "p_watt",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Watt
            };
            command.Parameters.Add(wattParameter);

            OracleParameter megjelenesParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.DateTime,
                ParameterName = "p_megjelenesev",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Megjelenesev
            };
            command.Parameters.Add(megjelenesParameter);

            OracleParameter tipusParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_tipus",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Tipus
            };
            command.Parameters.Add(tipusParameter);


            OracleParameter rowCountParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                ParameterName = "p_out_rowcnt",
                Direction = System.Data.ParameterDirection.Output
            };


            command.Connection = oc;
            command.Transaction = ot;

            
            try
            {
                command.ExecuteNonQuery();
                int affectedRows = int.Parse(rowCountParameter.Value.ToString());
                ot.Commit();
                return affectedRows;
            }
            catch (Exception)
            {

                ot.Rollback();
                return 0;
            }

            oc.Close();
       
        }

        public bool CheckSorszam(string sorszam)
        {
            OracleConnection oc = new OracleConnection();

            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "sf_check_sorszam",
            };

            OracleParameter correct = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.ReturnValue,
            };

            OracleParameter sorszamParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_sorszam",
                Direction = System.Data.ParameterDirection.Input,
                Value = sorszam
            };

            command.Parameters.Add(sorszamParameter);

            command.Connection = oc;
            try
            {
                int succesful = int.Parse(correct.Value.ToString());

                return succesful != 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
