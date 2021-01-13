
namespace Client
{
    partial class connectForm
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
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.labIP = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.labPort = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.tb_userName);
            this.gbInfo.Controls.Add(this.name);
            this.gbInfo.Controls.Add(this.tbIP);
            this.gbInfo.Controls.Add(this.labIP);
            this.gbInfo.Controls.Add(this.tbPort);
            this.gbInfo.Controls.Add(this.labPort);
            this.gbInfo.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.gbInfo.Location = new System.Drawing.Point(15, 16);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.gbInfo.Size = new System.Drawing.Size(375, 128);
            this.gbInfo.TabIndex = 10;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "連線資訊";
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(142, 81);
            this.tb_userName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(169, 35);
            this.tb_userName.TabIndex = 10;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(44, 82);
            this.name.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(101, 27);
            this.name.TabIndex = 9;
            this.name.Text = "用戶名稱:";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(49, 32);
            this.tbIP.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(169, 35);
            this.tbIP.TabIndex = 8;
            this.tbIP.Text = "127.0.0.1";
            // 
            // labIP
            // 
            this.labIP.AutoSize = true;
            this.labIP.Location = new System.Drawing.Point(18, 35);
            this.labIP.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.labIP.Name = "labIP";
            this.labIP.Size = new System.Drawing.Size(31, 27);
            this.labIP.TabIndex = 3;
            this.labIP.Text = "IP";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(291, 32);
            this.tbPort.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(72, 35);
            this.tbPort.TabIndex = 5;
            this.tbPort.Text = "8885";
            // 
            // labPort
            // 
            this.labPort.AutoSize = true;
            this.labPort.Location = new System.Drawing.Point(224, 35);
            this.labPort.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.labPort.Name = "labPort";
            this.labPort.Size = new System.Drawing.Size(67, 27);
            this.labPort.TabIndex = 6;
            this.labPort.Text = "PORT";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(102, 152);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(204, 45);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "啟動";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // connectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 213);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnConnect);
            this.Name = "connectForm";
            this.Text = "連接伺服器";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label labIP;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label labPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.Label name;
    }
}