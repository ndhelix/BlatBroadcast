using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace BlatBroadcast
{
  public partial class Form1 : Form
  {
    DataTable dtMail;
    public Form1()
    {
      InitializeComponent();
    }

    private void OFDinputCurr_FileOk(object sender, CancelEventArgs e)
    {

    }

    private void btnBatFile_Click(object sender, EventArgs e)
    {
      if (OFDinputCurr.ShowDialog() == DialogResult.OK)
      {
        txtBatFile.Text = OFDinputCurr.FileName;
      }

    }

    private void btnExcelMailFile_Click(object sender, EventArgs e)
    {
      if (OFDexcelMailFile.ShowDialog() == DialogResult.OK)
      {
        txtExcelMailFile.Text = OFDexcelMailFile.FileName;
      }

    }

    private void btnCalc_Click(object sender, EventArgs e)
    {
      dtMail = CommonUnit.Converter.xls2dt(txtExcelMailFile.Text, "main", "*");
      SendMail();
    }
    
    void SendMail()
    {
      HashSet<string> emails = new HashSet<string>();

      int i = 0;
      string s = "";
      foreach (DataRow dr in dtMail.DefaultView.ToTable(true, "email").Select())
      {
        emails.Add(dr["email"].ToString().ToLower());
      }
      RemoveBlackEmails(ref emails);
      foreach (string email in emails)
      {
        s += email + "\r\n";
        if (++i == 10)
        {
          i = 0;
          File.WriteAllText(txtOutMailList.Text, s);
          RunBatFile();
          Thread.Sleep(30*1000);
          toolStripStatusLabel1.Text = s;
          Application.DoEvents();
          s = "";
        }
      }
      if (i != 10)
      {
        File.WriteAllText(txtOutMailList.Text, s);
        Thread.Sleep(10 * 1000);
        RunBatFile();
      }
    }

    private void RemoveBlackEmails(ref HashSet<string> emails)
    {
      string blackemails = File.ReadAllText(txtBlackMailFile.Text);
      string[] divider = { "\r\n" };
      foreach (string blackemail in blackemails.Split(divider, StringSplitOptions.RemoveEmptyEntries))
      {
        emails.Remove(blackemail);
      }
    }



    void RunBatFile()
    {
      Process proc = new Process();
      proc.StartInfo.FileName = txtBatFile.Text;
      proc.StartInfo.UseShellExecute = false;
      proc.StartInfo.RedirectStandardError = true;
      proc.StartInfo.RedirectStandardOutput = true;
      proc.StartInfo.CreateNoWindow = true;
      proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
      proc.StartInfo.UseShellExecute = false;
      proc.Start();
      string error = proc.StandardError.ReadToEnd();
      string strout = proc.StandardOutput.ReadToEnd();
      proc.WaitForExit(5 * 1000);
      string msg = string.Format("{3} : {0}{1}{2}{1}", strout, "\r\n", error, DateTime.Now);
      File.AppendAllText(proc.StartInfo.FileName + ".log", msg);
    }

  }
}
