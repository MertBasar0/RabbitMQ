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
            this.txtQueueName = new System.Windows.Forms.TextBox();
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
            this.cbExchangeType = new System.Windows.Forms.ComboBox();
            this.txtRoutingKey = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            this.gbConnection.Location = new System.Drawing.Point(6, 2);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(492, 56);
            this.gbConnection.TabIndex = 0;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection";
            // 
            // btn_Connection
            // 
            this.btn_Connection.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Connection.Location = new System.Drawing.Point(391, 16);
            this.btn_Connection.Name = "btn_Connection";
            this.btn_Connection.Size = new System.Drawing.Size(89, 23);
            this.btn_Connection.TabIndex = 2;
            this.btn_Connection.Text = "Connect";
            this.btn_Connection.UseVisualStyleBackColor = true;
            this.btn_Connection.Click += new System.EventHandler(this.btn_Connection_Click);
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(128, 16);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(257, 23);
            this.txtConnectionString.TabIndex = 1;
            this.txtConnectionString.Text = "amqp://guest:guest@localhost:5672";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_queueDeclare);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtQueueName);
            this.groupBox2.Location = new System.Drawing.Point(6, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 104);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Declare Queue";
            // 
            // btn_queueDeclare
            // 
            this.btn_queueDeclare.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_queueDeclare.Location = new System.Drawing.Point(139, 25);
            this.btn_queueDeclare.Name = "btn_queueDeclare";
            this.btn_queueDeclare.Size = new System.Drawing.Size(89, 23);
            this.btn_queueDeclare.TabIndex = 2;
            this.btn_queueDeclare.Text = "Declare";
            this.btn_queueDeclare.UseVisualStyleBackColor = true;
            this.btn_queueDeclare.Click += new System.EventHandler(this.btn_queueDeclare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Queue Name";
            // 
            // txtQueueName
            // 
            this.txtQueueName.Location = new System.Drawing.Point(89, 54);
            this.txtQueueName.Name = "txtQueueName";
            this.txtQueueName.Size = new System.Drawing.Size(139, 23);
            this.txtQueueName.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_exchanceDeclare);
            this.groupBox3.Controls.Add(this.cbExchangeDeclareType);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtDeclareExchanceName);
            this.groupBox3.Location = new System.Drawing.Point(246, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 104);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Declare Exchance";
            // 
            // btn_exchanceDeclare
            // 
            this.btn_exchanceDeclare.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_exchanceDeclare.Location = new System.Drawing.Point(80, 75);
            this.btn_exchanceDeclare.Name = "btn_exchanceDeclare";
            this.btn_exchanceDeclare.Size = new System.Drawing.Size(154, 23);
            this.btn_exchanceDeclare.TabIndex = 2;
            this.btn_exchanceDeclare.Text = "Declare";
            this.btn_exchanceDeclare.UseVisualStyleBackColor = true;
            this.btn_exchanceDeclare.Click += new System.EventHandler(this.btn_exchanceDeclare_Click);
            // 
            // cbExchangeDeclareType
            // 
            this.cbExchangeDeclareType.FormattingEnabled = true;
            this.cbExchangeDeclareType.Location = new System.Drawing.Point(80, 46);
            this.cbExchangeDeclareType.Name = "cbExchangeDeclareType";
            this.cbExchangeDeclareType.Size = new System.Drawing.Size(154, 23);
            this.cbExchangeDeclareType.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            // 
            // txtDeclareExchanceName
            // 
            this.txtDeclareExchanceName.Location = new System.Drawing.Point(80, 17);
            this.txtDeclareExchanceName.Name = "txtDeclareExchanceName";
            this.txtDeclareExchanceName.Size = new System.Drawing.Size(154, 23);
            this.txtDeclareExchanceName.TabIndex = 1;
            // 
            // gbQueueExchange
            // 
            this.gbQueueExchange.Controls.Add(this.groupBox5);
            this.gbQueueExchange.Controls.Add(this.groupBox2);
            this.gbQueueExchange.Controls.Add(this.groupBox3);
            this.gbQueueExchange.Location = new System.Drawing.Point(0, 64);
            this.gbQueueExchange.Name = "gbQueueExchange";
            this.gbQueueExchange.Size = new System.Drawing.Size(498, 221);
            this.gbQueueExchange.TabIndex = 3;
            this.gbQueueExchange.TabStop = false;
            this.gbQueueExchange.Text = "Queue /Exchance Declare && Bind";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_bindQueue);
            this.groupBox5.Controls.Add(this.txtBindRoutingKey);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(128, 132);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(234, 82);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bind Queue && Exchange";
            // 
            // btn_bindQueue
            // 
            this.btn_bindQueue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_bindQueue.Location = new System.Drawing.Point(6, 51);
            this.btn_bindQueue.Name = "btn_bindQueue";
            this.btn_bindQueue.Size = new System.Drawing.Size(222, 23);
            this.btn_bindQueue.TabIndex = 2;
            this.btn_bindQueue.Text = "Bind Queue";
            this.btn_bindQueue.UseVisualStyleBackColor = true;
            // 
            // txtBindRoutingKey
            // 
            this.txtBindRoutingKey.Location = new System.Drawing.Point(93, 22);
            this.txtBindRoutingKey.Name = "txtBindRoutingKey";
            this.txtBindRoutingKey.Size = new System.Drawing.Size(135, 23);
            this.txtBindRoutingKey.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Routing Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(112, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Routing Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(61, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Exchange Name/Type";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 308);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 23);
            this.textBox2.TabIndex = 1;
            // 
            // cbExchangeType
            // 
            this.cbExchangeType.FormattingEnabled = true;
            this.cbExchangeType.Location = new System.Drawing.Point(345, 13);
            this.cbExchangeType.Name = "cbExchangeType";
            this.cbExchangeType.Size = new System.Drawing.Size(83, 23);
            this.cbExchangeType.TabIndex = 4;
            // 
            // txtRoutingKey
            // 
            this.txtRoutingKey.Location = new System.Drawing.Point(193, 39);
            this.txtRoutingKey.Name = "txtRoutingKey";
            this.txtRoutingKey.Size = new System.Drawing.Size(220, 23);
            this.txtRoutingKey.TabIndex = 1;
            this.txtRoutingKey.Text = "test_queue";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(61, 78);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(367, 110);
            this.txtMessage.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(61, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Message";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.richTextBox1.Location = new System.Drawing.Point(0, 548);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(495, 140);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(61, 211);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
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
            this.label9.Location = new System.Drawing.Point(61, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Repeat";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox1.Location = new System.Drawing.Point(199, 212);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Use Counter";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_Publish
            // 
            this.btn_Publish.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Publish.Location = new System.Drawing.Point(314, 194);
            this.btn_Publish.Name = "btn_Publish";
            this.btn_Publish.Size = new System.Drawing.Size(114, 40);
            this.btn_Publish.TabIndex = 9;
            this.btn_Publish.Text = "Publish";
            this.btn_Publish.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btn_Publish);
            this.pnlMain.Controls.Add(this.checkBox1);
            this.pnlMain.Controls.Add(this.numericUpDown1);
            this.pnlMain.Controls.Add(this.txtMessage);
            this.pnlMain.Controls.Add(this.cbExchangeType);
            this.pnlMain.Controls.Add(this.txtExchangeName);
            this.pnlMain.Controls.Add(this.txtRoutingKey);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Location = new System.Drawing.Point(0, 292);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(498, 258);
            this.pnlMain.TabIndex = 10;
            // 
            // txtExchangeName
            // 
            this.txtExchangeName.Location = new System.Drawing.Point(189, 13);
            this.txtExchangeName.Name = "txtExchangeName";
            this.txtExchangeName.Size = new System.Drawing.Size(150, 23);
            this.txtExchangeName.TabIndex = 1;
            this.txtExchangeName.Text = "MyCustomExchange";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbl_ConnectionStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 682);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(501, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslbl_ConnectionStatus
            // 
            this.tslbl_ConnectionStatus.Name = "tslbl_ConnectionStatus";
            this.tslbl_ConnectionStatus.Size = new System.Drawing.Size(192, 17);
            this.tslbl_ConnectionStatus.Text = "Connection State: Not Connnected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 704);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.gbQueueExchange);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.gbConnection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private TextBox txtQueueName;
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
        private ComboBox cbExchangeType;
        private TextBox txtRoutingKey;
        private TextBox txtMessage;
        private Label label8;
        private RichTextBox richTextBox1;
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