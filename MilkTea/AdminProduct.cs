using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using MilkTea.Models;

namespace MilkTea
{
	public partial class AdminProduct : Form
	{
		Account acc;
		public int AccountId { get; set; }
		public AdminProduct()
		{
			InitializeComponent();
			txtId.Enabled = false;
		}

        public AdminProduct(Account ac)
        {
            InitializeComponent();
            txtId.Enabled = false;
			acc = ac;
			AccountId = acc.AccountId;
        }

        private void AdminProduct_Load(object sender, EventArgs e)
		{
			using (var db = new MilkteaDBContext())
			{
				LoadProduct();
			}

		}

		private void LoadProduct()
		{
			using (var db = new MilkteaDBContext())
			{
				dgvAdProduct.AutoGenerateColumns = false;
				dgvAdProduct.Columns.Clear();
				dgvAdProduct.DataSource = null;

				var empProduct = db.Products.Select(e => new
				{
					id = e.ProductId,
					name = e.ProductName,
					category = e.Category.CategoryName,
					quantity = e.Quantity,
					price = e.Price,
					origin = e.Origin,
					manager = e.Manager.Name,
					image = e.Image
				}).ToList();
				dgvAdProduct.DataSource = empProduct;

				DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
				id.Name = "id";
				id.HeaderText = "Product ID";
				id.DataPropertyName = "id";

				DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
				name.Name = "name";
				name.HeaderText = "Product Name";
				name.DataPropertyName = "name";

				DataGridViewTextBoxColumn category = new DataGridViewTextBoxColumn();
				category.Name = "category";
				category.HeaderText = "Category";
				category.DataPropertyName = "category";

				DataGridViewTextBoxColumn quantity = new DataGridViewTextBoxColumn();
				quantity.Name = "quantity";
				quantity.HeaderText = "Quantity";
				quantity.DataPropertyName = "quantity";

				DataGridViewTextBoxColumn price = new DataGridViewTextBoxColumn();
				price.Name = "price";
				price.HeaderText = "Price";
				price.DataPropertyName = "price";

				DataGridViewTextBoxColumn origin = new DataGridViewTextBoxColumn();
				origin.Name = "origin";
				origin.HeaderText = "Origin";
				origin.DataPropertyName = "origin";

				DataGridViewTextBoxColumn image = new DataGridViewTextBoxColumn();
				image.Name = "image";
				image.HeaderText = "Image";
				image.DataPropertyName = "image";

				DataGridViewTextBoxColumn manager = new DataGridViewTextBoxColumn();
				manager.Name = "manager";
				manager.HeaderText = "Manager";
				manager.DataPropertyName = "manager";

				DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
				delete.Name = "delete";
				delete.HeaderText = "Action";
				delete.Text = "Delete";
				delete.UseColumnTextForButtonValue = true;

				dgvAdProduct.Columns.Add(id);
				dgvAdProduct.Columns.Add(name);
				dgvAdProduct.Columns.Add(category);
				dgvAdProduct.Columns.Add(quantity);
				dgvAdProduct.Columns.Add(price);
				dgvAdProduct.Columns.Add(origin);
				dgvAdProduct.Columns.Add(image);
				dgvAdProduct.Columns.Add(manager);
				dgvAdProduct.Columns.Add(delete);

				var categoryName = db.Categories.Select(x => x.CategoryName).ToList();
				cbCategory.DataSource = categoryName;
				cbCategory.SelectedIndex = -1;

				var filter = db.Categories.Select(x => x.CategoryName).ToList();
				cbFilter.DataSource = filter;
				cbFilter.SelectedIndex = -1;

				var managers = db.Accounts.Where(y => y.RoleId == 2).Select(x => x.Name).ToList();
				cbManager.DataSource = managers;
				cbManager.SelectedIndex = -1;
			}
		}

		private void dgvAdProduct_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			using (var db = new MilkteaDBContext())
			{
				if (e.RowIndex >= 0 && e.RowIndex < dgvAdProduct.Rows.Count && e.ColumnIndex >= 0)
				{
					txtId.Enabled = false;
					var id = dgvAdProduct.Rows[e.RowIndex].Cells["id"].Value.ToString();
					var name = dgvAdProduct.Rows[e.RowIndex].Cells["name"].Value.ToString();
					var category = dgvAdProduct.Rows[e.RowIndex].Cells["category"].Value.ToString();
					var quantity = Convert.ToInt32(dgvAdProduct.Rows[e.RowIndex].Cells["quantity"].Value);
					var price = dgvAdProduct.Rows[e.RowIndex].Cells["price"].Value.ToString();
					var origin = dgvAdProduct.Rows[e.RowIndex].Cells["origin"].Value.ToString();
					var imagePath = dgvAdProduct.Rows[e.RowIndex].Cells["image"].Value.ToString();


					txtId.Text = id;
					txtName.Text = name;
					cbCategory.DataSource = db.Categories.Select(x => x.CategoryName).ToList();
					cbCategory.SelectedItem = category;
					nudQuantity.Value = quantity;
					txtPrice.Text = price;
					txtOrigin.Text = origin;
					txtImage.Text = imagePath;
					byte[] imageData = File.ReadAllBytes(imagePath);
					Image image;
					using (MemoryStream ms = new MemoryStream(imageData))
					{
						image = Image.FromStream(ms);
					}
					pbImage.Image = image; // Set the image for the PictureBox
					pbImage.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust the image size mode if needed
				}
			}
		}


