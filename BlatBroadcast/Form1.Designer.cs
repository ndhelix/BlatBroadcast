namespace BlatBroadcast
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
      this.SS1 = new System.Windows.Forms.StatusStrip();
      this.SSlbl1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.btnBatFile = new System.Windows.Forms.Button();
      this.OFDinputCurr = new System.Windows.Forms.OpenFileDialog();
      this.txtBatFile = new System.Windows.Forms.TextBox();
      this.btnCalc = new System.Windows.Forms.Button();
      this.txtExcelMailFile = new System.Windows.Forms.TextBox();
      this.btnExcelMailFile = new System.Windows.Forms.Button();
      this.OFDexcelMailFile = new System.Windows.Forms.OpenFileDialog();
      this.txtOutMailList = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.txtBlackMailFile = new System.Windows.Forms.TextBox();
      this.button2 = new System.Windows.Forms.Button();
      this.SS1.SuspendLayout();
      this.SuspendLayout();
      // 
      // SS1
      // 
      this.SS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SSlbl1,
            this.toolStripStatusLabel1});
      this.SS1.Location = new System.Drawing.Point(0, 484);
      this.SS1.Name = "SS1";
      this.SS1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
      this.SS1.Size = new System.Drawing.Size(542, 25);
      this.SS1.TabIndex = 49;
      this.SS1.Text = "statusStrip1";
      // 
      // SSlbl1
      // 
      this.SSlbl1.Name = "SSlbl1";
      this.SSlbl1.Size = new System.Drawing.Size(0, 20);
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(169, 20);
      this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
      // 
      // btnBatFile
      // 
      this.btnBatFile.Location = new System.Drawing.Point(14, 8);
      this.btnBatFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnBatFile.Name = "btnBatFile";
      this.btnBatFile.Size = new System.Drawing.Size(119, 32);
      this.btnBatFile.TabIndex = 46;
      this.btnBatFile.Text = "Bat-file...";
      this.btnBatFile.UseVisualStyleBackColor = true;
      this.btnBatFile.Click += new System.EventHandler(this.btnBatFile_Click);
      // 
      // OFDinputCurr
      // 
      this.OFDinputCurr.Title = "Input file";
      this.OFDinputCurr.FileOk += new System.ComponentModel.CancelEventHandler(this.OFDinputCurr_FileOk);
      // 
      // txtBatFile
      // 
      this.txtBatFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtBatFile.Location = new System.Drawing.Point(143, 11);
      this.txtBatFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.txtBatFile.Name = "txtBatFile";
      this.txtBatFile.ReadOnly = true;
      this.txtBatFile.Size = new System.Drawing.Size(374, 26);
      this.txtBatFile.TabIndex = 48;
      this.txtBatFile.TabStop = false;
      // 
      // btnCalc
      // 
      this.btnCalc.Location = new System.Drawing.Point(14, 193);
      this.btnCalc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnCalc.Name = "btnCalc";
      this.btnCalc.Size = new System.Drawing.Size(119, 45);
      this.btnCalc.TabIndex = 47;
      this.btnCalc.Text = "Proceed";
      this.btnCalc.UseVisualStyleBackColor = true;
      this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
      // 
      // txtExcelMailFile
      // 
      this.txtExcelMailFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtExcelMailFile.Location = new System.Drawing.Point(143, 58);
      this.txtExcelMailFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.txtExcelMailFile.Name = "txtExcelMailFile";
      this.txtExcelMailFile.ReadOnly = true;
      this.txtExcelMailFile.Size = new System.Drawing.Size(374, 26);
      this.txtExcelMailFile.TabIndex = 48;
      this.txtExcelMailFile.TabStop = false;
      this.txtExcelMailFile.Text = "H:\\G\\mmosh\\Messages\\contacts_yandex_mmosh.xls";
      // 
      // btnExcelMailFile
      // 
      this.btnExcelMailFile.Location = new System.Drawing.Point(14, 54);
      this.btnExcelMailFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnExcelMailFile.Name = "btnExcelMailFile";
      this.btnExcelMailFile.Size = new System.Drawing.Size(119, 32);
      this.btnExcelMailFile.TabIndex = 46;
      this.btnExcelMailFile.Text = "Excel mail file...";
      this.btnExcelMailFile.UseVisualStyleBackColor = true;
      this.btnExcelMailFile.Click += new System.EventHandler(this.btnExcelMailFile_Click);
      // 
      // OFDexcelMailFile
      // 
      this.OFDexcelMailFile.Filter = "Excel file|*.xls*";
      this.OFDexcelMailFile.Title = "Input file";
      // 
      // txtOutMailList
      // 
      this.txtOutMailList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtOutMailList.Location = new System.Drawing.Point(143, 104);
      this.txtOutMailList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.txtOutMailList.Name = "txtOutMailList";
      this.txtOutMailList.Size = new System.Drawing.Size(374, 26);
      this.txtOutMailList.TabIndex = 48;
      this.txtOutMailList.TabStop = false;
      this.txtOutMailList.Text = "H:\\G\\mmosh\\Messages\\broadcast\\tf.txt";
      // 
      // button1
      // 
      this.button1.Enabled = false;
      this.button1.Location = new System.Drawing.Point(14, 100);
      this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(119, 32);
      this.button1.TabIndex = 46;
      this.button1.Text = "Output mail file";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.btnExcelMailFile_Click);
      // 
      // txtBlackMailFile
      // 
      this.txtBlackMailFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtBlackMailFile.Location = new System.Drawing.Point(143, 147);
      this.txtBlackMailFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.txtBlackMailFile.Name = "txtBlackMailFile";
      this.txtBlackMailFile.Size = new System.Drawing.Size(374, 26);
      this.txtBlackMailFile.TabIndex = 48;
      this.txtBlackMailFile.TabStop = false;
      this.txtBlackMailFile.Text = "H:\\G\\mmosh\\Messages\\blackemails.txt";
      // 
      // button2
      // 
      this.button2.Enabled = false;
      this.button2.Location = new System.Drawing.Point(14, 143);
      this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(119, 32);
      this.button2.TabIndex = 46;
      this.button2.Text = "Black mail file";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(542, 509);
      this.Controls.Add(this.SS1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.btnExcelMailFile);
      this.Controls.Add(this.btnBatFile);
      this.Controls.Add(this.txtBlackMailFile);
      this.Controls.Add(this.txtOutMailList);
      this.Controls.Add(this.txtExcelMailFile);
      this.Controls.Add(this.txtBatFile);
      this.Controls.Add(this.btnCalc);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.SS1.ResumeLayout(false);
      this.SS1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.StatusStrip SS1;
    private System.Windows.Forms.ToolStripStatusLabel SSlbl1;
    private System.Windows.Forms.Button btnBatFile;
    private System.Windows.Forms.OpenFileDialog OFDinputCurr;
    private System.Windows.Forms.TextBox txtBatFile;
    private System.Windows.Forms.Button btnCalc;
    private System.Windows.Forms.TextBox txtExcelMailFile;
    private System.Windows.Forms.Button btnExcelMailFile;
    private System.Windows.Forms.OpenFileDialog OFDexcelMailFile;
    private System.Windows.Forms.TextBox txtOutMailList;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.TextBox txtBlackMailFile;
    private System.Windows.Forms.Button button2;
  }
}

