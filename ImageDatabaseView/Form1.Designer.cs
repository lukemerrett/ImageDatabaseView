using System.Windows.Forms;

namespace ImageDatabaseView
{
    partial class Form1
    {
        private BindingSource accessBindingSource;
        private DataGridView accessDataGridView;

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
            this.components = new System.ComponentModel.Container();
            this.accessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.accessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // accessDataGridView
            // 
            this.accessDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accessDataGridView.Location = new System.Drawing.Point(12, 12);
            this.accessDataGridView.Name = "accessDataGridView";
            this.accessDataGridView.Size = new System.Drawing.Size(776, 426);
            this.accessDataGridView.TabIndex = 0;
            this.accessDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.accessDataGridView_CellFormatting);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.accessDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

