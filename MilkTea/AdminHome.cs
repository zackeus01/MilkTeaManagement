using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.InkML;
using Microsoft.Data.SqlClient;
using MilkTea.Models;

namespace MilkTeaManagement
{
	public partial class AdminHome : Form
	{
		private readonly MilkteaDBContext db = new MilkteaDBContext();

		public AdminHome()
		{
			InitializeComponent();
		}

		private void AdminHome_Load(object sender, EventArgs e)
		{
			var totalOrder = db.Orders.Count();
			label4.Text = totalOrder.ToString();

			var totalProduct = db.Products.Count();
			label5.Text = totalProduct.ToString();


		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
