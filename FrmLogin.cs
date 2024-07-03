using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisioDB_Viewer
{
    public partial class FrmLogin : Form
    {
        private string swServer = "10.18.32.15";
        private string swDB = "Software";
        private string swUser = "CADLayer";
        private string swPassword = "Fwt$CAD!2o24";
        private string svFES = "engsuite-sql-test.postgres.database.azure.com";
        private string dbFES = "engsuitetest";
        private string userFES = "engsuite_rohrs@engsuite-sql-test";
        private string pwFES = "Fas3_Zum5_Fyb3";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {

        }

        private void CmbBxServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbBxServer.SelectedItem == "VisioDB")
            {
                TxtServer.Text = swServer;
                TxtDB.Text = swDB;
                TxtUser.Text = swUser;
                TxtPasswort.Text = swPassword;
                BtnWeiter.Enabled = true;
            }

            else if (CmbBxServer.SelectedItem == "FES")
            {
                TxtServer.Text = svFES;
                TxtDB.Text = dbFES;
                TxtUser.Text = userFES;
                TxtPasswort.Text = pwFES;
                BtnWeiter.Enabled = true;
            }

            else
            {
                BtnWeiter.Enabled = false;
            }
        }
    }
}
