
namespace Vetera_MouseRec
{
    partial class CustomDataItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDataItem));
            this.button_delete = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_keyboard = new Vetera_MouseRec.CustomTextBox();
            this.text_mouse = new Vetera_MouseRec.CustomTextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.text_label = new Vetera_MouseRec.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.button_delete)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_keyboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_mouse)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_label)).BeginInit();
            this.SuspendLayout();
            // 
            // button_delete
            // 
            this.button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_delete.Image = ((System.Drawing.Image)(resources.GetObject("button_delete.Image")));
            this.button_delete.Location = new System.Drawing.Point(518, 0);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(71, 103);
            this.button_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_delete.TabIndex = 3;
            this.button_delete.TabStop = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.text_keyboard);
            this.panel1.Controls.Add(this.text_mouse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(392, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 103);
            this.panel1.TabIndex = 4;
            // 
            // text_keyboard
            // 
            this.text_keyboard.Alignment = System.Drawing.StringAlignment.Center;
            this.text_keyboard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text_keyboard.font = new System.Drawing.Font("Arial", 12F);
            this.text_keyboard.LineAlignment = System.Drawing.StringAlignment.Center;
            this.text_keyboard.Location = new System.Drawing.Point(0, 53);
            this.text_keyboard.Name = "text_keyboard";
            this.text_keyboard.Size = new System.Drawing.Size(126, 50);
            this.text_keyboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.text_keyboard.TabIndex = 1;
            this.text_keyboard.TabStop = false;
            this.text_keyboard.Text_String = "null";
            this.text_keyboard.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            // 
            // text_mouse
            // 
            this.text_mouse.Alignment = System.Drawing.StringAlignment.Center;
            this.text_mouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_mouse.font = new System.Drawing.Font("Arial", 12F);
            this.text_mouse.LineAlignment = System.Drawing.StringAlignment.Center;
            this.text_mouse.Location = new System.Drawing.Point(0, 0);
            this.text_mouse.Name = "text_mouse";
            this.text_mouse.Size = new System.Drawing.Size(126, 50);
            this.text_mouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.text_mouse.TabIndex = 0;
            this.text_mouse.TabStop = false;
            this.text_mouse.Text_String = "null";
            this.text_mouse.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            // 
            // text_name
            // 
            this.text_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.text_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.text_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.text_name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.text_name.Location = new System.Drawing.Point(3, 37);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(305, 25);
            this.text_name.TabIndex = 7;
            this.text_name.Text = "null";
            this.text_name.TextChanged += new System.EventHandler(this.text_name_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.text_name, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(81, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(311, 103);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // text_label
            // 
            this.text_label.Alignment = System.Drawing.StringAlignment.Far;
            this.text_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.text_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.text_label.font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.text_label.LineAlignment = System.Drawing.StringAlignment.Center;
            this.text_label.Location = new System.Drawing.Point(0, 0);
            this.text_label.Name = "text_label";
            this.text_label.Size = new System.Drawing.Size(81, 103);
            this.text_label.TabIndex = 2;
            this.text_label.TabStop = false;
            this.text_label.Text_String = "Name: ";
            this.text_label.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            // 
            // CustomDataItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.text_label);
            this.Name = "CustomDataItem";
            this.Size = new System.Drawing.Size(589, 103);
            ((System.ComponentModel.ISupportInitialize)(this.button_delete)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_keyboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_mouse)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_label)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomTextBox text_label;
        private System.Windows.Forms.PictureBox button_delete;
        private System.Windows.Forms.Panel panel1;
        private CustomTextBox text_keyboard;
        private CustomTextBox text_mouse;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
