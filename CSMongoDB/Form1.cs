using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using System.Reflection;


namespace CSMongoDB
{
    public partial class CSMongoDB : Form
    {

        private static string serverAddr = "mongodb://localhost:27017";
        private string dbName = "mytest";
        private string cName = "testcol";
        private string customCName = "customcol";

        private int outputNum1;
        public CSMongoDB()
        {   
            InitializeComponent();

            titleLbl.Text = "CSharp MongoDB";
            serverLbl.Text = " "; // No Server
            clientLbl.Text = "CLIENT " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + "";
            panelCustom.Visible = false;
            panelIN.Visible = false;
        }

        // Moving Form With Mouse
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        /*
        private bool checkMyTbs(TextBox nameTb)
        {
            if (nameTb.Text.Length == 0)
            {
                return true;
            } 
            else
            {
                return false;
            }
            
        }
        */

        // Form Events
        private void minimizeLbl_MouseLeave(object sender, EventArgs e)
        {
            minimizeLbl.BackColor = Color.FromArgb(55, 42, 105);
        }

        private void minimizeLbl_MouseMove(object sender, MouseEventArgs e)
        {
            minimizeLbl.BackColor = Color.FromArgb(75, 62, 125);
        }

        private void closeLbl_MouseMove(object sender, MouseEventArgs e)
        {
            closeLbl.BackColor = Color.FromArgb(75, 62, 125);
        }

        private void closeLbl_MouseLeave(object sender, EventArgs e)
        {
            closeLbl.BackColor = Color.FromArgb(55, 42, 105);
        }

        private void closeLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeLbl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }




        // Operation Events
        
