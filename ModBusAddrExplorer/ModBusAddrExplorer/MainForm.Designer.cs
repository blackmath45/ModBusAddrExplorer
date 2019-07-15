namespace ModBusAddrExplorer
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GRB_Connexion = new System.Windows.Forms.GroupBox();
            this.L_UpdateCount = new System.Windows.Forms.Label();
            this.txtConnectedStatus = new System.Windows.Forms.TextBox();
            this.BTN_Disconnect = new System.Windows.Forms.Button();
            this.BTN_Connect = new System.Windows.Forms.Button();
            this.TB_IP = new System.Windows.Forms.TextBox();
            this.GRB_Data = new System.Windows.Forms.GroupBox();
            this.BTN_Scan_Stop = new System.Windows.Forms.Button();
            this.L_Scan_Current = new System.Windows.Forms.Label();
            this.NUD_MinAddr = new System.Windows.Forms.NumericUpDown();
            this.NUD_MaxAddr = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Scan_Start = new System.Windows.Forms.Button();
            this.LB_Data = new System.Windows.Forms.ListBox();
            this.TMR_Read = new System.Windows.Forms.Timer(this.components);
            this.GRB_Analyse = new System.Windows.Forms.GroupBox();
            this.BTN_Analyse = new System.Windows.Forms.Button();
            this.LB_Analyse = new System.Windows.Forms.ListBox();
            this.CB_DataType = new System.Windows.Forms.ComboBox();
            this.TB_Analyse_Search = new System.Windows.Forms.TextBox();
            this.BTN_Scan_Reset = new System.Windows.Forms.Button();
            this.GRB_Connexion.SuspendLayout();
            this.GRB_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_MinAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_MaxAddr)).BeginInit();
            this.GRB_Analyse.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRB_Connexion
            // 
            this.GRB_Connexion.Controls.Add(this.L_UpdateCount);
            this.GRB_Connexion.Controls.Add(this.txtConnectedStatus);
            this.GRB_Connexion.Controls.Add(this.BTN_Disconnect);
            this.GRB_Connexion.Controls.Add(this.BTN_Connect);
            this.GRB_Connexion.Controls.Add(this.TB_IP);
            this.GRB_Connexion.Location = new System.Drawing.Point(12, 12);
            this.GRB_Connexion.Name = "GRB_Connexion";
            this.GRB_Connexion.Size = new System.Drawing.Size(804, 58);
            this.GRB_Connexion.TabIndex = 2;
            this.GRB_Connexion.TabStop = false;
            this.GRB_Connexion.Text = "Connexion";
            // 
            // L_UpdateCount
            // 
            this.L_UpdateCount.AutoSize = true;
            this.L_UpdateCount.Location = new System.Drawing.Point(673, 34);
            this.L_UpdateCount.Name = "L_UpdateCount";
            this.L_UpdateCount.Size = new System.Drawing.Size(0, 13);
            this.L_UpdateCount.TabIndex = 56;
            // 
            // txtConnectedStatus
            // 
            this.txtConnectedStatus.BackColor = System.Drawing.Color.Red;
            this.txtConnectedStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtConnectedStatus.Location = new System.Drawing.Point(402, 29);
            this.txtConnectedStatus.Name = "txtConnectedStatus";
            this.txtConnectedStatus.Size = new System.Drawing.Size(265, 23);
            this.txtConnectedStatus.TabIndex = 55;
            this.txtConnectedStatus.Text = "Not connected to Server";
            // 
            // BTN_Disconnect
            // 
            this.BTN_Disconnect.Location = new System.Drawing.Point(306, 29);
            this.BTN_Disconnect.Name = "BTN_Disconnect";
            this.BTN_Disconnect.Size = new System.Drawing.Size(90, 23);
            this.BTN_Disconnect.TabIndex = 2;
            this.BTN_Disconnect.Text = "Déconnecter";
            this.BTN_Disconnect.UseVisualStyleBackColor = true;
            this.BTN_Disconnect.Click += new System.EventHandler(this.BTN_Disconnect_Click);
            // 
            // BTN_Connect
            // 
            this.BTN_Connect.Location = new System.Drawing.Point(210, 29);
            this.BTN_Connect.Name = "BTN_Connect";
            this.BTN_Connect.Size = new System.Drawing.Size(90, 23);
            this.BTN_Connect.TabIndex = 1;
            this.BTN_Connect.Text = "Connecter";
            this.BTN_Connect.UseVisualStyleBackColor = true;
            this.BTN_Connect.Click += new System.EventHandler(this.BTN_Connect_Click);
            // 
            // TB_IP
            // 
            this.TB_IP.Location = new System.Drawing.Point(6, 31);
            this.TB_IP.Name = "TB_IP";
            this.TB_IP.Size = new System.Drawing.Size(198, 20);
            this.TB_IP.TabIndex = 0;
            // 
            // GRB_Data
            // 
            this.GRB_Data.Controls.Add(this.BTN_Scan_Reset);
            this.GRB_Data.Controls.Add(this.BTN_Scan_Stop);
            this.GRB_Data.Controls.Add(this.L_Scan_Current);
            this.GRB_Data.Controls.Add(this.NUD_MinAddr);
            this.GRB_Data.Controls.Add(this.NUD_MaxAddr);
            this.GRB_Data.Controls.Add(this.label1);
            this.GRB_Data.Controls.Add(this.BTN_Scan_Start);
            this.GRB_Data.Controls.Add(this.LB_Data);
            this.GRB_Data.Location = new System.Drawing.Point(12, 76);
            this.GRB_Data.Name = "GRB_Data";
            this.GRB_Data.Size = new System.Drawing.Size(406, 470);
            this.GRB_Data.TabIndex = 3;
            this.GRB_Data.TabStop = false;
            this.GRB_Data.Text = "Data";
            // 
            // BTN_Scan_Stop
            // 
            this.BTN_Scan_Stop.Location = new System.Drawing.Point(87, 29);
            this.BTN_Scan_Stop.Name = "BTN_Scan_Stop";
            this.BTN_Scan_Stop.Size = new System.Drawing.Size(75, 23);
            this.BTN_Scan_Stop.TabIndex = 65;
            this.BTN_Scan_Stop.Text = "Arrêter";
            this.BTN_Scan_Stop.UseVisualStyleBackColor = true;
            this.BTN_Scan_Stop.Click += new System.EventHandler(this.BTN_Scan_Stop_Click);
            // 
            // L_Scan_Current
            // 
            this.L_Scan_Current.AutoSize = true;
            this.L_Scan_Current.Location = new System.Drawing.Point(303, 34);
            this.L_Scan_Current.Name = "L_Scan_Current";
            this.L_Scan_Current.Size = new System.Drawing.Size(68, 13);
            this.L_Scan_Current.TabIndex = 64;
            this.L_Scan_Current.Text = "xxxxx / xxxxx";
            // 
            // NUD_MinAddr
            // 
            this.NUD_MinAddr.Location = new System.Drawing.Point(168, 32);
            this.NUD_MinAddr.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NUD_MinAddr.Name = "NUD_MinAddr";
            this.NUD_MinAddr.Size = new System.Drawing.Size(52, 20);
            this.NUD_MinAddr.TabIndex = 63;
            this.NUD_MinAddr.ValueChanged += new System.EventHandler(this.NUD_MinAddr_ValueChanged);
            // 
            // NUD_MaxAddr
            // 
            this.NUD_MaxAddr.Location = new System.Drawing.Point(239, 32);
            this.NUD_MaxAddr.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NUD_MaxAddr.Name = "NUD_MaxAddr";
            this.NUD_MaxAddr.Size = new System.Drawing.Size(52, 20);
            this.NUD_MaxAddr.TabIndex = 62;
            this.NUD_MaxAddr.Value = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NUD_MaxAddr.ValueChanged += new System.EventHandler(this.NUD_MaxAddr_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "/";
            // 
            // BTN_Scan_Start
            // 
            this.BTN_Scan_Start.Location = new System.Drawing.Point(6, 29);
            this.BTN_Scan_Start.Name = "BTN_Scan_Start";
            this.BTN_Scan_Start.Size = new System.Drawing.Size(75, 23);
            this.BTN_Scan_Start.TabIndex = 59;
            this.BTN_Scan_Start.Text = "Démarrer";
            this.BTN_Scan_Start.UseVisualStyleBackColor = true;
            this.BTN_Scan_Start.Click += new System.EventHandler(this.BTN_Scan_Start_Click);
            // 
            // LB_Data
            // 
            this.LB_Data.FormattingEnabled = true;
            this.LB_Data.Location = new System.Drawing.Point(6, 58);
            this.LB_Data.Name = "LB_Data";
            this.LB_Data.Size = new System.Drawing.Size(394, 407);
            this.LB_Data.TabIndex = 0;
            // 
            // TMR_Read
            // 
            this.TMR_Read.Interval = 25;
            this.TMR_Read.Tick += new System.EventHandler(this.TMR_Read_Tick);
            // 
            // GRB_Analyse
            // 
            this.GRB_Analyse.Controls.Add(this.TB_Analyse_Search);
            this.GRB_Analyse.Controls.Add(this.CB_DataType);
            this.GRB_Analyse.Controls.Add(this.LB_Analyse);
            this.GRB_Analyse.Controls.Add(this.BTN_Analyse);
            this.GRB_Analyse.Location = new System.Drawing.Point(424, 76);
            this.GRB_Analyse.Name = "GRB_Analyse";
            this.GRB_Analyse.Size = new System.Drawing.Size(392, 470);
            this.GRB_Analyse.TabIndex = 4;
            this.GRB_Analyse.TabStop = false;
            this.GRB_Analyse.Text = "Analyse";
            // 
            // BTN_Analyse
            // 
            this.BTN_Analyse.Location = new System.Drawing.Point(311, 29);
            this.BTN_Analyse.Name = "BTN_Analyse";
            this.BTN_Analyse.Size = new System.Drawing.Size(75, 23);
            this.BTN_Analyse.TabIndex = 0;
            this.BTN_Analyse.Text = "Analyse";
            this.BTN_Analyse.UseVisualStyleBackColor = true;
            this.BTN_Analyse.Click += new System.EventHandler(this.BTN_Analyse_Click);
            // 
            // LB_Analyse
            // 
            this.LB_Analyse.FormattingEnabled = true;
            this.LB_Analyse.Location = new System.Drawing.Point(6, 58);
            this.LB_Analyse.Name = "LB_Analyse";
            this.LB_Analyse.Size = new System.Drawing.Size(380, 407);
            this.LB_Analyse.TabIndex = 1;
            // 
            // CB_DataType
            // 
            this.CB_DataType.FormattingEnabled = true;
            this.CB_DataType.Location = new System.Drawing.Point(6, 31);
            this.CB_DataType.Name = "CB_DataType";
            this.CB_DataType.Size = new System.Drawing.Size(121, 21);
            this.CB_DataType.TabIndex = 2;
            // 
            // TB_Analyse_Search
            // 
            this.TB_Analyse_Search.Location = new System.Drawing.Point(133, 31);
            this.TB_Analyse_Search.Name = "TB_Analyse_Search";
            this.TB_Analyse_Search.Size = new System.Drawing.Size(172, 20);
            this.TB_Analyse_Search.TabIndex = 3;
            // 
            // BTN_Scan_Reset
            // 
            this.BTN_Scan_Reset.Location = new System.Drawing.Point(377, 29);
            this.BTN_Scan_Reset.Name = "BTN_Scan_Reset";
            this.BTN_Scan_Reset.Size = new System.Drawing.Size(23, 23);
            this.BTN_Scan_Reset.TabIndex = 66;
            this.BTN_Scan_Reset.Text = "R";
            this.BTN_Scan_Reset.UseVisualStyleBackColor = true;
            this.BTN_Scan_Reset.Click += new System.EventHandler(this.BTN_Scan_Reset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 558);
            this.Controls.Add(this.GRB_Analyse);
            this.Controls.Add(this.GRB_Data);
            this.Controls.Add(this.GRB_Connexion);
            this.Name = "MainForm";
            this.Text = "Main";
            this.GRB_Connexion.ResumeLayout(false);
            this.GRB_Connexion.PerformLayout();
            this.GRB_Data.ResumeLayout(false);
            this.GRB_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_MinAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_MaxAddr)).EndInit();
            this.GRB_Analyse.ResumeLayout(false);
            this.GRB_Analyse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GRB_Connexion;
        private System.Windows.Forms.Label L_UpdateCount;
        private System.Windows.Forms.TextBox txtConnectedStatus;
        private System.Windows.Forms.Button BTN_Disconnect;
        private System.Windows.Forms.Button BTN_Connect;
        private System.Windows.Forms.TextBox TB_IP;
        private System.Windows.Forms.GroupBox GRB_Data;
        private System.Windows.Forms.Label L_Scan_Current;
        private System.Windows.Forms.NumericUpDown NUD_MinAddr;
        private System.Windows.Forms.NumericUpDown NUD_MaxAddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Scan_Start;
        private System.Windows.Forms.ListBox LB_Data;
        private System.Windows.Forms.Button BTN_Scan_Stop;
        private System.Windows.Forms.Timer TMR_Read;
        private System.Windows.Forms.GroupBox GRB_Analyse;
        private System.Windows.Forms.ListBox LB_Analyse;
        private System.Windows.Forms.Button BTN_Analyse;
        private System.Windows.Forms.TextBox TB_Analyse_Search;
        private System.Windows.Forms.ComboBox CB_DataType;
        private System.Windows.Forms.Button BTN_Scan_Reset;
    }
}