		private bool IsValid()
		{
			bool flag = true;
			string msg = "";
			// Check Name
			if (string.IsNullOrWhiteSpace(txtName.Text))
			{
				flag = false;
				msg += "Product Name is required.\n";
			}
			else
			{
				using (var db = new MilkteaDBContext())
				{
					// Retrieve all products from the database
					var products = db.Products.ToList();
					// Check if name already exists (case-insensitive)
					var existingProduct = products.FirstOrDefault(p => p.ProductName.Equals(txtName.Text, StringComparison.OrdinalIgnoreCase));
					if (existingProduct != null)
					{
						flag = false;
						msg += "Product Name already exists.\n";
					}
				}
			}
			// Check Price
			if (string.IsNullOrWhiteSpace(txtPrice.Text))
			{
				flag = false;
				msg += "Price is required.\n";
			}
			else
			{
				int price;
				if (!int.TryParse(txtPrice.Text, out price) || price <= 1000)
				{
					flag = false;
					msg += "Price must be an integer greater than 1000.\n";
				}
			}
			// Check Origin
			if (string.IsNullOrWhiteSpace(txtOrigin.Text))
			{
				flag = false;
				msg += "Origin is required.\n";
			}
			// Check Image Path
			if (string.IsNullOrWhiteSpace(txtImage.Text))
			{
				flag = false;
				msg += "Image Path is required.\n";
			}
			if (!flag)
			{
				MessageBox.Show(msg);
			}
			return flag;
		}


		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (IsValid())
			{
				using (var db = new MilkteaDBContext())
				{
					var manager = db.Accounts.Include(a => a.Products).FirstOrDefault(x => x.AccountId == acc.AccountId);
					if (manager != null)
					{
						var empProduct = new Product
						{
							ProductName = txtName.Text,
							CategoryId = db.Categories.First(x => x.CategoryName == (string)cbCategory.SelectedItem).CategoryId,
							Quantity = (int)nudQuantity.Value,
							Price = Convert.ToInt32(txtPrice.Text),
							Origin = txtOrigin.Text,
							Image = txtImage.Text,
							Manager = manager
						};
						db.Products.Add(empProduct);
						if (db.SaveChanges() > 0)
						{
							MessageBox.Show("New product is added successfully.");
							LoadProduct();
							Reset();
						}
					}
					else
					{
						MessageBox.Show("Manager not found.");
					}
				}
			}
		}

		string imageFile;
		private void btnBrowse_Click(object sender, EventArgs e)
		{

			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";
			openFileDialog.Title = "Select an Image";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				imageFile = openFileDialog.FileName;
				pbImage.Image = Image.FromFile(imageFile);
				txtImage.Text = imageFile;
			}
		}

		private void dgvAdProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			using (var db = new MilkteaDBContext())
			{
				if (dgvAdProduct.Columns[e.ColumnIndex].Name == "delete")
				{
					var id = int.Parse(dgvAdProduct.Rows[e.RowIndex].Cells["id"].Value.ToString());
					if (MessageBox.Show("Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						var emp = db.Products.SingleOrDefault(e => e.ProductId == id);
						if (emp != null)
						{
							db.Products.Remove(emp);
							if (db.SaveChanges() > 0)
							{
								MessageBox.Show("Delete success.");
								LoadProduct();
								Reset();
							}
						}
					}
				}
			}
		}

		private void Reset()
		{
			txtId.Text = "";
			txtName.Text = "";
			cbCategory.SelectedIndex = -1;
			nudQuantity.Value = 0;
			txtPrice.Text = "";
			txtOrigin.Text = "";
			txtImage.Text = "";
			pbImage.Image = null;
		}
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			using (var db = new MilkteaDBContext())
			{
				var id = int.Parse(txtId.Text);
				var name = txtName.Text;
				var category = db.Categories.First(x => x.CategoryName == cbCategory.SelectedItem).CategoryId;
				var quantity = int.Parse(nudQuantity.Text);
				var price = int.Parse(txtPrice.Text);
				var origin = txtOrigin.Text;
				var image = txtImage.Text;

				var pro = db.Products.SingleOrDefault(e => e.ProductId == id);
				if (pro != null)
				{
					pro.ProductName = name;
					pro.CategoryId = category;
					pro.Quantity = quantity;
					pro.Price = price;
					pro.Origin = origin;
					pro.Image = image;

					if (db.SaveChanges() > 0)
					{
						MessageBox.Show("Update product success.");
						LoadProduct();
						Reset();
					}
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// Create a new Excel workbook
			var workbook = new XLWorkbook();

			// Add a worksheet to the workbook
			var worksheet = workbook.Worksheets.Add("Data");

			// Set the column headers
			worksheet.Cell(1, 1).Value = "Product ID";
			worksheet.Cell(1, 2).Value = "Product Name";
			worksheet.Cell(1, 3).Value = "Category";
			worksheet.Cell(1, 4).Value = "Quantity";
			worksheet.Cell(1, 5).Value = "Price";
			worksheet.Cell(1, 6).Value = "Origin";
			worksheet.Cell(1, 7).Value = "Image";
			worksheet.Cell(1, 8).Value = "Manager";
			worksheet.Cell(1, 9).Value = "Total Price";

			// Get the data from the database
			using (var db = new MilkteaDBContext())
			{
				var products = db.Products.Include(e => e.Category).Include(e => e.Manager).ToList();

				// Populate the worksheet with the data
				for (int i = 0; i < products.Count; i++)
				{
					var product = products[i];
					worksheet.Cell(i + 2, 1).Value = product.ProductId;
					worksheet.Cell(i + 2, 2).Value = product.ProductName;
					worksheet.Cell(i + 2, 3).Value = product.Category.CategoryName;
					worksheet.Cell(i + 2, 4).Value = product.Quantity;
					worksheet.Cell(i + 2, 5).Value = product.Price;
					worksheet.Cell(i + 2, 6).Value = product.Origin;
					worksheet.Cell(i + 2, 7).Value = product.Image;
					worksheet.Cell(i + 2, 8).Value = product.Manager.Username;
				}

			}

			// Save the workbook to a file
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
			saveFileDialog.Title = "Save Excel File";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				workbook.SaveAs(saveFileDialog.FileName);
				MessageBox.Show("Data saved to Excel file successfully.");
			}
		}

		private void LoadFilteredProduct(string selectedCategory)
		{
			using (var db = new MilkteaDBContext())
			{
				dgvAdProduct.AutoGenerateColumns = false;
				dgvAdProduct.Columns.Clear();
				dgvAdProduct.DataSource = null;

				var filteredProducts = db.Products
					.Where(p => p.Category.CategoryName.Equals(selectedCategory))
					.Select(e => new
					{
						id = e.ProductId,
						name = e.ProductName,
						category = e.Category.CategoryName,
						quantity = e.Quantity,
						price = e.Price,
						origin = e.Origin,
						manager = e.Manager.Name,
						image = e.Image
					})
					.ToList();

				dgvAdProduct.DataSource = filteredProducts;

				DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
				id.Name = "id";
				id.HeaderText = "Product ID";
				id.DataPropertyName = "id";

				DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
				name.Name = "name";
				name.HeaderText = "Product Name";
				name.DataPropertyName = "name";

				DataGridViewTextBoxColumn category = new DataGridViewTextBoxColumn();
				category.Name = "category";
				category.HeaderText = "Category";
				category.DataPropertyName = "category";

				DataGridViewTextBoxColumn quantity = new DataGridViewTextBoxColumn();
				quantity.Name = "quantity";
				quantity.HeaderText = "Quantity";
				quantity.DataPropertyName = "quantity";

				DataGridViewTextBoxColumn price = new DataGridViewTextBoxColumn();
				price.Name = "price";
				price.HeaderText = "Price";
				price.DataPropertyName = "price";

				DataGridViewTextBoxColumn origin = new DataGridViewTextBoxColumn();
				origin.Name = "origin";
				origin.HeaderText = "Origin";
				origin.DataPropertyName = "origin";

				DataGridViewTextBoxColumn image = new DataGridViewTextBoxColumn();
				image.Name = "image";
				image.HeaderText = "Image";
				image.DataPropertyName = "image";

				DataGridViewTextBoxColumn manager = new DataGridViewTextBoxColumn();
				manager.Name = "manager";
				manager.HeaderText = "Manager";
				manager.DataPropertyName = "manager";

				DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
				delete.Name = "delete";
				delete.HeaderText = "Action";
				delete.Text = "Delete";
				delete.UseColumnTextForButtonValue = true;

				dgvAdProduct.Columns.Add(id);
				dgvAdProduct.Columns.Add(name);
				dgvAdProduct.Columns.Add(category);
				dgvAdProduct.Columns.Add(quantity);
				dgvAdProduct.Columns.Add(price);
				dgvAdProduct.Columns.Add(origin);
				dgvAdProduct.Columns.Add(image);
				dgvAdProduct.Columns.Add(manager);
				dgvAdProduct.Columns.Add(delete);

				var managers = db.Accounts.Where(y => y.RoleId == 2).Select(x => x.Name).ToList();
				cbManager.DataSource = managers;
				cbManager.SelectedIndex = -1;

				var categoryName = db.Categories.Select(x => x.CategoryName).ToList();
				cbCategory.DataSource = categoryName;
				cbCategory.SelectedIndex = -1;


				var filter = db.Categories.Select(x => x.CategoryName).ToList();
				cbFilter.DataSource = filter;
				cbFilter.SelectedIndex = -1;
			}
		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			string selectedCategory = cbFilter.SelectedItem?.ToString();
			using (var db = new MilkteaDBContext())
			{
				if (!string.IsNullOrEmpty(selectedCategory))
				{
					LoadFilteredProduct(selectedCategory);
					Reset();
				}
				else
				{
					LoadProduct();
					Reset();

				}
			}
		}

		private void LoadManager(string selectedManager)
		{
			using (var db = new MilkteaDBContext())
			{
				dgvAdProduct.AutoGenerateColumns = false;
				dgvAdProduct.Columns.Clear();
				dgvAdProduct.DataSource = null;

				var filteredProducts = db.Products
					.Where(p => p.Manager.Name.Equals(selectedManager))
					.Select(e => new
					{
						id = e.ProductId,
						name = e.ProductName,
						category = e.Category.CategoryName,
						quantity = e.Quantity,
						price = e.Price,
						origin = e.Origin,
						image = e.Image,
						manager = e.Manager.Username,
					})
					.ToList();

				dgvAdProduct.DataSource = filteredProducts;

				DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
				id.Name = "id";
				id.HeaderText = "Product ID";
				id.DataPropertyName = "id";

				DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
				name.Name = "name";
				name.HeaderText = "Product Name";
				name.DataPropertyName = "name";

				DataGridViewTextBoxColumn category = new DataGridViewTextBoxColumn();
				category.Name = "category";
				category.HeaderText = "Category";
				category.DataPropertyName = "category";

				DataGridViewTextBoxColumn quantity = new DataGridViewTextBoxColumn();
				quantity.Name = "quantity";
				quantity.HeaderText = "Quantity";
				quantity.DataPropertyName = "quantity";

				DataGridViewTextBoxColumn price = new DataGridViewTextBoxColumn();
				price.Name = "price";
				price.HeaderText = "Price";
				price.DataPropertyName = "price";

				DataGridViewTextBoxColumn origin = new DataGridViewTextBoxColumn();
				origin.Name = "origin";
				origin.HeaderText = "Origin";
				origin.DataPropertyName = "origin";

				DataGridViewTextBoxColumn image = new DataGridViewTextBoxColumn();
				image.Name = "image";
				image.HeaderText = "Image";
				image.DataPropertyName = "image";

				DataGridViewTextBoxColumn manager = new DataGridViewTextBoxColumn();
				manager.Name = "manager";
				manager.HeaderText = "Manager";
				manager.DataPropertyName = "manager";

				DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
				delete.Name = "delete";
				delete.HeaderText = "Action";
				delete.Text = "Delete";
				delete.UseColumnTextForButtonValue = true;

				dgvAdProduct.Columns.Add(id);
				dgvAdProduct.Columns.Add(name);
				dgvAdProduct.Columns.Add(category);
				dgvAdProduct.Columns.Add(quantity);
				dgvAdProduct.Columns.Add(price);
				dgvAdProduct.Columns.Add(origin);
				dgvAdProduct.Columns.Add(image);
				dgvAdProduct.Columns.Add(manager);
				dgvAdProduct.Columns.Add(delete);

				var categoryName = db.Categories.Select(x => x.CategoryName).ToList();
				cbCategory.DataSource = categoryName;
				cbCategory.SelectedIndex = -1;

				var managers = db.Accounts.Where(y => y.RoleId == 2).Select(x => x.Name).ToList();
				cbManager.DataSource = managers;
				cbManager.SelectedIndex = -1;

				var filter = db.Categories.Select(x => x.CategoryName).ToList();
				cbFilter.DataSource = filter;
				cbFilter.SelectedIndex = -1;
			}
		}
		private void btnManager_Click(object sender, EventArgs e)
		{
			string selectedManager = cbManager.SelectedItem?.ToString();
			if (!string.IsNullOrEmpty(selectedManager))
			{
				LoadManager(selectedManager);
				Reset();
			}
			else
			{
				LoadProduct();
				Reset();
			}
		}
	}
}