        MongoClient dbClient = new MongoClient(serverAddr);
        private void btnShowall_Click(object sender, EventArgs e)
        {

            tbResult.Text = String.Empty; // Khali Kon Result Ro.
            var database = dbClient.GetDatabase(dbName);
            var collection = database.GetCollection<BsonDocument>(cName);
            var documents = collection.Find(new BsonDocument()).ToList();
            foreach (BsonDocument doc in documents)
            {
                tbResult.Text += doc.ToString() + Environment.NewLine;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (tbGetID.Text.Length != 0)
            {
                try
                {
                    outputNum1 = Convert.ToInt32(tbGetID.Text);
                }
                catch
                {
                    MessageBox.Show("Only ID Number","Error");
                    return;
                }
            } else
            {
                MessageBox.Show("Enter Value And Try AGAIN !", "Error");
                return;
            }
            tbResult.Text = String.Empty;
            var database = dbClient.GetDatabase(dbName);
            if (!cbCustom.Checked)
            {
                
                var collection = database.GetCollection<BsonDocument>(cName);
                var filter = Builders<BsonDocument>.Filter.Eq("id", outputNum1);
                var document = collection.Find(filter).FirstOrDefault();
                if (document == null)
                {
                    MessageBox.Show("Value Invalid", "Error");
                    return;
                }
                tbResult.Text = document.ToString();
            } else
            {
                var collection = database.GetCollection<BsonDocument>(customCName);
                var filter = Builders<BsonDocument>.Filter.Eq("id", outputNum1);
                var document = collection.Find(filter).FirstOrDefault();
                if (document == null)
                {
                    MessageBox.Show("Value Invalid", "Error");
                    return;
                }
                tbResult.Text = document.ToString();
            }
            tbGetID.Text = String.Empty;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (tbID.Text.Length == 0 || tbFname.Text.Length == 0 || tbLname.Text.Length == 0 || tbAge.Text.Length == 0 )
            {
                MessageBox.Show("Please fill all fields and try again.","Error Data Fields");
                return;
            }
            // MY OLD WAY :)
            /*
            bool State = checkMyTbs(tbID);
            if (State)
            {
                return;
            }
            */



            // Disable Interactions To Prevent Spam
            tbID.Enabled = false;
            tbFname.Enabled = false;
            tbLname.Enabled = false;
            tbAge.Enabled = false;

            btnInsert.Enabled = false;
            btnShow.Enabled = false;
            btnShowall.Enabled = false;
            btnUpdate.Enabled = false;

            var database = dbClient.GetDatabase(dbName);
            if (!cbCustom.Checked)
            {
                var collection = database.GetCollection<BsonDocument>(cName);
                var filter = Builders<BsonDocument>.Filter.Eq("id", int.Parse(tbID.Text));
                var document = collection.Find(filter).FirstOrDefault();
                if (document == null)
                {
                    var addDc = new BsonDocument {
                        { "id", int.Parse(tbID.Text) },
                        { "first_name",tbFname.Text  },
                        { "last_name", tbLname.Text },
                        { "age", int.Parse(tbAge.Text) }
                    };
                    var collec = database.GetCollection<BsonDocument>(cName);
                    collec.InsertOneAsync(addDc);
                    MessageBox.Show("Success", "COMPLETE");
                }
                else if (document != null)
                {
                    MessageBox.Show("This id is already taken , please try again with new ID.", "ERROR");
                }
            } 
            else
            {
                if (tbC1.Text.Length == 0 || tbC2.Text.Length == 0 || tbC3.Text.Length == 0 )
                {
                    MessageBox.Show("Please fill up fields.", "Error Name Fields");
                    return;
                }
                var collection = database.GetCollection<BsonDocument>(customCName);
                var filter = Builders<BsonDocument>.Filter.Eq("id", int.Parse(tbID.Text));
                var document = collection.Find(filter).FirstOrDefault();
                if (document == null)
                {

                    var addDc = new BsonDocument {
                        { "id", int.Parse(tbID.Text) },
                        { tbC1.Text, tbFname.Text  },
                        { tbC2.Text, tbLname.Text },
                        { tbC3.Text, tbAge.Text }
                    };
                    var collec = database.GetCollection<BsonDocument>(customCName);
                    collec.InsertOneAsync(addDc);
                    MessageBox.Show("Success", "COMPLETE (Custom)");
                }
                else if (document != null)
                {
                    MessageBox.Show("This id is already taken , please try again with new ID.", "ERROR");
                }
            }


            // Prepare For New Operation
            tbID.Enabled = true;
            tbFname.Enabled = true;
            tbLname.Enabled = true;

            tbAge.Enabled = true;
            btnInsert.Enabled = true;
            btnShow.Enabled = true;
            btnShowall.Enabled = true;
            btnUpdate.Enabled = true;

            tbID.Text = String.Empty;
            tbFname.Text = String.Empty;
            tbLname.Text = String.Empty;
            tbAge.Text = String.Empty;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbID.Text.Length == 0 || tbFname.Text.Length == 0 || tbLname.Text.Length == 0 || tbAge.Text.Length == 0)
            {
                MessageBox.Show("Please fill up fields.", "Error Data Fields");
                return;
            }
            var database = dbClient.GetDatabase(dbName);
            if (!cbCustom.Checked)
            {
                var collection = database.GetCollection<BsonDocument>(cName);
                var filter = Builders<BsonDocument>.Filter.Eq("id", int.Parse(tbID.Text));
                var update = Builders<BsonDocument>.Update
                    .Set("first_name", tbFname.Text)
                    .Set("last_name", tbLname.Text)
                    .Set("age", int.Parse(tbAge.Text));
                var result = collection.UpdateMany(filter, update);
            } else
            {
                //var updatefields = Builders<BsonDocument>.Update.Rename("firstname", "lastname");
                var collection = database.GetCollection<BsonDocument>(customCName);
                var filter = Builders<BsonDocument>.Filter.Eq("id", int.Parse(tbID.Text));
                var update = Builders<BsonDocument>.Update
                    .Set(tbC1.Text, tbFname.Text)
                    .Set(tbC2.Text, tbLname.Text)
                    .Set(tbC3.Text, tbAge.Text);
                var result = collection.UpdateMany(filter, update);

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tbGetID.Text.Length != 0)
            {
                var database = dbClient.GetDatabase(dbName);
                if (!cbCustom.Checked)
                {
                    var collection = database.GetCollection<BsonDocument>(cName);
                    var deleteFilter = Builders<BsonDocument>.Filter.Eq("id", int.Parse(tbGetID.Text));
                    collection.DeleteOne(deleteFilter);
                } else
                {
                    var collection = database.GetCollection<BsonDocument>(customCName);
                    var deleteFilter = Builders<BsonDocument>.Filter.Eq("id", int.Parse(tbGetID.Text));
                    collection.DeleteOne(deleteFilter);
                }
                MessageBox.Show("The Record ID " + tbGetID.Text.ToString() + " Deleted!","COMPLETE");
            } else
            {
                MessageBox.Show("Missing ID","Error");
            }
        }

        private void cbCustom_CheckedChanged(object sender, EventArgs e)
        {
            panelCustom.Visible = !panelCustom.Visible;
            panelIN.Visible = !panelIN.Visible;
        }

        
    }
}
