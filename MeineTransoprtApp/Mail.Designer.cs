namespace MeineTransoprtApp
{
  partial class Mail
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
      this.Mail_lbl = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // Mail_lbl
      // 
      this.Mail_lbl.AutoSize = true;
      this.Mail_lbl.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Mail_lbl.Location = new System.Drawing.Point(7, 47);
      this.Mail_lbl.Name = "Mail_lbl";
      this.Mail_lbl.Size = new System.Drawing.Size(235, 37);
      this.Mail_lbl.TabIndex = 0;
      this.Mail_lbl.Text = "Noch in Arbeit";
      // 
      // Mail
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(254, 238);
      this.Controls.Add(this.Mail_lbl);
      this.Name = "Mail";
      this.Text = "Mail";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label Mail_lbl;
  }
}