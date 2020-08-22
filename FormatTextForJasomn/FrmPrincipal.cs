using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormatTextForJasomn
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            AddLog("Insira a legenda completa...");
        }

        private void btnFormatText_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTextInput.Text == "")
                    return;

                string sText = txtTextInput.Text;
                char[] trimChars = { '"', '(', ')', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ':' };
                for (int i = 0; i < trimChars.Length; i++)
                {
                    sText = sText.Replace(trimChars[i], '$');

                }

                sText = sText.Replace("$", "");
                sText = sText.Replace("\r", "");
                sText = sText.Replace("\n", "");
                sText = sText.Replace("\r\n", "");


                string sPathFile = Directory.GetCurrentDirectory() + @"\BodyJson.txt";
                if (File.Exists(sPathFile))
                    File.Delete(sPathFile);

                using (StreamWriter stw = new StreamWriter(sPathFile))
                {
                    stw.WriteLine(sText);
                    stw.AutoFlush = true;
                    stw.Close();
                }

                AddLog("Arquivo gerado, caminho:" + sPathFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(":(", "Erro: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddLog(string Line)
        {
            string sMili = "000" + DateTime.Now.Millisecond.ToString();
            sMili = sMili.Substring(sMili.Length - 3, 3);
            string sLinha = String.Format("{0:HH:mm:ss}", DateTime.Now) + "." + sMili + " - " + Line;

            if (txtLog.Lines.Length > 10)
                txtLog.Clear();
            txtLog.Text += sLinha.Replace("\0", "") + "\r\n";
            if (txtLog.Text.Length > 0)
            {
                txtLog.Select(txtLog.Text.Length - 1, 0);
                txtLog.ScrollToCaret();
            }
        }
    }
}
