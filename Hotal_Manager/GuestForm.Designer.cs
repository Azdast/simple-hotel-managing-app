using System.ComponentModel;

namespace Hotal_Manager;

partial class GuestForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestForm));
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        panel_bottom = new System.Windows.Forms.Panel();
        button4 = new System.Windows.Forms.Button();
        button_delete = new System.Windows.Forms.Button();
        button_update = new System.Windows.Forms.Button();
        button_save = new System.Windows.Forms.Button();
        textBox_id = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        textBox_fname = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        textBox_lname = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        textBox_phone = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        textBox_city = new System.Windows.Forms.TextBox();
        button_guest = new System.Windows.Forms.Button();
        panel7 = new System.Windows.Forms.Panel();
        label6 = new System.Windows.Forms.Label();
        panel1 = new System.Windows.Forms.Panel();
        label7 = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        dataGridView_guest = new System.Windows.Forms.DataGridView();
        panel_bottom.SuspendLayout();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView_guest).BeginInit();
        SuspendLayout();
        // 
        // panel_bottom
        // 
        panel_bottom.Controls.Add(button4);
        panel_bottom.Controls.Add(button_delete);
        panel_bottom.Controls.Add(button_update);
        panel_bottom.Controls.Add(button_save);
        panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
        panel_bottom.Location = new System.Drawing.Point(0, 593);
        panel_bottom.Name = "panel_bottom";
        panel_bottom.Size = new System.Drawing.Size(916, 107);
        panel_bottom.TabIndex = 0;
        // 
        // button4
        // 
        button4.Dock = System.Windows.Forms.DockStyle.Left;
        button4.Image = ((System.Drawing.Image)resources.GetObject("button4.Image"));
        button4.Location = new System.Drawing.Point(471, 0);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(157, 107);
        button4.TabIndex = 3;
        button4.Text = "پاک کن";
        button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button_delete
        // 
        button_delete.Dock = System.Windows.Forms.DockStyle.Left;
        button_delete.Image = ((System.Drawing.Image)resources.GetObject("button_delete.Image"));
        button_delete.Location = new System.Drawing.Point(314, 0);
        button_delete.Name = "button_delete";
        button_delete.Size = new System.Drawing.Size(157, 107);
        button_delete.TabIndex = 2;
        button_delete.Text = "حذف";
        button_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        button_delete.UseVisualStyleBackColor = true;
        button_delete.Click += button3_Click;
        // 
        // button_update
        // 
        button_update.Dock = System.Windows.Forms.DockStyle.Left;
        button_update.Image = ((System.Drawing.Image)resources.GetObject("button_update.Image"));
        button_update.Location = new System.Drawing.Point(157, 0);
        button_update.Name = "button_update";
        button_update.Size = new System.Drawing.Size(157, 107);
        button_update.TabIndex = 1;
        button_update.Text = "به روز رسانی";
        button_update.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        button_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        button_update.UseVisualStyleBackColor = true;
        button_update.Click += button_update_Click;
        // 
        // button_save
        // 
        button_save.Dock = System.Windows.Forms.DockStyle.Left;
        button_save.Image = ((System.Drawing.Image)resources.GetObject("button_save.Image"));
        button_save.Location = new System.Drawing.Point(0, 0);
        button_save.Name = "button_save";
        button_save.Size = new System.Drawing.Size(157, 107);
        button_save.TabIndex = 0;
        button_save.Text = "ذخیره";
        button_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        button_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        button_save.UseVisualStyleBackColor = true;
        button_save.Click += button_save_Click;
        // 
        // textBox_id
        // 
        textBox_id.Location = new System.Drawing.Point(471, 480);
        textBox_id.Name = "textBox_id";
        textBox_id.Size = new System.Drawing.Size(171, 23);
        textBox_id.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(642, 480);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(57, 23);
        label1.TabIndex = 2;
        label1.Text = ":کدملی";
        label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(648, 507);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(33, 23);
        label2.TabIndex = 4;
        label2.Text = ":نام";
        label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
        // 
        // textBox_fname
        // 
        textBox_fname.Location = new System.Drawing.Point(471, 509);
        textBox_fname.Name = "textBox_fname";
        textBox_fname.Size = new System.Drawing.Size(171, 23);
        textBox_fname.TabIndex = 3;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(648, 538);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(97, 23);
        label3.TabIndex = 6;
        label3.Text = ":نام خانوادگی";
        label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
        // 
        // textBox_lname
        // 
        textBox_lname.Location = new System.Drawing.Point(471, 540);
        textBox_lname.Name = "textBox_lname";
        textBox_lname.Size = new System.Drawing.Size(171, 23);
        textBox_lname.TabIndex = 5;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(277, 478);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(55, 23);
        label4.TabIndex = 8;
        label4.Text = ":شماره تلفن";
        label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
        // 
        // textBox_phone
        // 
        textBox_phone.Location = new System.Drawing.Point(100, 478);
        textBox_phone.Name = "textBox_phone";
        textBox_phone.Size = new System.Drawing.Size(171, 23);
        textBox_phone.TabIndex = 7;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(277, 532);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(46, 23);
        label5.TabIndex = 10;
        label5.Text = ":شهر";
        label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
        // 
        // textBox_city
        // 
        textBox_city.Location = new System.Drawing.Point(100, 534);
        textBox_city.Name = "textBox_city";
        textBox_city.Size = new System.Drawing.Size(171, 23);
        textBox_city.TabIndex = 9;
        // 
        // button_guest
        // 
        button_guest.Dock = System.Windows.Forms.DockStyle.Top;
        button_guest.FlatAppearance.BorderSize = 0;
        button_guest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button_guest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button_guest.ForeColor = System.Drawing.SystemColors.ControlText;
        button_guest.Location = new System.Drawing.Point(0, 219);
        button_guest.Name = "button_guest";
        button_guest.Size = new System.Drawing.Size(178, 110);
        button_guest.TabIndex = 2;
        button_guest.Text = "مهمان ها";
        button_guest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        button_guest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        button_guest.UseVisualStyleBackColor = true;
        // 
        // panel7
        // 
        panel7.Dock = System.Windows.Forms.DockStyle.Top;
        panel7.Location = new System.Drawing.Point(0, 0);
        panel7.Name = "panel7";
        panel7.Size = new System.Drawing.Size(922, 89);
        panel7.TabIndex = 12;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(328, 0);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(258, 53);
        label6.TabIndex = 0;
        label6.Text = "مدیریت مهمان";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel1
        // 
        panel1.Controls.Add(label7);
        panel1.Controls.Add(label6);
        panel1.Dock = System.Windows.Forms.DockStyle.Top;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(916, 89);
        panel1.TabIndex = 11;
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.Location = new System.Drawing.Point(894, 0);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(22, 30);
        label7.TabIndex = 1;
        label7.Text = "X";
        label7.Click += label7_Click_2;
        // 
        // panel2
        // 
        panel2.Controls.Add(dataGridView_guest);
        panel2.Dock = System.Windows.Forms.DockStyle.Top;
        panel2.Location = new System.Drawing.Point(0, 89);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(916, 377);
        panel2.TabIndex = 12;
        // 
        // dataGridView_guest
        // 
        dataGridView_guest.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)128)), ((int)((byte)255)));
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridView_guest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dataGridView_guest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView_guest.BackgroundColor = System.Drawing.Color.White;
        dataGridView_guest.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dataGridView_guest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
        dataGridView_guest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dataGridView_guest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dataGridView_guest.ColumnHeadersHeight = 25;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dataGridView_guest.DefaultCellStyle = dataGridViewCellStyle3;
        dataGridView_guest.Dock = System.Windows.Forms.DockStyle.Fill;
        dataGridView_guest.EnableHeadersVisualStyles = false;
        dataGridView_guest.Location = new System.Drawing.Point(0, 0);
        dataGridView_guest.Name = "dataGridView_guest";
        dataGridView_guest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dataGridView_guest.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dataGridView_guest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dataGridView_guest.Size = new System.Drawing.Size(916, 377);
        dataGridView_guest.TabIndex = 0;
        dataGridView_guest.Text = "dataGridView1";
        dataGridView_guest.CellContentClick += dataGridView_guest_CellContentClick;
        // 
        // GuestForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ButtonFace;
        ClientSize = new System.Drawing.Size(916, 700);
        Controls.Add(panel2);
        Controls.Add(label5);
        Controls.Add(textBox_city);
        Controls.Add(label4);
        Controls.Add(textBox_phone);
        Controls.Add(label3);
        Controls.Add(textBox_lname);
        Controls.Add(label2);
        Controls.Add(textBox_fname);
        Controls.Add(label1);
        Controls.Add(textBox_id);
        Controls.Add(panel_bottom);
        Controls.Add(panel1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        Text = "GuestForm";
        Load += GuestForm_Load;
        panel_bottom.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView_guest).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.DataGridView dataGridView2;

    private System.Windows.Forms.DataGridView dataGridView_guest;

    private System.Windows.Forms.Button button_update;
    private System.Windows.Forms.Button button_delete;
    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.Button button_save;

    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button button_guest;
    private System.Windows.Forms.Panel panel7;


    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBox_city;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox_phone;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox_lname;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox_fname;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox textBox_id;

    private System.Windows.Forms.Panel panel_bottom;

    #endregion
}