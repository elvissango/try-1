using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             OpenFileDialog ofd = new OpenFileDialog();

    ofd.Title = "Select file";

    ofd.InitialDirectory = @"c:\";

//ofd.FileName = txtFileName.Text;//

    ofd.Filter = "Text and CSV Files(*.txt, *.csv)|*.txt;*.csv|Text Files(*.txt)|*.txt|CSV Files(*.csv)|*.csv|All Files(*.*)|*.*";

    ofd.FilterIndex = 1;

    ofd.RestoreDirectory = true;

    if (ofd.ShowDialog() == DialogResult.OK)

    {

        //txtFileName.Text = fdlg.FileName;//

       // DataSetSchemaImporterExtension();//

        Application.DoEvents();

    }
            public static DataTable GetDataTable(string strFileName)
{
    ADODB.Connection oConn = new ADODB.Connection();
    oConn.Open("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + System.IO.Path.GetDirectoryName(strFileName) + "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\";", "", "", 0);
    string strQuery = "SELECT * FROM [" + System.IO.Path.GetFileName(strFileName) + "]";
    ADODB.Recordset rs = new ADODB.Recordset();
    System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter();
    DataTable dt = new DataTable();
    rs.Open(strQuery, "Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + System.IO.Path.GetDirectoryName(strFileName) + "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\";",
        ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 1);
    adapter.Fill(dt, rs);
    return dt;
}
}

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        }
    }

