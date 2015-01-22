using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class MyForm : Form
    {
        private DataEntry[] myData = new DataEntry[100];
        private int entries = 2;
        private Boolean silenced = false;
        public MyForm()
        {
            InitializeComponent();
            
        }
        private void MyForm_Load(object sender, EventArgs e)
        {
            scheduleTimer.Interval = 5000;
            scheduleTimer.Start();
            Label title1 = new Label();
            title1.Text = "Name";
            title1.BackColor = Color.BlanchedAlmond;
            Label title2 = new Label();
            title2.Text = "Address";
            title2.BackColor = Color.BlanchedAlmond;
            Label title3 = new Label();
            title3.Text = "Phone Number";
            title3.BackColor = Color.BlanchedAlmond;
            viewTable.Controls.Add(title1);
            viewTable.Controls.Add(title2);
            viewTable.Controls.Add(title3);

            myData[0] = new DataEntry("ME", "110 St", 1000,new DateTime(2015,1,10));
            myData[1] = new DataEntry("HIM", "112 St", 1001, new DateTime(2015, 1, 10));
            for (int i = 0; i < entries; i++)
            {
                Label name = new Label();
                Label name2 = new Label();
                Label address = new Label();
                Label num = new Label();
                Label date = new Label();
                name.Text = myData[i].name;
                name2.Text = myData[i].name;
                address.Text = myData[i].address;
                num.Text = myData[i].phoneNumber.ToString();
                date.Text = myData[i].startDate.AddDays(7).ToLongDateString();
                viewTable.Controls.Add(name);
                viewTable.Controls.Add(address);
                viewTable.Controls.Add(num);
                scheduleTable.Controls.Add(name2);
                scheduleTable.Controls.Add(date);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void leaveChanged(object sender, EventArgs e)
        {
            leaveEnd.Text = (leaveStart.Value.AddDays(7)).ToLongDateString();
        }
        private void onEntered(object sender, EventArgs e)
        {
            //Error Prone
            try
            {
                myData[entries] = new DataEntry(firstNameBox.Text, addressBox.Text, Convert.ToInt32(homeNumberBox.Text),leaveStart.Value);
                Label name = new Label();
                Label name2 = new Label();
                Label address = new Label();
                Label num = new Label();
                Label date = new Label();
                name.Text = myData[entries].name;
                name2.Text = myData[entries].name;
                address.Text = myData[entries].address;
                num.Text = myData[entries].phoneNumber.ToString();
                date.Text = myData[entries].startDate.AddDays(7).ToLongDateString();
                viewTable.Controls.Add(name);
                viewTable.Controls.Add(address);
                viewTable.Controls.Add(num);
                scheduleTable.Controls.Add(name2);
                scheduleTable.Controls.Add(date);
                entries++;
            }
            catch (Exception exn) { }
            
        }

        private void scheduleCheck(object sender, EventArgs e)
        {
            for (int i = 0; i < entries; i++)
            {
                if (myData[i].startDate.AddDays(7).ToLongDateString() == DateTime.Today.ToLongDateString())
                {

                    if (!silenced)
                    {
                        pendingDocuments.Visible = true;
                    }
                }
            }
        }

        private void documentNotify_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void alertSilence(object sender, EventArgs e)
        {
            pendingDocuments.Visible = false;
            silenced = true;
        }

    }
    public class DataEntry
    {
        public String name;
        public String address;
        public int phoneNumber;
        public DateTime startDate;
        public DataEntry(String myName, String myAddress, int myNumber, DateTime date)
        {
            this.name = myName;
            this.address = myAddress;
            this.phoneNumber = myNumber;
            this.startDate = date;
        }
    }
}
