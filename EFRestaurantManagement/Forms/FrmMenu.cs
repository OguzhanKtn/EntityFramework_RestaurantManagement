using EFRestaurantManagement.Models.ORM;
using EFRestaurantManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFRestaurantManagement.Forms
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        MenuService menuService = new MenuService();
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            dataGridView1.DataSource = menuService.GetAll();
        }
        private void txtMenuAdd_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Title = txtTitle.Text;
            menu.Description = txtDescription.Text;
            menu.Price = Convert.ToInt32(txtPrice.Text);

            menuService.Add(menu);
            LoadData();
        }

        private void btnMenuDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;

            menuService.Delete(id);
            LoadData();
        }

        Menu menu;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RestaurantContext context = new RestaurantContext();
            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;

            menu = context.Menus.FirstOrDefault(x => x.Id == id)!;

            txtUpdatedPrice.Text = menu.Price.ToString();
        }

        private void btnMenuUpdate_Click(object sender, EventArgs e)
        {
            menu.Price = decimal.Parse(txtUpdatedPrice.Text);
            menuService.Update(menu);
            LoadData();
        }
    }
}
