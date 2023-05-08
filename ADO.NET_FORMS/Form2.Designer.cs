
namespace ADO.NET_FORMS
{
    partial class Form2
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
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FindAdapterButton = new System.Windows.Forms.Button();
            this.ToModifyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(131, 16);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(125, 27);
            this.yearTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Year of orders";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(262, 16);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(159, 29);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Find (SqlCommand)";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(600, 373);
            this.dataGridView1.TabIndex = 3;
            // 
            // FindAdapterButton
            // 
            this.FindAdapterButton.Location = new System.Drawing.Point(437, 16);
            this.FindAdapterButton.Name = "FindAdapterButton";
            this.FindAdapterButton.Size = new System.Drawing.Size(187, 29);
            this.FindAdapterButton.TabIndex = 4;
            this.FindAdapterButton.Text = "Find (SqlDataAdapter)";
            this.FindAdapterButton.UseVisualStyleBackColor = true;
            this.FindAdapterButton.Click += new System.EventHandler(this.FindAdapterButton_Click);
            // 
            // ToModifyButton
            // 
            this.ToModifyButton.Location = new System.Drawing.Point(649, 412);
            this.ToModifyButton.Name = "ToModifyButton";
            this.ToModifyButton.Size = new System.Drawing.Size(169, 29);
            this.ToModifyButton.TabIndex = 5;
            this.ToModifyButton.Text = "Go to modifying";
            this.ToModifyButton.UseVisualStyleBackColor = true;
            this.ToModifyButton.Click += new System.EventHandler(this.ToModifyButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 489);
            this.Controls.Add(this.ToModifyButton);
            this.Controls.Add(this.FindAdapterButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearTextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FindAdapterButton;
        private System.Windows.Forms.Button ToModifyButton;
    }
}