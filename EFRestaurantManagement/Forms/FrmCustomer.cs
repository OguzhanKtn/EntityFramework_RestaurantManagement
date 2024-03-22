using EFRestaurantManagement.Models.ORM;
using EFRestaurantManagement.Services;
using Microsoft.IdentityModel.Tokens;

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
            
            var name = txtCustomerName.Text.Trim();
            var surname = txtCustomerSurname.Text.Trim();
            var email = txtEmail.Text.Trim();
            var phone = txtPhone.Text.Trim();
            var address = txtAdress.Text.Trim();

           if(name.IsNullOrEmpty() || surname.IsNullOrEmpty() || email.IsNullOrEmpty() || phone.IsNullOrEmpty() || address.IsNullOrEmpty())
            {
                MessageBox.Show("Please fill the all fields !");
                return;
            }
            else
            {
                customer.Name = name;
                customer.Surname = surname;
                customer.Email = email;
                customer.Phone = phone;
                customer.Adress = address;
            }

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
            if(txtUpdateAddress.Text.IsNullOrEmpty() || txtUpdatePhone.Text.IsNullOrEmpty() || txtUpdateEmail.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please fill the all fields !");
            }
            else
            {
                updatedCustomer.Adress = txtUpdateAddress.Text;
                updatedCustomer.Email = txtUpdateEmail.Text;
                updatedCustomer.Phone = txtUpdatePhone.Text;
            }
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
