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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // Suchen_btn
      // 
      this.Suchen_btn.Location = new System.Drawing.Point(933, 46);
      this.Suchen_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Suchen_btn.Name = "Suchen_btn";
      this.Suchen_btn.Size = new System.Drawing.Size(100, 28);
      this.Suchen_btn.TabIndex = 0;
      this.Suchen_btn.Text = "Suchen";
      this.Suchen_btn.UseVisualStyleBackColor = true;
      this.Suchen_btn.Click += new System.EventHandler(this.Suchen_btn_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(475, 87);
      this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(132, 22);
      this.textBox1.TabIndex = 1;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(687, 87);
      this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(132, 22);
      this.textBox2.TabIndex = 2;
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(447, 46);
      this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(160, 24);
      this.comboBox1.TabIndex = 3;
      // 
      // comboBox2
      // 
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new System.Drawing.Point(687, 46);
      this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(160, 24);
      this.comboBox2.TabIndex = 4;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1067, 554);
      this.Controls.Add(this.comboBox2);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.Suchen_btn);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form1";
      this.Text = "SSV Applikation";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button Suchen_btn;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.ComboBox comboBox2;
  }
}

