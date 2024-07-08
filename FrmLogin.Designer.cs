using System.Drawing;
using System.Windows.Forms;

namespace VisioDB_Viewer
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblServer = new Label();
            LblDB = new Label();
            LblUser = new Label();
            LblPasswort = new Label();
            CmbBxServer = new ComboBox();
            TxtServer = new TextBox();
            TxtDB = new TextBox();
            TxtUser = new TextBox();
            TxtPasswort = new TextBox();
            BtnEnd = new Button();
            BtnWeiter = new Button();
            SuspendLayout();
            // 
            // LblServer
            // 
            LblServer.AutoSize = true;
            LblServer.Location = new Point(11, 9);
            LblServer.Name = "LblServer";
            LblServer.Size = new Size(50, 20);
            LblServer.TabIndex = 0;
            LblServer.Text = "Server";
            // 
            // LblDB
            // 
            LblDB.AutoSize = true;
            LblDB.Location = new Point(11, 43);
            LblDB.Name = "LblDB";
            LblDB.Size = new Size(81, 20);
            LblDB.TabIndex = 1;
            LblDB.Text = "Datenbank";
            // 
            // LblUser
            // 
            LblUser.AutoSize = true;
            LblUser.Location = new Point(11, 75);
            LblUser.Name = "LblUser";
            LblUser.Size = new Size(67, 20);
            LblUser.TabIndex = 2;
            LblUser.Text = "Benutzer";
            // 
            // LblPasswort
            // 
            LblPasswort.AutoSize = true;
            LblPasswort.Location = new Point(11, 108);
            LblPasswort.Name = "LblPasswort";
            LblPasswort.Size = new Size(66, 20);
            LblPasswort.TabIndex = 3;
            LblPasswort.Text = "Passwort";
            // 
            // CmbBxServer
            // 
            CmbBxServer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CmbBxServer.FormattingEnabled = true;
            CmbBxServer.Items.AddRange(new object[] { "<Server auswählen>", "VisioDB", "FES" });
            CmbBxServer.Location = new Point(101, 5);
            CmbBxServer.Name = "CmbBxServer";
            CmbBxServer.Size = new Size(151, 28);
            CmbBxServer.TabIndex = 4;
            CmbBxServer.SelectedIndexChanged += CmbBxServer_SelectedIndexChanged;
            // 
            // TxtServer
            // 
            TxtServer.Location = new Point(101, 5);
            TxtServer.Name = "TxtServer";
            TxtServer.Size = new Size(125, 27);
            TxtServer.TabIndex = 5;
            TxtServer.Visible = false;
            // 
            // TxtDB
            // 
            TxtDB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtDB.Location = new Point(101, 39);
            TxtDB.Name = "TxtDB";
            TxtDB.Size = new Size(151, 27);
            TxtDB.TabIndex = 6;
            // 
            // TxtUser
            // 
            TxtUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtUser.Location = new Point(101, 72);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(151, 27);
            TxtUser.TabIndex = 7;
            // 
            // TxtPasswort
            // 
            TxtPasswort.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtPasswort.Location = new Point(101, 105);
            TxtPasswort.Name = "TxtPasswort";
            TxtPasswort.PasswordChar = '#';
            TxtPasswort.Size = new Size(151, 27);
            TxtPasswort.TabIndex = 8;
            // 
            // BtnEnd
            // 
            BtnEnd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnEnd.Location = new Point(11, 149);
            BtnEnd.Name = "BtnEnd";
            BtnEnd.Size = new Size(94, 29);
            BtnEnd.TabIndex = 9;
            BtnEnd.Text = "Be&enden";
            BtnEnd.UseVisualStyleBackColor = true;
            BtnEnd.Click += BtnEnd_Click;
            // 
            // BtnWeiter
            // 
            BtnWeiter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnWeiter.Enabled = false;
            BtnWeiter.Location = new Point(158, 149);
            BtnWeiter.Name = "BtnWeiter";
            BtnWeiter.Size = new Size(94, 29);
            BtnWeiter.TabIndex = 10;
            BtnWeiter.Text = "Weiter";
            BtnWeiter.UseVisualStyleBackColor = true;
            BtnWeiter.Click += BtnWeiter_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 201);
            Controls.Add(BtnWeiter);
            Controls.Add(BtnEnd);
            Controls.Add(TxtPasswort);
            Controls.Add(TxtUser);
            Controls.Add(TxtDB);
            Controls.Add(TxtServer);
            Controls.Add(CmbBxServer);
            Controls.Add(LblPasswort);
            Controls.Add(LblUser);
            Controls.Add(LblDB);
            Controls.Add(LblServer);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblServer;
        private Label LblDB;
        private Label LblUser;
        private Label LblPasswort;
        private ComboBox CmbBxServer;
        private TextBox TxtServer;
        private TextBox TxtDB;
        private TextBox TxtUser;
        private TextBox TxtPasswort;
        private Button BtnEnd;
        private Button BtnWeiter;
    }
}