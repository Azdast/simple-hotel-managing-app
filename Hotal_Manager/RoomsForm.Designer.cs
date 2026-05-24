using System.ComponentModel;

namespace Hotal_Manager;

partial class RoomsForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsForm));
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        panel1 = new System.Windows.Forms.Panel();
        btnToggleCheckbox = new System.Windows.Forms.Button();
        btnDeleteRoom = new System.Windows.Forms.Button();
        btnAddRoom = new System.Windows.Forms.Button();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(btnToggleCheckbox);
        panel1.Controls.Add(btnDeleteRoom);
        panel1.Controls.Add(btnAddRoom);
        panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
        panel1.Location = new System.Drawing.Point(0, 550);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(900, 111);
        panel1.TabIndex = 0;
        // 
        // btnToggleCheckbox
        // 
        btnToggleCheckbox.Dock = System.Windows.Forms.DockStyle.Left;
        btnToggleCheckbox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnToggleCheckbox.Image = ((System.Drawing.Image)resources.GetObject("btnToggleCheckbox.Image"));
        btnToggleCheckbox.Location = new System.Drawing.Point(633, 0);
        btnToggleCheckbox.Name = "btnToggleCheckbox";
        btnToggleCheckbox.Size = new System.Drawing.Size(267, 111);
        btnToggleCheckbox.TabIndex = 2;
        btnToggleCheckbox.Text = "خالی یا پر کردن اتاق";
        btnToggleCheckbox.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        btnToggleCheckbox.UseVisualStyleBackColor = true;
        btnToggleCheckbox.Click += btnToggleCheckbox_Click;
        // 
        // btnDeleteRoom
        // 
        btnDeleteRoom.Dock = System.Windows.Forms.DockStyle.Left;
        btnDeleteRoom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnDeleteRoom.Image = ((System.Drawing.Image)resources.GetObject("btnDeleteRoom.Image"));
        btnDeleteRoom.Location = new System.Drawing.Point(316, 0);
        btnDeleteRoom.Name = "btnDeleteRoom";
        btnDeleteRoom.Size = new System.Drawing.Size(317, 111);
        btnDeleteRoom.TabIndex = 1;
        btnDeleteRoom.Text = "حذف اتاق";
        btnDeleteRoom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        btnDeleteRoom.UseVisualStyleBackColor = true;
        btnDeleteRoom.Click += btnDeleteRoom_Click;
        // 
        // btnAddRoom
        // 
        btnAddRoom.Dock = System.Windows.Forms.DockStyle.Left;
        btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnAddRoom.Image = ((System.Drawing.Image)resources.GetObject("btnAddRoom.Image"));
        btnAddRoom.Location = new System.Drawing.Point(0, 0);
        btnAddRoom.Name = "btnAddRoom";
        btnAddRoom.Size = new System.Drawing.Size(316, 111);
        btnAddRoom.TabIndex = 0;
        btnAddRoom.Text = "اضافه کردن اتاق";
        btnAddRoom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        btnAddRoom.UseVisualStyleBackColor = true;
        btnAddRoom.Click += btnAddRoom_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
        dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dataGridView1.ColumnHeadersHeight = 18;
        dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
        dataGridView1.EnableHeadersVisualStyles = false;
        dataGridView1.Location = new System.Drawing.Point(0, 124);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.Size = new System.Drawing.Size(900, 426);
        dataGridView1.TabIndex = 1;
        dataGridView1.Text = "dataGridView1";
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(326, 2);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(283, 57);
        label1.TabIndex = 2;
        label1.Text = "اتاق های هتل";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(867, 2);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(33, 36);
        label2.TabIndex = 3;
        label2.Text = "X";
        label2.Click += label2_Click;
        // 
        // RoomsForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(900, 661);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(dataGridView1);
        Controls.Add(panel1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        Text = "RoomsForm";
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.Button btnDeleteRoom;
    private System.Windows.Forms.Button btnToggleCheckbox;

    private System.Windows.Forms.Button btnAddRoom;

    private System.Windows.Forms.Panel panel1;

    #endregion
}