
namespace BT03_Binding_MonHoc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnkhong = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnsau = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btntruoc = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txttenmh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtloaimh = new System.Windows.Forms.TextBox();
            this.txtsotiet = new System.Windows.Forms.TextBox();
            this.txtmamh = new System.Windows.Forms.TextBox();
            this.btndau = new System.Windows.Forms.Button();
            this.lblstt = new System.Windows.Forms.Label();
            this.btncuoi = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.bdnmonhoc = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bdnmonhoc)).BeginInit();
            this.bdnmonhoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnkhong
            // 
            this.btnkhong.Location = new System.Drawing.Point(219, 221);
            this.btnkhong.Name = "btnkhong";
            this.btnkhong.Size = new System.Drawing.Size(54, 28);
            this.btnkhong.TabIndex = 37;
            this.btnkhong.Text = "Không";
            this.btnkhong.UseVisualStyleBackColor = true;
            // 
            // btnghi
            // 
            this.btnghi.Location = new System.Drawing.Point(157, 221);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(54, 28);
            this.btnghi.TabIndex = 36;
            this.btnghi.Text = "Ghi";
            this.btnghi.UseVisualStyleBackColor = true;
            // 
            // btnsau
            // 
            this.btnsau.Location = new System.Drawing.Point(219, 174);
            this.btnsau.Name = "btnsau";
            this.btnsau.Size = new System.Drawing.Size(54, 28);
            this.btnsau.TabIndex = 35;
            this.btnsau.Text = "Sau";
            this.btnsau.UseVisualStyleBackColor = true;
            this.btnsau.Click += new System.EventHandler(this.btnsau_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(85, 221);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(54, 28);
            this.btnhuy.TabIndex = 34;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            // 
            // btntruoc
            // 
            this.btntruoc.Location = new System.Drawing.Point(85, 174);
            this.btntruoc.Name = "btntruoc";
            this.btntruoc.Size = new System.Drawing.Size(54, 28);
            this.btntruoc.TabIndex = 33;
            this.btntruoc.Text = "Trước";
            this.btntruoc.UseVisualStyleBackColor = true;
            this.btntruoc.Click += new System.EventHandler(this.btntruoc_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(12, 221);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(54, 28);
            this.btnthem.TabIndex = 32;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 32);
            this.label5.TabIndex = 39;
            this.label5.Text = "DANH SÁCH MÔN HỌC";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txttenmh
            // 
            this.txttenmh.Location = new System.Drawing.Point(102, 75);
            this.txttenmh.Name = "txttenmh";
            this.txttenmh.Size = new System.Drawing.Size(241, 20);
            this.txttenmh.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tên MH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Mã MH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Số tiết";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Loại môn";
            // 
            // txtloaimh
            // 
            this.txtloaimh.Location = new System.Drawing.Point(102, 137);
            this.txtloaimh.Name = "txtloaimh";
            this.txtloaimh.Size = new System.Drawing.Size(241, 20);
            this.txtloaimh.TabIndex = 43;
            // 
            // txtsotiet
            // 
            this.txtsotiet.Location = new System.Drawing.Point(102, 106);
            this.txtsotiet.Name = "txtsotiet";
            this.txtsotiet.Size = new System.Drawing.Size(241, 20);
            this.txtsotiet.TabIndex = 43;
            // 
            // txtmamh
            // 
            this.txtmamh.Location = new System.Drawing.Point(102, 44);
            this.txtmamh.Name = "txtmamh";
            this.txtmamh.Size = new System.Drawing.Size(241, 20);
            this.txtmamh.TabIndex = 43;
            // 
            // btndau
            // 
            this.btndau.Location = new System.Drawing.Point(12, 174);
            this.btndau.Name = "btndau";
            this.btndau.Size = new System.Drawing.Size(54, 28);
            this.btndau.TabIndex = 33;
            this.btndau.Text = "Đầu";
            this.btndau.UseVisualStyleBackColor = true;
            this.btndau.Click += new System.EventHandler(this.btndau_Click);
            // 
            // lblstt
            // 
            this.lblstt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblstt.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstt.Location = new System.Drawing.Point(157, 174);
            this.lblstt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstt.Name = "lblstt";
            this.lblstt.Size = new System.Drawing.Size(54, 28);
            this.lblstt.TabIndex = 106;
            this.lblstt.Text = "STT";
            this.lblstt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncuoi
            // 
            this.btncuoi.Location = new System.Drawing.Point(289, 174);
            this.btncuoi.Name = "btncuoi";
            this.btncuoi.Size = new System.Drawing.Size(54, 28);
            this.btncuoi.TabIndex = 34;
            this.btncuoi.Text = "Cuối";
            this.btncuoi.UseVisualStyleBackColor = true;
            this.btncuoi.Click += new System.EventHandler(this.btncuoi_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(289, 221);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(54, 28);
            this.btnthoat.TabIndex = 34;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // bdnmonhoc
            // 
            this.bdnmonhoc.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bdnmonhoc.CountItem = this.bindingNavigatorCountItem;
            this.bdnmonhoc.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bdnmonhoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bdnmonhoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bdnmonhoc.Location = new System.Drawing.Point(0, 253);
            this.bdnmonhoc.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnmonhoc.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnmonhoc.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnmonhoc.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnmonhoc.Name = "bdnmonhoc";
            this.bdnmonhoc.PositionItem = this.bindingNavigatorPositionItem;
            this.bdnmonhoc.Size = new System.Drawing.Size(369, 25);
            this.bdnmonhoc.TabIndex = 107;
            this.bdnmonhoc.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 278);
            this.Controls.Add(this.bdnmonhoc);
            this.Controls.Add(this.lblstt);
            this.Controls.Add(this.txtmamh);
            this.Controls.Add(this.txtsotiet);
            this.Controls.Add(this.txtloaimh);
            this.Controls.Add(this.txttenmh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnkhong);
            this.Controls.Add(this.btnghi);
            this.Controls.Add(this.btnsau);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btncuoi);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btndau);
            this.Controls.Add(this.btntruoc);
            this.Controls.Add(this.btnthem);
            this.Name = "Form1";
            this.Text = "Binding Môn học nâng cao";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdnmonhoc)).EndInit();
            this.bdnmonhoc.ResumeLayout(false);
            this.bdnmonhoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnkhong;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnsau;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btntruoc;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttenmh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtloaimh;
        private System.Windows.Forms.TextBox txtsotiet;
        private System.Windows.Forms.TextBox txtmamh;
        private System.Windows.Forms.Button btndau;
        private System.Windows.Forms.Label lblstt;
        private System.Windows.Forms.Button btncuoi;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.BindingNavigator bdnmonhoc;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}

