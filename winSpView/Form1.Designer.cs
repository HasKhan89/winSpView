namespace winSpView
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtViewDescription = new System.Windows.Forms.TextBox();
            this.btnViewEkle = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEmailGonder = new System.Windows.Forms.Button();
            this.txtViewName = new System.Windows.Forms.TextBox();
            this.txtViewClearName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Raporlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(822, 396);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtViewDescription
            // 
            this.txtViewDescription.Location = new System.Drawing.Point(274, 63);
            this.txtViewDescription.MaxLength = 250;
            this.txtViewDescription.Name = "txtViewDescription";
            this.txtViewDescription.Size = new System.Drawing.Size(168, 23);
            this.txtViewDescription.TabIndex = 3;
            // 
            // btnViewEkle
            // 
            this.btnViewEkle.Location = new System.Drawing.Point(448, 63);
            this.btnViewEkle.Name = "btnViewEkle";
            this.btnViewEkle.Size = new System.Drawing.Size(75, 23);
            this.btnViewEkle.TabIndex = 4;
            this.btnViewEkle.Text = "View Ekle";
            this.btnViewEkle.UseVisualStyleBackColor = true;
            this.btnViewEkle.Click += new System.EventHandler(this.btnViewEkle_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(529, 64);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // btnEmailGonder
            // 
            this.btnEmailGonder.Location = new System.Drawing.Point(703, 64);
            this.btnEmailGonder.Name = "btnEmailGonder";
            this.btnEmailGonder.Size = new System.Drawing.Size(131, 23);
            this.btnEmailGonder.TabIndex = 4;
            this.btnEmailGonder.Text = "E-Mail Gönder";
            this.btnEmailGonder.UseVisualStyleBackColor = true;
            this.btnEmailGonder.Click += new System.EventHandler(this.btnEmailGonder_Click);
            // 
            // txtViewName
            // 
            this.txtViewName.Location = new System.Drawing.Point(274, 34);
            this.txtViewName.MaxLength = 60;
            this.txtViewName.Name = "txtViewName";
            this.txtViewName.Size = new System.Drawing.Size(168, 23);
            this.txtViewName.TabIndex = 3;
            // 
            // txtViewClearName
            // 
            this.txtViewClearName.Location = new System.Drawing.Point(274, 5);
            this.txtViewClearName.MaxLength = 100;
            this.txtViewClearName.Name = "txtViewClearName";
            this.txtViewClearName.Size = new System.Drawing.Size(168, 23);
            this.txtViewClearName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "View Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Açk. :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 501);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEmailGonder);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnViewEkle);
            this.Controls.Add(this.txtViewClearName);
            this.Controls.Add(this.txtViewName);
            this.Controls.Add(this.txtViewDescription);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Views";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtViewDescription;
        private System.Windows.Forms.Button btnViewEkle;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEmailGonder;
        private System.Windows.Forms.TextBox txtViewName;
        private System.Windows.Forms.TextBox txtViewClearName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

