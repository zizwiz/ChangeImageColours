
namespace ColourChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_filters = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_ColourFiltersData = new System.Windows.Forms.DataGridView();
            this.RedByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GreenByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlueByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlphaByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.cmbobx_ColourFilters = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_apply_filter = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbl_filter_name = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_delete_filter = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btn_update_filter = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btn_new_filter = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btn_open_image = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btn_save_image = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.picbx_Original = new System.Windows.Forms.PictureBox();
            this.picbx_result = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tab_filters.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ColourFiltersData)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel15.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_result)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(31, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(141, 42);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(30, 3);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(141, 42);
            this.btn_help.TabIndex = 1;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_filters);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1444, 306);
            this.tabControl1.TabIndex = 2;
            // 
            // tab_filters
            // 
            this.tab_filters.Controls.Add(this.tableLayoutPanel5);
            this.tab_filters.Location = new System.Drawing.Point(4, 29);
            this.tab_filters.Name = "tab_filters";
            this.tab_filters.Padding = new System.Windows.Forms.Padding(3);
            this.tab_filters.Size = new System.Drawing.Size(1436, 273);
            this.tab_filters.TabIndex = 1;
            this.tab_filters.Text = "Filters";
            this.tab_filters.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1430, 267);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_ColourFiltersData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(852, 261);
            this.panel3.TabIndex = 0;
            // 
            // dgv_ColourFiltersData
            // 
            this.dgv_ColourFiltersData.AllowUserToAddRows = false;
            this.dgv_ColourFiltersData.AllowUserToDeleteRows = false;
            this.dgv_ColourFiltersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ColourFiltersData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RedByte,
            this.GreenByte,
            this.BlueByte,
            this.AlphaByte,
            this.NotUsed});
            this.dgv_ColourFiltersData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ColourFiltersData.Location = new System.Drawing.Point(0, 0);
            this.dgv_ColourFiltersData.Name = "dgv_ColourFiltersData";
            this.dgv_ColourFiltersData.RowHeadersWidth = 62;
            this.dgv_ColourFiltersData.RowTemplate.Height = 28;
            this.dgv_ColourFiltersData.Size = new System.Drawing.Size(852, 261);
            this.dgv_ColourFiltersData.TabIndex = 0;
            // 
            // RedByte
            // 
            this.RedByte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RedByte.HeaderText = "Red Byte";
            this.RedByte.MinimumWidth = 8;
            this.RedByte.Name = "RedByte";
            this.RedByte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GreenByte
            // 
            this.GreenByte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GreenByte.HeaderText = "Green Byte";
            this.GreenByte.MinimumWidth = 8;
            this.GreenByte.Name = "GreenByte";
            this.GreenByte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BlueByte
            // 
            this.BlueByte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BlueByte.HeaderText = "Blue Byte";
            this.BlueByte.MinimumWidth = 8;
            this.BlueByte.Name = "BlueByte";
            this.BlueByte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AlphaByte
            // 
            this.AlphaByte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AlphaByte.HeaderText = "Alpha Byte";
            this.AlphaByte.MinimumWidth = 8;
            this.AlphaByte.Name = "AlphaByte";
            this.AlphaByte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NotUsed
            // 
            this.NotUsed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NotUsed.HeaderText = "Not Used";
            this.NotUsed.MinimumWidth = 8;
            this.NotUsed.Name = "NotUsed";
            this.NotUsed.ReadOnly = true;
            this.NotUsed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(861, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(566, 261);
            this.panel4.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(566, 261);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel15);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(560, 46);
            this.panel5.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.cmbobx_ColourFilters);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(560, 46);
            this.panel15.TabIndex = 0;
            // 
            // cmbobx_ColourFilters
            // 
            this.cmbobx_ColourFilters.FormattingEnabled = true;
            this.cmbobx_ColourFilters.Location = new System.Drawing.Point(44, 9);
            this.cmbobx_ColourFilters.Name = "cmbobx_ColourFilters";
            this.cmbobx_ColourFilters.Size = new System.Drawing.Size(472, 28);
            this.cmbobx_ColourFilters.Sorted = true;
            this.cmbobx_ColourFilters.TabIndex = 0;
            this.cmbobx_ColourFilters.SelectedIndexChanged += new System.EventHandler(this.cmbobx_ColourFilters_SelectedIndexChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 7;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel7.Controls.Add(this.panel6, 5, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel8, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel9, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.panel10, 5, 2);
            this.tableLayoutPanel7.Controls.Add(this.panel11, 3, 2);
            this.tableLayoutPanel7.Controls.Add(this.panel12, 1, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 5;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(560, 203);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(378, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(174, 58);
            this.panel6.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_apply_filter);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(8, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(174, 58);
            this.panel7.TabIndex = 7;
            // 
            // btn_apply_filter
            // 
            this.btn_apply_filter.Location = new System.Drawing.Point(18, 8);
            this.btn_apply_filter.Name = "btn_apply_filter";
            this.btn_apply_filter.Size = new System.Drawing.Size(138, 43);
            this.btn_apply_filter.TabIndex = 7;
            this.btn_apply_filter.Text = "Apply Filter";
            this.btn_apply_filter.UseVisualStyleBackColor = true;
            this.btn_apply_filter.Click += new System.EventHandler(this.btn_apply_filter_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_reset);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(193, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(174, 58);
            this.panel8.TabIndex = 8;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(17, 8);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(138, 43);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lbl_filter_name);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(8, 141);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(174, 59);
            this.panel9.TabIndex = 9;
            // 
            // lbl_filter_name
            // 
            this.lbl_filter_name.AutoSize = true;
            this.lbl_filter_name.Location = new System.Drawing.Point(65, 19);
            this.lbl_filter_name.Name = "lbl_filter_name";
            this.lbl_filter_name.Size = new System.Drawing.Size(51, 20);
            this.lbl_filter_name.TabIndex = 2;
            this.lbl_filter_name.Text = "label1";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btn_delete_filter);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(378, 72);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(174, 58);
            this.panel10.TabIndex = 10;
            // 
            // btn_delete_filter
            // 
            this.btn_delete_filter.Location = new System.Drawing.Point(17, 8);
            this.btn_delete_filter.Name = "btn_delete_filter";
            this.btn_delete_filter.Size = new System.Drawing.Size(138, 43);
            this.btn_delete_filter.TabIndex = 4;
            this.btn_delete_filter.Text = "Delete Filter";
            this.btn_delete_filter.UseVisualStyleBackColor = true;
            this.btn_delete_filter.Click += new System.EventHandler(this.btn_delete_filter_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btn_update_filter);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(193, 72);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(174, 58);
            this.panel11.TabIndex = 11;
            // 
            // btn_update_filter
            // 
            this.btn_update_filter.Location = new System.Drawing.Point(17, 8);
            this.btn_update_filter.Name = "btn_update_filter";
            this.btn_update_filter.Size = new System.Drawing.Size(138, 43);
            this.btn_update_filter.TabIndex = 5;
            this.btn_update_filter.Text = "Update Filter";
            this.btn_update_filter.UseVisualStyleBackColor = true;
            this.btn_update_filter.Click += new System.EventHandler(this.btn_update_filter_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btn_new_filter);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(8, 72);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(174, 58);
            this.panel12.TabIndex = 12;
            // 
            // btn_new_filter
            // 
            this.btn_new_filter.Location = new System.Drawing.Point(10, 8);
            this.btn_new_filter.Name = "btn_new_filter";
            this.btn_new_filter.Size = new System.Drawing.Size(152, 43);
            this.btn_new_filter.TabIndex = 3;
            this.btn_new_filter.Text = "Create New Filter";
            this.btn_new_filter.UseVisualStyleBackColor = true;
            this.btn_new_filter.Click += new System.EventHandler(this.btn_new_filter_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1436, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ToDo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1456, 827);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 13;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 11, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel13, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel14, 7, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 770);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1450, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_help);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 48);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1247, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 48);
            this.panel2.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btn_open_image);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(525, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(194, 48);
            this.panel13.TabIndex = 2;
            // 
            // btn_open_image
            // 
            this.btn_open_image.Location = new System.Drawing.Point(27, 3);
            this.btn_open_image.Name = "btn_open_image";
            this.btn_open_image.Size = new System.Drawing.Size(141, 42);
            this.btn_open_image.TabIndex = 1;
            this.btn_open_image.Text = "Open Image";
            this.btn_open_image.UseVisualStyleBackColor = true;
            this.btn_open_image.Click += new System.EventHandler(this.btn_open_image_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btn_save_image);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(730, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(194, 48);
            this.panel14.TabIndex = 3;
            // 
            // btn_save_image
            // 
            this.btn_save_image.Location = new System.Drawing.Point(27, 3);
            this.btn_save_image.Name = "btn_save_image";
            this.btn_save_image.Size = new System.Drawing.Size(141, 42);
            this.btn_save_image.TabIndex = 1;
            this.btn_save_image.Text = "Save Image";
            this.btn_save_image.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.13009F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.86991F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1450, 761);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.picbx_Original, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.picbx_result, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 317);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1442, 439);
            this.tableLayoutPanel4.TabIndex = 16;
            // 
            // picbx_Original
            // 
            this.picbx_Original.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbx_Original.Location = new System.Drawing.Point(4, 5);
            this.picbx_Original.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picbx_Original.Name = "picbx_Original";
            this.picbx_Original.Size = new System.Drawing.Size(713, 429);
            this.picbx_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_Original.TabIndex = 3;
            this.picbx_Original.TabStop = false;
            // 
            // picbx_result
            // 
            this.picbx_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbx_result.Location = new System.Drawing.Point(725, 5);
            this.picbx_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picbx_result.Name = "picbx_result";
            this.picbx_result.Size = new System.Drawing.Size(713, 429);
            this.picbx_result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_result.TabIndex = 4;
            this.picbx_result.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 827);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1478, 833);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colour Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_filters.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ColourFiltersData)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbobx_ColourFilters;
        private System.Windows.Forms.TabPage tab_filters;
        private System.Windows.Forms.DataGridView dgv_ColourFiltersData;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn GreenByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlueByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlphaByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotUsed;
        private System.Windows.Forms.Label lbl_filter_name;
        private System.Windows.Forms.Button btn_update_filter;
        private System.Windows.Forms.Button btn_delete_filter;
        private System.Windows.Forms.Button btn_new_filter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox picbx_Original;
        private System.Windows.Forms.PictureBox picbx_result;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btn_open_image;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btn_save_image;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btn_apply_filter;
    }
}

