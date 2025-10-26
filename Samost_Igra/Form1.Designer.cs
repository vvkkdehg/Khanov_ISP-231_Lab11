namespace Samost_Igra
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
            this.pravLBL = new System.Windows.Forms.Label();
            this.nePravLBL = new System.Windows.Forms.Label();
            this.infoLBL = new System.Windows.Forms.Label();
            this.textVvod = new System.Windows.Forms.TextBox();
            this.slovoLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pravLBL
            // 
            this.pravLBL.AutoSize = true;
            this.pravLBL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pravLBL.Location = new System.Drawing.Point(53, 39);
            this.pravLBL.Name = "pravLBL";
            this.pravLBL.Size = new System.Drawing.Size(148, 19);
            this.pravLBL.TabIndex = 0;
            this.pravLBL.Text = "Правильных слов: 0";
            // 
            // nePravLBL
            // 
            this.nePravLBL.AutoSize = true;
            this.nePravLBL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nePravLBL.Location = new System.Drawing.Point(324, 39);
            this.nePravLBL.Name = "nePravLBL";
            this.nePravLBL.Size = new System.Drawing.Size(165, 19);
            this.nePravLBL.TabIndex = 1;
            this.nePravLBL.Text = "Неправильных слов: 0";
            // 
            // infoLBL
            // 
            this.infoLBL.AutoSize = true;
            this.infoLBL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLBL.Location = new System.Drawing.Point(134, 265);
            this.infoLBL.Name = "infoLBL";
            this.infoLBL.Size = new System.Drawing.Size(256, 19);
            this.infoLBL.TabIndex = 3;
            this.infoLBL.Text = "Нажмите Enter чтобы ввести слово";
            // 
            // textVvod
            // 
            this.textVvod.Location = new System.Drawing.Point(196, 224);
            this.textVvod.Name = "textVvod";
            this.textVvod.Size = new System.Drawing.Size(136, 20);
            this.textVvod.TabIndex = 4;
            this.textVvod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textVvod_KeyDown);
            // 
            // slovoLBL
            // 
            this.slovoLBL.AutoSize = true;
            this.slovoLBL.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.slovoLBL.Location = new System.Drawing.Point(222, 112);
            this.slovoLBL.Name = "slovoLBL";
            this.slovoLBL.Size = new System.Drawing.Size(77, 29);
            this.slovoLBL.TabIndex = 2;
            this.slovoLBL.Text = "Слово";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.textVvod);
            this.Controls.Add(this.infoLBL);
            this.Controls.Add(this.slovoLBL);
            this.Controls.Add(this.nePravLBL);
            this.Controls.Add(this.pravLBL);
            this.Name = "Form1";
            this.Text = "Typing game ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pravLBL;
        private System.Windows.Forms.Label nePravLBL;
        private System.Windows.Forms.Label infoLBL;
        private System.Windows.Forms.TextBox textVvod;
        private System.Windows.Forms.Label slovoLBL;
    }
}

