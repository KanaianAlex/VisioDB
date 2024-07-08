using Georg;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisioFileTest;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

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

        private void BtnEnd_Click(object sender, EventArgs e) => Application.Exit();

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

        private void OpenDB()
        {
            DB.clsConnection cn = DB.clsConnection.Manager();
            IGEOrgConnection.ConnectionErrorInfo err = new();
            err.Fehlerklasse = IGEOrgConnection.eConnectionError.NO_ERROR;

            if (TxtUser.Text.Length == 0 || TxtPasswort.Text.Length == 0)
            {
                MessageBox.Show("Bitte Username und Passwort eingeben!", "Eingabe erforderlich!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            err = cn.OpenPostgreSQLDB(DB.clsConnection.SYS, TxtServer.Text, TxtUser.Text, TxtPasswort.Text, TxtDB.Text);

            if (err.Fehlerklasse != IGEOrgConnection.eConnectionError.NO_ERROR)
            {
                cn.RemoveAll();
                DialogResult result = MessageBox.Show(cn.GetErrorDescription(err.Fehlerklasse, err.Ausnahme.Message), "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                {
                    if (result == DialogResult.Cancel)
                    {
                        Close();
                        return;
                    }
                    else if (result == DialogResult.Retry)
                    {
                        return;
                    }
                }
            }

            //Close(); // einkommentiert, da sonst das Main-Formular und damit die App geschlossen wird
            FrmMain frmMain = new();
            frmMain.Show();
        }

        private void BtnWeiter_Click(object sender, EventArgs e)
        {
            OpenDB();
        }
    }
}
