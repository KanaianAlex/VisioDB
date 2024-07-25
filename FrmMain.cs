using Microsoft.Office.Interop.Visio;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Georg;
using System.Data;
using VisioDB_Viewer;

namespace VisioFileTest
{
    public partial class FrmMain : Form
    {
        static    Master? vConnectorMaster;
        static Shape? vConnector;
        static Cell? vBeginCell;
        static Cell? vEndCell;
        static Shape? vFromShape;
        static Shape? vToShape;

        /* gets the values of the coordinates */
        readonly double pageWidth;
        readonly double pageHeight;
        // Create a new instance of the Visio application
        static Microsoft.Office.Interop.Visio.Application? visioApp;

        static Document? visioDoc;

        static Document? vStencil; // Visio-FICHTNER-Vorlage
        public FrmMain()
        {
            InitializeComponent();

            vConnectorMaster = null;
            vConnector = null;

            //Page visioPage = visioDoc.Pages[1]; // Assuming you want to work with the first page of the Visio document

            //pageWidth = visioPage.PageSheet.get_Cells("PageWidth").ResultIU;
            //pageHeight = visioPage.PageSheet.get_Cells("PageHeight").ResultIU;
        }

        #region "events"

        private void BtnSoftware_Click(object sender, EventArgs e)
        {
            IGEOrgCommand cmd = DB.clsConnection.Manager().GetCommand(DB.clsConnection.SYS);
            DataTable dt = cmd.GetTable(DB.clsConnection.SYS, "Software");
            if (dt != null)
            {
                DGvTable.DataSource = dt;
            }
        }

