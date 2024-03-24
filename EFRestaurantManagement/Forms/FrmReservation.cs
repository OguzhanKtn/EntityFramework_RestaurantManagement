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
    public partial class FrmReservation : Form
    {
        public FrmReservation()
        {
            InitializeComponent();
        }
        CustomerService customerService = new CustomerService();
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void FrmReservation_Load(object sender, EventArgs e)
        {
            LoadData();
            cmbCustomers.DataSource = customerService.GetAll();
            cmbCustomers.DisplayMember = "FullName";
            cmbCustomers.ValueMember = "Id";
        }

        ReservationService reservationService = new ReservationService();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.CustomerId = (int)cmbCustomers.SelectedValue;
            reservation.ReservationDate = dtReservation.Value;
            reservation.Note = txtNotes.Text.Trim();

            reservationService.Add(reservation);
            LoadData();
        }

        void LoadData()
        {
            dataGridView1.DataSource = reservationService.GetAll();
        }

        Reservation rsv;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RestaurantContext context = new RestaurantContext();
            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            rsv = context.Reservations.FirstOrDefault(x => x.Id == id)!;
            dtUpdatedRsv.Value = rsv.ReservationDate;
            txtUpdatedNotes.Text = rsv.Note;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            reservationService.Delete(id);
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            rsv.Note = txtUpdatedNotes.Text;
            rsv.ReservationDate = dtUpdatedRsv.Value;
            reservationService.Update(rsv);
            LoadData();
        }
    }
}
