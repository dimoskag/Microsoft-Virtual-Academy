namespace SimpleDataApp
{
   partial class NewCustomer
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
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.txtCustomerID = new System.Windows.Forms.TextBox();
         this.txtCustomerName = new System.Windows.Forms.TextBox();
         this.btnCreateAccount = new System.Windows.Forms.Button();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.numOrderAmount = new System.Windows.Forms.NumericUpDown();
         this.btnPlaceOrder = new System.Windows.Forms.Button();
         this.btnAddFinish = new System.Windows.Forms.Button();
         this.btnAddAnotherAccount = new System.Windows.Forms.Button();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).BeginInit();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.txtCustomerID);
         this.groupBox1.Controls.Add(this.txtCustomerName);
         this.groupBox1.Location = new System.Drawing.Point(12, 12);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(264, 116);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Add Account";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(6, 79);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(68, 13);
         this.label2.TabIndex = 3;
         this.label2.Text = "Customer ID:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(6, 33);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(85, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "Customer Name:";
         // 
         // txtCustomerID
         // 
         this.txtCustomerID.Location = new System.Drawing.Point(145, 76);
         this.txtCustomerID.Name = "txtCustomerID";
         this.txtCustomerID.ReadOnly = true;
         this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
         this.txtCustomerID.TabIndex = 1;
         // 
         // txtCustomerName
         // 
         this.txtCustomerName.Location = new System.Drawing.Point(97, 30);
         this.txtCustomerName.Name = "txtCustomerName";
         this.txtCustomerName.Size = new System.Drawing.Size(148, 20);
         this.txtCustomerName.TabIndex = 0;
         // 
         // btnCreateAccount
         // 
         this.btnCreateAccount.Location = new System.Drawing.Point(282, 91);
         this.btnCreateAccount.Name = "btnCreateAccount";
         this.btnCreateAccount.Size = new System.Drawing.Size(75, 23);
         this.btnCreateAccount.TabIndex = 1;
         this.btnCreateAccount.Text = "Create Account";
         this.btnCreateAccount.UseVisualStyleBackColor = true;
         this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.dtpOrderDate);
         this.groupBox2.Controls.Add(this.label4);
         this.groupBox2.Controls.Add(this.label3);
         this.groupBox2.Controls.Add(this.numOrderAmount);
         this.groupBox2.Location = new System.Drawing.Point(12, 134);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(264, 107);
         this.groupBox2.TabIndex = 2;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Create Order";
         // 
         // dtpOrderDate
         // 
         this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
         this.dtpOrderDate.Location = new System.Drawing.Point(87, 64);
         this.dtpOrderDate.Name = "dtpOrderDate";
         this.dtpOrderDate.Size = new System.Drawing.Size(158, 20);
         this.dtpOrderDate.TabIndex = 3;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(6, 70);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(62, 13);
         this.label4.TabIndex = 2;
         this.label4.Text = "Order Date:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(6, 29);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(75, 13);
         this.label3.TabIndex = 1;
         this.label3.Text = "Order Amount:";
         // 
         // numOrderAmount
         // 
         this.numOrderAmount.Location = new System.Drawing.Point(87, 27);
         this.numOrderAmount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
         this.numOrderAmount.Name = "numOrderAmount";
         this.numOrderAmount.Size = new System.Drawing.Size(158, 20);
         this.numOrderAmount.TabIndex = 0;
         this.numOrderAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.numOrderAmount.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
         // 
         // btnPlaceOrder
         // 
         this.btnPlaceOrder.Location = new System.Drawing.Point(283, 204);
         this.btnPlaceOrder.Name = "btnPlaceOrder";
         this.btnPlaceOrder.Size = new System.Drawing.Size(74, 23);
         this.btnPlaceOrder.TabIndex = 3;
         this.btnPlaceOrder.Text = "Place Order";
         this.btnPlaceOrder.UseVisualStyleBackColor = true;
         this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
         // 
         // btnAddFinish
         // 
         this.btnAddFinish.Location = new System.Drawing.Point(282, 269);
         this.btnAddFinish.Name = "btnAddFinish";
         this.btnAddFinish.Size = new System.Drawing.Size(75, 23);
         this.btnAddFinish.TabIndex = 4;
         this.btnAddFinish.Text = "Finish";
         this.btnAddFinish.UseVisualStyleBackColor = true;
         this.btnAddFinish.Click += new System.EventHandler(this.btnAddFinish_Click);
         // 
         // btnAddAnotherAccount
         // 
         this.btnAddAnotherAccount.Location = new System.Drawing.Point(21, 269);
         this.btnAddAnotherAccount.Name = "btnAddAnotherAccount";
         this.btnAddAnotherAccount.Size = new System.Drawing.Size(121, 23);
         this.btnAddAnotherAccount.TabIndex = 5;
         this.btnAddAnotherAccount.Text = "Add Another Account";
         this.btnAddAnotherAccount.UseVisualStyleBackColor = true;
         this.btnAddAnotherAccount.Click += new System.EventHandler(this.btnAddAnotherAccount_Click);
         // 
         // NewCustomer
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(388, 316);
         this.Controls.Add(this.btnAddAnotherAccount);
         this.Controls.Add(this.btnAddFinish);
         this.Controls.Add(this.btnPlaceOrder);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.btnCreateAccount);
         this.Controls.Add(this.groupBox1);
         this.Name = "NewCustomer";
         this.Text = "NewCustomer";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtCustomerID;
      private System.Windows.Forms.TextBox txtCustomerName;
      private System.Windows.Forms.Button btnCreateAccount;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.NumericUpDown numOrderAmount;
      private System.Windows.Forms.DateTimePicker dtpOrderDate;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button btnPlaceOrder;
      private System.Windows.Forms.Button btnAddFinish;
      private System.Windows.Forms.Button btnAddAnotherAccount;
   }
}