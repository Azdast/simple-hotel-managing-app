using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Hotal_Manager
{
    public partial class PersonnelForm : Form
    {
        private DataTable personnelTable;

        public PersonnelForm()
        {
            InitializeComponent();
            InitializePersonnelTable();
            SetupGridColumns(); // <-- Replace auto-generated columns with custom ones (including dropdown)
            addRow();
        }

        private void InitializePersonnelTable()
        {
            personnelTable = new DataTable();
            personnelTable.Columns.Add("ID", typeof(string));
            personnelTable.Columns.Add("FirstName", typeof(string));
            personnelTable.Columns.Add("LastName", typeof(string));
            personnelTable.Columns.Add("Shift", typeof(string)); // New column for Morning/Afternoon
        }

        // Configure DataGridView to show a ComboBox column for Shift
        private void SetupGridColumns()
        {
            dataGridView_personnel.AutoGenerateColumns = false;
            dataGridView_personnel.Columns.Clear();

            // ID column (readonly)
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "ID";
            idCol.HeaderText = "کد ملی";
            idCol.DataPropertyName = "ID";
            idCol.ReadOnly = true;
            dataGridView_personnel.Columns.Add(idCol);

            // FirstName column
            DataGridViewTextBoxColumn firstNameCol = new DataGridViewTextBoxColumn();
            firstNameCol.Name = "FirstName";
            firstNameCol.HeaderText = "نام";
            firstNameCol.DataPropertyName = "FirstName";
            dataGridView_personnel.Columns.Add(firstNameCol);

            // LastName column
            DataGridViewTextBoxColumn lastNameCol = new DataGridViewTextBoxColumn();
            lastNameCol.Name = "LastName";
            lastNameCol.HeaderText = "نام خانوادگی";
            lastNameCol.DataPropertyName = "LastName";
            dataGridView_personnel.Columns.Add(lastNameCol);

            // Shift column as ComboBox (dropdown for Morning/Afternoon)
            DataGridViewComboBoxColumn shiftCol = new DataGridViewComboBoxColumn();
            shiftCol.Name = "Shift";
            shiftCol.HeaderText = "شیفت";
            shiftCol.DataPropertyName = "Shift";
            shiftCol.Items.AddRange("Morning", "Afternoon");
            shiftCol.FlatStyle = FlatStyle.Flat;
            dataGridView_personnel.Columns.Add(shiftCol);
        }

        // Insert a new personnel record (shift gets a default value, e.g., "Morning")
        private bool InsertPersonnel(string id, string firstName, string lastName)
        {
            // Check for duplicate ID
            foreach (DataRow row in personnelTable.Rows)
            {
                if (row["ID"].ToString() == id)
                {
                    MessageBox.Show("این شناسه قبلاً ثبت شده است", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            DataRow newRow = personnelTable.NewRow();
            newRow["ID"] = id;
            newRow["FirstName"] = firstName;
            newRow["LastName"] = lastName;
            newRow["Shift"] = "Morning"; // Default shift (user can change later from the grid)
            personnelTable.Rows.Add(newRow);
            return true;
        }

        // Update an existing personnel record (only FirstName and LastName – Shift is NOT updated here)
        private bool EditPersonnel(string id, string firstName, string lastName)
        {
            foreach (DataRow row in personnelTable.Rows)
            {
                if (row["ID"].ToString() == id)
                {
                    row["FirstName"] = firstName;
                    row["LastName"] = lastName;
                    // Shift column remains unchanged (only editable via grid)
                    return true;
                }
            }
            return false;
        }

        // Delete a personnel record by ID
        private bool DeletePersonnel(string id)
        {
            foreach (DataRow row in personnelTable.Rows)
            {
                if (row["ID"].ToString() == id)
                {
                    personnelTable.Rows.Remove(row);
                    return true;
                }
            }
            return false;
        }

        private DataTable GetPersonnel()
        {
            return personnelTable;
        }

        private void RefreshGrid()
        {
            dataGridView_personnel.DataSource = null;
            dataGridView_personnel.DataSource = GetPersonnel();
        }

        private void ClearFields()
        {
            textBox_idp.Clear();
            textBox_fnamep.Clear();
            textBox_lnamep.Clear();
        }

        private void PersonnelForm_Load(object sender, EventArgs e)
        {
            dataGridView_personnel.DefaultCellStyle.ForeColor = Color.Black;
            RefreshGrid();
        }

        private void addRow()
        {
            InsertPersonnel("1363433539", "محمدرضا", "ازدست");
            InsertPersonnel("1363433572", "فرید", "بارنجی");
            RefreshGrid();
        }

        private void button_savep_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_idp.Text) || string.IsNullOrWhiteSpace(textBox_fnamep.Text))
            {
                MessageBox.Show("پر کردن شناسه و نام واجب است", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string id = textBox_idp.Text.Trim();
                string firstName = textBox_fnamep.Text.Trim();
                string lastName = textBox_lnamep.Text.Trim();

                if (InsertPersonnel(id, firstName, lastName))
                {
                    MessageBox.Show("پرسنل ذخیره شد", "Personnel Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("پرسنل ذخیره نشد (شناسه تکراری)", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_updatep_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_idp.Text) || string.IsNullOrWhiteSpace(textBox_fnamep.Text))
            {
                MessageBox.Show("پر کردن شناسه و نام واجب است", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string id = textBox_idp.Text.Trim();
                string firstName = textBox_fnamep.Text.Trim();
                string lastName = textBox_lnamep.Text.Trim();

                if (EditPersonnel(id, firstName, lastName))
                {
                    MessageBox.Show("پرسنل به‌روزرسانی شد", "Personnel Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button_deletep_Click(object sender, EventArgs e)
        {
            if (dataGridView_personnel.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفاً یک ردیف برای حذف انتخاب کنید.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string id = dataGridView_personnel.SelectedRows[0].Cells["ID"].Value?.ToString();
            if (string.IsNullOrEmpty(id))
                return;

            DialogResult result = MessageBox.Show($"آیا از حذف پرسنل با شناسه {id} مطمئن هستید؟", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (DeletePersonnel(id))
                {
                    MessageBox.Show("پرسنل حذف شد", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("حذف انجام نشد - شناسه یافت نشد", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_personnel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_personnel.Rows[e.RowIndex];
                textBox_idp.Text = row.Cells["ID"].Value?.ToString();
                textBox_fnamep.Text = row.Cells["FirstName"].Value?.ToString();
                textBox_lnamep.Text = row.Cells["LastName"].Value?.ToString();
                // Do NOT load Shift into any textbox (there is no shift UI control)
            }
        }

        private void label_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}