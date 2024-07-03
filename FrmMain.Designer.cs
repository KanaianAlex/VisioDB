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
            BTNcreateVisioFile = new Button();
            BTNcreateTaskShape = new Button();
            BtnCreateConnector = new Button();
            BTN_imageCreator = new Button();
            BTN_BlattErstellen = new Button();
            BtnAnbinder = new Button();
            BtnMailShapeCreator = new Button();
            SuspendLayout();
            // 
            // BTNcreateVisioFile
            // 
            BTNcreateVisioFile.AutoSize = true;
            BTNcreateVisioFile.Location = new Point(125, 48);
            BTNcreateVisioFile.Margin = new Padding(3, 2, 3, 2);
            BTNcreateVisioFile.Name = "BTNcreateVisioFile";
            BTNcreateVisioFile.Size = new Size(82, 25);
            BTNcreateVisioFile.TabIndex = 0;
            BTNcreateVisioFile.Text = "create File";
            BTNcreateVisioFile.UseVisualStyleBackColor = true;
            BTNcreateVisioFile.Click += BTNcreateVisioFile_Click;
            // 
            // BTNcreateTaskShape
            // 
            BTNcreateTaskShape.AutoSize = true;
            BTNcreateTaskShape.Location = new Point(318, 140);
            BTNcreateTaskShape.Margin = new Padding(3, 2, 3, 2);
            BTNcreateTaskShape.Name = "BTNcreateTaskShape";
            BTNcreateTaskShape.Size = new Size(121, 25);
            BTNcreateTaskShape.TabIndex = 1;
            BTNcreateTaskShape.Text = "create Task-Shape";
            BTNcreateTaskShape.UseVisualStyleBackColor = true;
            BTNcreateTaskShape.Click += BTNcreateTaskShape_Click;
            // 
            // BtnCreateConnector
            // 
            BtnCreateConnector.AutoSize = true;
            BtnCreateConnector.Location = new Point(602, 140);
            BtnCreateConnector.Margin = new Padding(3, 2, 3, 2);
            BtnCreateConnector.Name = "BtnCreateConnector";
            BtnCreateConnector.Size = new Size(157, 25);
            BtnCreateConnector.TabIndex = 2;
            BtnCreateConnector.Text = "create End-Shape";
            BtnCreateConnector.UseVisualStyleBackColor = true;
            BtnCreateConnector.Click += BtnCreateConnector_Click;
            // 
            // BTN_imageCreator
            // 
            BTN_imageCreator.Location = new Point(318, 207);
            BTN_imageCreator.Name = "BTN_imageCreator";
            BTN_imageCreator.Size = new Size(113, 56);
            BTN_imageCreator.TabIndex = 3;
            BTN_imageCreator.Text = "Bild erstellen";
            BTN_imageCreator.UseVisualStyleBackColor = true;
            BTN_imageCreator.Click += BTN_imageCreator_Click;
            // 
            // BTN_BlattErstellen
            // 
            BTN_BlattErstellen.Location = new Point(318, 312);
            BTN_BlattErstellen.Name = "BTN_BlattErstellen";
            BTN_BlattErstellen.Size = new Size(302, 75);
            BTN_BlattErstellen.TabIndex = 4;
            BTN_BlattErstellen.Text = "Visio-Blatt erstellen";
            BTN_BlattErstellen.UseVisualStyleBackColor = true;
            BTN_BlattErstellen.Click += BTN_BlattErstellen_Click;
            // 
            // BtnAnbinder
            // 
            BtnAnbinder.Location = new Point(786, 89);
            BtnAnbinder.Name = "BtnAnbinder";
            BtnAnbinder.Size = new Size(121, 126);
            BtnAnbinder.TabIndex = 5;
            BtnAnbinder.Text = "Shapes verbinden";
            BtnAnbinder.UseVisualStyleBackColor = true;
            BtnAnbinder.Click += BtnAnbinder_Click;
            // 
            // BtnMailShapeCreator
            // 
            BtnMailShapeCreator.AutoSize = true;
            BtnMailShapeCreator.Location = new Point(460, 140);
            BtnMailShapeCreator.Name = "BtnMailShapeCreator";
            BtnMailShapeCreator.Size = new Size(112, 25);
            BtnMailShapeCreator.TabIndex = 6;
            BtnMailShapeCreator.Text = "create Mail-Shape";
            BtnMailShapeCreator.UseVisualStyleBackColor = true;
            BtnMailShapeCreator.Click += BtnMailShapeCreator_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 505);
            Controls.Add(BtnMailShapeCreator);
            Controls.Add(BtnAnbinder);
            Controls.Add(BTN_BlattErstellen);
            Controls.Add(BTN_imageCreator);
            Controls.Add(BtnCreateConnector);
            Controls.Add(BTNcreateTaskShape);
            Controls.Add(BTNcreateVisioFile);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNcreateVisioFile;
        private Button BTNcreateTaskShape;
        private Button BtnCreateConnector;
        private Button BTN_imageCreator;
        private Button BTN_BlattErstellen;
        private Button BtnAnbinder;
        private Button BtnMailShapeCreator;
    }
}
