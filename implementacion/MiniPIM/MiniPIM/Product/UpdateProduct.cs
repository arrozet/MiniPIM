using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPIM.Product
{
    public partial class UpdateProductControl : UserControl
    {
        public UpdateProductControl()
        {
            InitializeComponent();
        }

        private void BtnLoadThumbnail_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg)|*.jpg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxThumbnail.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        
    }
}
