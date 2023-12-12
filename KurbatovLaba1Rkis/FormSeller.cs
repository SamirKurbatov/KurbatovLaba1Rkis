using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KurbatovLaba1Rkis
{
    public partial class FormSeller : Form
    {
        public FormSeller()
        {
            InitializeComponent();
        }

        private void FormSeller_Load(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            label2.Text = FormAuthorization.EnterUser.First_Name + " " + FormAuthorization.EnterUser.Second_Name;
            label3.Text = model.Roles.FirstOrDefault(x => x.ID == FormAuthorization.EnterUser.RoleID).Name;
            pictureBox1.Image = Image.FromFile($@"Photo\{FormAuthorization.EnterUser.Pictures}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
