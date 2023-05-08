
namespace ADO.NET_FORMS
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ByIdRButton = new System.Windows.Forms.RadioButton();
            this.ByAnRButton = new System.Windows.Forms.RadioButton();
            this.FilterBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(433, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(453, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Results";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(130, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Analysis type";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(130, 30);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(192, 27);
            this.idTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Find";
            // 
            // ByIdRButton
            // 
            this.ByIdRButton.AutoSize = true;
            this.ByIdRButton.Checked = true;
            this.ByIdRButton.Location = new System.Drawing.Point(9, 72);
            this.ByIdRButton.Name = "ByIdRButton";
            this.ByIdRButton.Size = new System.Drawing.Size(63, 24);
            this.ByIdRButton.TabIndex = 9;
            this.ByIdRButton.TabStop = true;
            this.ByIdRButton.Text = "by id";
            this.ByIdRButton.UseVisualStyleBackColor = true;
            this.ByIdRButton.CheckedChanged += new System.EventHandler(this.ByIdRButton_CheckedChanged);
            // 
            // ByAnRButton
            // 
            this.ByAnRButton.AutoSize = true;
            this.ByAnRButton.Location = new System.Drawing.Point(9, 117);
            this.ByAnRButton.Name = "ByAnRButton";
            this.ByAnRButton.Size = new System.Drawing.Size(101, 24);
            this.ByAnRButton.TabIndex = 10;
            this.ByAnRButton.Text = "by analysis";
            this.ByAnRButton.UseVisualStyleBackColor = true;
            this.ByAnRButton.CheckedChanged += new System.EventHandler(this.ByAnRButton_CheckedChanged);
            // 
            // FilterBox
            // 
            this.FilterBox.Location = new System.Drawing.Point(433, 40);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.PlaceholderText = "Enter data to find by...";
            this.FilterBox.Size = new System.Drawing.Size(265, 27);
            this.FilterBox.TabIndex = 11;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(792, 40);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(94, 29);
            this.FindButton.TabIndex = 12;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(7, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 236);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ByAnRButton);
            this.groupBox2.Controls.Add(this.ByIdRButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(7, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 179);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find specific result";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(907, 93);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(43, 38);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            this.DeleteButton.MouseHover += new System.EventHandler(this.DeleteButton_MouseHover);
            // 
            // InsertButton
            // 
            this.InsertButton.Image = ((System.Drawing.Image)(resources.GetObject("InsertButton.Image")));
            this.InsertButton.Location = new System.Drawing.Point(907, 137);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(43, 38);
            this.InsertButton.TabIndex = 16;
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            this.InsertButton.MouseHover += new System.EventHandler(this.InsertButton_MouseHover);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.Location = new System.Drawing.Point(907, 181);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(43, 38);
            this.UpdateButton.TabIndex = 17;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            this.UpdateButton.MouseHover += new System.EventHandler(this.UpdateButton_MouseHover);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 542);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton ByIdRButton;
        private System.Windows.Forms.RadioButton ByAnRButton;
        private System.Windows.Forms.TextBox FilterBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}