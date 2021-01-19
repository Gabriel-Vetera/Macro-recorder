
namespace Vetera_MouseRec
{
    partial class CreatePlaybackCreate
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
            this.cpc_flowLayoutPanel_collection = new System.Windows.Forms.FlowLayoutPanel();
            this.cpc_button_load = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.cpc_tableLayoutPanel_pbButtons = new System.Windows.Forms.TableLayoutPanel();
            this.cpc_button_generalSettings = new System.Windows.Forms.Button();
            this.cpc_panel1 = new System.Windows.Forms.Panel();
            this.cpc_button_cancel = new System.Windows.Forms.Button();
            this.cpc_button_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cpc_tableLayoutPanel_pbButtons.SuspendLayout();
            this.cpc_panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpc_flowLayoutPanel_collection
            // 
            this.cpc_flowLayoutPanel_collection.AllowDrop = true;
            this.cpc_flowLayoutPanel_collection.AutoScroll = true;
            this.cpc_flowLayoutPanel_collection.AutoSize = true;
            this.cpc_flowLayoutPanel_collection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cpc_flowLayoutPanel_collection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_flowLayoutPanel_collection.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.cpc_flowLayoutPanel_collection.Location = new System.Drawing.Point(0, 57);
            this.cpc_flowLayoutPanel_collection.Name = "cpc_flowLayoutPanel_collection";
            this.cpc_flowLayoutPanel_collection.Size = new System.Drawing.Size(812, 393);
            this.cpc_flowLayoutPanel_collection.TabIndex = 0;
            this.cpc_flowLayoutPanel_collection.WrapContents = false;
            this.cpc_flowLayoutPanel_collection.DragDrop += new System.Windows.Forms.DragEventHandler(this.cpc_flowLayoutPanel_collection_DragDrop);
            this.cpc_flowLayoutPanel_collection.DragEnter += new System.Windows.Forms.DragEventHandler(this.cpc_flowLayoutPanel_collection_DragEnter);
            this.cpc_flowLayoutPanel_collection.Resize += new System.EventHandler(this.cpc_flowLayoutPanel_collection_Resize);
            // 
            // cpc_button_load
            // 
            this.cpc_button_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cpc_button_load.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_button_load.FlatAppearance.BorderSize = 0;
            this.cpc_button_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpc_button_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpc_button_load.Location = new System.Drawing.Point(287, 3);
            this.cpc_button_load.Name = "cpc_button_load";
            this.cpc_button_load.Size = new System.Drawing.Size(278, 51);
            this.cpc_button_load.TabIndex = 0;
            this.cpc_button_load.Text = "Load Collection";
            this.cpc_button_load.UseVisualStyleBackColor = false;
            this.cpc_button_load.Click += new System.EventHandler(this.cpc_button_load_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // update
            // 
            this.update.Interval = 10;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // cpc_tableLayoutPanel_pbButtons
            // 
            this.cpc_tableLayoutPanel_pbButtons.ColumnCount = 3;
            this.cpc_tableLayoutPanel_pbButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.cpc_tableLayoutPanel_pbButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.cpc_tableLayoutPanel_pbButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.cpc_tableLayoutPanel_pbButtons.Controls.Add(this.cpc_button_load, 1, 0);
            this.cpc_tableLayoutPanel_pbButtons.Controls.Add(this.cpc_button_generalSettings, 0, 0);
            this.cpc_tableLayoutPanel_pbButtons.Controls.Add(this.cpc_panel1, 2, 0);
            this.cpc_tableLayoutPanel_pbButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.cpc_tableLayoutPanel_pbButtons.Location = new System.Drawing.Point(0, 0);
            this.cpc_tableLayoutPanel_pbButtons.Name = "cpc_tableLayoutPanel_pbButtons";
            this.cpc_tableLayoutPanel_pbButtons.RowCount = 1;
            this.cpc_tableLayoutPanel_pbButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cpc_tableLayoutPanel_pbButtons.Size = new System.Drawing.Size(812, 57);
            this.cpc_tableLayoutPanel_pbButtons.TabIndex = 2;
            // 
            // cpc_button_generalSettings
            // 
            this.cpc_button_generalSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cpc_button_generalSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_button_generalSettings.FlatAppearance.BorderSize = 0;
            this.cpc_button_generalSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpc_button_generalSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpc_button_generalSettings.Location = new System.Drawing.Point(3, 3);
            this.cpc_button_generalSettings.Name = "cpc_button_generalSettings";
            this.cpc_button_generalSettings.Size = new System.Drawing.Size(278, 51);
            this.cpc_button_generalSettings.TabIndex = 0;
            this.cpc_button_generalSettings.Text = "General settings";
            this.cpc_button_generalSettings.UseVisualStyleBackColor = false;
            // 
            // cpc_panel1
            // 
            this.cpc_panel1.Controls.Add(this.cpc_button_cancel);
            this.cpc_panel1.Controls.Add(this.cpc_button_save);
            this.cpc_panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpc_panel1.Location = new System.Drawing.Point(571, 3);
            this.cpc_panel1.Name = "cpc_panel1";
            this.cpc_panel1.Size = new System.Drawing.Size(238, 51);
            this.cpc_panel1.TabIndex = 1;
            // 
            // cpc_button_cancel
            // 
            this.cpc_button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cpc_button_cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cpc_button_cancel.FlatAppearance.BorderSize = 0;
            this.cpc_button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpc_button_cancel.Location = new System.Drawing.Point(0, 30);
            this.cpc_button_cancel.Name = "cpc_button_cancel";
            this.cpc_button_cancel.Size = new System.Drawing.Size(238, 21);
            this.cpc_button_cancel.TabIndex = 2;
            this.cpc_button_cancel.Text = "Cancel";
            this.cpc_button_cancel.UseVisualStyleBackColor = false;
            this.cpc_button_cancel.Click += new System.EventHandler(this.cpc_button_cancel_Click);
            // 
            // cpc_button_save
            // 
            this.cpc_button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cpc_button_save.Dock = System.Windows.Forms.DockStyle.Top;
            this.cpc_button_save.FlatAppearance.BorderSize = 0;
            this.cpc_button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpc_button_save.Location = new System.Drawing.Point(0, 0);
            this.cpc_button_save.Name = "cpc_button_save";
            this.cpc_button_save.Size = new System.Drawing.Size(238, 27);
            this.cpc_button_save.TabIndex = 1;
            this.cpc_button_save.Text = "Save..";
            this.cpc_button_save.UseVisualStyleBackColor = false;
            this.cpc_button_save.Click += new System.EventHandler(this.cpc_button_save_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cpc_flowLayoutPanel_collection);
            this.panel1.Controls.Add(this.cpc_tableLayoutPanel_pbButtons);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 450);
            this.panel1.TabIndex = 3;
            // 
            // CreatePlaybackCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreatePlaybackCreate";
            this.Text = "CreatePlayback";
            this.cpc_tableLayoutPanel_pbButtons.ResumeLayout(false);
            this.cpc_panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel cpc_flowLayoutPanel_collection;
        private System.Windows.Forms.Button cpc_button_load;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.TableLayoutPanel cpc_tableLayoutPanel_pbButtons;
        private System.Windows.Forms.Button cpc_button_generalSettings;
        private System.Windows.Forms.Panel cpc_panel1;
        private System.Windows.Forms.Button cpc_button_cancel;
        private System.Windows.Forms.Button cpc_button_save;
        private System.Windows.Forms.Panel panel1;
    }
}