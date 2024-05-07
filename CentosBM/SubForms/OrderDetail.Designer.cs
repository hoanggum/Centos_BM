﻿namespace CentosBM.SubForms
{
    partial class OrderDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxShipmentStatus = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxOrderStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxCustomerAddress = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelOrderTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelOrderDetail = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxShipmentStatus);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.comboBoxOrderStatus);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxCustomerPhoneNumber);
            this.panel1.Controls.Add(this.textBoxCustomerAddress);
            this.panel1.Controls.Add(this.textBoxCustomerName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelOrderDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelOrderID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 193);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxShipmentStatus
            // 
            this.comboBoxShipmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShipmentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxShipmentStatus.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxShipmentStatus.FormattingEnabled = true;
            this.comboBoxShipmentStatus.Items.AddRange(new object[] {
            "Chờ giao hàng"});
            this.comboBoxShipmentStatus.Location = new System.Drawing.Point(227, 142);
            this.comboBoxShipmentStatus.Margin = new System.Windows.Forms.Padding(11, 5, 0, 0);
            this.comboBoxShipmentStatus.Name = "comboBoxShipmentStatus";
            this.comboBoxShipmentStatus.Size = new System.Drawing.Size(330, 34);
            this.comboBoxShipmentStatus.Sorted = true;
            this.comboBoxShipmentStatus.TabIndex = 13;
            this.comboBoxShipmentStatus.SelectedValueChanged += new System.EventHandler(this.comboBoxShipmentStatus_SelectedValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(561, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 26);
            this.label15.TabIndex = 12;
            this.label15.Text = "Thanh toán:";
            // 
            // comboBoxOrderStatus
            // 
            this.comboBoxOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxOrderStatus.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxOrderStatus.FormattingEnabled = true;
            this.comboBoxOrderStatus.Items.AddRange(new object[] {
            "Đã thanh toán"});
            this.comboBoxOrderStatus.Location = new System.Drawing.Point(706, 142);
            this.comboBoxOrderStatus.Margin = new System.Windows.Forms.Padding(11, 5, 0, 0);
            this.comboBoxOrderStatus.Name = "comboBoxOrderStatus";
            this.comboBoxOrderStatus.Size = new System.Drawing.Size(194, 34);
            this.comboBoxOrderStatus.Sorted = true;
            this.comboBoxOrderStatus.TabIndex = 11;
            this.comboBoxOrderStatus.SelectionChangeCommitted += new System.EventHandler(this.comboBoxShipmentStatus_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 26);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tình trạng đơn hàng:";
            // 
            // textBoxCustomerPhoneNumber
            // 
            this.textBoxCustomerPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxCustomerPhoneNumber.Location = new System.Drawing.Point(706, 52);
            this.textBoxCustomerPhoneNumber.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxCustomerPhoneNumber.Multiline = true;
            this.textBoxCustomerPhoneNumber.Name = "textBoxCustomerPhoneNumber";
            this.textBoxCustomerPhoneNumber.Size = new System.Drawing.Size(194, 32);
            this.textBoxCustomerPhoneNumber.TabIndex = 9;
            this.textBoxCustomerPhoneNumber.TextChanged += new System.EventHandler(this.comboBoxShipmentStatus_SelectedValueChanged);
            // 
            // textBoxCustomerAddress
            // 
            this.textBoxCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxCustomerAddress.Location = new System.Drawing.Point(227, 99);
            this.textBoxCustomerAddress.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxCustomerAddress.Multiline = true;
            this.textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            this.textBoxCustomerAddress.Size = new System.Drawing.Size(673, 32);
            this.textBoxCustomerAddress.TabIndex = 8;
            this.textBoxCustomerAddress.TextChanged += new System.EventHandler(this.comboBoxShipmentStatus_SelectedValueChanged);
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxCustomerName.Location = new System.Drawing.Point(227, 52);
            this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxCustomerName.Multiline = true;
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(330, 32);
            this.textBoxCustomerName.TabIndex = 7;
            this.textBoxCustomerName.TextChanged += new System.EventHandler(this.comboBoxShipmentStatus_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(14, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(561, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên khách hàng:";
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderDate.ForeColor = System.Drawing.Color.Black;
            this.labelOrderDate.Location = new System.Drawing.Point(702, 11);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(120, 26);
            this.labelOrderDate.TabIndex = 3;
            this.labelOrderDate.Text = "20/12/2023";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(559, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày tạo đơn:";
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderID.ForeColor = System.Drawing.Color.Black;
            this.labelOrderID.Location = new System.Drawing.Point(223, 11);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(79, 26);
            this.labelOrderID.TabIndex = 1;
            this.labelOrderID.Text = "Order1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancelOrder);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.labelEmployeeID);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.labelOrderTotal);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.labelEmployeeName);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 756);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 183);
            this.panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(25, 110);
            this.btnSave.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 50);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCancelOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnCancelOrder.FlatAppearance.BorderSize = 0;
            this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCancelOrder.ForeColor = System.Drawing.Color.Black;
            this.btnCancelOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelOrder.Location = new System.Drawing.Point(199, 110);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(130, 50);
            this.btnCancelOrder.TabIndex = 35;
            this.btnCancelOrder.Text = "Cancel order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(772, 110);
            this.btnExit.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 50);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeID.ForeColor = System.Drawing.Color.Black;
            this.labelEmployeeID.Location = new System.Drawing.Point(199, 70);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(55, 26);
            this.labelEmployeeID.TabIndex = 18;
            this.labelEmployeeID.Text = "NV1";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(20, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 26);
            this.label9.TabIndex = 14;
            this.label9.Text = "Mã nhân viên:";
            // 
            // labelOrderTotal
            // 
            this.labelOrderTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOrderTotal.AutoSize = true;
            this.labelOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderTotal.ForeColor = System.Drawing.Color.Black;
            this.labelOrderTotal.Location = new System.Drawing.Point(730, 25);
            this.labelOrderTotal.Name = "labelOrderTotal";
            this.labelOrderTotal.Size = new System.Drawing.Size(173, 26);
            this.labelOrderTotal.TabIndex = 13;
            this.labelOrderTotal.Text = "10230123 VND";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(568, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 26);
            this.label11.TabIndex = 12;
            this.label11.Text = "Tổng tiền:";
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.labelEmployeeName.Location = new System.Drawing.Point(195, 24);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(182, 26);
            this.labelEmployeeName.TabIndex = 11;
            this.labelEmployeeName.Text = "Nguyễn Minh Thư";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(20, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 26);
            this.label13.TabIndex = 10;
            this.label13.Text = "Người tạo đơn:";
            // 
            // panelOrderDetail
            // 
            this.panelOrderDetail.AutoScroll = true;
            this.panelOrderDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelOrderDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrderDetail.Location = new System.Drawing.Point(0, 193);
            this.panelOrderDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelOrderDetail.Name = "panelOrderDetail";
            this.panelOrderDetail.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.panelOrderDetail.Size = new System.Drawing.Size(922, 563);
            this.panelOrderDetail.TabIndex = 2;
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 939);
            this.Controls.Add(this.panelOrderDetail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(944, 995);
            this.MinimumSize = new System.Drawing.Size(944, 995);
            this.Name = "OrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderDetail";
            this.Load += new System.EventHandler(this.OrderDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCustomerPhoneNumber;
        private System.Windows.Forms.TextBox textBoxCustomerAddress;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelOrderDetail;
        private System.Windows.Forms.Label labelEmployeeID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelOrderTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboBoxOrderStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxShipmentStatus;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnSave;
    }
}