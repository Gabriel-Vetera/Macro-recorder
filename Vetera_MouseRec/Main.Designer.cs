
namespace Vetera_MouseRec
{
    partial class Main
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
            this.update = new System.Windows.Forms.Timer(this.components);
            this.panel_data_items = new System.Windows.Forms.FlowLayoutPanel();
            this.main_button_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.main_text_emty = new Vetera_MouseRec.CustomTextBox();
            this.main_button_load = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_text_emty)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Interval = 10;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // panel_data_items
            // 
            this.panel_data_items.AllowDrop = true;
            this.panel_data_items.AutoScroll = true;
            this.panel_data_items.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_data_items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_data_items.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel_data_items.Location = new System.Drawing.Point(0, 0);
            this.panel_data_items.Name = "panel_data_items";
            this.panel_data_items.Size = new System.Drawing.Size(679, 450);
            this.panel_data_items.TabIndex = 0;
            this.panel_data_items.WrapContents = false;
            this.panel_data_items.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_data_items_DragDrop);
            this.panel_data_items.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_data_items_DragEnter);
            // 
            // main_button_save
            // 
            this.main_button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.main_button_save.FlatAppearance.BorderSize = 0;
            this.main_button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_button_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.main_button_save.Location = new System.Drawing.Point(3, 118);
            this.main_button_save.Name = "main_button_save";
            this.main_button_save.Size = new System.Drawing.Size(115, 106);
            this.main_button_save.TabIndex = 1;
            this.main_button_save.Text = "Save..";
            this.main_button_save.UseVisualStyleBackColor = false;
            this.main_button_save.Click += new System.EventHandler(this.main_button_save_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(679, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 450);
            this.panel1.TabIndex = 2;
            // 
            // main_text_emty
            // 
            this.main_text_emty.Alignment = System.Drawing.StringAlignment.Center;
            this.main_text_emty.font = new System.Drawing.Font("Arial", 12F);
            this.main_text_emty.LineAlignment = System.Drawing.StringAlignment.Center;
            this.main_text_emty.Location = new System.Drawing.Point(322, 176);
            this.main_text_emty.Name = "main_text_emty";
            this.main_text_emty.Size = new System.Drawing.Size(200, 100);
            this.main_text_emty.TabIndex = 0;
            this.main_text_emty.TabStop = false;
            this.main_text_emty.Text_String = "null";
            this.main_text_emty.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            // 
            // main_button_load
            // 
            this.main_button_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.main_button_load.FlatAppearance.BorderSize = 0;
            this.main_button_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_button_load.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.main_button_load.Location = new System.Drawing.Point(3, 3);
            this.main_button_load.Name = "main_button_load";
            this.main_button_load.Size = new System.Drawing.Size(115, 106);
            this.main_button_load.TabIndex = 2;
            this.main_button_load.Text = "Load";
            this.main_button_load.UseVisualStyleBackColor = false;
            this.main_button_load.Click += new System.EventHandler(this.main_button_load_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.main_button_load, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.main_button_save, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(121, 450);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main_text_emty);
            this.Controls.Add(this.panel_data_items);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_text_emty)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer update;
        public System.Windows.Forms.FlowLayoutPanel panel_data_items;
        private System.Windows.Forms.Button main_button_save;
        private System.Windows.Forms.Panel panel1;
        private CustomTextBox main_text_emty;
        private System.Windows.Forms.Button main_button_load;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}