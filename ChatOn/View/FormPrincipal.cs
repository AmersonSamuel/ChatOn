using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatOn.View
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEscolhaCadLog());
        }

        private void picBoxLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }


            // Reexibe os controles originais em splitContainer1.Panel2
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(btnIniciar);
        }


        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();

            activeForm = childForm;
        }

        private void picBoxLogo_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }

            // Limpa os controles do formulário filho, se houver algum
            splitContainer1.Panel2.Controls.Clear();

            // Reexibe os controles originais em splitContainer1.Panel2
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(btnIniciar);
            splitContainer1.Panel2.Controls.SetChildIndex(btnIniciar, 0);
        }
    }
}
