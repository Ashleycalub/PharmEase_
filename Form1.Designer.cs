namespace PharmEase_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.LogInPanel = new System.Windows.Forms.Panel();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.AddUserPanel = new System.Windows.Forms.Panel();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbUserN = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMobileNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateOfbirth = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbUserrole = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ViewUserPanel = new System.Windows.Forms.Panel();
            this.VUdeletebtn = new System.Windows.Forms.Button();
            this.tbSearchUser = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ViewUserdgview = new System.Windows.Forms.DataGridView();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.AdduserCancelbtn = new System.Windows.Forms.Button();
            this.AdduserSavebtn = new System.Windows.Forms.Button();
            this.ProfileUpdatebtn = new System.Windows.Forms.Button();
            this.ProfileCancelbtn = new System.Windows.Forms.Button();
            this.PharmacistPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Administratorpanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnViewUser = new System.Windows.Forms.Button();
            this.btnAdduser = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnSignin = new System.Windows.Forms.Button();
            this.TransparentLoginPanel = new System.Windows.Forms.Panel();
            this.Uname = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Pword = new System.Windows.Forms.Label();
            this.LogInPanel.SuspendLayout();
            this.AdminPanel.SuspendLayout();
            this.ProfilePanel.SuspendLayout();
            this.AddUserPanel.SuspendLayout();
            this.ViewUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewUserdgview)).BeginInit();
            this.DashboardPanel.SuspendLayout();
            this.PharmacistPanel.SuspendLayout();
            this.Administratorpanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.TransparentLoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogInPanel
            // 
            this.LogInPanel.BackColor = System.Drawing.Color.Lavender;
            this.LogInPanel.BackgroundImage = global::PharmEase_.Properties.Resources.FI0U5Mt;
            this.LogInPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogInPanel.Controls.Add(this.TransparentLoginPanel);
            this.LogInPanel.Location = new System.Drawing.Point(0, 0);
            this.LogInPanel.Name = "LogInPanel";
            this.LogInPanel.Size = new System.Drawing.Size(952, 522);
            this.LogInPanel.TabIndex = 0;
            // 
            // AdminPanel
            // 
            this.AdminPanel.Controls.Add(this.DashboardPanel);
            this.AdminPanel.Controls.Add(this.AddUserPanel);
            this.AdminPanel.Controls.Add(this.ViewUserPanel);
            this.AdminPanel.Controls.Add(this.ProfilePanel);
            this.AdminPanel.Controls.Add(this.ButtonsPanel);
            this.AdminPanel.Location = new System.Drawing.Point(0, 0);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(945, 519);
            this.AdminPanel.TabIndex = 12;
            this.AdminPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminPanel_Paint);
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.BackColor = System.Drawing.Color.Lavender;
            this.ProfilePanel.Controls.Add(this.ProfileCancelbtn);
            this.ProfilePanel.Controls.Add(this.ProfileUpdatebtn);
            this.ProfilePanel.Controls.Add(this.label18);
            this.ProfilePanel.Controls.Add(this.textBox1);
            this.ProfilePanel.Controls.Add(this.label16);
            this.ProfilePanel.Controls.Add(this.textBox2);
            this.ProfilePanel.Controls.Add(this.label17);
            this.ProfilePanel.Controls.Add(this.label19);
            this.ProfilePanel.Controls.Add(this.textBox4);
            this.ProfilePanel.Controls.Add(this.label20);
            this.ProfilePanel.Controls.Add(this.dateTimePicker1);
            this.ProfilePanel.Controls.Add(this.label21);
            this.ProfilePanel.Controls.Add(this.textBox5);
            this.ProfilePanel.Controls.Add(this.label22);
            this.ProfilePanel.Controls.Add(this.comboBox1);
            this.ProfilePanel.Location = new System.Drawing.Point(217, 0);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(732, 522);
            this.ProfilePanel.TabIndex = 4;
            // 
            // AddUserPanel
            // 
            this.AddUserPanel.BackColor = System.Drawing.Color.Lavender;
            this.AddUserPanel.Controls.Add(this.AdduserCancelbtn);
            this.AddUserPanel.Controls.Add(this.AdduserSavebtn);
            this.AddUserPanel.Controls.Add(this.userPassword);
            this.AddUserPanel.Controls.Add(this.label13);
            this.AddUserPanel.Controls.Add(this.tbUserN);
            this.AddUserPanel.Controls.Add(this.label12);
            this.AddUserPanel.Controls.Add(this.label7);
            this.AddUserPanel.Controls.Add(this.tbMobileNo);
            this.AddUserPanel.Controls.Add(this.label10);
            this.AddUserPanel.Controls.Add(this.dateOfbirth);
            this.AddUserPanel.Controls.Add(this.label9);
            this.AddUserPanel.Controls.Add(this.tbName);
            this.AddUserPanel.Controls.Add(this.label8);
            this.AddUserPanel.Controls.Add(this.flowLayoutPanel3);
            this.AddUserPanel.Controls.Add(this.cbUserrole);
            this.AddUserPanel.Controls.Add(this.label6);
            this.AddUserPanel.Location = new System.Drawing.Point(217, 0);
            this.AddUserPanel.Name = "AddUserPanel";
            this.AddUserPanel.Size = new System.Drawing.Size(732, 522);
            this.AddUserPanel.TabIndex = 14;
            // 
            // userPassword
            // 
            this.userPassword.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.userPassword.Location = new System.Drawing.Point(400, 224);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(271, 29);
            this.userPassword.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label13.Location = new System.Drawing.Point(396, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 21);
            this.label13.TabIndex = 22;
            this.label13.Text = "Password:";
            // 
            // tbUserN
            // 
            this.tbUserN.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbUserN.Location = new System.Drawing.Point(400, 143);
            this.tbUserN.Name = "tbUserN";
            this.tbUserN.Size = new System.Drawing.Size(271, 29);
            this.tbUserN.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label12.Location = new System.Drawing.Point(396, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 21);
            this.label12.TabIndex = 20;
            this.label12.Text = "User Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label7.Location = new System.Drawing.Point(64, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "User Role:";
            // 
            // tbMobileNo
            // 
            this.tbMobileNo.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbMobileNo.Location = new System.Drawing.Point(68, 377);
            this.tbMobileNo.Name = "tbMobileNo";
            this.tbMobileNo.Size = new System.Drawing.Size(271, 29);
            this.tbMobileNo.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label10.Location = new System.Drawing.Point(63, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 21);
            this.label10.TabIndex = 15;
            this.label10.Text = "Mobile Number:";
            // 
            // dateOfbirth
            // 
            this.dateOfbirth.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dateOfbirth.Location = new System.Drawing.Point(68, 293);
            this.dateOfbirth.Name = "dateOfbirth";
            this.dateOfbirth.Size = new System.Drawing.Size(271, 29);
            this.dateOfbirth.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label9.Location = new System.Drawing.Point(63, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Date of Birth:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbName.Location = new System.Drawing.Point(68, 219);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(271, 29);
            this.tbName.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label8.Location = new System.Drawing.Point(63, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Name:";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(365, 86);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(2, 350);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // cbUserrole
            // 
            this.cbUserrole.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cbUserrole.FormattingEnabled = true;
            this.cbUserrole.Location = new System.Drawing.Point(67, 142);
            this.cbUserrole.Name = "cbUserrole";
            this.cbUserrole.Size = new System.Drawing.Size(272, 29);
            this.cbUserrole.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Add User";
            // 
            // ViewUserPanel
            // 
            this.ViewUserPanel.BackColor = System.Drawing.Color.Lavender;
            this.ViewUserPanel.Controls.Add(this.VUdeletebtn);
            this.ViewUserPanel.Controls.Add(this.tbSearchUser);
            this.ViewUserPanel.Controls.Add(this.label15);
            this.ViewUserPanel.Controls.Add(this.label14);
            this.ViewUserPanel.Controls.Add(this.ViewUserdgview);
            this.ViewUserPanel.Location = new System.Drawing.Point(217, 0);
            this.ViewUserPanel.Name = "ViewUserPanel";
            this.ViewUserPanel.Size = new System.Drawing.Size(732, 522);
            this.ViewUserPanel.TabIndex = 14;
            // 
            // VUdeletebtn
            // 
            this.VUdeletebtn.BackColor = System.Drawing.Color.Red;
            this.VUdeletebtn.Location = new System.Drawing.Point(614, 395);
            this.VUdeletebtn.Name = "VUdeletebtn";
            this.VUdeletebtn.Size = new System.Drawing.Size(87, 30);
            this.VUdeletebtn.TabIndex = 10;
            this.VUdeletebtn.Text = "Delete";
            this.VUdeletebtn.UseVisualStyleBackColor = false;
            // 
            // tbSearchUser
            // 
            this.tbSearchUser.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbSearchUser.Location = new System.Drawing.Point(183, 115);
            this.tbSearchUser.Name = "tbSearchUser";
            this.tbSearchUser.Size = new System.Drawing.Size(331, 29);
            this.tbSearchUser.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(179, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "User name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 32);
            this.label14.TabIndex = 1;
            this.label14.Text = "View User";
            // 
            // ViewUserdgview
            // 
            this.ViewUserdgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewUserdgview.Location = new System.Drawing.Point(29, 167);
            this.ViewUserdgview.Name = "ViewUserdgview";
            this.ViewUserdgview.Size = new System.Drawing.Size(672, 222);
            this.ViewUserdgview.TabIndex = 0;
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.BackColor = System.Drawing.Color.Lavender;
            this.DashboardPanel.Controls.Add(this.PharmacistPanel);
            this.DashboardPanel.Controls.Add(this.Administratorpanel);
            this.DashboardPanel.Controls.Add(this.label3);
            this.DashboardPanel.Location = new System.Drawing.Point(217, 0);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(735, 522);
            this.DashboardPanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dashboard";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.textBox1.Location = new System.Drawing.Point(363, 395);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 29);
            this.textBox1.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label16.Location = new System.Drawing.Point(359, 374);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 21);
            this.label16.TabIndex = 36;
            this.label16.Text = "Password:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.textBox2.Location = new System.Drawing.Point(363, 323);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 29);
            this.textBox2.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label17.Location = new System.Drawing.Point(359, 299);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 21);
            this.label17.TabIndex = 34;
            this.label17.Text = "User Name:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label19.Location = new System.Drawing.Point(362, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 21);
            this.label19.TabIndex = 31;
            this.label19.Text = "User Role:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.textBox4.Location = new System.Drawing.Point(364, 259);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(271, 29);
            this.textBox4.TabIndex = 30;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label20.Location = new System.Drawing.Point(359, 235);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(131, 21);
            this.label20.TabIndex = 29;
            this.label20.Text = "Mobile Number:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dateTimePicker1.Location = new System.Drawing.Point(365, 196);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(271, 29);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label21.Location = new System.Drawing.Point(360, 175);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(110, 21);
            this.label21.TabIndex = 27;
            this.label21.Text = "Date of Birth:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.textBox5.Location = new System.Drawing.Point(366, 139);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(271, 29);
            this.textBox5.TabIndex = 26;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label22.Location = new System.Drawing.Point(361, 117);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 21);
            this.label22.TabIndex = 25;
            this.label22.Text = "Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(365, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 29);
            this.comboBox1.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(28, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 32);
            this.label18.TabIndex = 38;
            this.label18.Text = "Profile";
            // 
            // AdduserCancelbtn
            // 
            this.AdduserCancelbtn.Location = new System.Drawing.Point(584, 265);
            this.AdduserCancelbtn.Name = "AdduserCancelbtn";
            this.AdduserCancelbtn.Size = new System.Drawing.Size(87, 30);
            this.AdduserCancelbtn.TabIndex = 25;
            this.AdduserCancelbtn.Text = "Cancel";
            this.AdduserCancelbtn.UseVisualStyleBackColor = true;
            // 
            // AdduserSavebtn
            // 
            this.AdduserSavebtn.Location = new System.Drawing.Point(462, 265);
            this.AdduserSavebtn.Name = "AdduserSavebtn";
            this.AdduserSavebtn.Size = new System.Drawing.Size(87, 30);
            this.AdduserSavebtn.TabIndex = 24;
            this.AdduserSavebtn.Text = "Save";
            this.AdduserSavebtn.UseVisualStyleBackColor = true;
            // 
            // ProfileUpdatebtn
            // 
            this.ProfileUpdatebtn.Location = new System.Drawing.Point(400, 456);
            this.ProfileUpdatebtn.Name = "ProfileUpdatebtn";
            this.ProfileUpdatebtn.Size = new System.Drawing.Size(87, 30);
            this.ProfileUpdatebtn.TabIndex = 39;
            this.ProfileUpdatebtn.Text = "Update";
            this.ProfileUpdatebtn.UseVisualStyleBackColor = true;
            // 
            // ProfileCancelbtn
            // 
            this.ProfileCancelbtn.Location = new System.Drawing.Point(522, 456);
            this.ProfileCancelbtn.Name = "ProfileCancelbtn";
            this.ProfileCancelbtn.Size = new System.Drawing.Size(87, 30);
            this.ProfileCancelbtn.TabIndex = 40;
            this.ProfileCancelbtn.Text = "Cancel";
            this.ProfileCancelbtn.UseVisualStyleBackColor = true;
            // 
            // PharmacistPanel
            // 
            this.PharmacistPanel.BackgroundImage = global::PharmEase_.Properties.Resources.Rectangle_21;
            this.PharmacistPanel.Controls.Add(this.label5);
            this.PharmacistPanel.Location = new System.Drawing.Point(379, 114);
            this.PharmacistPanel.Name = "PharmacistPanel";
            this.PharmacistPanel.Size = new System.Drawing.Size(301, 336);
            this.PharmacistPanel.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(105, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pharmacist";
            // 
            // Administratorpanel
            // 
            this.Administratorpanel.BackgroundImage = global::PharmEase_.Properties.Resources.Rectangle_21;
            this.Administratorpanel.Controls.Add(this.label4);
            this.Administratorpanel.Location = new System.Drawing.Point(53, 114);
            this.Administratorpanel.Name = "Administratorpanel";
            this.Administratorpanel.Size = new System.Drawing.Size(301, 336);
            this.Administratorpanel.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(99, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Administrator";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackgroundImage = global::PharmEase_.Properties.Resources.Rectangle_21;
            this.ButtonsPanel.Controls.Add(this.btnLogout);
            this.ButtonsPanel.Controls.Add(this.btnProfile);
            this.ButtonsPanel.Controls.Add(this.btnViewUser);
            this.ButtonsPanel.Controls.Add(this.btnAdduser);
            this.ButtonsPanel.Controls.Add(this.btnDashboard);
            this.ButtonsPanel.Location = new System.Drawing.Point(2, 2);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(219, 516);
            this.ButtonsPanel.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnLogout.Location = new System.Drawing.Point(0, 403);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(216, 40);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnProfile.Location = new System.Drawing.Point(0, 341);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(216, 40);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnViewUser
            // 
            this.btnViewUser.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnViewUser.Location = new System.Drawing.Point(0, 280);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(216, 40);
            this.btnViewUser.TabIndex = 2;
            this.btnViewUser.Text = "View User";
            this.btnViewUser.UseVisualStyleBackColor = true;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // btnAdduser
            // 
            this.btnAdduser.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnAdduser.Location = new System.Drawing.Point(0, 219);
            this.btnAdduser.Name = "btnAdduser";
            this.btnAdduser.Size = new System.Drawing.Size(216, 40);
            this.btnAdduser.TabIndex = 1;
            this.btnAdduser.Text = "Add User";
            this.btnAdduser.UseVisualStyleBackColor = true;
            this.btnAdduser.Click += new System.EventHandler(this.btnAdduser_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnDashboard.Location = new System.Drawing.Point(0, 156);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(216, 40);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(182, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 29);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbUsername.Location = new System.Drawing.Point(68, 228);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(208, 29);
            this.tbUsername.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbPassword.Location = new System.Drawing.Point(68, 154);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(208, 29);
            this.tbPassword.TabIndex = 1;
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.Color.White;
            this.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSignin.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnSignin.ForeColor = System.Drawing.Color.Black;
            this.btnSignin.Location = new System.Drawing.Point(71, 274);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(95, 29);
            this.btnSignin.TabIndex = 9;
            this.btnSignin.Text = "Sign in";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // TransparentLoginPanel
            // 
            this.TransparentLoginPanel.BackColor = System.Drawing.Color.Transparent;
            this.TransparentLoginPanel.Controls.Add(this.Pword);
            this.TransparentLoginPanel.Controls.Add(this.Uname);
            this.TransparentLoginPanel.Controls.Add(this.Login);
            this.TransparentLoginPanel.Controls.Add(this.btnSignin);
            this.TransparentLoginPanel.Controls.Add(this.tbPassword);
            this.TransparentLoginPanel.Controls.Add(this.tbUsername);
            this.TransparentLoginPanel.Controls.Add(this.btnCancel);
            this.TransparentLoginPanel.ForeColor = System.Drawing.Color.Transparent;
            this.TransparentLoginPanel.Location = new System.Drawing.Point(314, 86);
            this.TransparentLoginPanel.Name = "TransparentLoginPanel";
            this.TransparentLoginPanel.Size = new System.Drawing.Size(350, 383);
            this.TransparentLoginPanel.TabIndex = 1;
            // 
            // Uname
            // 
            this.Uname.AutoSize = true;
            this.Uname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uname.ForeColor = System.Drawing.Color.Cyan;
            this.Uname.Location = new System.Drawing.Point(67, 130);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(93, 21);
            this.Uname.TabIndex = 12;
            this.Uname.Text = "User name:";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Mistral", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.Cyan;
            this.Login.Location = new System.Drawing.Point(122, 53);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(99, 47);
            this.Login.TabIndex = 11;
            this.Login.Text = "Log In";
            // 
            // Pword
            // 
            this.Pword.AutoSize = true;
            this.Pword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pword.ForeColor = System.Drawing.Color.Cyan;
            this.Pword.Location = new System.Drawing.Point(67, 207);
            this.Pword.Name = "Pword";
            this.Pword.Size = new System.Drawing.Size(88, 21);
            this.Pword.TabIndex = 13;
            this.Pword.Text = "Password:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 522);
            this.Controls.Add(this.LogInPanel);
            this.Controls.Add(this.AdminPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LogInPanel.ResumeLayout(false);
            this.AdminPanel.ResumeLayout(false);
            this.ProfilePanel.ResumeLayout(false);
            this.ProfilePanel.PerformLayout();
            this.AddUserPanel.ResumeLayout(false);
            this.AddUserPanel.PerformLayout();
            this.ViewUserPanel.ResumeLayout(false);
            this.ViewUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewUserdgview)).EndInit();
            this.DashboardPanel.ResumeLayout(false);
            this.DashboardPanel.PerformLayout();
            this.PharmacistPanel.ResumeLayout(false);
            this.PharmacistPanel.PerformLayout();
            this.Administratorpanel.ResumeLayout(false);
            this.Administratorpanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.TransparentLoginPanel.ResumeLayout(false);
            this.TransparentLoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogInPanel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAdduser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnViewUser;
        private System.Windows.Forms.Panel DashboardPanel;
        private System.Windows.Forms.Panel PharmacistPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Administratorpanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel AddUserPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbUserrole;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateOfbirth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMobileNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbUserN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel ViewUserPanel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView ViewUserdgview;
        private System.Windows.Forms.TextBox tbSearchUser;
        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.Button VUdeletebtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ProfileUpdatebtn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button AdduserCancelbtn;
        private System.Windows.Forms.Button AdduserSavebtn;
        private System.Windows.Forms.Button ProfileCancelbtn;
        private System.Windows.Forms.Panel TransparentLoginPanel;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label Uname;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Pword;
    }
}

