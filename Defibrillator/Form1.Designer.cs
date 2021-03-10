
namespace Defibrillator
{
    partial class frmDefibrillator
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.btnLekeres = new System.Windows.Forms.Button();
            this.lbEredmeny = new System.Windows.Forms.ListBox();
            this.btnUjAdat = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(25, 25);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(103, 20);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X koordináta:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(24, 68);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(103, 20);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y koordináta:";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(152, 24);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(193, 26);
            this.tbX.TabIndex = 2;
            this.tbX.TextChanged += new System.EventHandler(this.tbX_TextChanged);
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(153, 68);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(191, 26);
            this.tbY.TabIndex = 3;
            this.tbY.TextChanged += new System.EventHandler(this.tbY_TextChanged);
            // 
            // btnLekeres
            // 
            this.btnLekeres.Location = new System.Drawing.Point(95, 120);
            this.btnLekeres.Name = "btnLekeres";
            this.btnLekeres.Size = new System.Drawing.Size(193, 35);
            this.btnLekeres.TabIndex = 4;
            this.btnLekeres.Text = "ADATOK LEKÉRÉSE";
            this.btnLekeres.UseVisualStyleBackColor = true;
            this.btnLekeres.Click += new System.EventHandler(this.btnLekeres_Click);
            // 
            // lbEredmeny
            // 
            this.lbEredmeny.FormattingEnabled = true;
            this.lbEredmeny.ItemHeight = 20;
            this.lbEredmeny.Location = new System.Drawing.Point(46, 172);
            this.lbEredmeny.Name = "lbEredmeny";
            this.lbEredmeny.Size = new System.Drawing.Size(285, 184);
            this.lbEredmeny.TabIndex = 5;
            // 
            // btnUjAdat
            // 
            this.btnUjAdat.Location = new System.Drawing.Point(18, 393);
            this.btnUjAdat.Name = "btnUjAdat";
            this.btnUjAdat.Size = new System.Drawing.Size(193, 33);
            this.btnUjAdat.TabIndex = 6;
            this.btnUjAdat.Text = "ÚJ ADAT MEGADÁSA";
            this.btnUjAdat.UseVisualStyleBackColor = true;
            this.btnUjAdat.Click += new System.EventHandler(this.btnUjAdat_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(240, 393);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(117, 32);
            this.btnKilepes.TabIndex = 7;
            this.btnKilepes.Text = "KILÉPÉS";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // frmDefibrillator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(123)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnUjAdat);
            this.Controls.Add(this.lbEredmeny);
            this.Controls.Add(this.btnLekeres);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDefibrillator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Defibrillator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Button btnLekeres;
        private System.Windows.Forms.ListBox lbEredmeny;
        private System.Windows.Forms.Button btnUjAdat;
        private System.Windows.Forms.Button btnKilepes;
    }
}

