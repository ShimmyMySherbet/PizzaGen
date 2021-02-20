using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaGen
{
    public partial class Renderer : Form
    {
        public RenderClient RenderClient = new RenderClient();
        public Renderer()
        {
            InitializeComponent();
        }

        private void txtVal_TextChanged(object sender, EventArgs e)
        {
            SendRender();
        }

        public void SendRender()
        {
            Image rd = RenderClient.Render(txtVal.Text);
            pbViewPort.Image = rd;
        }



        private void btnFont_Click(object sender, EventArgs e)
        {
            if (FDSelect.ShowDialog() == DialogResult.OK)
            {
                RenderClient.font = FDSelect.Font;
                Font NF = new Font(FDSelect.Font.FontFamily, 16);
                lblFontStyle.Font = NF;
                SendRender();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (SFDSave.ShowDialog() == DialogResult.OK)
            {
                using(FileStream NewStream = new FileStream(SFDSave.FileName, FileMode.OpenOrCreate))
                {
                    RenderClient.RenderToStream(txtVal.Text, NewStream);
                    NewStream.Close();
                }

            }
        }

        private void Renderer_Load(object sender, EventArgs e)
        {
            RenderClient.font = Font;
        }
    
    }
}
