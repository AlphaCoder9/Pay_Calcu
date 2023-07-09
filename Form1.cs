using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnComputePay_Click(object sender, EventArgs e)
        {


        }

        private void btnComputePay_Click_1(object sender, EventArgs e)
        {
            // first create one object of employee
            // than read data from the text boxes and compy to employee object
            // then call ComputePay in Employee object and display results
            Employee emp = new Employee();
            emp.FirstName = txtFirstName.Text;
            emp.LastName = txtLastName.Text;
            emp.HoursWorked = double.Parse(txtHoursWorked.Text);
            emp.PayRate = double.Parse(txtPayRate.Text);

            double pay = emp.ComputePay();
            lblPay.Text = pay.ToString();


        }
    }
}
