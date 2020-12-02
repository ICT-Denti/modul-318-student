namespace MeineTransoprtApp
{
  partial class MainForm
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.Suchen_btn = new System.Windows.Forms.Button();
      this.Start_txt = new System.Windows.Forms.TextBox();
      this.End_txt = new System.Windows.Forms.TextBox();
      this.Start_lbl = new System.Windows.Forms.Label();
      this.Ankuft_lbl = new System.Windows.Forms.Label();
      this.Ankuft_grp = new System.Windows.Forms.GroupBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.Datum_dtp = new System.Windows.Forms.DateTimePicker();
      this.datum_lbl = new System.Windows.Forms.Label();
      this.zeit_lbl = new System.Windows.Forms.Label();
      this.zeit_dtp = new System.Windows.Forms.DateTimePicker();
      this.Ankuft_grp.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Suchen_btn
      // 
      this.Suchen_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Suchen_btn.ForeColor = System.Drawing.Color.Black;
      this.Suchen_btn.Location = new System.Drawing.Point(392, 23);
      this.Suchen_btn.Name = "Suchen_btn";
      this.Suchen_btn.Size = new System.Drawing.Size(143, 43);
      this.Suchen_btn.TabIndex = 5;
      this.Suchen_btn.Text = "Suche Starten";
      this.Suchen_btn.UseVisualStyleBackColor = true;
      this.Suchen_btn.Click += new System.EventHandler(this.Suchen_btn_Click);
      // 
      // Start_txt
      // 
      this.Start_txt.Location = new System.Drawing.Point(6, 36);
      this.Start_txt.Name = "Start_txt";
      this.Start_txt.Size = new System.Drawing.Size(130, 26);
      this.Start_txt.TabIndex = 1;
      // 
      // End_txt
      // 
      this.End_txt.Location = new System.Drawing.Point(6, 36);
      this.End_txt.Name = "End_txt";
      this.End_txt.Size = new System.Drawing.Size(130, 26);
      this.End_txt.TabIndex = 2;
      this.End_txt.AcceptsTabChanged += new System.EventHandler(this.Suchen_btn_Click);
      // 
      // Start_lbl
      // 
      this.Start_lbl.AutoSize = true;
      this.Start_lbl.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Start_lbl.Location = new System.Drawing.Point(5, 11);
      this.Start_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.Start_lbl.Name = "Start_lbl";
      this.Start_lbl.Size = new System.Drawing.Size(78, 22);
      this.Start_lbl.TabIndex = 3;
      this.Start_lbl.Text = "Abfahrt";
      // 
      // Ankuft_lbl
      // 
      this.Ankuft_lbl.AutoSize = true;
      this.Ankuft_lbl.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Ankuft_lbl.Location = new System.Drawing.Point(5, 11);
      this.Ankuft_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.Ankuft_lbl.Name = "Ankuft_lbl";
      this.Ankuft_lbl.Size = new System.Drawing.Size(70, 22);
      this.Ankuft_lbl.TabIndex = 3;
      this.Ankuft_lbl.Text = "Ankuft";
      // 
      // Ankuft_grp
      // 
      this.Ankuft_grp.BackColor = System.Drawing.Color.DodgerBlue;
      this.Ankuft_grp.Controls.Add(this.End_txt);
      this.Ankuft_grp.Controls.Add(this.Ankuft_lbl);
      this.Ankuft_grp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Ankuft_grp.Location = new System.Drawing.Point(186, 12);
      this.Ankuft_grp.Name = "Ankuft_grp";
      this.Ankuft_grp.Size = new System.Drawing.Size(143, 69);
      this.Ankuft_grp.TabIndex = 2;
      this.Ankuft_grp.TabStop = false;
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.Color.OrangeRed;
      this.groupBox1.Controls.Add(this.Start_txt);
      this.groupBox1.Controls.Add(this.Start_lbl);
      this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(143, 69);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      // 
      // Datum_dtp
      // 
      this.Datum_dtp.Location = new System.Drawing.Point(129, 108);
      this.Datum_dtp.Name = "Datum_dtp";
      this.Datum_dtp.Size = new System.Drawing.Size(200, 20);
      this.Datum_dtp.TabIndex = 4;
      this.Datum_dtp.Value = new System.DateTime(2020, 12, 2, 9, 9, 0, 0);
      // 
      // datum_lbl
      // 
      this.datum_lbl.AutoSize = true;
      this.datum_lbl.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.datum_lbl.Location = new System.Drawing.Point(188, 84);
      this.datum_lbl.Name = "datum_lbl";
      this.datum_lbl.Size = new System.Drawing.Size(77, 22);
      this.datum_lbl.TabIndex = 6;
      this.datum_lbl.Text = "Datum:";
      // 
      // zeit_lbl
      // 
      this.zeit_lbl.AutoSize = true;
      this.zeit_lbl.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.zeit_lbl.Location = new System.Drawing.Point(14, 84);
      this.zeit_lbl.Name = "zeit_lbl";
      this.zeit_lbl.Size = new System.Drawing.Size(50, 22);
      this.zeit_lbl.TabIndex = 6;
      this.zeit_lbl.Text = "Zeit:";
      // 
      // zeit_dtp
      // 
      this.zeit_dtp.CustomFormat = "HH:mm";
      this.zeit_dtp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.zeit_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.zeit_dtp.Location = new System.Drawing.Point(18, 109);
      this.zeit_dtp.Name = "zeit_dtp";
      this.zeit_dtp.RightToLeftLayout = true;
      this.zeit_dtp.ShowUpDown = true;
      this.zeit_dtp.Size = new System.Drawing.Size(96, 20);
      this.zeit_dtp.TabIndex = 3;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightCyan;
      this.ClientSize = new System.Drawing.Size(547, 450);
      this.Controls.Add(this.zeit_lbl);
      this.Controls.Add(this.datum_lbl);
      this.Controls.Add(this.zeit_dtp);
      this.Controls.Add(this.Datum_dtp);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.Ankuft_grp);
      this.Controls.Add(this.Suchen_btn);
      this.Name = "MainForm";
      this.Text = "SSV Applikation";
      this.Ankuft_grp.ResumeLayout(false);
      this.Ankuft_grp.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button Suchen_btn;
    private System.Windows.Forms.TextBox Start_txt;
    private System.Windows.Forms.TextBox End_txt;
    private System.Windows.Forms.Label Start_lbl;
    private System.Windows.Forms.Label Ankuft_lbl;
    private System.Windows.Forms.GroupBox Ankuft_grp;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DateTimePicker Datum_dtp;
    private System.Windows.Forms.Label datum_lbl;
    private System.Windows.Forms.Label zeit_lbl;
    private System.Windows.Forms.DateTimePicker zeit_dtp;
  }
}

