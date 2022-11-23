using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace MainForm { 
    public class DBClass
    {
        private int selectedRowIndex;
        private int selectedKeyValue;
        OracleDataAdapter dBAdapter;
        DataSet dS;
        OracleCommandBuilder myCommandBuilder;
        DataTable phoneTable;
        public int SelectedRowIndex { get { return selectedRowIndex; } set { selectedRowIndex = value; } }
        public int SelectedKeyValue { get { return selectedKeyValue; } set { selectedKeyValue = value; } }
        public OracleDataAdapter DBAdapter { get { return dBAdapter; } set { dBAdapter = value; } }
        public DataSet DS { get { return dS; } set { dS = value; } }
        public OracleCommandBuilder MyCommandBuilder
        {
            get { return myCommandBuilder; }
            set { myCommandBuilder = value; }
        }
        public DataTable PhoneTable { get { return phoneTable; } set { phoneTable = value; } }
        public void DB_Open()
        {
            try
            {
                string connectionString = "User Id=; Password=; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                string commandString = "select * from Phone";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public void DB_ObjCreate()
        {
            PhoneTable = new DataTable();
        }
    }
}