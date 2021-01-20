
namespace Vetera_MouseRec
{
    partial class SaveDialog
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
            this.savedialog_button_selectpath = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.savedialog_textBox_tilte = new System.Windows.Forms.TextBox();
            this.savedialog_textBox_description = new System.Windows.Forms.TextBox();
            this.savedialog_button_save = new System.Windows.Forms.Button();
            this.savedialog_button_cancel = new System.Windows.Forms.Button();
            this.showdialog_textBox_path = new Vetera_MouseRec.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.showdialog_textBox_path)).BeginInit();
            this.SuspendLayout();
            // 
            // savedialog_button_selectpath
            // 
            this.savedialog_button_selectpath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.savedialog_button_selectpath.FlatAppearance.BorderSize = 0;
            this.savedialog_button_selectpath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savedialog_button_selectpath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.savedialog_button_selectpath.Location = new System.Drawing.Point(522, 12);
            this.savedialog_button_selectpath.Name = "savedialog_button_selectpath";
            this.savedialog_button_selectpath.Size = new System.Drawing.Size(39, 31);
            this.savedialog_button_selectpath.TabIndex = 1;
            this.savedialog_button_selectpath.Text = "...";
            this.savedialog_button_selectpath.UseVisualStyleBackColor = false;
            this.savedialog_button_selectpath.Click += new System.EventHandler(this.savedialog_button_selectpath_Click);
            // 
            // savedialog_textBox_tilte
            // 
            this.savedialog_textBox_tilte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.savedialog_textBox_tilte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savedialog_textBox_tilte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedialog_textBox_tilte.Location = new System.Drawing.Point(12, 73);
            this.savedialog_textBox_tilte.Name = "savedialog_textBox_tilte";
            this.savedialog_textBox_tilte.Size = new System.Drawing.Size(504, 25);
            this.savedialog_textBox_tilte.TabIndex = 2;
            this.savedialog_textBox_tilte.Click += new System.EventHandler(this.savedialog_textBox_tilte_Click);
            this.savedialog_textBox_tilte.TextChanged += new System.EventHandler(this.savedialog_textBox_tilte_TextChanged);
            this.savedialog_textBox_tilte.Leave += new System.EventHandler(this.savedialog_textBox_tilte_Leave);
            // 
            // savedialog_textBox_description
            // 
            this.savedialog_textBox_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.savedialog_textBox_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savedialog_textBox_description.Location = new System.Drawing.Point(13, 112);
            this.savedialog_textBox_description.Multiline = true;
            this.savedialog_textBox_description.Name = "savedialog_textBox_description";
            this.savedialog_textBox_description.Size = new System.Drawing.Size(503, 142);
            this.savedialog_textBox_description.TabIndex = 3;
            this.savedialog_textBox_description.MouseClick += new System.Windows.Forms.MouseEventHandler(this.savedialog_textBox_description_MouseClick);
            this.savedialog_textBox_description.TextChanged += new System.EventHandler(this.savedialog_textBox_description_TextChanged);
            this.savedialog_textBox_description.Leave += new System.EventHandler(this.savedialog_textBox_description_Leave);
            // 
            // savedialog_button_save
            // 
            this.savedialog_button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.savedialog_button_save.FlatAppearance.BorderSize = 0;
            this.savedialog_button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savedialog_button_save.ForeColor = System.Drawing.SystemColors.WindowText;
            this.savedialog_button_save.Location = new System.Drawing.Point(13, 261);
            this.savedialog_button_save.Name = "savedialog_button_save";
            this.savedialog_button_save.Size = new System.Drawing.Size(390, 41);
            this.savedialog_button_save.TabIndex = 4;
            this.savedialog_button_save.Text = "Save";
            this.savedialog_button_save.UseVisualStyleBackColor = false;
            this.savedialog_button_save.Click += new System.EventHandler(this.savedialog_button_save_Click);
            // 
            // savedialog_button_cancel
            // 
            this.savedialog_button_cancel.FlatAppearance.BorderSize = 0;
            this.savedialog_button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savedialog_button_cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.savedialog_button_cancel.Location = new System.Drawing.Point(409, 261);
            this.savedialog_button_cancel.Name = "savedialog_button_cancel";
            this.savedialog_button_cancel.Size = new System.Drawing.Size(107, 41);
            this.savedialog_button_cancel.TabIndex = 6;
            this.savedialog_button_cancel.Text = "Cancel";
            this.savedialog_button_cancel.UseVisualStyleBackColor = true;
            this.savedialog_button_cancel.Click += new System.EventHandler(this.savedialog_button_cancel_Click);
            // 
            // showdialog_textBox_path
            // 
            this.showdialog_textBox_path.Alignment = System.Drawing.StringAlignment.Near;
            this.showdialog_textBox_path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.showdialog_textBox_path.font = new System.Drawing.Font("Arial", 16F);
            this.showdialog_textBox_path.LineAlignment = System.Drawing.StringAlignment.Center;
            this.showdialog_textBox_path.Location = new System.Drawing.Point(13, 12);
            this.showdialog_textBox_path.Name = "showdialog_textBox_path";
            this.showdialog_textBox_path.Size = new System.Drawing.Size(503, 31);
            this.showdialog_textBox_path.TabIndex = 5;
            this.showdialog_textBox_path.TabStop = false;
            this.showdialog_textBox_path.Text_String = "nillll";
            this.showdialog_textBox_path.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            // 
            // SaveDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 312);
            this.Controls.Add(this.savedialog_button_cancel);
            this.Controls.Add(this.showdialog_textBox_path);
            this.Controls.Add(this.savedialog_button_save);
            this.Controls.Add(this.savedialog_textBox_description);
            this.Controls.Add(this.savedialog_textBox_tilte);
            this.Controls.Add(this.savedialog_button_selectpath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaveDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save..";
            this.Load += new System.EventHandler(this.SaveDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showdialog_textBox_path)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button savedialog_button_selectpath;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox savedialog_textBox_tilte;
        private System.Windows.Forms.TextBox savedialog_textBox_description;
        private System.Windows.Forms.Button savedialog_button_save;
        private CustomTextBox showdialog_textBox_path;
        private System.Windows.Forms.Button savedialog_button_cancel;
    }
}