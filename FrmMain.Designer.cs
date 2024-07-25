namespace VisioFileTest
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            BTNcreateVisioFile = new Button();
            BTNcreateTaskShape = new Button();
            BtnCreateConnector = new Button();
            BTN_imageCreator = new Button();
            BTN_BlattErstellen = new Button();
            BtnAnbinder = new Button();
            BtnMailShapeCreator = new Button();
            splitContainer1 = new SplitContainer();
            BtnShapeScanner = new Button();
            BtnOpenVisioFiel = new Button();
            BtnSoftware = new Button();
            DGvTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGvTable).BeginInit();
            SuspendLayout();
            // 
            // BTNcreateVisioFile
            // 
            BTNcreateVisioFile.AutoSize = true;
            BTNcreateVisioFile.Location = new Point(4, 478);
            BTNcreateVisioFile.Margin = new Padding(3, 2, 3, 2);
            BTNcreateVisioFile.Name = "BTNcreateVisioFile";
            BTNcreateVisioFile.Size = new Size(88, 25);
            BTNcreateVisioFile.TabIndex = 0;
            BTNcreateVisioFile.Text = "create File";
            BTNcreateVisioFile.UseVisualStyleBackColor = true;
            BTNcreateVisioFile.Click += BTNcreateVisioFile_Click;
            // 
            // BTNcreateTaskShape
            // 
            BTNcreateTaskShape.AutoSize = true;
            BTNcreateTaskShape.Location = new Point(-2, 47);
            BTNcreateTaskShape.Margin = new Padding(3, 2, 3, 2);
            BTNcreateTaskShape.Name = "BTNcreateTaskShape";
            BTNcreateTaskShape.Size = new Size(132, 25);
            BTNcreateTaskShape.TabIndex = 1;
            BTNcreateTaskShape.Text = "Prozess 1 visualisieren";
            BTNcreateTaskShape.UseVisualStyleBackColor = true;
            BTNcreateTaskShape.Click += BTNcreateTaskShape_Click;
            // 
            // BtnCreateConnector
            // 
            BtnCreateConnector.AutoSize = true;
            BtnCreateConnector.Location = new Point(4, 117);
            BtnCreateConnector.Margin = new Padding(3, 2, 3, 2);
            BtnCreateConnector.Name = "BtnCreateConnector";
            BtnCreateConnector.Size = new Size(119, 25);
            BtnCreateConnector.TabIndex = 2;
            BtnCreateConnector.Text = "create End-Shape";
            BtnCreateConnector.UseVisualStyleBackColor = true;
            BtnCreateConnector.Click += BtnCreateConnector_Click;
            // 
            // BTN_imageCreator
            // 
            BTN_imageCreator.Location = new Point(4, 173);
            BTN_imageCreator.Name = "BTN_imageCreator";
            BTN_imageCreator.Size = new Size(88, 22);
            BTN_imageCreator.TabIndex = 3;
            BTN_imageCreator.Text = "Bild erstellen";
            BTN_imageCreator.UseVisualStyleBackColor = true;
            BTN_imageCreator.Click += BTN_imageCreator_Click;
            // 
            // BTN_BlattErstellen
            // 
            BTN_BlattErstellen.Location = new Point(69, 345);
            BTN_BlattErstellen.Name = "BTN_BlattErstellen";
            BTN_BlattErstellen.Size = new Size(88, 22);
            BTN_BlattErstellen.TabIndex = 4;
            BTN_BlattErstellen.Text = "Visio-Blatt erstellen";
            BTN_BlattErstellen.UseVisualStyleBackColor = true;
            BTN_BlattErstellen.Click += BTN_BlattErstellen_Click;
            // 
            // BtnAnbinder
            // 
            BtnAnbinder.Location = new Point(4, 202);
            BtnAnbinder.Name = "BtnAnbinder";
            BtnAnbinder.Size = new Size(88, 22);
            BtnAnbinder.TabIndex = 5;
            BtnAnbinder.Text = "Shapes verbinden";
            BtnAnbinder.UseVisualStyleBackColor = true;
            BtnAnbinder.Click += BtnAnbinder_Click;
            // 
            // BtnMailShapeCreator
            // 
            BtnMailShapeCreator.AutoSize = true;
            BtnMailShapeCreator.Location = new Point(4, 145);
            BtnMailShapeCreator.Name = "BtnMailShapeCreator";
            BtnMailShapeCreator.Size = new Size(122, 25);
            BtnMailShapeCreator.TabIndex = 6;
            BtnMailShapeCreator.Text = "create Mail-Shape";
            BtnMailShapeCreator.UseVisualStyleBackColor = true;
            BtnMailShapeCreator.Click += BtnMailShapeCreator_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(BtnShapeScanner);
            splitContainer1.Panel1.Controls.Add(BtnOpenVisioFiel);
            splitContainer1.Panel1.Controls.Add(BtnSoftware);
            splitContainer1.Panel1.Controls.Add(BTNcreateVisioFile);
            splitContainer1.Panel1.Controls.Add(BTN_BlattErstellen);
            splitContainer1.Panel1.Controls.Add(BtnAnbinder);
            splitContainer1.Panel1.Controls.Add(BtnMailShapeCreator);
            splitContainer1.Panel1.Controls.Add(BTNcreateTaskShape);
            splitContainer1.Panel1.Controls.Add(BTN_imageCreator);
            splitContainer1.Panel1.Controls.Add(BtnCreateConnector);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(DGvTable);
            splitContainer1.Size = new Size(931, 505);
            splitContainer1.SplitterDistance = 181;
            splitContainer1.TabIndex = 7;
            // 
            // BtnShapeScanner
            // 
            BtnShapeScanner.Location = new Point(12, 302);
            BtnShapeScanner.Margin = new Padding(3, 2, 3, 2);
            BtnShapeScanner.Name = "BtnShapeScanner";
            BtnShapeScanner.Size = new Size(113, 22);
            BtnShapeScanner.TabIndex = 9;
            BtnShapeScanner.Text = "Shapes scannen";
            BtnShapeScanner.UseVisualStyleBackColor = true;
            BtnShapeScanner.Click += BtnShapeScanner_Click;
            // 
            // BtnOpenVisioFiel
            // 
            BtnOpenVisioFiel.Location = new Point(0, 11);
            BtnOpenVisioFiel.Margin = new Padding(3, 2, 3, 2);
            BtnOpenVisioFiel.Name = "BtnOpenVisioFiel";
            BtnOpenVisioFiel.Size = new Size(119, 22);
            BtnOpenVisioFiel.TabIndex = 8;
            BtnOpenVisioFiel.Text = "Open Visio-File";
            BtnOpenVisioFiel.UseVisualStyleBackColor = true;
            BtnOpenVisioFiel.Click += BtnOpenVisioFiel_Click;
            // 
            // BtnSoftware
            // 
            BtnSoftware.Location = new Point(12, 248);
            BtnSoftware.Margin = new Padding(3, 2, 3, 2);
            BtnSoftware.Name = "BtnSoftware";
            BtnSoftware.Size = new Size(88, 22);
            BtnSoftware.TabIndex = 7;
            BtnSoftware.Text = "Open Table";
            BtnSoftware.UseVisualStyleBackColor = true;
            BtnSoftware.Click += BtnSoftware_Click;
            // 
            // DGvTable
            // 
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            DGvTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGvTable.Dock = DockStyle.Fill;
            DGvTable.Location = new Point(0, 0);
            DGvTable.Margin = new Padding(3, 2, 3, 2);
            DGvTable.Name = "DGvTable";
            DGvTable.RowHeadersWidth = 51;
            DGvTable.Size = new Size(746, 505);
            DGvTable.TabIndex = 0;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 505);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMain";
            Text = "Form1";
            FormClosing += FrmMain_FormClosing;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGvTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BTNcreateVisioFile;
        private Button BTNcreateTaskShape;
        private Button BtnCreateConnector;
        private Button BTN_imageCreator;
        private Button BTN_BlattErstellen;
        private Button BtnAnbinder;
        private Button BtnMailShapeCreator;
        private SplitContainer splitContainer1;
        private Button BtnSoftware;
        private DataGridView DGvTable;
        private Button BtnOpenVisioFiel;
        private Button BtnShapeScanner;
    }
}
