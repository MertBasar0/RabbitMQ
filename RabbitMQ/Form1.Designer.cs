namespace RabbitMQ
{
    partial class Form1
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
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.btn_Connection = new System.Windows.Forms.Button();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_queueDeclare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeclareQueueName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_exchanceDeclare = new System.Windows.Forms.Button();
            this.cbExchangeDeclareType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeclareExchanceName = new System.Windows.Forms.TextBox();
            this.gbQueueExchange = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_bindQueue = new System.Windows.Forms.Button();
            this.txtBindRoutingKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtRoutingKey = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_Publish = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtExchangeName = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslbl_ConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbConnection.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbQueueExchange.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.btn_Connection);
            this.gbConnection.Controls.Add(this.txtConnectionString);
            this.gbConnection.Controls.Add(this.label1);
            this.gbConnection.Location = new System.Drawing.Point(9, 3);
            this.gbConnection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConnection.Size = new System.Drawing.Size(703, 93);
            this.gbConnection.TabIndex = 0;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection";
            // 
            // btn_Connection
            // 
            this.btn_Connection.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Connection.Location = new System.Drawing.Point(559, 27);
            this.btn_Connection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Connection.Name = "btn_Connection";
            this.btn_Connection.Size = new System.Drawing.Size(127, 38);
            this.btn_Connection.TabIndex = 2;
            this.btn_Connection.Text = "Connect";
            this.btn_Connection.UseVisualStyleBackColor = true;
            this.btn_Connection.Click += new System.EventHandler(this.btn_Connection_Click);
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(183, 27);
            this.txtConnectionString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(365, 31);
            this.txtConnectionString.TabIndex = 1;
            this.txtConnectionString.Text = "amqp://guest:guest@localhost:5672";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_queueDeclare);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDeclareQueueName);
            this.groupBox2.Location = new System.Drawing.Point(9, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(334, 173);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Declare Queue";
            // 
            // btn_queueDeclare
            // 
            this.btn_queueDeclare.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_queueDeclare.Location = new System.Drawing.Point(199, 42);
            this.btn_queueDeclare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_queueDeclare.Name = "btn_queueDeclare";
            this.btn_queueDeclare.Size = new System.Drawing.Size(127, 38);
            this.btn_queueDeclare.TabIndex = 2;
            this.btn_queueDeclare.Text = "Declare";
            this.btn_queueDeclare.UseVisualStyleBackColor = true;
            this.btn_queueDeclare.Click += new System.EventHandler(this.btn_queueDeclare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Queue Name";
            // 
            // txtDeclareQueueName
            // 
            this.txtDeclareQueueName.Location = new System.Drawing.Point(127, 90);
            this.txtDeclareQueueName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeclareQueueName.Name = "txtDeclareQueueName";
            this.txtDeclareQueueName.Size = new System.Drawing.Size(197, 31);
            this.txtDeclareQueueName.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_exchanceDeclare);
            this.groupBox3.Controls.Add(this.cbExchangeDeclareType);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtDeclareExchanceName);
            this.groupBox3.Location = new System.Drawing.Point(351, 37);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(334, 173);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Declare Exchance";
            // 
            // btn_exchanceDeclare
            // 
            this.btn_exchanceDeclare.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_exchanceDeclare.Location = new System.Drawing.Point(114, 125);
            this.btn_exchanceDeclare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exchanceDeclare.Name = "btn_exchanceDeclare";
            this.btn_exchanceDeclare.Size = new System.Drawing.Size(220, 38);
            this.btn_exchanceDeclare.TabIndex = 2;
            this.btn_exchanceDeclare.Text = "Declare";
            this.btn_exchanceDeclare.UseVisualStyleBackColor = true;
            this.btn_exchanceDeclare.Click += new System.EventHandler(this.btn_exchanceDeclare_Click);
            // 
            // cbExchangeDeclareType
            // 
            this.cbExchangeDeclareType.FormattingEnabled = true;
            this.cbExchangeDeclareType.Location = new System.Drawing.Point(114, 77);
            this.cbExchangeDeclareType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbExchangeDeclareType.Name = "cbExchangeDeclareType";
            this.cbExchangeDeclareType.Size = new System.Drawing.Size(218, 33);
            this.cbExchangeDeclareType.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(17, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(17, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            // 
            // txtDeclareExchanceName
            // 
            this.txtDeclareExchanceName.Location = new System.Drawing.Point(114, 28);
            this.txtDeclareExchanceName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeclareExchanceName.Name = "txtDeclareExchanceName";
            this.txtDeclareExchanceName.Size = new System.Drawing.Size(218, 31);
            this.txtDeclareExchanceName.TabIndex = 1;
            // 
            // gbQueueExchange
            // 
            this.gbQueueExchange.Controls.Add(this.groupBox5);
            this.gbQueueExchange.Controls.Add(this.groupBox2);
            this.gbQueueExchange.Controls.Add(this.groupBox3);
            this.gbQueueExchange.Enabled = false;
            this.gbQueueExchange.Location = new System.Drawing.Point(0, 107);
            this.gbQueueExchange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbQueueExchange.Name = "gbQueueExchange";
            this.gbQueueExchange.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbQueueExchange.Size = new System.Drawing.Size(711, 368);
            this.gbQueueExchange.TabIndex = 3;
            this.gbQueueExchange.TabStop = false;
            this.gbQueueExchange.Text = "Queue /Exchance Declare && Bind";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_bindQueue);
            this.groupBox5.Controls.Add(this.txtBindRoutingKey);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(183, 220);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(334, 137);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bind Queue && Exchange";
            // 
            // btn_bindQueue
            // 
            this.btn_bindQueue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_bindQueue.Location = new System.Drawing.Point(9, 85);
            this.btn_bindQueue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_bindQueue.Name = "btn_bindQueue";
            this.btn_bindQueue.Size = new System.Drawing.Size(317, 38);
            this.btn_bindQueue.TabIndex = 2;
            this.btn_bindQueue.Text = "Bind Queue";
            this.btn_bindQueue.UseVisualStyleBackColor = true;
            this.btn_bindQueue.Click += new System.EventHandler(this.btn_bindQueue_Click);
            // 
            // txtBindRoutingKey
            // 
            this.txtBindRoutingKey.Location = new System.Drawing.Point(133, 37);
            this.txtBindRoutingKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBindRoutingKey.Name = "txtBindRoutingKey";
            this.txtBindRoutingKey.Size = new System.Drawing.Size(191, 31);
            this.txtBindRoutingKey.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Routing Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(160, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Routing Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(87, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Exchange Name/Type";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(260, 513);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 31);
            this.textBox2.TabIndex = 1;
            // 
            // txtRoutingKey
            // 
            this.txtRoutingKey.Location = new System.Drawing.Point(276, 65);
            this.txtRoutingKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoutingKey.Name = "txtRoutingKey";
            this.txtRoutingKey.Size = new System.Drawing.Size(313, 31);
            this.txtRoutingKey.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(87, 130);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(523, 181);
            this.txtMessage.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(87, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Message";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtLog.Location = new System.Drawing.Point(0, 913);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(705, 231);
            this.txtLog.TabIndex = 6;
            this.txtLog.Text = "";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(87, 352);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(171, 31);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(87, 322);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Repeat";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox1.Location = new System.Drawing.Point(284, 353);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 29);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Use Counter";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_Publish
            // 
            this.btn_Publish.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Publish.Location = new System.Drawing.Point(449, 323);
            this.btn_Publish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Publish.Name = "btn_Publish";
            this.btn_Publish.Size = new System.Drawing.Size(163, 67);
            this.btn_Publish.TabIndex = 9;
            this.btn_Publish.Text = "Publish";
            this.btn_Publish.UseVisualStyleBackColor = true;
            this.btn_Publish.Click += new System.EventHandler(this.btn_Publish_Click_1);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btn_Publish);
            this.pnlMain.Controls.Add(this.checkBox1);
            this.pnlMain.Controls.Add(this.numericUpDown1);
            this.pnlMain.Controls.Add(this.txtMessage);
            this.pnlMain.Controls.Add(this.txtExchangeName);
            this.pnlMain.Controls.Add(this.txtRoutingKey);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Enabled = false;
            this.pnlMain.Location = new System.Drawing.Point(0, 487);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(711, 430);
            this.pnlMain.TabIndex = 10;
            // 
            // txtExchangeName
            // 
            this.txtExchangeName.Location = new System.Drawing.Point(270, 22);
            this.txtExchangeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExchangeName.Name = "txtExchangeName";
            this.txtExchangeName.Size = new System.Drawing.Size(319, 31);
            this.txtExchangeName.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbl_ConnectionStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1141);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 20, 0);
            this.statusStrip1.Size = new System.Drawing.Size(716, 32);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslbl_ConnectionStatus
            // 
            this.tslbl_ConnectionStatus.Name = "tslbl_ConnectionStatus";
            this.tslbl_ConnectionStatus.Size = new System.Drawing.Size(285, 25);
            this.tslbl_ConnectionStatus.Text = "Connection State: Not Connnected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 1173);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.gbQueueExchange);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.gbConnection);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbQueueExchange.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbConnection;
        private Button btn_Connection;
        private TextBox txtConnectionString;
        private Label label1;
        private GroupBox groupBox2;
        private Button btn_queueDeclare;
        private Label label3;
        private TextBox txtDeclareQueueName;
        private GroupBox groupBox3;
        private Button btn_exchanceDeclare;
        private ComboBox cbExchangeDeclareType;
        private Label label5;
        private Label label4;
        private TextBox txtDeclareExchanceName;
        private GroupBox gbQueueExchange;
        private GroupBox groupBox5;
        private Button btn_bindQueue;
        private TextBox txtBindRoutingKey;
        private Label label2;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private TextBox txtRoutingKey;
        private TextBox txtMessage;
        private Label label8;
        private RichTextBox txtLog;
        private NumericUpDown numericUpDown1;
        private Label label9;
        private CheckBox checkBox1;
        private Button btn_Publish;
        private Panel pnlMain;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tslbl_ConnectionStatus;
        private TextBox txtExchangeName;
    }
}