namespace ApuntadorDesktop
{
    partial class FrmApunte
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
            this.lblAnotaciones = new System.Windows.Forms.Label();
            this.btnSlider = new System.Windows.Forms.Button();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.pnlSlider = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.lblApunte = new System.Windows.Forms.Label();
            this.pnlSlider.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAnotaciones
            // 
            this.lblAnotaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnotaciones.AutoSize = true;
            this.lblAnotaciones.Location = new System.Drawing.Point(121, 419);
            this.lblAnotaciones.Name = "lblAnotaciones";
            this.lblAnotaciones.Size = new System.Drawing.Size(69, 13);
            this.lblAnotaciones.TabIndex = 2;
            this.lblAnotaciones.Text = "Anotaciones:";
            // 
            // btnSlider
            // 
            this.btnSlider.Location = new System.Drawing.Point(153, 12);
            this.btnSlider.Name = "btnSlider";
            this.btnSlider.Size = new System.Drawing.Size(75, 23);
            this.btnSlider.TabIndex = 3;
            this.btnSlider.Text = "Menu";
            this.btnSlider.UseVisualStyleBackColor = true;
            this.btnSlider.Click += new System.EventHandler(this.btnSlider_Click);
            // 
            // tm
            // 
            this.tm.Interval = 1000;
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // pnlSlider
            // 
            this.pnlSlider.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlSlider.Controls.Add(this.listBox1);
            this.pnlSlider.Controls.Add(this.button4);
            this.pnlSlider.Controls.Add(this.button3);
            this.pnlSlider.Controls.Add(this.button2);
            this.pnlSlider.Controls.Add(this.button1);
            this.pnlSlider.Location = new System.Drawing.Point(12, 12);
            this.pnlSlider.Name = "pnlSlider";
            this.pnlSlider.Size = new System.Drawing.Size(103, 538);
            this.pnlSlider.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Completo",
            "",
            "Anexos",
            "",
            "Guardar",
            "",
            "Opciones",
            "",
            "Salir"});
            this.listBox1.Location = new System.Drawing.Point(4, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(84, 130);
            this.listBox1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 480);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(124, 444);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(578, 106);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(153, 69);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(300, 252);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // lblApunte
            // 
            this.lblApunte.AutoSize = true;
            this.lblApunte.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApunte.Location = new System.Drawing.Point(392, 13);
            this.lblApunte.Name = "lblApunte";
            this.lblApunte.Size = new System.Drawing.Size(67, 18);
            this.lblApunte.TabIndex = 7;
            this.lblApunte.Text = "Apunte";
            // 
            // FrmApunte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 600);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.lblApunte);
            this.Controls.Add(this.pnlSlider);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSlider);
            this.Controls.Add(this.lblAnotaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmApunte";
            this.Text = "Nuevo Apunte";
            this.pnlSlider.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnotaciones;
        private System.Windows.Forms.Button btnSlider;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.Panel pnlSlider;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label lblApunte;

    }
}