
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
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbobx_ColourFilters = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_update_filter = new System.Windows.Forms.Button();
            this.btn_delete_filter = new System.Windows.Forms.Button();
            this.btn_new_filter = new System.Windows.Forms.Button();
            this.lbl_filter_name = new System.Windows.Forms.Label();
            this.dgv_ColourFiltersData = new System.Windows.Forms.DataGridView();
            this.RedByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GreenByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlueByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlphaByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ColourFiltersData)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(1029, 679);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(141, 42);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(83, 647);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(141, 42);
            this.btn_help.TabIndex = 1;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(65, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1109, 525);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbobx_ColourFilters);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1101, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbobx_ColourFilters
            // 
            this.cmbobx_ColourFilters.FormattingEnabled = true;
            this.cmbobx_ColourFilters.Location = new System.Drawing.Point(609, 194);
            this.cmbobx_ColourFilters.Name = "cmbobx_ColourFilters";
            this.cmbobx_ColourFilters.Size = new System.Drawing.Size(351, 28);
            this.cmbobx_ColourFilters.Sorted = true;
            this.cmbobx_ColourFilters.TabIndex = 0;
            this.cmbobx_ColourFilters.SelectedIndexChanged += new System.EventHandler(this.cmbobx_ColourFilters_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_update_filter);
            this.tabPage2.Controls.Add(this.btn_delete_filter);
            this.tabPage2.Controls.Add(this.btn_new_filter);
            this.tabPage2.Controls.Add(this.lbl_filter_name);
            this.tabPage2.Controls.Add(this.dgv_ColourFiltersData);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1101, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_update_filter
            // 
            this.btn_update_filter.Location = new System.Drawing.Point(248, 408);
            this.btn_update_filter.Name = "btn_update_filter";
            this.btn_update_filter.Size = new System.Drawing.Size(138, 43);
            this.btn_update_filter.TabIndex = 5;
            this.btn_update_filter.Text = "Update Filter";
            this.btn_update_filter.UseVisualStyleBackColor = true;
            this.btn_update_filter.Click += new System.EventHandler(this.btn_update_filter_Click);
            // 
            // btn_delete_filter
            // 
            this.btn_delete_filter.Location = new System.Drawing.Point(82, 408);
            this.btn_delete_filter.Name = "btn_delete_filter";
            this.btn_delete_filter.Size = new System.Drawing.Size(138, 43);
            this.btn_delete_filter.TabIndex = 4;
            this.btn_delete_filter.Text = "Delete Filter";
            this.btn_delete_filter.UseVisualStyleBackColor = true;
            this.btn_delete_filter.Click += new System.EventHandler(this.btn_delete_filter_Click);
            // 
            // btn_new_filter
            // 
            this.btn_new_filter.Location = new System.Drawing.Point(838, 408);
            this.btn_new_filter.Name = "btn_new_filter";
            this.btn_new_filter.Size = new System.Drawing.Size(152, 43);
            this.btn_new_filter.TabIndex = 3;
            this.btn_new_filter.Text = "Create New Filter";
            this.btn_new_filter.UseVisualStyleBackColor = true;
            this.btn_new_filter.Click += new System.EventHandler(this.btn_new_filter_Click);
            // 
            // lbl_filter_name
            // 
            this.lbl_filter_name.AutoSize = true;
            this.lbl_filter_name.Location = new System.Drawing.Point(90, 33);
            this.lbl_filter_name.Name = "lbl_filter_name";
            this.lbl_filter_name.Size = new System.Drawing.Size(51, 20);
            this.lbl_filter_name.TabIndex = 2;
            this.lbl_filter_name.Text = "label1";
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
            this.dgv_ColourFiltersData.Location = new System.Drawing.Point(82, 67);
            this.dgv_ColourFiltersData.Name = "dgv_ColourFiltersData";
            this.dgv_ColourFiltersData.RowHeadersWidth = 62;
            this.dgv_ColourFiltersData.RowTemplate.Height = 28;
            this.dgv_ColourFiltersData.Size = new System.Drawing.Size(908, 320);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 756);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Colour Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ColourFiltersData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbobx_ColourFilters;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}

