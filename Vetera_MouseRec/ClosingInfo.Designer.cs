
namespace Vetera_MouseRec
{
    partial class ClosingInfo
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
            this.closingText_info = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.closingButton_yes = new System.Windows.Forms.Button();
            this.closingButton_cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closingText_info
            // 
            this.closingText_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.closingText_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closingText_info.Location = new System.Drawing.Point(20, 30);
            this.closingText_info.Name = "closingText_info";
            this.closingText_info.ReadOnly = true;
            this.closingText_info.Size = new System.Drawing.Size(760, 332);
            this.closingText_info.TabIndex = 1;
            this.closingText_info.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.closingButton_yes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.closingButton_cancel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 362);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 68);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // closingButton_yes
            // 
            this.closingButton_yes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closingButton_yes.FlatAppearance.BorderSize = 0;
            this.closingButton_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closingButton_yes.Location = new System.Drawing.Point(3, 3);
            this.closingButton_yes.Name = "closingButton_yes";
            this.closingButton_yes.Size = new System.Drawing.Size(374, 62);
            this.closingButton_yes.TabIndex = 1;
            this.closingButton_yes.Text = "Yes";
            this.closingButton_yes.UseVisualStyleBackColor = true;
            this.closingButton_yes.Click += new System.EventHandler(this.closingButton_yes_Click);
            // 
            // closingButton_cancel
            // 
            this.closingButton_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closingButton_cancel.FlatAppearance.BorderSize = 0;
            this.closingButton_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closingButton_cancel.Location = new System.Drawing.Point(383, 3);
            this.closingButton_cancel.Name = "closingButton_cancel";
            this.closingButton_cancel.Size = new System.Drawing.Size(374, 62);
            this.closingButton_cancel.TabIndex = 0;
            this.closingButton_cancel.Text = "Cancel";
            this.closingButton_cancel.UseVisualStyleBackColor = true;
            this.closingButton_cancel.Click += new System.EventHandler(this.closingButton_cancel_Click);
            // 
            // ClosingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closingText_info);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "ClosingInfo";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "ClosingInfo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox closingText_info;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button closingButton_yes;
        private System.Windows.Forms.Button closingButton_cancel;
    }
}