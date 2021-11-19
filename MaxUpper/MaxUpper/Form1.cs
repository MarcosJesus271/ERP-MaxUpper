using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace MaxUpper
{
    public partial class Form1 : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "qsNOhPK7cJxme95EdJvWpef8bnbA2jWXC8CD7rmQ",
            BasePath = "https://maxupper-a687d-default-rtdb.firebaseio.com/"

        };

        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
        }

       
        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            client = new FireSharp.FirebaseClient(config);

                if (client != null)
            {
                lblConnStatus.Text = "Connected";
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
             Loading _load = new Loading();
            _load.Show();
            

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private async Task guna2Button2_ClickAsync(object sender, EventArgs e)
        {
            
        }
    }
}
