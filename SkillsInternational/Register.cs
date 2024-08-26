using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillsInternational
{
    public partial class Register : Form
    {
        private SqlConnection connection;

        public Register()
        {
            InitializeComponent();
            string conCode = "Data Source=CHAMATH-TUF\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True";
            connection = new SqlConnection(conCode);
        }

        // logout
        private void logoutLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }

        // eixt
        private void eixtLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // registration number
        private void registerNumberCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Registration WHERE RegNo=@RegNo", connection);
                cmd.Parameters.AddWithValue("@RegNo", registerNumberCombo.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    firstNameInput.Text = reader["FirstName"].ToString();
                    lastNameInput.Text = reader["LastName"].ToString();
                    dateofBirthPicker.Value = Convert.ToDateTime(reader["DateOfBirth"]);
                    string gender = reader["Gender"].ToString();
                    if (gender == "Male")
                    {
                        maleRadio.Checked = true;
                    }
                    else
                    {
                        femalRadio.Checked = true;
                    }
                    addressInput.Text = reader["Address"].ToString();
                    emailInput.Text = reader["Email"].ToString();
                    mobileInput.Text = reader["MobilePhone"].ToString();
                    homeInput.Text = reader["HomePhone"].ToString();
                    parentNameInput.Text = reader["ParentName"].ToString();
                    nicInput.Text = reader["NIC"].ToString();
                    contactInput.Text = reader["ContactNo"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student details: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        // first name input
        private void firstNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        // last name input
        private void lastNameInput_TextChanged(object sender, EventArgs e)
        {

        }
        
        // date of birth
        private void dateofBirthPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        // gender
        private void maleRadio_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void femalRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        // address
        private void addressInput_TextChanged(object sender, EventArgs e)
        {

        }

        // email
        private void emailInput_TextChanged(object sender, EventArgs e)
        {

        }

        // mobile number
        private void mobileInput_TextChanged(object sender, EventArgs e)
        {

        }

        // home number
        private void homeInput_TextChanged(object sender, EventArgs e)
        {

        }

        // parent name
        private void parentNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        // nic number
        private void nicInput_TextChanged(object sender, EventArgs e)
        {

        }

        // parent contact number
        private void contactInput_TextChanged(object sender, EventArgs e)
        {

        }

        // register button
        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Registration (RegNo, FirstName, LastName, DateOfBirth, Gender, Address, Email, MobilePhone, HomePhone, ParentName, NIC, ContactNumber) VALUES (@RegNo,@FirstName, @LastName, @DateOfBirth, @Gender, @Address, @Email, @MobilePhone, @HomePhone, @ParentName, @NIC, @ContactNo)", connection);

                cmd.Parameters.AddWithValue("@RegNo", registerNumberCombo.Text);
                cmd.Parameters.AddWithValue("@FirstName", firstNameInput.Text);
                cmd.Parameters.AddWithValue("@LastName", lastNameInput.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateofBirthPicker.Value);
                cmd.Parameters.AddWithValue("@Gender", maleRadio.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@Address", addressInput.Text);
                cmd.Parameters.AddWithValue("@Email", emailInput.Text);
                cmd.Parameters.AddWithValue("@MobilePhone", mobileInput.Text);
                cmd.Parameters.AddWithValue("@HomePhone", homeInput.Text);
                cmd.Parameters.AddWithValue("@ParentName", parentNameInput.Text);
                cmd.Parameters.AddWithValue("@NIC", nicInput.Text);
                cmd.Parameters.AddWithValue("@ContactNo", contactInput.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRegistrationNumbers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during registration: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        // update button
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Registration SET FirstName=@FirstName, LastName=@LastName, DateOfBirth=@DateOfBirth, Gender=@Gender, Address=@Address, Email=@Email, MobilePhone=@MobilePhone, HomePhone=@HomePhone, ParentName=@ParentName, NIC=@NIC, ContactNumber=@ContactNo WHERE RegNo=@RegNo", connection);

                cmd.Parameters.AddWithValue("@RegNo", registerNumberCombo.Text);
                cmd.Parameters.AddWithValue("@FirstName", firstNameInput.Text);
                cmd.Parameters.AddWithValue("@LastName", lastNameInput.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateofBirthPicker.Value);
                cmd.Parameters.AddWithValue("@Gender", maleRadio.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@Address", addressInput.Text);
                cmd.Parameters.AddWithValue("@Email", emailInput.Text);
                cmd.Parameters.AddWithValue("@MobilePhone", mobileInput.Text);
                cmd.Parameters.AddWithValue("@HomePhone", homeInput.Text);
                cmd.Parameters.AddWithValue("@ParentName", parentNameInput.Text);
                cmd.Parameters.AddWithValue("@NIC", nicInput.Text);
                cmd.Parameters.AddWithValue("@ContactNo", contactInput.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Update successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during update: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        // clear button
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // delete button
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Registration WHERE RegNo=@RegNo", connection);
                    cmd.Parameters.AddWithValue("@RegNo", registerNumberCombo.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deletion successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRegistrationNumbers();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during deletion: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void ClearForm()
        {
            firstNameInput.Clear();
            lastNameInput.Clear();
            addressInput.Clear();
            emailInput.Clear();
            mobileInput.Clear();
            homeInput.Clear();
            parentNameInput.Clear();
            nicInput.Clear();
            contactInput.Clear();
            registerNumberCombo.SelectedIndex = -1;
            maleRadio.Checked = false;
            femalRadio.Checked = false;
            dateofBirthPicker.Value = DateTime.Now;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            LoadRegistrationNumbers();
        }

        private void LoadRegistrationNumbers()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT RegNo FROM Registration", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    registerNumberCombo.Items.Add(reader["RegNo"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading registration numbers: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void registerGroup_Enter(object sender, EventArgs e)
        {

        }
    }
}
