using System;
using System.Data;
using System.Windows.Forms;

namespace Hotal_Manager
{
    public partial class GuestForm : Form
    {
        // In-memory data table to store guests (no database)
        private DataTable guestTable;

        public GuestForm()
        {
            InitializeComponent();
            InitializeGuestTable();
            addGuest();
        }

        private void InitializeGuestTable()
        {
            guestTable = new DataTable();
            guestTable.Columns.Add("ID", typeof(string));
            guestTable.Columns.Add("FirstName", typeof(string));
            guestTable.Columns.Add("LastName", typeof(string));
            guestTable.Columns.Add("Phone", typeof(string));
            guestTable.Columns.Add("City", typeof(string));
        }
        

        // Simulate "insert" into the in-memory table
        private bool InsertGuest(string id, string fname, string lname, string phone, string city)
        {
            // Check if ID already exists
            foreach (DataRow row in guestTable.Rows)
            {
                if (row["ID"].ToString() == id)
                {
                    MessageBox.Show("این شناسه قبلاً ثبت شده است", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            DataRow newRow = guestTable.NewRow();
            newRow["ID"] = id;
            newRow["FirstName"] = fname;
            newRow["LastName"] = lname;
            newRow["Phone"] = phone;
            newRow["City"] = city;
            guestTable.Rows.Add(newRow);
            return true;
        }

        // Simulate "edit" – update existing row
        private bool EditGuest(string id, string fname, string lname, string phone, string city)
        {
            foreach (DataRow row in guestTable.Rows)
            {
                if (row["ID"].ToString() == id)
                {
                    row["FirstName"] = fname;
                    row["LastName"] = lname;
                    row["Phone"] = phone;
                    row["City"] = city;
                    return true;
                }
            }
            return false; // ID not found
        }

        // Get all guests as a DataTable (for DataGridView)
        private DataTable GetGuests()
        {
            return guestTable;
        }

        private void RefreshGrid()
        {
            dataGridView_guest.DataSource = null;
            dataGridView_guest.DataSource = GetGuests();
        }

        private void ClearFields()
        {
            textBox_id.Clear();
            textBox_fname.Clear();
            textBox_lname.Clear();
            textBox_phone.Clear();
            textBox_city.Clear();
        }

        private void addGuest()
        {
            InsertGuest("1363433539", "علیرضا", "ازدست", "90240773", "تبریز");
            //RefreshGrid();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "" || textBox_fname.Text == "" || textBox_phone.Text == "")
            {
                MessageBox.Show("پر کردن شناسه، نام و تلفن واجب است", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string id = textBox_id.Text;
                string fname = textBox_fname.Text;
                string lname = textBox_lname.Text;
                string phone = textBox_phone.Text;
                string city = textBox_city.Text;

                bool inserted = InsertGuest(id, fname, lname, phone, city);
                if (inserted)
                {
                    MessageBox.Show("مهمان ذخیره شد", "Guest Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("مهمان ذخیره نشد (شناسه تکراری)", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            dataGridView_guest.DefaultCellStyle.ForeColor = Color.Black;
            RefreshGrid();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "" || textBox_fname.Text == "" || textBox_phone.Text == "")
            {
                MessageBox.Show("پر کردن شناسه، نام و تلفن واجب است", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string id = textBox_id.Text;
                string fname = textBox_fname.Text;
                string lname = textBox_lname.Text;
                string phone = textBox_phone.Text;
                string city = textBox_city.Text;

                bool edited = EditGuest(id, fname, lname, phone, city);
                if (edited)
                {
                    MessageBox.Show("مهمان به‌روزرسانی شد", "Guest Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("شناسه مورد نظر یافت نشد", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_guest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_guest.Rows[e.RowIndex];
                textBox_id.Text = row.Cells[0].Value?.ToString();
                textBox_fname.Text = row.Cells[1].Value?.ToString();
                textBox_lname.Text = row.Cells[2].Value?.ToString();
                textBox_phone.Text = row.Cells[3].Value?.ToString();
                textBox_city.Text = row.Cells[4].Value?.ToString();
            }
        }

        private void label7_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Keep other unused event methods empty or remove them
        private void dataGridView_guest_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label7_Click_1(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView_guest.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفا یک مهمان برای حذف انتخاب کنید.", "No Selection");
                return;
            }

            string id = dataGridView_guest.SelectedRows[0].Cells["ID"].Value?.ToString();
            if (string.IsNullOrEmpty(id))
                return;

            DialogResult result = MessageBox.Show($"آیا از حذف مهمان با شناسه {id} مطمئن هستید؟", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Delete from DataTable
                DataRow[] rows = guestTable.Select($"ID = '{id}'");
                if (rows.Length > 0)
                {
                    guestTable.Rows.Remove(rows[0]);
                    RefreshGrid();
                    ClearFields();
                    MessageBox.Show("مهمان حذف شد", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("شناسه یافت نشد", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}