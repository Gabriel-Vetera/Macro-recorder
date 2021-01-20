
namespace Vetera_MouseRec
{
    partial class Item_ShowDataItems
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
            this.components = new System.ComponentModel.Container();
            this.TextField = new System.Windows.Forms.RichTextBox();
            this.pictureBox_Border = new System.Windows.Forms.PictureBox();
            this.oderField = new System.Windows.Forms.RichTextBox();
            this.order_Backgrund = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_Backgrund)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextField
            // 
            this.TextField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextField.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextField.Location = new System.Drawing.Point(0, 0);
            this.TextField.Name = "TextField";
            this.TextField.ReadOnly = true;
            this.TextField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TextField.Size = new System.Drawing.Size(74, 43);
            this.TextField.TabIndex = 0;
            this.TextField.Text = "hoooo";
            this.TextField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customTextBox1_MouseDown);
            // 
            // pictureBox_Border
            // 
            this.pictureBox_Border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Border.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Border.Name = "pictureBox_Border";
            this.pictureBox_Border.Size = new System.Drawing.Size(223, 43);
            this.pictureBox_Border.TabIndex = 1;
            this.pictureBox_Border.TabStop = false;
            this.pictureBox_Border.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Border_Paint);
            // 
            // oderField
            // 
            this.oderField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oderField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oderField.Location = new System.Drawing.Point(181, 4);
            this.oderField.MaximumSize = new System.Drawing.Size(80, 80);
            this.oderField.Name = "oderField";
            this.oderField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.oderField.Size = new System.Drawing.Size(30, 30);
            this.oderField.TabIndex = 2;
            this.oderField.Text = "";
            this.oderField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.oder_MouseClick);
            this.oderField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oder_KeyPress);
            // 
            // order_Backgrund
            // 
            this.order_Backgrund.BackColor = System.Drawing.Color.LightSalmon;
            this.order_Backgrund.Location = new System.Drawing.Point(146, 11);
            this.order_Backgrund.Name = "order_Backgrund";
            this.order_Backgrund.Size = new System.Drawing.Size(29, 29);
            this.order_Backgrund.TabIndex = 3;
            this.order_Backgrund.TabStop = false;
            this.order_Backgrund.Paint += new System.Windows.Forms.PaintEventHandler(this.order_Backgrund_Paint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            this.contextMenuStrip1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip1_MouseClick);
            this.contextMenuStrip1.MouseLeave += new System.EventHandler(this.contextMenuStrip1_MouseLeave);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // Item_ShowDataItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.Controls.Add(this.order_Backgrund);
            this.Controls.Add(this.oderField);
            this.Controls.Add(this.TextField);
            this.Controls.Add(this.pictureBox_Border);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Item_ShowDataItems";
            this.Size = new System.Drawing.Size(223, 43);
            this.Resize += new System.EventHandler(this.Item_ShowDataItems_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_Backgrund)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextField;
        private System.Windows.Forms.PictureBox pictureBox_Border;
        private System.Windows.Forms.RichTextBox oderField;
        private System.Windows.Forms.PictureBox order_Backgrund;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
