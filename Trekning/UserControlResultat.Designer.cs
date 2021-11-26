namespace Trekning
{
   partial class UserControlResultat
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.dataGridViewResultat = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultat)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGridViewResultat
         // 
         this.dataGridViewResultat.AllowUserToAddRows = false;
         this.dataGridViewResultat.AllowUserToDeleteRows = false;
         this.dataGridViewResultat.AllowUserToOrderColumns = true;
         this.dataGridViewResultat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
         this.dataGridViewResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridViewResultat.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dataGridViewResultat.Location = new System.Drawing.Point(0, 0);
         this.dataGridViewResultat.Name = "dataGridViewResultat";
         this.dataGridViewResultat.ReadOnly = true;
         this.dataGridViewResultat.Size = new System.Drawing.Size(506, 416);
         this.dataGridViewResultat.TabIndex = 1;
         // 
         // UserControlResultatcs
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.dataGridViewResultat);
         this.Name = "UserControlResultatcs";
         this.Size = new System.Drawing.Size(506, 416);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultat)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView dataGridViewResultat;
   }
}
