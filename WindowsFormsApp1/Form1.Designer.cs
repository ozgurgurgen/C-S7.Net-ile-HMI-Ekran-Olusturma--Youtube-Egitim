namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ipAddress = new System.Windows.Forms.TextBox();
            this.plc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.plcTipi = new System.Windows.Forms.ComboBox();
            this.SlotCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RackCombo = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.durumLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DBX00 = new System.Windows.Forms.TextBox();
            this.DBX01 = new System.Windows.Forms.TextBox();
            this.DBW2 = new System.Windows.Forms.TextBox();
            this.DBW4 = new System.Windows.Forms.TextBox();
            this.VeriCek = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(91, 34);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(150, 20);
            this.ipAddress.TabIndex = 0;
            this.ipAddress.TextChanged += new System.EventHandler(this.ipAddress_TextChanged);
            // 
            // plc
            // 
            this.plc.AutoSize = true;
            this.plc.Location = new System.Drawing.Point(36, 37);
            this.plc.Name = "plc";
            this.plc.Size = new System.Drawing.Size(40, 13);
            this.plc.TabIndex = 1;
            this.plc.Text = "PLC IP";
            this.plc.Click += new System.EventHandler(this.plc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PLC Tipi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(91, 98);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(390, 23);
            this.connect.TabIndex = 4;
            this.connect.Text = "PLC\'ye Bağlan";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(91, 127);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(390, 23);
            this.disconnect.TabIndex = 5;
            this.disconnect.Text = "PLC Bağlantısını Kopar";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // plcTipi
            // 
            this.plcTipi.FormattingEnabled = true;
            this.plcTipi.Items.AddRange(new object[] {
            "S71500",
            "S71200",
            "S7300",
            "S7200"});
            this.plcTipi.Location = new System.Drawing.Point(91, 63);
            this.plcTipi.Name = "plcTipi";
            this.plcTipi.Size = new System.Drawing.Size(150, 21);
            this.plcTipi.TabIndex = 6;
            this.plcTipi.SelectedIndexChanged += new System.EventHandler(this.plcTipi_SelectedIndexChanged);
            // 
            // SlotCombo
            // 
            this.SlotCombo.FormattingEnabled = true;
            this.SlotCombo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.SlotCombo.Location = new System.Drawing.Point(331, 63);
            this.SlotCombo.Name = "SlotCombo";
            this.SlotCombo.Size = new System.Drawing.Size(150, 21);
            this.SlotCombo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rack";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Slot";
            // 
            // RackCombo
            // 
            this.RackCombo.FormattingEnabled = true;
            this.RackCombo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.RackCombo.Location = new System.Drawing.Point(331, 34);
            this.RackCombo.Name = "RackCombo";
            this.RackCombo.Size = new System.Drawing.Size(150, 21);
            this.RackCombo.TabIndex = 11;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.durumLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(528, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // durumLabel
            // 
            this.durumLabel.Name = "durumLabel";
            this.durumLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "DB4.DBX0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "DB4.DBX0.1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "DB4.DBW2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "DB4.DBW4";
            // 
            // DBX00
            // 
            this.DBX00.Location = new System.Drawing.Point(178, 228);
            this.DBX00.Name = "DBX00";
            this.DBX00.Size = new System.Drawing.Size(100, 20);
            this.DBX00.TabIndex = 18;
            // 
            // DBX01
            // 
            this.DBX01.Location = new System.Drawing.Point(178, 269);
            this.DBX01.Name = "DBX01";
            this.DBX01.Size = new System.Drawing.Size(100, 20);
            this.DBX01.TabIndex = 19;
            // 
            // DBW2
            // 
            this.DBW2.Location = new System.Drawing.Point(367, 224);
            this.DBW2.Name = "DBW2";
            this.DBW2.Size = new System.Drawing.Size(100, 20);
            this.DBW2.TabIndex = 20;
            // 
            // DBW4
            // 
            this.DBW4.Location = new System.Drawing.Point(367, 269);
            this.DBW4.Name = "DBW4";
            this.DBW4.Size = new System.Drawing.Size(100, 20);
            this.DBW4.TabIndex = 21;
            // 
            // VeriCek
            // 
            this.VeriCek.Location = new System.Drawing.Point(107, 309);
            this.VeriCek.Name = "VeriCek";
            this.VeriCek.Size = new System.Drawing.Size(360, 23);
            this.VeriCek.TabIndex = 22;
            this.VeriCek.Text = "Verileri Çek";
            this.VeriCek.UseVisualStyleBackColor = true;
            this.VeriCek.Click += new System.EventHandler(this.VeriCek_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.VeriCek);
            this.Controls.Add(this.DBW4);
            this.Controls.Add(this.DBW2);
            this.Controls.Add(this.DBX01);
            this.Controls.Add(this.DBX00);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.RackCombo);
            this.Controls.Add(this.SlotCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plcTipi);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plc);
            this.Controls.Add(this.ipAddress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipAddress;
        private System.Windows.Forms.Label plc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.ComboBox plcTipi;
        private System.Windows.Forms.ComboBox SlotCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RackCombo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel durumLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DBX00;
        private System.Windows.Forms.TextBox DBX01;
        private System.Windows.Forms.TextBox DBW2;
        private System.Windows.Forms.TextBox DBW4;
        private System.Windows.Forms.Button VeriCek;
        private System.Windows.Forms.Timer timer1;
    }
}

