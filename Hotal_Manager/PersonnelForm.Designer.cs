using System.ComponentModel;

namespace Hotal_Manager;

partial class PersonnelForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonnelForm));
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        panel1 = new System.Windows.Forms.Panel();
        label4 = new System.Windows.Forms.Label();
        label_exit = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        button_deletep = new System.Windows.Forms.Button();
        button_updatep = new System.Windows.Forms.Button();
        button_savep = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        textBox_lnamep = new System.Windows.Forms.TextBox();
        textBox_fnamep = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        textBox_idp = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        panel3 = new System.Windows.Forms.Panel();
        dataGridView_personnel = new System.Windows.Forms.DataGridView();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView_personnel).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(label4);
        panel1.Controls.Add(label_exit);
        panel1.Dock = System.Windows.Forms.DockStyle.Top;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(916, 135);
        panel1.TabIndex = 0;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(321, 9);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(230, 58);
        label4.TabIndex = 1;
        label4.Text = "اطلاعات پرسنل";
        // 
        // label_exit
        // 
        label_exit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label_exit.Location = new System.Drawing.Point(869, 0);
        label_exit.Name = "label_exit";
        label_exit.Size = new System.Drawing.Size(31, 35);
        label_exit.TabIndex = 0;
        label_exit.Text = "X";
        label_exit.Click += label_exit_Click_1;
        // 
        // panel2
        // 
        panel2.Controls.Add(button_deletep);
        panel2.Controls.Add(button_updatep);
        panel2.Controls.Add(button_savep);
        panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
        panel2.Location = new System.Drawing.Point(0, 562);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(916, 138);
        panel2.TabIndex = 1;
        // 
        // button_deletep
        // 
        button_deletep.Dock = System.Windows.Forms.DockStyle.Left;
        button_deletep.Image = ((System.Drawing.Image)resources.GetObject("button_deletep.Image"));
        button_deletep.Location = new System.Drawing.Point(300, 0);
        button_deletep.Name = "button_deletep";
        button_deletep.Size = new System.Drawing.Size(150, 138);
        button_deletep.TabIndex = 2;
        button_deletep.Text = "حذف";
        button_deletep.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        button_deletep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        button_deletep.UseVisualStyleBackColor = true;
        button_deletep.Click += button_deletep_Click;
        // 
        // button_updatep
        // 
        button_updatep.Dock = System.Windows.Forms.DockStyle.Left;
        button_updatep.Image = ((System.Drawing.Image)resources.GetObject("button_updatep.Image"));
        button_updatep.Location = new System.Drawing.Point(150, 0);
        button_updatep.Name = "button_updatep";
        button_updatep.Size = new System.Drawing.Size(150, 138);
        button_updatep.TabIndex = 1;
        button_updatep.Text = "به روز رسانی";
        button_updatep.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        button_updatep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        button_updatep.UseVisualStyleBackColor = true;
        button_updatep.Click += button_updatep_Click;
        // 
        // button_savep
        // 
        button_savep.Dock = System.Windows.Forms.DockStyle.Left;
        button_savep.Image = ((System.Drawing.Image)resources.GetObject("button_savep.Image"));
        button_savep.Location = new System.Drawing.Point(0, 0);
        button_savep.Name = "button_savep";
        button_savep.Size = new System.Drawing.Size(150, 138);
        button_savep.TabIndex = 0;
        button_savep.Text = "ذخیره";
        button_savep.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        button_savep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        button_savep.UseVisualStyleBackColor = true;
        button_savep.Click += button_savep_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(833, 458);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(42, 29);
        label1.TabIndex = 2;
        label1.Text = "نام";
        // 
        // textBox_lnamep
        // 
        textBox_lnamep.Location = new System.Drawing.Point(658, 463);
        textBox_lnamep.Name = "textBox_lnamep";
        textBox_lnamep.Size = new System.Drawing.Size(169, 23);
        textBox_lnamep.TabIndex = 3;
        // 
        // textBox_fnamep
        // 
        textBox_fnamep.Location = new System.Drawing.Point(358, 463);
        textBox_fnamep.Name = "textBox_fnamep";
        textBox_fnamep.Size = new System.Drawing.Size(169, 23);
        textBox_fnamep.TabIndex = 5;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(533, 458);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(125, 29);
        label2.TabIndex = 4;
        label2.Text = "نام خانوادگی";
        // 
        // textBox_idp
        // 
        textBox_idp.Location = new System.Drawing.Point(59, 464);
        textBox_idp.Name = "textBox_idp";
        textBox_idp.Size = new System.Drawing.Size(169, 23);
        textBox_idp.TabIndex = 7;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(234, 459);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(125, 29);
        label3.TabIndex = 6;
        label3.Text = "کد ملی";
        // 
        // panel3
        // 
        panel3.Controls.Add(dataGridView_personnel);
        panel3.Dock = System.Windows.Forms.DockStyle.Top;
        panel3.Location = new System.Drawing.Point(0, 135);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(916, 306);
        panel3.TabIndex = 8;
        // 
        // dataGridView_personnel
        // 
        dataGridView_personnel.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridView_personnel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dataGridView_personnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView_personnel.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dataGridView_personnel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
        dataGridView_personnel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dataGridView_personnel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dataGridView_personnel.ColumnHeadersHeight = 18;
        dataGridView_personnel.Dock = System.Windows.Forms.DockStyle.Fill;
        dataGridView_personnel.EnableHeadersVisualStyles = false;
        dataGridView_personnel.Location = new System.Drawing.Point(0, 0);
        dataGridView_personnel.Name = "dataGridView_personnel";
        dataGridView_personnel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dataGridView_personnel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dataGridView_personnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dataGridView_personnel.Size = new System.Drawing.Size(916, 306);
        dataGridView_personnel.TabIndex = 0;
        dataGridView_personnel.Text = "dataGridView1";
        // 
        // PersonnelForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(916, 700);
        Controls.Add(panel3);
        Controls.Add(textBox_idp);
        Controls.Add(label3);
        Controls.Add(textBox_fnamep);
        Controls.Add(label2);
        Controls.Add(textBox_lnamep);
        Controls.Add(label1);
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        Text = "PersonnelForm";
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView_personnel).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label_exit;

    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.DataGridView dataGridView_personnel;

    private System.Windows.Forms.Button button_deletep;

    private System.Windows.Forms.TextBox textBox_idp;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.TextBox textBox_lnamep;
    private System.Windows.Forms.TextBox textBox_fnamep;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button button_updatep;

    private System.Windows.Forms.Button button_savep;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel panel1;

    #endregion
}