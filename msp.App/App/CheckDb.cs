using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Data.Common;
using Msp.Infrastructure;

namespace Msp.App.App
{
    public partial class CheckDb : DevExpress.XtraEditors.XtraForm
    {
        public CheckDb()
        {
            InitializeComponent();
        }

        public static SqlCommand SqlCreateCommandFront()
        {
            string connectionString = "initial catalog=" + AppMain.SqlConnection.Database
                + ";data source=" + AppMain.SqlConnection.Server
                + ";user id=" + AppMain.SqlConnection.UserId
                + ";password=" + AppMain.SqlConnection.Password
                + ";Packet Size=8000;Connect Timeout=120";
            //if (SednaFBMain.user != null)
            //{
            //    connectionString += ";WSID=SEDNAFB|" + SednaFBMain.user;
            //    connectionString += "|" + System.Environment.MachineName.ToString().Trim();
            //}
            AppMain.LcConnectionString = connectionString;
            SqlConnection sConn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sConn;
            cmd.CommandTimeout = 0;
            return cmd;
        }

        public static DataTable ExecuteSelectCommand(DbCommand command)
        {
            DataTable table = new DataTable();
            try
            {
                command.Connection.Open();
                DbDataReader reader = command.ExecuteReader();
                table.Load(reader);
                reader.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                command.Connection.Close();
            }
            return table;
        }

        public static int ExecuteNonQuery(DbCommand command)
        {
            int affectRows = -1;
            try
            {
                command.Connection.Open();
                affectRows = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                command.Connection.Close();
            }
            return affectRows;
        }

        public void UpdateFromStart()
        {
            CheckForIllegalCrossThreadCalls = false;
            int maximum = 1500;
            this.progressBarControl1.Properties.Step = 1;
            this.progressBarControl1.Properties.PercentView = true;
            this.progressBarControl1.Properties.Maximum = maximum;
            this.progressBarControl1.Properties.Minimum = 0;

            System.Threading.Thread t1 = new System.Threading.Thread(UpdateDatabaseStartEvent);
            t1.Start();
            this.ShowDialog();
        }


