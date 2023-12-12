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
    public partial class FormAuthorization : Form
    {
        public static User EnterUser;

        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnterUser = null;
            Model1 model = new Model1();

            EnterUser = model.Users.FirstOrDefault(x => x.Login == textBox1.Text && x.Password == textBox2.Text);

            if (EnterUser != null)
            {
                switch (EnterUser.RoleID)
                {
                    case 1:
                        var formManager = new FormManager();
                        formManager.ShowDialog();
                        break;
                    case 2:
                        var formSeller = new FormSeller();
                        formSeller.ShowDialog();
                        break;
                    case 3:
                        var formDirector = new FormDirector();
                        formDirector.ShowDialog();
                        break;
                    default:
                        throw new Exception("Роль не найдена!");
                }
            }
        }
    }
}
