using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Handler
{
    public partial class CodeImport : Form
    {
        public CodeImport()
        {
            InitializeComponent();
        }

        private void btnProcessCodes_Click(object sender, EventArgs e)
        {
            int codecount = 0;
            Dictionary<string, RichTextBox> b = new Dictionary<string, RichTextBox>();
            b.Add(CodeHandlerForm.CAMO, camocodesRT);
            b.Add(CodeHandlerForm.CONTAINER, cccodesRT);
            b.Add(CodeHandlerForm.OTHER, othercodesRT);

            foreach(KeyValuePair<string,RichTextBox> box in b)
            {

                string[] codelist = GetText(box.Value);
                foreach(string c in codelist)
                {
                    if ( !c.Equals(""))
                    {
                        Code code = new Code() { Category=box.Key,ID=c,IsDeleted=false,OnHold=false};
                        Program.AllCodes.Add(code);
                        codecount++;
                    }
                }

            }
            MessageBox.Show("All codes has been processed: " + codecount + " codes has been imported", "Importing Codes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private string[] GetText(RichTextBox codeBox)
        {
            codeBox.SelectAll();
            codeBox.Focus();
            return codeBox.SelectedText.Split('\n');
        }
    }
}
