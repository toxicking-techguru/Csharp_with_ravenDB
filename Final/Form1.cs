using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Raven.Client;
using Raven.Client.Documents;
using Raven.Client.Documents.Session;
namespace Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            var docstore = new DocumentStore
            { Database = "Message", Urls = new[] { "http://localhost:8080" } };
            docstore.Initialize();
            using (var session = docstore.OpenSession())
            {
                var number = session.Load<Id>("1");
                double a = number.ParentNo;

            }
            using (var session = docstore.OpenSession())
            {
                session.Store(new Id
                {
                    ParentNo = +1111353272,
                });

                session.SaveChanges();
            }


            InitializeComponent();
            comboBox2.Items.Add("Charles Boateng");comboBox2.Items.Add("James Blunt"); comboBox2.Items.Add("Joseph");comboBox2.Items.Add("Paul Scholes");comboBox2.Items.Add("Neli Amstrong");comboBox2.Items.Add("Amy Farowawler");comboBox2.Items.Add("Joseph Davies");comboBox2.Items.Add("Kentucky"); comboBox2.Items.Add("Taylor swift"); comboBox1.Items.Add("IN");comboBox1.Items.Add("OUT");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.DarkGray;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "IN")
                MessageBox.Show("MESSAGE SENT ", "STUDENT IN",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else if (comboBox1.Text == "OUT")
                MessageBox.Show("MESSAGE SENT", "STUDENT OUT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private class Id
        {
            public long ParentNo { get; set; }
        }
    }
}
