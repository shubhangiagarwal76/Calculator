using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.WindowsForm
{
    public partial class Calculator : Form
    {

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public Calculator()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 561);
            Controls.Add(addGrid());
            Controls.Add(addTextBox());
            Controls.Add(addMenuStrip());
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

       
            
            
           
            
           
           
         
        MenuStrip addMenuStrip()
        {
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            editToolStripMenuItem,
            exitToolStripMenuItem,
            helpToolStripMenuItem
    });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(784, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            copyToolStripMenuItem,
            pasteToolStripMenuItem});
            editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            helpToolStripMenuItem.Text = "Help!";

            return menuStrip1;
        }
         

        RichTextBox addTextBox()
        {
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            richTextBox1.Location = new System.Drawing.Point(0, 25);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(784, 96);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            return richTextBox1;
        }
        

        DataGridView addGrid()
        {
            dataGridView1 = new System.Windows.Forms.DataGridView();
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(784, 440);
            dataGridView1.TabIndex = 2;
            return dataGridView1;
        }
            
            // 
            // Form1
            // 
            

    }



   
}
