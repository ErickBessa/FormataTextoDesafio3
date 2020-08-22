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
            AddLog("Insira as informacoes...");
            lbxType.Items.Add("video");
            lbxType.Items.Add("article");
        }

        private bool checkControls()
        {

            bool bOk = true;
            if (txtTitle.Text == "")
                bOk = false;

            if (txtAuthor.Text == "")
                bOk = false;

            if (txtTextInput.Text == "")
                bOk = false;

            if (txtUrl.Text == "")
                bOk = false;

            if (lbxType.SelectedItem == null)
                bOk = false;

            if (!bOk)
            {
                MessageBox.Show(":l", "Preencha todos os campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            return bOk;
        }

        private void btnFormatText_Click(object sender, EventArgs e)
        {
            try
            {

                if (!checkControls())
                    return;

                StringBuilder text = new StringBuilder();
                text.Append("{\r\n");
                text.Append("\"title\":\"" + txtTitle.Text + "\",\r\n");
                text.Append("\"author\":\"" + txtAuthor.Text + "\",\r\n");

                string sText = txtTextInput.Text;
                char[] trimChars = { '"' };
                for (int i = 0; i < trimChars.Length; i++)
                {
                    sText = sText.Replace(trimChars[i], '$');
                }

                sText = sText.Replace("$", "");
                sText = sText.Replace("\r", "");
                sText = sText.Replace("\n", "");
                sText = sText.Replace("\r\n", "");

                text.Append("\"body\":\"" + sText + "\",\r\n");
                text.Append("\"type\":\"" + lbxType.SelectedItem + "\",\r\n");
                text.Append("\"url\":\"" + txtUrl.Text + "\"\r\n");
                text.Append("}");

                string sPathFile = Directory.GetCurrentDirectory() + $@"\{txtTitle.Text }.JSON";
                if (File.Exists(sPathFile))
                    File.Delete(sPathFile);

                using (StreamWriter stw = new StreamWriter(sPathFile))
                {
                    stw.WriteLine(text.ToString());
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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
