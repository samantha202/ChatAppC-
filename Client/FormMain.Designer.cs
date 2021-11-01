
namespace Client
{
    partial class FormMain
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
            this.history = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.indicator = new System.Windows.Forms.Panel();
            this.input = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // history
            // 
            this.history.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.history.Location = new System.Drawing.Point(12, 68);
            this.history.Multiline = true;
            this.history.Name = "history";
            this.history.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.history.Size = new System.Drawing.Size(629, 444);
            this.history.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(696, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 452);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(730, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Participants";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 668);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(355, 10);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // indicator
            // 
            this.indicator.Location = new System.Drawing.Point(12, 28);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(28, 27);
            this.indicator.TabIndex = 4;
            // 
            // input
            // 
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input.Location = new System.Drawing.Point(32, 620);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(355, 42);
            this.input.TabIndex = 5;
            this.input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSend.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSend.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSend.Location = new System.Drawing.Point(450, 648);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(178, 69);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConnect.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConnect.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnConnect.Location = new System.Drawing.Point(705, 648);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(178, 69);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(974, 729);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.input);
            this.Controls.Add(this.indicator);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.history);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox history;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel indicator;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConnect;
    }
}