        private void BtnOpenVisioFiel_Click(object sender, EventArgs e)
        {
            string levonFileName = Tools.modFiles.GetFilenameFromDialog("Selektiere Visio-Datei", @"D:\OneDrive - Fichtner GmbH & Co. KG\Dokumente\Arbeiten\FICHTNER\Visio\", "Visio-Dateien (*.vsdx)|*.vsdx");
            visioApp = new();
            visioDoc = visioApp.Documents.Open(levonFileName);
            vStencil = visioApp.Documents.OpenEx("C:\\Vorlagen\\Visio-Vorlagen\\Fichtner Shape.vssx", 4); // Visio-FICHTNER-Vorlage
            if (visioDoc != null)
            {
                visioApp.Visible = true;
            }

            // Generate a new page name
            string newPageName = "Neues Blatt";
            int counter = 1;

            while (PageExists(newPageName))
            {
                newPageName = $"Neues Blatt {counter}";
                counter++;
            }

            // Create a new page in the active document
            Page newPage = visioDoc.Pages.Add();

            // Set the name of the new page
            newPage.Name = newPageName;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void BTNcreateVisioFile_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Visio application
            var visioApp = new Microsoft.Office.Interop.Visio.Application();

            // Release the COM objects to avoid memory leaks
            //Marshal.ReleaseComObject(visioDoc);
            Marshal.ReleaseComObject(visioApp);

            // Show a message box indicating the file creation success
            MessageBox.Show("Visio file created successfully!");
        }

        private void BTNcreateTaskShape_Click(object sender, EventArgs e)
        {
            IGEOrgCommand cmd = DB.clsConnection.Manager().GetCommand(DB.clsConnection.SYS);
            DataTable dtConn = cmd.GetTableFromSelect("SYS", "select * from connectoren where prozessid = 1");

            //Startconnector ermitteln
            foreach (DataRow dr in dtConn.Rows)
            {
                if (dr["isstart"] is true)
                {
                    //StartSoftware
                    string? startSW = dr["v_software"].ToString();
                    DataTable dtSW = cmd.GetTableFromSelect("SYS", "select * from software where id = " + startSW);
                    // Get the active page
                    Page page = visioApp!.ActivePage;
                    Master masters = vStencil.Masters["Aufgabe"]; // string-array als einfache Auswahl
                    vToShape = page.Drop(masters, Convert.ToDouble(dtSW.Rows[0]["posx"]), Convert.ToDouble(dtSW.Rows[0]["posy"]));
                    vToShape.Text = Convert.ToString(dtSW.Rows[0]["beschreibung"]);
                }
            }





            DataTable dt = cmd.GetTable(DB.clsConnection.SYS, "Software");
            if (dt != null)
            {
                DGvTable.DataSource = dt;
            }




            // Get the active page
            //Page page = visioApp.ActivePage;

            //Master masters = vStencil.Masters["Aufgabe"]; // string-array als einfache Auswahl
            //vToShape = page.Drop(masters, pageWidth - 3, pageHeight - 2);
            //vToShape.Text = "variable Koordinaten";

            if (vFromShape != null)
            {
                CreateConnector(vFromShape, vToShape);
            }
            vFromShape = vToShape;

            // Save the document
            visioDoc.Save();
        }

        private void BtnCreateConnector_Click(object sender, EventArgs e)
        {
            // Get the active page
            Page page = visioApp.ActivePage; // pro Page mit eigenem Zeichnblatt-Namen anwenden

            Master masters = vStencil.Masters["Endereignis"];
            Shape testShape = page.Drop(masters, 4, 4);
            testShape.Text = "Mista Krebs";

            testShape.CellsU["Width"].ResultIU = 2;
            testShape.CellsU["Height"].ResultIU = 3;

            visioDoc.Save();
        }

        private void BTN_imageCreator_Click(object sender, EventArgs e)
        {
            //// Get the active page
            //Page page = visioApp.ActivePage;

            //// Specify the path to the image file
            //string imagePath = "D:\\OneDrive - Fichtner GmbH & Co. KG\\Dokumente\\it.schule\\B7B8\\B7B8_Englisch\\KA2\\OtherFunnyPics\\physicsTeacher.png";

            //// Load the image into Visio
            //Shape imageShape = page.Import(imagePath);

            //// Set the position and size of the image shape
            //imageShape.CellsU["PinX"].ResultIU = 5;
            //imageShape.CellsU["PinY"].ResultIU = 5;
            //imageShape.CellsU["Width"].ResultIU = 2;
            //imageShape.CellsU["Height"].ResultIU = 3;

            //imageShape.Text = "Position: 5, 5";

            //visioDoc.Save();
        }

        private void BTN_BlattErstellen_Click(object sender, EventArgs e)
        {
            // Generate a new page name
            string newPageName = "Neues Blatt";
            int counter = 1;

            while (PageExists(newPageName))
            {
                newPageName = $"Neues Blatt {counter}";
                counter++;
            }

            // Create a new page in the active document
            Page newPage = visioDoc.Pages.Add();

            // Set the name of the new page
            newPage.Name = newPageName;
        }
        private void BtnAnbinder_Click(object sender, EventArgs e)
        {
            //CreateConnector(vFromShape, vToShape); // calls the defined Method beneath
        }

        private void BtnMailShapeCreator_Click(object sender, EventArgs e)
        {
            //// Get the active page
            //Page page = visioApp.ActivePage;

            //Master masters = vStencil.Masters["Nachricht"]; // string-array als einfache Auswahl
            //vToShape = page.Drop(masters, 7, 4);
            //vToShape.Text = "Mail an Kevin";

            //if (vFromShape != null)
            //{
            //    CreateConnector(vFromShape, vToShape);
            //}
            //vFromShape = vToShape;

            //// Save the document
            //visioDoc.Save();
        }
        private void BtnShapeScanner_Click(object sender, EventArgs e)
        {
            foreach (Page page in visioDoc.Pages)
            {
                if (page.Name == "TestSR")
                {
                    foreach (Shape shape in page.Shapes)
                    {
                        double width = shape.CellsU["Width"].ResultIU;
                        double height = shape.CellsU["Height"].ResultIU;
                        double width1 = shape.CellsU["Width"].Units;
                        double height1 = shape.CellsU["Height"].Units;
                        string line = shape.CellsU["LinePattern"].ResultStr[32];
                        if (shape.ID == 1023)
                        {

                            break;
                        }
                    }
                }
            }
            
            Page visioPage = visioDoc.Pages[1];
            foreach (Shape shape in visioPage.Shapes)
            {
                if (shape.ID == 248)
                {
                    
                    break;
                }
            }
        }

        #endregion

        #region "methods"
        private static bool PageExists(string pageName)
        {
            foreach (Page page in visioDoc.Pages)
            {
                if (page.Name == pageName)
                {
                    return true;
                }
            }
            return false;
        }

        static void CreateConnector(Shape taskShape, Shape mailShape)
        {
            // Get the active page
            Page page = visioApp.ActivePage;

            //vConnectorMaster ??= vStencil.Masters["Sequenzfluss.46"]; // Name des Schablonenpfeils
            vConnector = page.Drop(vConnectorMaster, 0, 0);
            vBeginCell = vConnector.CellsU["BeginX"];
            vBeginCell.GlueTo(taskShape.CellsU["AlignRight"]);
            vEndCell = vConnector.CellsU["EndX"];
            vEndCell.GlueTo(mailShape.CellsU["AlignLeft"]);
            vConnector.SendToBack();
        }
        #endregion


    }
}
