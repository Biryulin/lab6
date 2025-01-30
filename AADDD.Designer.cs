namespace _30_01_225
{
    partial class AADDD
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label vladelecLabel;
            System.Windows.Forms.Label vozrastLabel;
            System.Windows.Forms.Label размерLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kvaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.vladelecTextBox = new System.Windows.Forms.TextBox();
            this.vozrastTextBox = new System.Windows.Forms.TextBox();
            this.размерTextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            vladelecLabel = new System.Windows.Forms.Label();
            vozrastLabel = new System.Windows.Forms.Label();
            размерLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kvaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(188, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление данных";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "СОХРАНИТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "ВЫЙТИ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kvaBindingSource
            // 
            this.kvaBindingSource.DataSource = typeof(_30_01_225.DataModel.Kva);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(85, 103);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 11;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kvaBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(142, 100);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 12;
            // 
            // vladelecLabel
            // 
            vladelecLabel.AutoSize = true;
            vladelecLabel.Location = new System.Drawing.Point(85, 129);
            vladelecLabel.Name = "vladelecLabel";
            vladelecLabel.Size = new System.Drawing.Size(51, 13);
            vladelecLabel.TabIndex = 13;
            vladelecLabel.Text = "Vladelec:";
            // 
            // vladelecTextBox
            // 
            this.vladelecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kvaBindingSource, "Vladelec", true));
            this.vladelecTextBox.Location = new System.Drawing.Point(142, 126);
            this.vladelecTextBox.Name = "vladelecTextBox";
            this.vladelecTextBox.Size = new System.Drawing.Size(100, 20);
            this.vladelecTextBox.TabIndex = 14;
            // 
            // vozrastLabel
            // 
            vozrastLabel.AutoSize = true;
            vozrastLabel.Location = new System.Drawing.Point(85, 155);
            vozrastLabel.Name = "vozrastLabel";
            vozrastLabel.Size = new System.Drawing.Size(45, 13);
            vozrastLabel.TabIndex = 15;
            vozrastLabel.Text = "Vozrast:";
            // 
            // vozrastTextBox
            // 
            this.vozrastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kvaBindingSource, "Vozrast", true));
            this.vozrastTextBox.Location = new System.Drawing.Point(142, 152);
            this.vozrastTextBox.Name = "vozrastTextBox";
            this.vozrastTextBox.Size = new System.Drawing.Size(100, 20);
            this.vozrastTextBox.TabIndex = 16;
            // 
            // размерLabel
            // 
            размерLabel.AutoSize = true;
            размерLabel.Location = new System.Drawing.Point(85, 181);
            размерLabel.Name = "размерLabel";
            размерLabel.Size = new System.Drawing.Size(49, 13);
            размерLabel.TabIndex = 17;
            размерLabel.Text = "Размер:";
            // 
            // размерTextBox
            // 
            this.размерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kvaBindingSource, "Размер", true));
            this.размерTextBox.Location = new System.Drawing.Point(142, 178);
            this.размерTextBox.Name = "размерTextBox";
            this.размерTextBox.Size = new System.Drawing.Size(100, 20);
            this.размерTextBox.TabIndex = 18;
            // 
            // AADDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 322);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(vladelecLabel);
            this.Controls.Add(this.vladelecTextBox);
            this.Controls.Add(vozrastLabel);
            this.Controls.Add(this.vozrastTextBox);
            this.Controls.Add(размерLabel);
            this.Controls.Add(this.размерTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AADDD";
            this.Text = "AADDD";
            this.Load += new System.EventHandler(this.AADDD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kvaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource kvaBindingSource;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox vladelecTextBox;
        private System.Windows.Forms.TextBox vozrastTextBox;
        private System.Windows.Forms.TextBox размерTextBox;
    }
}