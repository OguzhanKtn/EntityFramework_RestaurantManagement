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
    public partial class FrmOrder : Form
    {
        public FrmOrder()
        {
            InitializeComponent();
        }

        RestaurantContext db = new RestaurantContext();
        OrderService orderService = new OrderService();
        private void FrmOrder_Load(object sender, EventArgs e)
        {
            LoadData();
            cmbRsvDateCustomer.DataSource = db.Reservations.ToList();
            cmbRsvDateCustomer.DisplayMember = "CstmrRsvDate";
            cmbRsvDateCustomer.ValueMember = "Id";

            cmbMenus.DataSource = db.Menus.ToList();
            cmbMenus.DisplayMember = "MenuDetail";
            cmbMenus.ValueMember = "Id";
        }

        void LoadData()
        {
            dataGridView1.DataSource = orderService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.MenuId = (int)cmbMenus.SelectedValue!;
            order.ReservationId = (int)cmbRsvDateCustomer.SelectedValue!;
            order.OrderDate = dtOrder.Value;
            order.Quantity = Convert.ToInt32(txtQuantity.Text);

            orderService.Add(order);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            orderService.Delete(id);
            LoadData();
        }
    }
}
