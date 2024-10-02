
namespace ColourChanger
{
    partial class FilterName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterName));
            this.btn_filterName_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_filterName = new System.Windows.Forms.TextBox();
            this.btn_filterName_go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_filterName_exit
            // 
            this.btn_filterName_exit.Location = new System.Drawing.Point(25, 106);
            this.btn_filterName_exit.Name = "btn_filterName_exit";
            this.btn_filterName_exit.Size = new System.Drawing.Size(153, 56);
            this.btn_filterName_exit.TabIndex = 11;
            this.btn_filterName_exit.Text = "Exit";
            this.btn_filterName_exit.UseVisualStyleBackColor = true;
            this.btn_filterName_exit.Click += new System.EventHandler(this.btn_filterName_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filter Name:";
            // 
            // txtbx_filterName
            // 
            this.txtbx_filterName.Location = new System.Drawing.Point(148, 32);
            this.txtbx_filterName.Name = "txtbx_filterName";
            this.txtbx_filterName.Size = new System.Drawing.Size(604, 26);
            this.txtbx_filterName.TabIndex = 9;
            // 
            // btn_filterName_go
            // 
            this.btn_filterName_go.Location = new System.Drawing.Point(599, 106);
            this.btn_filterName_go.Name = "btn_filterName_go";
            this.btn_filterName_go.Size = new System.Drawing.Size(153, 56);
            this.btn_filterName_go.TabIndex = 10;
            this.btn_filterName_go.Text = "Go";
            this.btn_filterName_go.UseVisualStyleBackColor = true;
            this.btn_filterName_go.Click += new System.EventHandler(this.btn_filterName_go_Click);
            // 
            // FilterName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 199);
            this.Controls.Add(this.btn_filterName_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_filterName);
            this.Controls.Add(this.btn_filterName_go);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterName";
            this.Text = "FilterName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_filterName_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_filterName;
        private System.Windows.Forms.Button btn_filterName_go;
    }
}