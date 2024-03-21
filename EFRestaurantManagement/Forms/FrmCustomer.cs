using EFRestaurantManagement.Models.ORM;
using EFRestaurantManagement.Services;

namespace EFRestaurantManagement
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        CustomerService customerService = new CustomerService();
        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Name = txtCustomerName.Text;
            customer.Surname = txtCustomerSurname.Text;
            customer.Email = txtEmail.Text;
            customer.Phone = txtPhone.Text;
            customer.Adress = txtAdress.Text;

            try
            {
                customerService.CustomerAdd(customer);
                MessageBox.Show("Customer added successfully !");
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        void LoadData()
        {
            List<Customer> customers = customerService.GetAll();
            dataGridView1.DataSource = customers;
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                customerService.CustomerDelete(id);

                MessageBox.Show("Customer deleted succesfully !");
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        Customer updatedCustomer;
        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            updatedCustomer.Adress = txtUpdateAddress.Text;
            updatedCustomer.Email = txtUpdateEmail.Text;
            updatedCustomer.Phone = txtUpdatePhone.Text;

            customerService.CustomerUpdate(updatedCustomer);
            LoadData() ;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;

            RestaurantContext db = new RestaurantContext();

            updatedCustomer = db.Customers.FirstOrDefault(updatedCustomer => updatedCustomer.Id == id)!;

            if (updatedCustomer != null)
            {
                txtUpdateAddress.Text = updatedCustomer.Adress;
                txtUpdateEmail.Text = updatedCustomer.Email;
                txtUpdatePhone.Text = updatedCustomer.Phone;
            }
        }
    }
}
