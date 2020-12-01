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
      this.SuspendLayout();
      // 
      // Suchen_btn
      // 
      this.Suchen_btn.Location = new System.Drawing.Point(584, 49);
      this.Suchen_btn.Margin = new System.Windows.Forms.Padding(4);
      this.Suchen_btn.Name = "Suchen_btn";
      this.Suchen_btn.Size = new System.Drawing.Size(100, 28);
      this.Suchen_btn.TabIndex = 0;
      this.Suchen_btn.Text = "Suchen";
      this.Suchen_btn.UseVisualStyleBackColor = true;
      this.Suchen_btn.Click += new System.EventHandler(this.Suchen_btn_Click);
      // 
      // Start_txt
      // 
      this.Start_txt.Location = new System.Drawing.Point(226, 52);
      this.Start_txt.Margin = new System.Windows.Forms.Padding(4);
      this.Start_txt.Name = "Start_txt";
      this.Start_txt.Size = new System.Drawing.Size(132, 22);
      this.Start_txt.TabIndex = 1;
      this.Start_txt.AcceptsTabChanged += new System.EventHandler(this.End_txt_TextChanged);
      this.Start_txt.TextChanged += new System.EventHandler(this.Start_txt_TextChanged);
      // 
      // End_txt
      // 
      this.End_txt.Location = new System.Drawing.Point(408, 52);
      this.End_txt.Margin = new System.Windows.Forms.Padding(4);
      this.End_txt.Name = "End_txt";
      this.End_txt.Size = new System.Drawing.Size(132, 22);
      this.End_txt.TabIndex = 2;
      this.End_txt.AcceptsTabChanged += new System.EventHandler(this.Suchen_btn_Click);
      this.End_txt.TextChanged += new System.EventHandler(this.End_txt_TextChanged);
      // 
      // Start_lbl
      // 
      this.Start_lbl.AutoSize = true;
      this.Start_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Start_lbl.Location = new System.Drawing.Point(222, 9);
      this.Start_lbl.Name = "Start_lbl";
      this.Start_lbl.Size = new System.Drawing.Size(62, 19);
      this.Start_lbl.TabIndex = 3;
      this.Start_lbl.Text = "Abfahrt";
      // 
      // Ankuft_lbl
      // 
      this.Ankuft_lbl.AutoSize = true;
      this.Ankuft_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Ankuft_lbl.Location = new System.Drawing.Point(404, 9);
      this.Ankuft_lbl.Name = "Ankuft_lbl";
      this.Ankuft_lbl.Size = new System.Drawing.Size(55, 19);
      this.Ankuft_lbl.TabIndex = 3;
      this.Ankuft_lbl.Text = "Ankuft";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(729, 554);
      this.Controls.Add(this.Ankuft_lbl);
      this.Controls.Add(this.Start_lbl);
      this.Controls.Add(this.End_txt);
      this.Controls.Add(this.Start_txt);
      this.Controls.Add(this.Suchen_btn);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "MainForm";
      this.Text = "SSV Applikation";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button Suchen_btn;
    private System.Windows.Forms.TextBox Start_txt;
    private System.Windows.Forms.TextBox End_txt;
    private System.Windows.Forms.Label Start_lbl;
    private System.Windows.Forms.Label Ankuft_lbl;
  }
}

