
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
            this.tabChangeImageColours = new System.Windows.Forms.TabPage();
            this.tabModifyFilters = new System.Windows.Forms.TabPage();
            this.cmbobx_ColourFilters = new System.Windows.Forms.ComboBox();
            this.dgv_ColourFiltersData = new System.Windows.Forms.DataGridView();
            this.RedByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GreenByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlueByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlphaByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabChangeImageColours.SuspendLayout();
            this.tabModifyFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ColourFiltersData)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(1001, 593);
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
            this.tabControl1.Controls.Add(this.tabChangeImageColours);
            this.tabControl1.Controls.Add(this.tabModifyFilters);
            this.tabControl1.Location = new System.Drawing.Point(115, 112);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1007, 379);
            this.tabControl1.TabIndex = 2;
            // 
            // tabChangeImageColours
            // 
            this.tabChangeImageColours.Controls.Add(this.cmbobx_ColourFilters);
            this.tabChangeImageColours.Location = new System.Drawing.Point(4, 29);
            this.tabChangeImageColours.Name = "tabChangeImageColours";
            this.tabChangeImageColours.Padding = new System.Windows.Forms.Padding(3);
            this.tabChangeImageColours.Size = new System.Drawing.Size(824, 346);
            this.tabChangeImageColours.TabIndex = 0;
            this.tabChangeImageColours.Text = "Change Image Colours";
            this.tabChangeImageColours.UseVisualStyleBackColor = true;
            // 
            // tabModifyFilters
            // 
            this.tabModifyFilters.Controls.Add(this.dgv_ColourFiltersData);
            this.tabModifyFilters.Location = new System.Drawing.Point(4, 29);
            this.tabModifyFilters.Name = "tabModifyFilters";
            this.tabModifyFilters.Padding = new System.Windows.Forms.Padding(3);
            this.tabModifyFilters.Size = new System.Drawing.Size(999, 346);
            this.tabModifyFilters.TabIndex = 1;
            this.tabModifyFilters.Text = "Modify Image Colour Filters";
            this.tabModifyFilters.UseVisualStyleBackColor = true;
            // 
            // cmbobx_ColourFilters
            // 
            this.cmbobx_ColourFilters.FormattingEnabled = true;
            this.cmbobx_ColourFilters.Location = new System.Drawing.Point(533, 34);
            this.cmbobx_ColourFilters.Name = "cmbobx_ColourFilters";
            this.cmbobx_ColourFilters.Size = new System.Drawing.Size(245, 28);
            this.cmbobx_ColourFilters.TabIndex = 0;
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
            this.dgv_ColourFiltersData.Location = new System.Drawing.Point(70, 55);
            this.dgv_ColourFiltersData.Name = "dgv_ColourFiltersData";
            this.dgv_ColourFiltersData.RowHeadersWidth = 62;
            this.dgv_ColourFiltersData.RowTemplate.Height = 28;
            this.dgv_ColourFiltersData.Size = new System.Drawing.Size(855, 191);
            this.dgv_ColourFiltersData.TabIndex = 0;
            // 
            // RedByte
            // 
            this.RedByte.HeaderText = "Red Byte";
            this.RedByte.MinimumWidth = 8;
            this.RedByte.Name = "RedByte";
            this.RedByte.Width = 150;
            // 
            // GreenByte
            // 
            this.GreenByte.HeaderText = "Green Byte";
            this.GreenByte.MinimumWidth = 8;
            this.GreenByte.Name = "GreenByte";
            this.GreenByte.Width = 150;
            // 
            // BlueByte
            // 
            this.BlueByte.HeaderText = "Blue Byte";
            this.BlueByte.MinimumWidth = 8;
            this.BlueByte.Name = "BlueByte";
            this.BlueByte.Width = 150;
            // 
            // AlphaByte
            // 
            this.AlphaByte.HeaderText = "Alpha Byte";
            this.AlphaByte.MinimumWidth = 8;
            this.AlphaByte.Name = "AlphaByte";
            this.AlphaByte.Width = 150;
            // 
            // NotUsed
            // 
            this.NotUsed.HeaderText = "NotUsed";
            this.NotUsed.MinimumWidth = 8;
            this.NotUsed.Name = "NotUsed";
            this.NotUsed.Width = 150;
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
            this.tabChangeImageColours.ResumeLayout(false);
            this.tabModifyFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ColourFiltersData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabChangeImageColours;
        private System.Windows.Forms.ComboBox cmbobx_ColourFilters;
        private System.Windows.Forms.TabPage tabModifyFilters;
        private System.Windows.Forms.DataGridView dgv_ColourFiltersData;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn GreenByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlueByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlphaByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotUsed;
    }
}

