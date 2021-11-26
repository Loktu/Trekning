namespace Trekning
{
    partial class FormTrekning
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
            this.dataGridViewTrekning = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrekning)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTrekning
            // 
            this.dataGridViewTrekning.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTrekning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrekning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTrekning.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTrekning.Name = "dataGridViewTrekning";
            this.dataGridViewTrekning.Size = new System.Drawing.Size(206, 603);
            this.dataGridViewTrekning.TabIndex = 0;
            // 
            // FormTrekning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 603);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewTrekning);
            this.Name = "FormTrekning";
            this.Text = "Trekning";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrekning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTrekning;
    }
}