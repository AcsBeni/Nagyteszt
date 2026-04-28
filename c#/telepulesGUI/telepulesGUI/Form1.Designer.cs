namespace telepulesGUI
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
            this.Listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minkozszamBtn = new System.Windows.Forms.Button();
            this.minvarszamBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datetxt = new System.Windows.Forms.TextBox();
            this.dateBtn = new System.Windows.Forms.Button();
            this.populationgrowthLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Listbox
            // 
            this.Listbox.FormattingEnabled = true;
            this.Listbox.Location = new System.Drawing.Point(32, 109);
            this.Listbox.Name = "Listbox";
            this.Listbox.Size = new System.Drawing.Size(756, 316);
            this.Listbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Területi egység";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Szűrések";
            // 
            // minkozszamBtn
            // 
            this.minkozszamBtn.Location = new System.Drawing.Point(279, 49);
            this.minkozszamBtn.Name = "minkozszamBtn";
            this.minkozszamBtn.Size = new System.Drawing.Size(85, 40);
            this.minkozszamBtn.TabIndex = 5;
            this.minkozszamBtn.Text = "\tminimális községszám";
            this.minkozszamBtn.UseVisualStyleBackColor = true;
            this.minkozszamBtn.Click += new System.EventHandler(this.minkozszamBtn_Click);
            // 
            // minvarszamBtn
            // 
            this.minvarszamBtn.Location = new System.Drawing.Point(370, 49);
            this.minvarszamBtn.Name = "minvarszamBtn";
            this.minvarszamBtn.Size = new System.Drawing.Size(81, 40);
            this.minvarszamBtn.TabIndex = 6;
            this.minvarszamBtn.Text = "\tminimális városszám";
            this.minvarszamBtn.UseVisualStyleBackColor = true;
            this.minvarszamBtn.Click += new System.EventHandler(this.minvarszamBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "vármegye",
            "régió",
            "nagyrégió"});
            this.comboBox1.Location = new System.Drawing.Point(33, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Év";
            // 
            // datetxt
            // 
            this.datetxt.Location = new System.Drawing.Point(480, 49);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(124, 20);
            this.datetxt.TabIndex = 9;
            // 
            // dateBtn
            // 
            this.dateBtn.Location = new System.Drawing.Point(633, 45);
            this.dateBtn.Name = "dateBtn";
            this.dateBtn.Size = new System.Drawing.Size(125, 27);
            this.dateBtn.TabIndex = 10;
            this.dateBtn.Text = "Össznép becslése";
            this.dateBtn.UseVisualStyleBackColor = true;
            this.dateBtn.Click += new System.EventHandler(this.dateBtn_Click);
            // 
            // populationgrowthLbl
            // 
            this.populationgrowthLbl.AutoSize = true;
            this.populationgrowthLbl.Location = new System.Drawing.Point(477, 76);
            this.populationgrowthLbl.Name = "populationgrowthLbl";
            this.populationgrowthLbl.Size = new System.Drawing.Size(0, 13);
            this.populationgrowthLbl.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.populationgrowthLbl);
            this.Controls.Add(this.dateBtn);
            this.Controls.Add(this.datetxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.minvarszamBtn);
            this.Controls.Add(this.minkozszamBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Listbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button minkozszamBtn;
        private System.Windows.Forms.Button minvarszamBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox datetxt;
        private System.Windows.Forms.Button dateBtn;
        private System.Windows.Forms.Label populationgrowthLbl;
    }
}

