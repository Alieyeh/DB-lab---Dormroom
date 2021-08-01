﻿
namespace Dormitory.forms
{
    partial class Room_Froms
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
            this.components = new System.ComponentModel.Container();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blocknum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmptyCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumber,
            this.FloorNum,
            this.Blocknum,
            this.Capacity,
            this.EmptyCap,
            this.Cost});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 253);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // RoomNumber
            // 
            this.RoomNumber.HeaderText = "Room";
            this.RoomNumber.MinimumWidth = 6;
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Width = 125;
            // 
            // FloorNum
            // 
            this.FloorNum.HeaderText = "Floor";
            this.FloorNum.MinimumWidth = 6;
            this.FloorNum.Name = "FloorNum";
            this.FloorNum.Width = 125;
            // 
            // Blocknum
            // 
            this.Blocknum.HeaderText = "Block";
            this.Blocknum.MinimumWidth = 6;
            this.Blocknum.Name = "Blocknum";
            this.Blocknum.Width = 125;
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.MinimumWidth = 6;
            this.Capacity.Name = "Capacity";
            this.Capacity.Width = 125;
            // 
            // EmptyCap
            // 
            this.EmptyCap.HeaderText = "Empty Capacity";
            this.EmptyCap.MinimumWidth = 6;
            this.EmptyCap.Name = "EmptyCap";
            this.EmptyCap.Width = 125;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(406, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Room_Froms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Room_Froms";
            this.Text = "Room_Froms";
            this.Load += new System.EventHandler(this.Room_Froms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blocknum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmptyCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Select;
        private System.Windows.Forms.Button button1;
    }
}