        public void UpdateDatabaseStartEvent()
        {
            //this.Show();
            this.progressBarControl1.Properties.Step = 1;
            this.progressBarControl1.Properties.PercentView = true;
            this.progressBarControl1.Properties.Maximum = 691;
            this.progressBarControl1.Properties.Minimum = 0;

            SqlCommand sCommand = SqlCreateCommandFront();

            #region - CreateTable
            sCommand.CommandText = "SELECT  [TableName] = so.name FROM sysobjects so WHERE so.xtype = 'U' GROUP BY so.name ";
            DataTable tblTableList = ExecuteSelectCommand(sCommand);
            progressBarControl1.PerformStep();
            progressBarControl1.Update(); Application.DoEvents();
            DataColumn[] KeysTableList = new DataColumn[1];
            KeysTableList[0] = tblTableList.Columns["TableName"];
            tblTableList.PrimaryKey = KeysTableList;


            if (tblTableList.Rows.Contains("Users") == false)
            {
                sCommand.CommandText = " CREATE TABLE [dbo].[Users]( "
                        + "     [id][int] IDENTITY(1, 1) NOT NULL, "
                        + "     [username] [nvarchar] (50) NOT NULL, "
                        + "     [password] [nvarchar] (50) NULL, "
                        + " 	[note] [text] NULL, "
                        + " 	[date] [datetime] NULL, "
                        + " 	[Active] [bit] NULL, "
                        + " 	[HaspPassword] [nvarchar] (50) NULL, "
                        + " 	[Email] [nvarchar] (50) NULL, "
                        + "  CONSTRAINT[PK_users] PRIMARY KEY CLUSTERED "
                        + " ( "
                        + "    [username] ASC "
                        + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                        + " ) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
                //sCommand.CommandText = "INSERT INTO FBAccIntParameter (IntType,DocumentTypeCode,PayType)  VALUES(5,1,'0')";
                //ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

            if (tblTableList.Rows.Contains("Cashiers") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[Cashiers]( "
                        +"     [id][int] NOT NULL, "
                        +"    [name] [nvarchar] (50) NULL, "
                        +" 	[surname] [nvarchar] (50) NULL, "
                        +" 	[address] [nvarchar] (50) NULL, "
                        +" 	[phone] [nvarchar] (50) NULL, "
                        +" 	[tcId] [nvarchar] (50) NULL, "
                        +" 	[authority] [bit] NULL, "
                        +" 	[date] [datetime] NULL, "
                        +" 	[salary] [bigint] NULL, "
                        +" 	[userId] [int] NULL, "
                        +" 	[cashNo] [int] NULL, "
                        +"  CONSTRAINT[PK_cashiers] PRIMARY KEY CLUSTERED "
                        +" ( "
                        +"    [id] ASC "
                        +" )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                        +" ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);
            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

            if (tblTableList.Rows.Contains("Categories") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[Categories]( "
                    + "     [id][int] NOT NULL, "
                    + "    [name] [nvarchar] (50) NULL, "
                    + " 	[type] [nvarchar] (50) NULL, "
                    + "  CONSTRAINT[PK_categories] PRIMARY KEY CLUSTERED "
                    + " ( "
                    + "    [id] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                    + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

            if (tblTableList.Rows.Contains("Company") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[Company]( "
                    + "     [RecId][int] NOT NULL, "
                    
                    + "    [CompanyCode] [nchar] (10) NULL, "
                    + " 	[CompanyName] [nchar] (10) NULL, "
                    + "  CONSTRAINT[PK_Company] PRIMARY KEY CLUSTERED "
                    + " ( "
                    + "    [RecId] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                    + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

            if (tblTableList.Rows.Contains("Customers") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[Customers]( "
                    + "     [id][int] NOT NULL, "
                    + "    [name] [nvarchar] (50) NULL, "
                    + " 	[surname] [nvarchar] (50) NULL, "
                    + " 	[address] [nvarchar] (50) NULL, "
                    + " 	[phone] [nvarchar] (50) NULL, "
                    + " 	[active] [bit] NULL, "
                    + " 	[date] [datetime] NULL, "
                    + "  CONSTRAINT[PK_customers] PRIMARY KEY CLUSTERED "
                    + " ( "
                    + "    [id] ASC "
                    + " )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY] "
                    + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

            if (tblTableList.Rows.Contains("Parameters") == false)
            {
                sCommand.CommandText = "CREATE TABLE [dbo].[Parameters]( "
                    + "     [RecId][int] NULL, "
                    + "     [NumaratorShow] [bit] NULL "
                    + " ) ON[PRIMARY]";
                ExecuteNonQuery(sCommand);

            }
            progressBarControl1.PerformStep();
            progressBarControl1.Update();
            Application.DoEvents();

            //sCommand.CommandText = "Select top 1 * from ProductionMeans  WITH (nolock) ";
            //DataTable tblProductionMeans = GenericDataAccess.ExecuteSelectCommand(sCommand);
            //if (tblProductionMeans.Columns.Contains("MainId") == false)
            //{
            //    sCommand.CommandText = "ALTER TABLE ProductionMeans ADD MainId int NULL";
            //    GenericDataAccess.ExecuteNonQuery(sCommand);
            //    sCommand.CommandText = "Update ProductionMeans set MainId = 0";
            //    GenericDataAccess.ExecuteNonQuery(sCommand);
            //    sCommand.CommandText = "ALTER TABLE dbo.ProductionMeans ADD CONSTRAINT DF_ProductionMeans_MainId DEFAULT 0 FOR MainId";
            //    GenericDataAccess.ExecuteNonQuery(sCommand);
            //}
            //progressBarControl1.PerformStep();
            //progressBarControl1.Update(); Application.DoEvents();



            sCommand.Parameters.Clear();
            sCommand.CommandText = "Update ProgramsControl set MspVersion=@MspVersion ";
            sCommand.Parameters.Add("MspVersion", SqlDbType.VarChar).Value = AppMain.MspVersion.ToString().Trim();
            ExecuteNonQuery(sCommand);
            progressBarControl1.PerformStep();
            progressBarControl1.Update(); Application.DoEvents();

            this.Close();

            #endregion


        }


    }
}