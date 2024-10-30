using System;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmEmployee : Form
    {
        private PictureBox btnDelete;
        private Panel panel12;
        private TextBox txtContactNo;
        private Panel panel11;
        private Label label13;
        private TextBox txtAllowance;
        private Panel panel10;
        private Label label12;
        private TextBox txtOverTime;
        private Panel panel8;
        private Label label11;
        private TextBox txtMonthlySalary;
        private Panel panel9;
        private Label label9;
        private Label label10;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtEmail;
        private TextBox txtRole;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox1;
        private Button btnUpdate;
        private Panel panel7;
        private TextBox txtAddress;
        private Panel panel6;
        private TextBox txtLastName;
        private Panel panel5;
        private TextBox txtFirstName;
        private Panel panel4;
        private TextBox txtEmployeeID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Label label3;
        private Label label14;
        private DateTimePicker dateTimePicker1;
        private Button btnRegister;
        private Label label1;

        public frmEmployee()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //Used to insert a new record to the database
        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString, commandString;

            // Connection string to the database
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=Griffindo_Toys;Integrated Security=True";
            commandString = "INSERT INTO Employee VALUES ('" + txtFirstName.Text + "' , '" + txtLastName.Text + "','" + txtAddress.Text + "','" + txtContactNo.Text + "','" + txtEmail.Text + "','" + txtRole.Text + "','" + txtMonthlySalary.Text + "','" + txtOverTime.Text + "','" + txtAllowance.Text + "','" + dateTimePicker1.Value + "')";

            //Establishs a connection to the SQL Server
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Employee Registered Successfully");
            conn.Close();

        }

        private void btnSearch(object sender, EventArgs e)
        {
            //Used to search a record of an existing employee in the database
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=Griffindo_Toys;Integrated Security=True";
            commandString = "SELECT * FROM Employee WHERE Employee_ID = '" + txtEmployeeID.Text + "'";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(commandString, conn);
            SqlDataReader reader = null;

            try
            { conn.Open(); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtFirstName.Text = reader[1].ToString();
                txtLastName.Text = reader[2].ToString();
                txtAddress.Text = reader[3].ToString();
                txtContactNo.Text = reader[4].ToString();
                txtEmail.Text = reader[5].ToString();
                txtRole.Text = reader[6].ToString();
                txtMonthlySalary.Text = reader[7].ToString();
                txtOverTime.Text = reader[8].ToString();
                txtAllowance.Text = reader[9].ToString();
                dateTimePicker1.Text = reader[10].ToString();

            }
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=Griffindo_Toys;Integrated Security=True";
            commandString = "UPDATE Employee SET FirstName = '" + txtFirstName.Text + "' , LastName = '" + txtLastName.Text + "' , Address = '" + txtAddress.Text + "' , Contact_No = '" + txtContactNo.Text + "' , Email = '" + txtEmail.Text + "' , Role = '" + txtRole.Text + "', MonthlySalary = '" + txtMonthlySalary.Text + "' , OverTime = '" + txtOverTime.Text + "' , Allowance = '" + txtAllowance.Text + "', DateTimePicker = '" + dateTimePicker1.Text + "' where Employee_ID = '" + txtEmployeeID.Text + "'";
            if (MessageBox.Show("Are you sure, you want to Update this record?", "Sure?", MessageBoxButtons.YesNo) == DialogResult.No) { return; }

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            MessageBox.Show("Record Updated Successfully");
            txtEmployeeID.Focus();
            conn.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard obj = new Dashboard();
            obj.Show();

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=Griffindo_Toys;Integrated Security=True";

            commandString = "DELETE Employee FROM Employee where Employee.EmployeeID = '" + txtEmployeeID.Text + "'";
            if (MessageBox.Show("Are you sure, you want to delete this record?", "Sure?", MessageBoxButtons.YesNo) == DialogResult.No) { return; }
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully");
            conn.Close();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAllowance = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOverTime = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMonthlySalary = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(27, 462);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 64);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 149;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(178)))));
            this.panel12.Location = new System.Drawing.Point(707, 264);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(199, 1);
            this.panel12.TabIndex = 134;
            // 
            // txtContactNo
            // 
            this.txtContactNo.BackColor = System.Drawing.Color.White;
            this.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContactNo.ForeColor = System.Drawing.Color.Black;
            this.txtContactNo.Location = new System.Drawing.Point(707, 236);
            this.txtContactNo.Multiline = true;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(199, 28);
            this.txtContactNo.TabIndex = 130;
            this.txtContactNo.TextChanged += new System.EventHandler(this.txtContactNo_TextChanged);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(178)))));
            this.panel11.Location = new System.Drawing.Point(292, 525);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(199, 1);
            this.panel11.TabIndex = 148;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(542, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 24);
            this.label13.TabIndex = 126;
            this.label13.Text = "Contact No.";
            // 
            // txtAllowance
            // 
            this.txtAllowance.BackColor = System.Drawing.Color.White;
            this.txtAllowance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAllowance.ForeColor = System.Drawing.Color.Black;
            this.txtAllowance.Location = new System.Drawing.Point(292, 497);
            this.txtAllowance.Multiline = true;
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Size = new System.Drawing.Size(199, 28);
            this.txtAllowance.TabIndex = 147;
            this.txtAllowance.TextChanged += new System.EventHandler(this.txtAllowance_TextChanged);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(178)))));
            this.panel10.Location = new System.Drawing.Point(293, 486);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(199, 1);
            this.panel10.TabIndex = 145;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(119, 502);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 24);
            this.label12.TabIndex = 146;
            this.label12.Text = "Allowance";
            // 
            // txtOverTime
            // 
            this.txtOverTime.BackColor = System.Drawing.Color.White;
            this.txtOverTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOverTime.ForeColor = System.Drawing.Color.Black;
            this.txtOverTime.Location = new System.Drawing.Point(293, 458);
            this.txtOverTime.Multiline = true;
            this.txtOverTime.Name = "txtOverTime";
            this.txtOverTime.Size = new System.Drawing.Size(199, 28);
            this.txtOverTime.TabIndex = 144;
            this.txtOverTime.TextChanged += new System.EventHandler(this.txtOverTime_TextChanged);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(178)))));
            this.panel8.Location = new System.Drawing.Point(294, 439);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(199, 1);
            this.panel8.TabIndex = 142;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(119, 463);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 24);
            this.label11.TabIndex = 143;
            this.label11.Text = "Overtime Rate";
            // 
            // txtMonthlySalary
            // 
            this.txtMonthlySalary.BackColor = System.Drawing.Color.White;
            this.txtMonthlySalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonthlySalary.ForeColor = System.Drawing.Color.Black;
            this.txtMonthlySalary.Location = new System.Drawing.Point(294, 411);
            this.txtMonthlySalary.Multiline = true;
            this.txtMonthlySalary.Name = "txtMonthlySalary";
            this.txtMonthlySalary.Size = new System.Drawing.Size(199, 28);
            this.txtMonthlySalary.TabIndex = 140;
            this.txtMonthlySalary.TextChanged += new System.EventHandler(this.txtMonthlySalary_TextChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(178)))));
            this.panel9.Location = new System.Drawing.Point(120, 169);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(517, 3);
            this.panel9.TabIndex = 139;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(116, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 24);
            this.label9.TabIndex = 138;
            this.label9.Text = "Monthly Salary";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(115, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 24);
            this.label10.TabIndex = 141;
            this.label10.Text = "Personal Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(178)))));
            this.panel2.Location = new System.Drawing.Point(292, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 1);
            this.panel2.TabIndex = 137;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(178)))));
            this.panel1.Location = new System.Drawing.Point(293, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 1);
            this.panel1.TabIndex = 136;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(292, 279);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 28);
            this.txtEmail.TabIndex = 131;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtRole
            // 
            this.txtRole.BackColor = System.Drawing.Color.White;
            this.txtRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRole.ForeColor = System.Drawing.Color.Black;
            this.txtRole.Location = new System.Drawing.Point(293, 369);
            this.txtRole.Multiline = true;
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(199, 28);
            this.txtRole.TabIndex = 133;
            this.txtRole.TextChanged += new System.EventHandler(this.txtRole_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(119, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 24);
            this.label8.TabIndex = 129;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(119, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 24);
            this.label7.TabIndex = 128;
            this.label7.Text = "Role";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 135;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(178)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(707, 486);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(199, 40);
            this.btnUpdate.TabIndex = 132;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(178)))));
            this.panel7.Location = new System.Drawing.Point(292, 259);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(199, 1);
            this.panel7.TabIndex = 127;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(292, 231);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(199, 28);
            this.txtAddress.TabIndex = 122;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(178)))));
            this.panel6.Location = new System.Drawing.Point(707, 211);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(199, 1);
            this.panel6.TabIndex = 125;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.Location = new System.Drawing.Point(707, 183);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(199, 28);
            this.txtLastName.TabIndex = 121;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(178)))));
            this.panel5.Location = new System.Drawing.Point(292, 211);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(199, 1);
            this.panel5.TabIndex = 124;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(292, 183);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(199, 28);
            this.txtFirstName.TabIndex = 123;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(178)))));
            this.panel4.Location = new System.Drawing.Point(292, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 1);
            this.panel4.TabIndex = 118;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BackColor = System.Drawing.Color.White;
            this.txtEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeID.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeeID.Location = new System.Drawing.Point(292, 94);
            this.txtEmployeeID.Multiline = true;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(199, 28);
            this.txtEmployeeID.TabIndex = 117;
            this.txtEmployeeID.TextChanged += new System.EventHandler(this.txtEmployeeID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 115;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(542, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 114;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 113;
            this.label4.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 111;
            this.label2.Text = "Employee ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 45);
            this.label1.TabIndex = 110;
            this.label1.Text = "Employee";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(524, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 150;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(178)))));
            this.panel3.Location = new System.Drawing.Point(117, 351);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 3);
            this.panel3.TabIndex = 142;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 143;
            this.label3.Text = "Job Information";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(542, 374);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 24);
            this.label14.TabIndex = 151;
            this.label14.Text = "Joined Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(707, 376);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 22);
            this.dateTimePicker1.TabIndex = 152;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.Window;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(178)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(707, 83);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(199, 40);
            this.btnRegister.TabIndex = 153;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // frmEmployee
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 571);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAllowance);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtOverTime);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMonthlySalary);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=Griffindo_Toys;Integrated Security=True";
            commandString = "SELECT * FROM Employee WHERE Employee_ID = '" + txtEmployeeID.Text + "'";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(commandString, conn);
            SqlDataReader reader = null;

            try
            { conn.Open(); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtFirstName.Text = reader[1].ToString();
                txtLastName.Text = reader[2].ToString();
                txtAddress.Text = reader[3].ToString();
                txtContactNo.Text = reader[4].ToString();
                txtEmail.Text = reader[5].ToString();
                txtRole.Text = reader[6].ToString();
                txtMonthlySalary.Text = reader[7].ToString();
                txtOverTime.Text = reader[8].ToString();
                txtAllowance.Text = reader[9].ToString();
                dateTimePicker1.Text = reader[10].ToString();

            }
            conn.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;

            // Connection string to the database
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=Griffindo_Toys;Integrated Security=True";
            commandString = "INSERT INTO Employee VALUES ('" + txtFirstName.Text + "' , '" + txtLastName.Text + "','" + txtAddress.Text + "','" + txtContactNo.Text + "','" + txtEmail.Text + "','" + txtRole.Text + "','" + txtMonthlySalary.Text + "','" + txtOverTime.Text + "','" + txtAllowance.Text + "','" + dateTimePicker1.Value + "')";

            //Establishs a connection to the SQL Server
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Employee Registered Successfully");
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;

            // Connection string to the database
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=Griffindo_Toys;Integrated Security=True";
            commandString = "UPDATE Employee SET FirstName = '" + txtFirstName.Text + "' , LastName = '" + txtLastName.Text + "' , Address = '" + txtAddress.Text + "' , Contact_No = '" + txtContactNo.Text + "' , Email = '" + txtEmail.Text + "' , Role = '" + txtRole.Text + "', MonthlySalary = '" + txtMonthlySalary.Text + "' , OverTime = '" + txtOverTime.Text + "' , Allowance = '" + txtAllowance.Text + "', DateTimePicker = '" + dateTimePicker1.Text + "' where Employee_ID = '" + txtEmployeeID.Text + "'";
            if (MessageBox.Show("Are you sure, you want to Update this record?", "Sure?", MessageBoxButtons.YesNo) == DialogResult.No) { return; }

            //Establishs a connection to the SQL Server
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            MessageBox.Show("Record Updated Successfully");
            txtEmployeeID.Focus();
            conn.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard obj = new Dashboard();
            obj.Show();
        }
        private void frmEmployee_Load(object sender, EventArgs e)
        {

        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonthlySalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOverTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAllowance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-30NVOUQ\\SQLEXPRESS;Initial Catalog=Griffindo_Toys;Integrated Security=True";

            commandString = "DELETE Employee FROM Employee where Employee.EmployeeID = '" + txtEmployeeID.Text + "'";
            if (MessageBox.Show("Are you sure, you want to delete this record?", "Sure?", MessageBoxButtons.YesNo) == DialogResult.No) { return; }
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully");
            conn.Close();
        }
    }
}
