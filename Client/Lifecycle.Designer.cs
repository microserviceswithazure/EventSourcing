﻿namespace Client
{
    partial class Lifecycle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lifecycle));
            this.txtProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAuditLog = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_AddToInventory = new System.Windows.Forms.Button();
            this.btn_ShipToCustomer = new System.Windows.Forms.Button();
            this.btn_DeliveredToCustomer = new System.Windows.Forms.Button();
            this.btn_ReshipToCustomer = new System.Windows.Forms.Button();
            this.btn_AuditLifecycle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProd
            // 
            this.txtProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProd.Location = new System.Drawing.Point(239, 143);
            this.txtProd.Margin = new System.Windows.Forms.Padding(1);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(260, 38);
            this.txtProd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(36, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(36, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product Name";
            // 
            // txtProdName
            // 
            this.txtProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.Location = new System.Drawing.Point(239, 187);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(1);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(260, 38);
            this.txtProdName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(33, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Warehouse Code";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(239, 230);
            this.txtCode.Margin = new System.Windows.Forms.Padding(1);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(260, 38);
            this.txtCode.TabIndex = 8;
            this.txtCode.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(34, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Customer Name";
            // 
            // txtCusName
            // 
            this.txtCusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusName.Location = new System.Drawing.Point(197, 96);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(1);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(180, 38);
            this.txtCusName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(36, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Supplier";
            // 
            // txtSup
            // 
            this.txtSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSup.Location = new System.Drawing.Point(239, 100);
            this.txtSup.Margin = new System.Windows.Forms.Padding(1);
            this.txtSup.Name = "txtSup";
            this.txtSup.Size = new System.Drawing.Size(260, 38);
            this.txtSup.TabIndex = 12;
            this.txtSup.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(21, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Add product";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtAuditLog
            // 
            this.txtAuditLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuditLog.Location = new System.Drawing.Point(1362, 144);
            this.txtAuditLog.Margin = new System.Windows.Forms.Padding(1);
            this.txtAuditLog.Multiline = true;
            this.txtAuditLog.Name = "txtAuditLog";
            this.txtAuditLog.Size = new System.Drawing.Size(463, 683);
            this.txtAuditLog.TabIndex = 16;
            this.txtAuditLog.Text = "Ship Product";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(1657, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Audit Log";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(19, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Database Status";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btn_AddToInventory
            // 
            this.btn_AddToInventory.BackColor = System.Drawing.Color.Teal;
            this.btn_AddToInventory.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddToInventory.Location = new System.Drawing.Point(37, 301);
            this.btn_AddToInventory.Margin = new System.Windows.Forms.Padding(1);
            this.btn_AddToInventory.Name = "btn_AddToInventory";
            this.btn_AddToInventory.Size = new System.Drawing.Size(221, 37);
            this.btn_AddToInventory.TabIndex = 21;
            this.btn_AddToInventory.Text = "Add To Inventory";
            this.btn_AddToInventory.UseVisualStyleBackColor = false;
            this.btn_AddToInventory.Click += new System.EventHandler(this.btn_AddToInventory_Click);
            // 
            // btn_ShipToCustomer
            // 
            this.btn_ShipToCustomer.BackColor = System.Drawing.Color.Teal;
            this.btn_ShipToCustomer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShipToCustomer.Location = new System.Drawing.Point(34, 158);
            this.btn_ShipToCustomer.Margin = new System.Windows.Forms.Padding(1);
            this.btn_ShipToCustomer.Name = "btn_ShipToCustomer";
            this.btn_ShipToCustomer.Size = new System.Drawing.Size(221, 37);
            this.btn_ShipToCustomer.TabIndex = 22;
            this.btn_ShipToCustomer.Text = "Ship To Customer";
            this.btn_ShipToCustomer.UseVisualStyleBackColor = false;
            this.btn_ShipToCustomer.Click += new System.EventHandler(this.btn_ShipToCustomer_Click);
            // 
            // btn_DeliveredToCustomer
            // 
            this.btn_DeliveredToCustomer.BackColor = System.Drawing.Color.Green;
            this.btn_DeliveredToCustomer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeliveredToCustomer.Location = new System.Drawing.Point(42, 110);
            this.btn_DeliveredToCustomer.Margin = new System.Windows.Forms.Padding(1);
            this.btn_DeliveredToCustomer.Name = "btn_DeliveredToCustomer";
            this.btn_DeliveredToCustomer.Size = new System.Drawing.Size(255, 37);
            this.btn_DeliveredToCustomer.TabIndex = 23;
            this.btn_DeliveredToCustomer.Text = "Delivered To Customer";
            this.btn_DeliveredToCustomer.UseVisualStyleBackColor = false;
            this.btn_DeliveredToCustomer.Click += new System.EventHandler(this.btn_DeliveredToCustomer_Click);
            // 
            // btn_ReshipToCustomer
            // 
            this.btn_ReshipToCustomer.BackColor = System.Drawing.Color.Maroon;
            this.btn_ReshipToCustomer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReshipToCustomer.Location = new System.Drawing.Point(225, 42);
            this.btn_ReshipToCustomer.Margin = new System.Windows.Forms.Padding(1);
            this.btn_ReshipToCustomer.Name = "btn_ReshipToCustomer";
            this.btn_ReshipToCustomer.Size = new System.Drawing.Size(138, 57);
            this.btn_ReshipToCustomer.TabIndex = 24;
            this.btn_ReshipToCustomer.Text = "Reship";
            this.btn_ReshipToCustomer.UseVisualStyleBackColor = false;
            this.btn_ReshipToCustomer.Click += new System.EventHandler(this.btn_ReshipToCustomer_Click);
            // 
            // btn_AuditLifecycle
            // 
            this.btn_AuditLifecycle.BackColor = System.Drawing.Color.Teal;
            this.btn_AuditLifecycle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AuditLifecycle.Location = new System.Drawing.Point(1362, 78);
            this.btn_AuditLifecycle.Margin = new System.Windows.Forms.Padding(1);
            this.btn_AuditLifecycle.Name = "btn_AuditLifecycle";
            this.btn_AuditLifecycle.Size = new System.Drawing.Size(241, 37);
            this.btn_AuditLifecycle.TabIndex = 25;
            this.btn_AuditLifecycle.Text = "Audit Lifecycle";
            this.btn_AuditLifecycle.UseVisualStyleBackColor = false;
            this.btn_AuditLifecycle.Click += new System.EventHandler(this.btn_AuditLifecycle_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.lblProductID);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(38, 543);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 230);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtProd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtProdName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCode);
            this.panel2.Controls.Add(this.btn_AddToInventory);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSup);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(38, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 375);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtCusName);
            this.panel3.Controls.Add(this.btn_ShipToCustomer);
            this.panel3.Location = new System.Drawing.Point(594, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(398, 228);
            this.panel3.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(29, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "Product purchased";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.btn_DeliveredToCustomer);
            this.panel4.Location = new System.Drawing.Point(1024, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(311, 183);
            this.panel4.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(37, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(218, 29);
            this.label11.TabIndex = 23;
            this.label11.Text = "Delivery received";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.btn_ReshipToCustomer);
            this.panel5.Location = new System.Drawing.Point(594, 363);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(398, 127);
            this.panel5.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(33, 42);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 29);
            this.label12.TabIndex = 23;
            this.label12.Text = "Product Lost";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblProductID.Location = new System.Drawing.Point(266, 109);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(94, 34);
            this.lblProductID.TabIndex = 22;
            this.lblProductID.Text = "name";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblProductName.Location = new System.Drawing.Point(442, 109);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(94, 34);
            this.lblProductName.TabIndex = 23;
            this.lblProductName.Text = "name";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(637, 109);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(94, 34);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "name";
            // 
            // Lifecycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 916);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_AuditLifecycle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAuditLog);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Lifecycle";
            this.Text = "Lifecycle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Lifecycle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAuditLog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_AddToInventory;
        private System.Windows.Forms.Button btn_ShipToCustomer;
        private System.Windows.Forms.Button btn_DeliveredToCustomer;
        private System.Windows.Forms.Button btn_ReshipToCustomer;
        private System.Windows.Forms.Button btn_AuditLifecycle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductID;
    }
}