namespace WindowsFormsApplication3
{
    partial class Wlc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wlc));
            this.label1 = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.TextBox();
            this.izberiSlika = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cB1 = new System.Windows.Forms.ComboBox();
            this.zapochni = new System.Windows.Forms.Button();
            this.errorIme = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorIme)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Внеси име:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ime
            // 
            this.Ime.Location = new System.Drawing.Point(205, 236);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(143, 20);
            this.Ime.TabIndex = 1;
            this.Ime.Validating += new System.ComponentModel.CancelEventHandler(this.Ime_Validating);
            // 
            // izberiSlika
            // 
            this.izberiSlika.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.izberiSlika.Location = new System.Drawing.Point(205, 274);
            this.izberiSlika.Name = "izberiSlika";
            this.izberiSlika.Size = new System.Drawing.Size(143, 23);
            this.izberiSlika.TabIndex = 2;
            this.izberiSlika.Text = "Избери";
            this.izberiSlika.UseVisualStyleBackColor = false;
            this.izberiSlika.Click += new System.EventHandler(this.izberiSlika_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Избери слика:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Избери ниво:";
            // 
            // cB1
            // 
            this.cB1.AutoCompleteCustomSource.AddRange(new string[] {
            "Почетник",
            "Напреден"});
            this.cB1.FormattingEnabled = true;
            this.cB1.Items.AddRange(new object[] {
            "Почетник",
            "Напреден"});
            this.cB1.Location = new System.Drawing.Point(205, 318);
            this.cB1.Name = "cB1";
            this.cB1.Size = new System.Drawing.Size(143, 21);
            this.cB1.TabIndex = 5;
            // 
            // zapochni
            // 
            this.zapochni.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.zapochni.Location = new System.Drawing.Point(205, 362);
            this.zapochni.Name = "zapochni";
            this.zapochni.Size = new System.Drawing.Size(143, 23);
            this.zapochni.TabIndex = 6;
            this.zapochni.Text = "Започни со игра";
            this.zapochni.UseVisualStyleBackColor = false;
            this.zapochni.Click += new System.EventHandler(this.zapochni_Click);
            // 
            // errorIme
            // 
            this.errorIme.ContainerControl = this;
            // 
            // Wlc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.zapochni);
            this.Controls.Add(this.cB1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.izberiSlika);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.label1);
            this.Name = "Wlc";
            this.Text = "Сложувалка";
            ((System.ComponentModel.ISupportInitialize)(this.errorIme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.Button izberiSlika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cB1;
        private System.Windows.Forms.Button zapochni;
        private System.Windows.Forms.ErrorProvider errorIme;
    }
}

