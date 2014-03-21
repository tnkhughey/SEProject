namespace WindowsFormsApplication1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabs = new System.Windows.Forms.TabControl();
            this.addNewEntryTabPage = new System.Windows.Forms.TabPage();
            this.failureLabel = new System.Windows.Forms.Label();
            this.successLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addrTextBox2 = new System.Windows.Forms.TextBox();
            this.zipLabel1 = new System.Windows.Forms.Label();
            this.zipTextBox1 = new System.Windows.Forms.TextBox();
            this.stateTextBox1 = new System.Windows.Forms.TextBox();
            this.stateLabel1 = new System.Windows.Forms.Label();
            this.cityTextBox1 = new System.Windows.Forms.TextBox();
            this.cityLabelTab1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.dayMenuTab1 = new System.Windows.Forms.ComboBox();
            this.monthMenuTab1 = new System.Windows.Forms.ComboBox();
            this.yearTab1 = new System.Windows.Forms.TextBox();
            this.numChildTextBox = new System.Windows.Forms.TextBox();
            this.numAdultsTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addrNumNameTextBox1 = new System.Windows.Forms.TextBox();
            this.miTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.dateVistLabelTab1 = new System.Windows.Forms.Label();
            this.numChildLabel = new System.Windows.Forms.Label();
            this.numAdultsLabel = new System.Windows.Forms.Label();
            this.phoneLabel2 = new System.Windows.Forms.Label();
            this.addrNumName1 = new System.Windows.Forms.Label();
            this.miLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.SearchTabPage = new System.Windows.Forms.TabPage();
            this.searchMenuTab2 = new System.Windows.Forms.ComboBox();
            this.searchDataGrid = new System.Windows.Forms.DataGridView();
            this.searchButtonTab2 = new System.Windows.Forms.Button();
            this.searchTextTab2 = new System.Windows.Forms.TextBox();
            this.searchLabelTab2 = new System.Windows.Forms.Label();
            this.statsTabPage = new System.Windows.Forms.TabPage();
            this.yearMenuTab3 = new System.Windows.Forms.TextBox();
            this.statsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.searchButtonTab3 = new System.Windows.Forms.Button();
            this.searchMenuTab3 = new System.Windows.Forms.ComboBox();
            this.monthMenuTab3 = new System.Windows.Forms.ComboBox();
            this.dayMenuTab3 = new System.Windows.Forms.ComboBox();
            this.viewAllTabPage = new System.Windows.Forms.TabPage();
            this.viewAllDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midInit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetNameNumColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityColumnSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateColumnSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipColumnSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adults = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.children = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabs.SuspendLayout();
            this.addNewEntryTabPage.SuspendLayout();
            this.SearchTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGrid)).BeginInit();
            this.statsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statsChart)).BeginInit();
            this.viewAllTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabs.Controls.Add(this.addNewEntryTabPage);
            this.tabs.Controls.Add(this.SearchTabPage);
            this.tabs.Controls.Add(this.statsTabPage);
            this.tabs.Controls.Add(this.viewAllTabPage);
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.ItemSize = new System.Drawing.Size(150, 70);
            this.tabs.Location = new System.Drawing.Point(2, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1487, 783);
            this.tabs.TabIndex = 0;
            // 
            // addNewEntryTabPage
            // 
            this.addNewEntryTabPage.BackColor = System.Drawing.Color.White;
            this.addNewEntryTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addNewEntryTabPage.Controls.Add(this.failureLabel);
            this.addNewEntryTabPage.Controls.Add(this.successLabel);
            this.addNewEntryTabPage.Controls.Add(this.label1);
            this.addNewEntryTabPage.Controls.Add(this.addrTextBox2);
            this.addNewEntryTabPage.Controls.Add(this.zipLabel1);
            this.addNewEntryTabPage.Controls.Add(this.zipTextBox1);
            this.addNewEntryTabPage.Controls.Add(this.stateTextBox1);
            this.addNewEntryTabPage.Controls.Add(this.stateLabel1);
            this.addNewEntryTabPage.Controls.Add(this.cityTextBox1);
            this.addNewEntryTabPage.Controls.Add(this.cityLabelTab1);
            this.addNewEntryTabPage.Controls.Add(this.saveButton);
            this.addNewEntryTabPage.Controls.Add(this.dayMenuTab1);
            this.addNewEntryTabPage.Controls.Add(this.monthMenuTab1);
            this.addNewEntryTabPage.Controls.Add(this.yearTab1);
            this.addNewEntryTabPage.Controls.Add(this.numChildTextBox);
            this.addNewEntryTabPage.Controls.Add(this.numAdultsTextBox);
            this.addNewEntryTabPage.Controls.Add(this.phoneTextBox);
            this.addNewEntryTabPage.Controls.Add(this.addrNumNameTextBox1);
            this.addNewEntryTabPage.Controls.Add(this.miTextBox);
            this.addNewEntryTabPage.Controls.Add(this.lNameTextBox);
            this.addNewEntryTabPage.Controls.Add(this.fNameTextBox);
            this.addNewEntryTabPage.Controls.Add(this.dateVistLabelTab1);
            this.addNewEntryTabPage.Controls.Add(this.numChildLabel);
            this.addNewEntryTabPage.Controls.Add(this.numAdultsLabel);
            this.addNewEntryTabPage.Controls.Add(this.phoneLabel2);
            this.addNewEntryTabPage.Controls.Add(this.addrNumName1);
            this.addNewEntryTabPage.Controls.Add(this.miLabel);
            this.addNewEntryTabPage.Controls.Add(this.lNameLabel);
            this.addNewEntryTabPage.Controls.Add(this.fNameLabel);
            this.addNewEntryTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewEntryTabPage.ForeColor = System.Drawing.Color.Black;
            this.addNewEntryTabPage.Location = new System.Drawing.Point(4, 74);
            this.addNewEntryTabPage.Name = "addNewEntryTabPage";
            this.addNewEntryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addNewEntryTabPage.Size = new System.Drawing.Size(1479, 705);
            this.addNewEntryTabPage.TabIndex = 3;
            this.addNewEntryTabPage.Text = "    ADD NEW ENTRY     ";
            // 
            // failureLabel
            // 
            this.failureLabel.AutoSize = true;
            this.failureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.failureLabel.ForeColor = System.Drawing.Color.Red;
            this.failureLabel.Location = new System.Drawing.Point(497, 529);
            this.failureLabel.Name = "failureLabel";
            this.failureLabel.Size = new System.Drawing.Size(304, 25);
            this.failureLabel.TabIndex = 30;
            this.failureLabel.Text = "Patron Not Added to Database";
            this.failureLabel.Visible = false;
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.successLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.successLabel.Location = new System.Drawing.Point(497, 529);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(392, 25);
            this.successLabel.TabIndex = 29;
            this.successLabel.Text = "Patron Successfully Added to Database";
            this.successLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(27, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Address Line 2";
            // 
            // addrTextBox2
            // 
            this.addrTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addrTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.addrTextBox2.Location = new System.Drawing.Point(220, 219);
            this.addrTextBox2.Name = "addrTextBox2";
            this.addrTextBox2.Size = new System.Drawing.Size(315, 31);
            this.addrTextBox2.TabIndex = 27;
            // 
            // zipLabel1
            // 
            this.zipLabel1.AutoSize = true;
            this.zipLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.zipLabel1.Location = new System.Drawing.Point(1184, 171);
            this.zipLabel1.Name = "zipLabel1";
            this.zipLabel1.Size = new System.Drawing.Size(42, 25);
            this.zipLabel1.TabIndex = 26;
            this.zipLabel1.Text = "Zip";
            // 
            // zipTextBox1
            // 
            this.zipTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zipTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.zipTextBox1.Location = new System.Drawing.Point(1232, 165);
            this.zipTextBox1.Name = "zipTextBox1";
            this.zipTextBox1.Size = new System.Drawing.Size(90, 31);
            this.zipTextBox1.TabIndex = 25;
            // 
            // stateTextBox1
            // 
            this.stateTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.stateTextBox1.Location = new System.Drawing.Point(1067, 165);
            this.stateTextBox1.Name = "stateTextBox1";
            this.stateTextBox1.Size = new System.Drawing.Size(90, 31);
            this.stateTextBox1.TabIndex = 24;
            // 
            // stateLabel1
            // 
            this.stateLabel1.AutoSize = true;
            this.stateLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.stateLabel1.Location = new System.Drawing.Point(999, 169);
            this.stateLabel1.Name = "stateLabel1";
            this.stateLabel1.Size = new System.Drawing.Size(62, 25);
            this.stateLabel1.TabIndex = 23;
            this.stateLabel1.Text = "State";
            // 
            // cityTextBox1
            // 
            this.cityTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.cityTextBox1.Location = new System.Drawing.Point(776, 171);
            this.cityTextBox1.Name = "cityTextBox1";
            this.cityTextBox1.Size = new System.Drawing.Size(189, 31);
            this.cityTextBox1.TabIndex = 22;
            // 
            // cityLabelTab1
            // 
            this.cityLabelTab1.AutoSize = true;
            this.cityLabelTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.cityLabelTab1.Location = new System.Drawing.Point(721, 171);
            this.cityLabelTab1.Name = "cityLabelTab1";
            this.cityLabelTab1.Size = new System.Drawing.Size(49, 25);
            this.cityLabelTab1.TabIndex = 21;
            this.cityLabelTab1.Text = "City";
            // 
            // saveButton
            // 
            this.saveButton.AutoEllipsis = true;
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.Location = new System.Drawing.Point(932, 505);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(275, 66);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dayMenuTab1
            // 
            this.dayMenuTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.dayMenuTab1.FormattingEnabled = true;
            this.dayMenuTab1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayMenuTab1.Location = new System.Drawing.Point(360, 433);
            this.dayMenuTab1.Name = "dayMenuTab1";
            this.dayMenuTab1.Size = new System.Drawing.Size(121, 33);
            this.dayMenuTab1.TabIndex = 19;
            this.dayMenuTab1.Text = "Day";
            // 
            // monthMenuTab1
            // 
            this.monthMenuTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.monthMenuTab1.FormattingEnabled = true;
            this.monthMenuTab1.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthMenuTab1.Location = new System.Drawing.Point(176, 429);
            this.monthMenuTab1.Name = "monthMenuTab1";
            this.monthMenuTab1.Size = new System.Drawing.Size(121, 33);
            this.monthMenuTab1.TabIndex = 18;
            this.monthMenuTab1.Text = "Month";
            // 
            // yearTab1
            // 
            this.yearTab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.yearTab1.Location = new System.Drawing.Point(560, 435);
            this.yearTab1.Name = "yearTab1";
            this.yearTab1.Size = new System.Drawing.Size(208, 31);
            this.yearTab1.TabIndex = 17;
            this.yearTab1.Text = "Year";
            // 
            // numChildTextBox
            // 
            this.numChildTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numChildTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.numChildTextBox.Location = new System.Drawing.Point(230, 374);
            this.numChildTextBox.Name = "numChildTextBox";
            this.numChildTextBox.Size = new System.Drawing.Size(315, 31);
            this.numChildTextBox.TabIndex = 16;
            // 
            // numAdultsTextBox
            // 
            this.numAdultsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numAdultsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.numAdultsTextBox.Location = new System.Drawing.Point(220, 316);
            this.numAdultsTextBox.Name = "numAdultsTextBox";
            this.numAdultsTextBox.Size = new System.Drawing.Size(315, 31);
            this.numAdultsTextBox.TabIndex = 15;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.phoneTextBox.Location = new System.Drawing.Point(120, 266);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(315, 31);
            this.phoneTextBox.TabIndex = 14;
            // 
            // addrNumNameTextBox1
            // 
            this.addrNumNameTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addrNumNameTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.addrNumNameTextBox1.Location = new System.Drawing.Point(360, 171);
            this.addrNumNameTextBox1.Name = "addrNumNameTextBox1";
            this.addrNumNameTextBox1.Size = new System.Drawing.Size(315, 31);
            this.addrNumNameTextBox1.TabIndex = 12;
            // 
            // miTextBox
            // 
            this.miTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.miTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.miTextBox.Location = new System.Drawing.Point(81, 135);
            this.miTextBox.Name = "miTextBox";
            this.miTextBox.Size = new System.Drawing.Size(44, 31);
            this.miTextBox.TabIndex = 11;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lNameTextBox.Location = new System.Drawing.Point(176, 83);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(315, 31);
            this.lNameTextBox.TabIndex = 10;
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.fNameTextBox.Location = new System.Drawing.Point(176, 39);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(315, 31);
            this.fNameTextBox.TabIndex = 9;
            // 
            // dateVistLabelTab1
            // 
            this.dateVistLabelTab1.AutoSize = true;
            this.dateVistLabelTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.dateVistLabelTab1.Location = new System.Drawing.Point(28, 433);
            this.dateVistLabelTab1.Name = "dateVistLabelTab1";
            this.dateVistLabelTab1.Size = new System.Drawing.Size(128, 25);
            this.dateVistLabelTab1.TabIndex = 8;
            this.dateVistLabelTab1.Text = "Date of Visit";
            // 
            // numChildLabel
            // 
            this.numChildLabel.AutoSize = true;
            this.numChildLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.numChildLabel.Location = new System.Drawing.Point(27, 374);
            this.numChildLabel.Name = "numChildLabel";
            this.numChildLabel.Size = new System.Drawing.Size(197, 25);
            this.numChildLabel.TabIndex = 7;
            this.numChildLabel.Text = "Number of Children";
            // 
            // numAdultsLabel
            // 
            this.numAdultsLabel.AutoSize = true;
            this.numAdultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.numAdultsLabel.Location = new System.Drawing.Point(28, 322);
            this.numAdultsLabel.Name = "numAdultsLabel";
            this.numAdultsLabel.Size = new System.Drawing.Size(177, 25);
            this.numAdultsLabel.TabIndex = 6;
            this.numAdultsLabel.Text = "Number of Adults";
            // 
            // phoneLabel2
            // 
            this.phoneLabel2.AutoSize = true;
            this.phoneLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.phoneLabel2.Location = new System.Drawing.Point(27, 272);
            this.phoneLabel2.Name = "phoneLabel2";
            this.phoneLabel2.Size = new System.Drawing.Size(74, 25);
            this.phoneLabel2.TabIndex = 5;
            this.phoneLabel2.Text = "Phone";
            // 
            // addrNumName1
            // 
            this.addrNumName1.AutoSize = true;
            this.addrNumName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.addrNumName1.Location = new System.Drawing.Point(27, 177);
            this.addrNumName1.Name = "addrNumName1";
            this.addrNumName1.Size = new System.Drawing.Size(314, 25);
            this.addrNumName1.TabIndex = 3;
            this.addrNumName1.Text = "Address Street Num. and Name";
            // 
            // miLabel
            // 
            this.miLabel.AutoSize = true;
            this.miLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.miLabel.Location = new System.Drawing.Point(28, 135);
            this.miLabel.Name = "miLabel";
            this.miLabel.Size = new System.Drawing.Size(47, 25);
            this.miLabel.TabIndex = 2;
            this.miLabel.Text = "M.I.";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lNameLabel.Location = new System.Drawing.Point(27, 83);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(109, 25);
            this.lNameLabel.TabIndex = 1;
            this.lNameLabel.Text = "LastName";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.fNameLabel.Location = new System.Drawing.Point(27, 39);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(110, 25);
            this.fNameLabel.TabIndex = 0;
            this.fNameLabel.Text = "FirstName";
            // 
            // SearchTabPage
            // 
            this.SearchTabPage.Controls.Add(this.searchMenuTab2);
            this.SearchTabPage.Controls.Add(this.searchDataGrid);
            this.SearchTabPage.Controls.Add(this.searchButtonTab2);
            this.SearchTabPage.Controls.Add(this.searchTextTab2);
            this.SearchTabPage.Controls.Add(this.searchLabelTab2);
            this.SearchTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.SearchTabPage.Location = new System.Drawing.Point(4, 74);
            this.SearchTabPage.Name = "SearchTabPage";
            this.SearchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTabPage.Size = new System.Drawing.Size(1479, 705);
            this.SearchTabPage.TabIndex = 4;
            this.SearchTabPage.Text = "   SEARCH   ";
            this.SearchTabPage.UseVisualStyleBackColor = true;
            // 
            // searchMenuTab2
            // 
            this.searchMenuTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.searchMenuTab2.FormattingEnabled = true;
            this.searchMenuTab2.Items.AddRange(new object[] {
            "First and Last Name",
            "Phone",
            "LastVisit"});
            this.searchMenuTab2.Location = new System.Drawing.Point(716, 31);
            this.searchMenuTab2.Name = "searchMenuTab2";
            this.searchMenuTab2.Size = new System.Drawing.Size(281, 54);
            this.searchMenuTab2.TabIndex = 20;
            // 
            // searchDataGrid
            // 
            this.searchDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.searchDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.searchDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.searchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.midInit,
            this.streetNameNumColumn1,
            this.cityColumnSearch,
            this.stateColumnSearch,
            this.zipColumnSearch,
            this.addr2,
            this.phone,
            this.adults,
            this.children,
            this.lastVisit});
            this.searchDataGrid.EnableHeadersVisualStyles = false;
            this.searchDataGrid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchDataGrid.Location = new System.Drawing.Point(0, 109);
            this.searchDataGrid.Name = "searchDataGrid";
            this.searchDataGrid.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.searchDataGrid.Size = new System.Drawing.Size(1365, 499);
            this.searchDataGrid.TabIndex = 3;
            this.searchDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchDataGrid_CellContentClick);
            // 
            // searchButtonTab2
            // 
            this.searchButtonTab2.Location = new System.Drawing.Point(1110, 26);
            this.searchButtonTab2.Name = "searchButtonTab2";
            this.searchButtonTab2.Size = new System.Drawing.Size(232, 62);
            this.searchButtonTab2.TabIndex = 2;
            this.searchButtonTab2.Text = "SEARCH";
            this.searchButtonTab2.UseVisualStyleBackColor = true;
            this.searchButtonTab2.Click += new System.EventHandler(this.searchButtonTab2_Click);
            // 
            // searchTextTab2
            // 
            this.searchTextTab2.Location = new System.Drawing.Point(169, 31);
            this.searchTextTab2.Name = "searchTextTab2";
            this.searchTextTab2.Size = new System.Drawing.Size(388, 53);
            this.searchTextTab2.TabIndex = 1;
            // 
            // searchLabelTab2
            // 
            this.searchLabelTab2.AutoSize = true;
            this.searchLabelTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.searchLabelTab2.Location = new System.Drawing.Point(42, 42);
            this.searchLabelTab2.Name = "searchLabelTab2";
            this.searchLabelTab2.Size = new System.Drawing.Size(121, 38);
            this.searchLabelTab2.TabIndex = 0;
            this.searchLabelTab2.Text = "Search";
            // 
            // statsTabPage
            // 
            this.statsTabPage.Controls.Add(this.yearMenuTab3);
            this.statsTabPage.Controls.Add(this.statsChart);
            this.statsTabPage.Controls.Add(this.searchButtonTab3);
            this.statsTabPage.Controls.Add(this.searchMenuTab3);
            this.statsTabPage.Controls.Add(this.monthMenuTab3);
            this.statsTabPage.Controls.Add(this.dayMenuTab3);
            this.statsTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.statsTabPage.Location = new System.Drawing.Point(4, 74);
            this.statsTabPage.Name = "statsTabPage";
            this.statsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.statsTabPage.Size = new System.Drawing.Size(1479, 705);
            this.statsTabPage.TabIndex = 5;
            this.statsTabPage.Text = "   STATISTICS   ";
            this.statsTabPage.UseVisualStyleBackColor = true;
            // 
            // yearMenuTab3
            // 
            this.yearMenuTab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearMenuTab3.Location = new System.Drawing.Point(920, 34);
            this.yearMenuTab3.Name = "yearMenuTab3";
            this.yearMenuTab3.Size = new System.Drawing.Size(173, 35);
            this.yearMenuTab3.TabIndex = 25;
            this.yearMenuTab3.Text = "Year";
            // 
            // statsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.statsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.statsChart.Legends.Add(legend1);
            this.statsChart.Location = new System.Drawing.Point(172, 111);
            this.statsChart.Name = "statsChart";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.Name = "Children";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "Adults";
            this.statsChart.Series.Add(series1);
            this.statsChart.Series.Add(series2);
            this.statsChart.Size = new System.Drawing.Size(880, 431);
            this.statsChart.TabIndex = 24;
            this.statsChart.Text = "chart1";
            // 
            // searchButtonTab3
            // 
            this.searchButtonTab3.Location = new System.Drawing.Point(1108, 33);
            this.searchButtonTab3.Name = "searchButtonTab3";
            this.searchButtonTab3.Size = new System.Drawing.Size(216, 51);
            this.searchButtonTab3.TabIndex = 23;
            this.searchButtonTab3.Text = "SEARCH";
            this.searchButtonTab3.UseVisualStyleBackColor = true;
            this.searchButtonTab3.Click += new System.EventHandler(this.searchButtonTab3_Click);
            // 
            // searchMenuTab3
            // 
            this.searchMenuTab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMenuTab3.FormattingEnabled = true;
            this.searchMenuTab3.Items.AddRange(new object[] {
            "Year",
            "Month",
            "Day"});
            this.searchMenuTab3.Location = new System.Drawing.Point(42, 33);
            this.searchMenuTab3.Name = "searchMenuTab3";
            this.searchMenuTab3.Size = new System.Drawing.Size(262, 37);
            this.searchMenuTab3.TabIndex = 22;
            this.searchMenuTab3.Text = "Search Criteria";
            // 
            // monthMenuTab3
            // 
            this.monthMenuTab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthMenuTab3.FormattingEnabled = true;
            this.monthMenuTab3.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthMenuTab3.Location = new System.Drawing.Point(362, 33);
            this.monthMenuTab3.Name = "monthMenuTab3";
            this.monthMenuTab3.Size = new System.Drawing.Size(229, 37);
            this.monthMenuTab3.TabIndex = 21;
            this.monthMenuTab3.Text = "January";
            // 
            // dayMenuTab3
            // 
            this.dayMenuTab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayMenuTab3.FormattingEnabled = true;
            this.dayMenuTab3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayMenuTab3.Location = new System.Drawing.Point(656, 33);
            this.dayMenuTab3.Name = "dayMenuTab3";
            this.dayMenuTab3.Size = new System.Drawing.Size(223, 37);
            this.dayMenuTab3.TabIndex = 20;
            this.dayMenuTab3.Text = "Day";
            // 
            // viewAllTabPage
            // 
            this.viewAllTabPage.Controls.Add(this.viewAllDataGrid);
            this.viewAllTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.viewAllTabPage.Location = new System.Drawing.Point(4, 74);
            this.viewAllTabPage.Name = "viewAllTabPage";
            this.viewAllTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.viewAllTabPage.Size = new System.Drawing.Size(1479, 705);
            this.viewAllTabPage.TabIndex = 6;
            this.viewAllTabPage.Text = "   VIEW ALL   ";
            this.viewAllTabPage.UseVisualStyleBackColor = true;
            // 
            // viewAllDataGrid
            // 
            this.viewAllDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.viewAllDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewAllDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.viewAllDataGrid.ColumnHeadersHeight = 41;
            this.viewAllDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.City,
            this.State,
            this.Zip,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.viewAllDataGrid.EnableHeadersVisualStyles = false;
            this.viewAllDataGrid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.viewAllDataGrid.Location = new System.Drawing.Point(3, 0);
            this.viewAllDataGrid.Name = "viewAllDataGrid";
            this.viewAllDataGrid.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewAllDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.viewAllDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.viewAllDataGrid.Size = new System.Drawing.Size(1480, 533);
            this.viewAllDataGrid.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.FillWeight = 10F;
            this.dataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 126;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 126;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "MI";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 59;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.HeaderText = "StreetName/Num";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 188;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "Address Line 2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 168;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 71;
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 83;
            // 
            // Zip
            // 
            this.Zip.HeaderText = "Zip";
            this.Zip.Name = "Zip";
            this.Zip.ReadOnly = true;
            this.Zip.Width = 64;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 94;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.HeaderText = "Adults";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 92;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.HeaderText = "Children";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 110;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.HeaderText = "Last Visit";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 116;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 53;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FirstName.FillWeight = 10F;
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 126;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 126;
            // 
            // midInit
            // 
            this.midInit.HeaderText = "MI";
            this.midInit.Name = "midInit";
            this.midInit.ReadOnly = true;
            this.midInit.Width = 59;
            // 
            // streetNameNumColumn1
            // 
            this.streetNameNumColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.streetNameNumColumn1.HeaderText = "St.Num/Name";
            this.streetNameNumColumn1.Name = "streetNameNumColumn1";
            this.streetNameNumColumn1.ReadOnly = true;
            this.streetNameNumColumn1.Width = 160;
            // 
            // cityColumnSearch
            // 
            this.cityColumnSearch.HeaderText = "City";
            this.cityColumnSearch.Name = "cityColumnSearch";
            this.cityColumnSearch.ReadOnly = true;
            this.cityColumnSearch.Width = 71;
            // 
            // stateColumnSearch
            // 
            this.stateColumnSearch.HeaderText = "State";
            this.stateColumnSearch.Name = "stateColumnSearch";
            this.stateColumnSearch.ReadOnly = true;
            this.stateColumnSearch.Width = 83;
            // 
            // zipColumnSearch
            // 
            this.zipColumnSearch.HeaderText = "Zip";
            this.zipColumnSearch.Name = "zipColumnSearch";
            this.zipColumnSearch.ReadOnly = true;
            this.zipColumnSearch.Width = 64;
            // 
            // addr2
            // 
            this.addr2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addr2.HeaderText = "Address Line 2";
            this.addr2.Name = "addr2";
            this.addr2.ReadOnly = true;
            this.addr2.Width = 168;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 94;
            // 
            // adults
            // 
            this.adults.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.adults.HeaderText = "Adults";
            this.adults.Name = "adults";
            this.adults.ReadOnly = true;
            this.adults.Width = 92;
            // 
            // children
            // 
            this.children.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.children.HeaderText = "Children";
            this.children.Name = "children";
            this.children.ReadOnly = true;
            this.children.Width = 110;
            // 
            // lastVisit
            // 
            this.lastVisit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lastVisit.HeaderText = "Last Visit";
            this.lastVisit.Name = "lastVisit";
            this.lastVisit.ReadOnly = true;
            this.lastVisit.Width = 116;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1489, 797);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Chard Wray Food Pantry";
            this.tabs.ResumeLayout(false);
            this.addNewEntryTabPage.ResumeLayout(false);
            this.addNewEntryTabPage.PerformLayout();
            this.SearchTabPage.ResumeLayout(false);
            this.SearchTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGrid)).EndInit();
            this.statsTabPage.ResumeLayout(false);
            this.statsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statsChart)).EndInit();
            this.viewAllTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewAllDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Label miLabel;
        private System.Windows.Forms.Label dateVistLabelTab1;
        private System.Windows.Forms.Label numChildLabel;
        private System.Windows.Forms.Label numAdultsLabel;
        private System.Windows.Forms.Label phoneLabel2;
        private System.Windows.Forms.Label addrNumName1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TabPage SearchTabPage;
        private System.Windows.Forms.Label searchLabelTab2;
        private System.Windows.Forms.TabPage statsTabPage;
        private System.Windows.Forms.TabPage viewAllTabPage;
        private System.Windows.Forms.TextBox searchTextTab2;
        private System.Windows.Forms.Button searchButtonTab2;
        private System.Windows.Forms.ComboBox searchMenuTab2;
        private System.Windows.Forms.Button searchButtonTab3;
        private System.Windows.Forms.ComboBox searchMenuTab3;
        private System.Windows.Forms.ComboBox monthMenuTab3;
        private System.Windows.Forms.ComboBox dayMenuTab3;
        private System.Windows.Forms.DataGridView viewAllDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewAllFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewAllLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewAllMiddleInitial;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewAllAddressLine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewAllAddressLine2;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewAllPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewAllAdults;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewAllChildren;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewAllPrevVisit;
        private System.Windows.Forms.TextBox yearMenuTab3;
        private System.Windows.Forms.Label cityLabelTab1;
        private System.Windows.Forms.Label stateLabel1;
        private System.Windows.Forms.Label zipLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        public System.Windows.Forms.DataGridView searchDataGrid;
        public System.Windows.Forms.TabPage addNewEntryTabPage;
        public System.Windows.Forms.TextBox fNameTextBox;
        public System.Windows.Forms.ComboBox dayMenuTab1;
        public System.Windows.Forms.ComboBox monthMenuTab1;
        public System.Windows.Forms.TextBox yearTab1;
        public System.Windows.Forms.TextBox numChildTextBox;
        public System.Windows.Forms.TextBox numAdultsTextBox;
        public System.Windows.Forms.TextBox phoneTextBox;
        public System.Windows.Forms.TextBox addrNumNameTextBox1;
        public System.Windows.Forms.TextBox lNameTextBox;
        public System.Windows.Forms.TextBox stateTextBox1;
        public System.Windows.Forms.TextBox cityTextBox1;
        public System.Windows.Forms.TextBox zipTextBox1;
        public System.Windows.Forms.TextBox addrTextBox2;
        public System.Windows.Forms.TextBox miTextBox;
        public System.Windows.Forms.Label successLabel;
        public System.Windows.Forms.Label failureLabel;
        public System.Windows.Forms.DataVisualization.Charting.Chart statsChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn midInit;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetNameNumColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityColumnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateColumnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipColumnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn addr2;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn adults;
        private System.Windows.Forms.DataGridViewTextBoxColumn children;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastVisit;
    }
}

