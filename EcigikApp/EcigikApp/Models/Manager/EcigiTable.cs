using EcigikApp.Models.Records;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcigikApp.Models.Manager
{
    class EcigiTable
    {
        OracleConnection GetOracleConnection()
        {
            OracleConnection oc = new OracleConnection();

            string connectionString = @"Data Source=193.225.33.71;User Id=AI18MZ;Password=EKE2020;";
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
                CommandText = "SELECT m.nev, e.sorszam FROM " +
                " ecigik e INNER JOIN markak m ON m.id = e.marka_id"
            };

            command.Connection = oc;

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Ecigik ecigi = new Ecigik();
                ecigi.Sorszam = reader["sorszam"].ToString();               
                ecigi.Marka = reader["nev"].ToString();

                records.Add(ecigi);
            }
            oc.Close();

            return records;
        }


        public int Delete(Ecigik record)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "DELETE FROM ecigik WHERE sorszam = :sorszam"
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
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "spInsert_ecigik"
            };

            //paraméterek! Hiszen fontos, hogy ne égessük bele a progiba az adatokat, ezért kellenek paraméterek!!!!
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

            OracleParameter markaParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_marka",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Marka
            };
            command.Parameters.Add(markaParameter);

            OracleParameter wattParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                ParameterName = "p_watt",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Watt
            };
            command.Parameters.Add(wattParameter);

            OracleParameter megjeleneseveParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_megjelenesev",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Megjelenesev
            };
            command.Parameters.Add(megjeleneseveParameter);

            OracleParameter tipusParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_tipus",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Tipus
            };
            command.Parameters.Add(tipusParameter);
       

            OracleParameter rowcountParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                ParameterName = "p_out_rowcnt",
                Direction = System.Data.ParameterDirection.Output
            };

            command.Connection = oc;
            command.Transaction = ot;

            oc.Close();

            try
            {
                command.ExecuteNonQuery();
                int affectedRows = int.Parse(rowcountParameter.Value.ToString());
                ot.Commit();
                return affectedRows;
            }
            catch (Exception)
            {
                ot.Rollback();
                return 0;
            }


        }


        public bool CheckSorszam(string sorszam)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "sf_check_sorszam"
            };

            OracleParameter correct = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.ReturnValue
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
        public bool CheckNev(string nev)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "sf_check_nev"
            };

            OracleParameter correct = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.ReturnValue
            };

            OracleParameter nevParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_nev",
                Direction = System.Data.ParameterDirection.Input,
                Value = nev

            };
            command.Parameters.Add(nevParameter);

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
