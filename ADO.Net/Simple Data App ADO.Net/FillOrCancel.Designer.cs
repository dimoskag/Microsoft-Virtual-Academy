namespace SimpleDataApp
{
   partial class FillOrCancel
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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.btnFindByOrderID = new System.Windows.Forms.Button();
         this.btnCancelOrder = new System.Windows.Forms.Button();
         this.btnFillOrder = new System.Windows.Forms.Button();
         this.btnFinishUpdates = new System.Windows.Forms.Button();
         this.dtpFillDate = new System.Windows.Forms.DateTimePicker();
         this.dgvCustomerOrders = new System.Windows.Forms.DataGridView();
         this.txtOrderID = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(9, 23);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(50, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Order ID:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 64);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(90, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Specify filled date";
         // 
         // btnFindByOrderID
         // 
         this.btnFindByOrderID.Location = new System.Drawing.Point(204, 18);
         this.btnFindByOrderID.Name = "btnFindByOrderID";
         this.btnFindByOrderID.Size = new System.Drawing.Size(95, 23);
         this.btnFindByOrderID.TabIndex = 2;
         this.btnFindByOrderID.Text = "Find Order";
         this.btnFindByOrderID.UseVisualStyleBackColor = true;
         this.btnFindByOrderID.Click += new System.EventHandler(this.btnFindByOrderID_Click);
         // 
         // btnCancelOrder
         // 
         this.btnCancelOrder.Location = new System.Drawing.Point(12, 262);
         this.btnCancelOrder.Name = "btnCancelOrder";
         this.btnCancelOrder.Size = new System.Drawing.Size(90, 23);
         this.btnCancelOrder.TabIndex = 3;
         this.btnCancelOrder.Text = "Cancel Order";
         this.btnCancelOrder.UseVisualStyleBackColor = true;
         this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
         // 
         // btnFillOrder
         // 
         this.btnFillOrder.Location = new System.Drawing.Point(169, 262);
         this.btnFillOrder.Name = "btnFillOrder";
         this.btnFillOrder.Size = new System.Drawing.Size(82, 23);
         this.btnFillOrder.TabIndex = 4;
         this.btnFillOrder.Text = "Fill Order";
         this.btnFillOrder.UseVisualStyleBackColor = true;
         this.btnFillOrder.Click += new System.EventHandler(this.btnFillOrder_Click);
         // 
         // btnFinishUpdates
         // 
         this.btnFinishUpdates.Location = new System.Drawing.Point(375, 262);
         this.btnFinishUpdates.Name = "btnFinishUpdates";
         this.btnFinishUpdates.Size = new System.Drawing.Size(75, 23);
         this.btnFinishUpdates.TabIndex = 5;
         this.btnFinishUpdates.Text = "Finish";
         this.btnFinishUpdates.UseVisualStyleBackColor = true;
         this.btnFinishUpdates.Click += new System.EventHandler(this.btnFinishUpdates_Click);
         // 
         // dtpFillDate
         // 
         this.dtpFillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
         this.dtpFillDate.Location = new System.Drawing.Point(108, 58);
         this.dtpFillDate.Name = "dtpFillDate";
         this.dtpFillDate.Size = new System.Drawing.Size(200, 20);
         this.dtpFillDate.TabIndex = 6;
         // 
         // dgvCustomerOrders
         // 
         this.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvCustomerOrders.Location = new System.Drawing.Point(12, 100);
         this.dgvCustomerOrders.Name = "dgvCustomerOrders";
         this.dgvCustomerOrders.ReadOnly = true;
         this.dgvCustomerOrders.RowHeadersVisible = false;
         this.dgvCustomerOrders.Size = new System.Drawing.Size(438, 156);
         this.dgvCustomerOrders.TabIndex = 7;
         // 
         // txtOrderID
         // 
         this.txtOrderID.Location = new System.Drawing.Point(65, 20);
         this.txtOrderID.Name = "txtOrderID";
         this.txtOrderID.Size = new System.Drawing.Size(133, 20);
         this.txtOrderID.TabIndex = 8;
         // 
         // FillOrCancel
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(462, 299);
         this.Controls.Add(this.txtOrderID);
         this.Controls.Add(this.dgvCustomerOrders);
         this.Controls.Add(this.dtpFillDate);
         this.Controls.Add(this.btnFinishUpdates);
         this.Controls.Add(this.btnFillOrder);
         this.Controls.Add(this.btnCancelOrder);
         this.Controls.Add(this.btnFindByOrderID);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "FillOrCancel";
         this.Text = "FillOrCancel";
         ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button btnFindByOrderID;
      private System.Windows.Forms.Button btnCancelOrder;
      private System.Windows.Forms.Button btnFillOrder;
      private System.Windows.Forms.Button btnFinishUpdates;
      private System.Windows.Forms.DateTimePicker dtpFillDate;
      private System.Windows.Forms.DataGridView dgvCustomerOrders;
      private System.Windows.Forms.TextBox txtOrderID;
   }
}
