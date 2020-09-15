using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.WindowsForm
{
    public partial class Calculator : Form
    {

        private MenuStrip menuStrip1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private TextBox richTextBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button8;
        private Button button16;
        private Button button28;
        private Button button7;
        private Button button31;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button11;
        private Button button26;
        private Button button34;
        private Button button25;
        private Button button6;
        private Button button32;
        private Button button30;
        private Button button33;
        private Button button29;
        private Button button15;
        private Button button9;
        private Button button24;
        private Button button27;
        private Button button10;
        private Button button23;
        private Button button22;
        private Button button21;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button12;
        private Button button14;
        private Button button4;
        private Button button5;
        StringBuilder expression;
        double result;

        public Calculator()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 561);
            Controls.Add(addTable2());
            Controls.Add(addTable1());
            Controls.Add(addTextBox());
            Controls.Add(addMenuStrip());
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Calculator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            
            ResumeLayout(false);
            PerformLayout();
        }

        MenuStrip addMenuStrip()
        {
            menuStrip1 = new MenuStrip();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();

            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, exitToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyToolStripMenuItem, pasteToolStripMenuItem});
            editToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(42, 21);
            editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(180, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(180, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new Font("Segoe UI", 9.75F);
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(40, 21);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Font = new Font("Segoe UI", 9.75F);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(51, 21);
            helpToolStripMenuItem.Text = "Help!";

            return menuStrip1;
        }
         

        TextBox addTextBox()
        {
            richTextBox1 = new TextBox();
            richTextBox1.Dock = DockStyle.Top;
            //richTextBox1.RightToLeft = RightToLeft.Yes;
            //richTextBox1.TextAlign = Right;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.BackColor = Color.Black;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(0, 25);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(584, 96);
            richTextBox1.Font = new Font("Segoe UI", 40F);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "0";
            return richTextBox1;
        }
        

       

        TableLayoutPanel addTable1()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
           
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(button8, 0, 0);
            tableLayoutPanel1.Controls.Add(button16, 1, 0);
            tableLayoutPanel1.Controls.Add(button31, 2, 0);
            tableLayoutPanel1.Controls.Add(button28, 3, 0);
            tableLayoutPanel1.Controls.Add(button7, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.BackColor = Color.Gray;
            tableLayoutPanel1.Location = new Point(0, 121);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(584, 65);
            tableLayoutPanel1.TabIndex = 39;
            return tableLayoutPanel1;
        }
        // 
        // tableLayoutPanel2
        // 
        TableLayoutPanel addTable2()
        {
            tableLayoutPanel2 = new TableLayoutPanel();
            addButton();
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28572F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28572F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28572F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28572F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28572F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28572F));
            tableLayoutPanel2.Controls.Add(button1, 2, 0);
            tableLayoutPanel2.Controls.Add(button2, 3, 0);
            tableLayoutPanel2.Controls.Add(button3, 4, 0);
            tableLayoutPanel2.Controls.Add(button11, 0, 3);
            tableLayoutPanel2.Controls.Add(button26, 6, 1);
            tableLayoutPanel2.Controls.Add(button34, 0, 2);
            tableLayoutPanel2.Controls.Add(button25, 2, 1);
            tableLayoutPanel2.Controls.Add(button6, 0, 1);
            tableLayoutPanel2.Controls.Add(button32, 1, 3);
            tableLayoutPanel2.Controls.Add(button30, 0, 0);
            tableLayoutPanel2.Controls.Add(button33, 1, 2);
            tableLayoutPanel2.Controls.Add(button29, 6, 3);
            tableLayoutPanel2.Controls.Add(button15, 1, 0);
            tableLayoutPanel2.Controls.Add(button9, 1, 1);
            tableLayoutPanel2.Controls.Add(button24, 3, 1);
            tableLayoutPanel2.Controls.Add(button27, 6, 0);
            tableLayoutPanel2.Controls.Add(button10, 6, 2);
            tableLayoutPanel2.Controls.Add(button23, 4, 1);
            tableLayoutPanel2.Controls.Add(button22, 2, 2);
            tableLayoutPanel2.Controls.Add(button21, 3, 2);
            tableLayoutPanel2.Controls.Add(button20, 4, 2);
            tableLayoutPanel2.Controls.Add(button19, 2, 3);
            tableLayoutPanel2.Controls.Add(button18, 3, 3);
            tableLayoutPanel2.Controls.Add(button17, 4, 3);
            tableLayoutPanel2.Controls.Add(button12, 5, 3);
            tableLayoutPanel2.Controls.Add(button14, 5, 2);
            tableLayoutPanel2.Controls.Add(button4, 5, 0);
            tableLayoutPanel2.Controls.Add(button5, 5, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.BackColor = Color.Gray;
            tableLayoutPanel2.Location = new Point(0, 186);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(584, 275);
            tableLayoutPanel2.TabIndex = 40;
            return tableLayoutPanel2;
        }
            void addButton()
            {
            button8 = new Button();
            button16 = new Button();
            button28 = new Button();
            button7 = new Button();
            button31 = new Button();
            button29 = new Button();
            button30 = new Button();
            button14 = new Button();
            button12 = new Button();
            button17 = new Button();
            button20 = new Button();
            button21 = new Button();
            button18 = new Button();
            button19 = new Button();
            button22 = new Button();
            button33 = new Button();
            button32 = new Button();
            button11 = new Button();
            button34 = new Button();
            button6 = new Button();
            button9 = new Button();
            button25 = new Button();
            button24 = new Button();
            button23 = new Button();
            button5 = new Button();
            button26 = new Button();
            button27 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button15 = new Button();
            button10 = new Button();

            button8.BackColor = SystemColors.ButtonFace;
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(3, 3);
            button8.Name = "button8";
            button8.Size = new Size(110, 59);
            button8.TabIndex = 10;
            button8.Text = "MR";
            button8.Margin = new Padding(1);
            button8.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.ButtonFace;
            button16.Dock = DockStyle.Fill;
            button16.Location = new Point(119, 3);
            button16.Name = "button16";
            button16.Size = new Size(110, 59);
            button16.TabIndex = 18;
            button16.Text = "MS";
            button16.UseVisualStyleBackColor = false;
            // 
            // button28
            // 
            button28.BackColor = SystemColors.ButtonFace;
            button28.Dock = DockStyle.Fill;
            button28.Location = new Point(351, 3);
            button28.Name = "button28";
            button28.Size = new Size(110, 59);
            button28.TabIndex = 30;
            button28.Text = "C/CE";
            button28.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonFace;
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(467, 3);
            button7.Name = "button7";
            button7.Size = new Size(114, 59);
            button7.TabIndex = 34;
            button7.Text = "<-";
            button7.UseVisualStyleBackColor = false;
            //button7.Click += new System.EventHandler(button7_Click);
            // 
            // button31
            // 
            button31.BackColor = SystemColors.ButtonFace;
            button31.Dock = DockStyle.Fill;
            button31.Location = new Point(235, 3);
            button31.Name = "button31";
            button31.Size = new Size(110, 59);
            button31.TabIndex = 35;
            button31.Text = "M+";
            button31.UseVisualStyleBackColor = false;
            // 
            // button29
            // 
            button29.BackColor = SystemColors.ButtonFace;
            button29.Dock = DockStyle.Fill;
            button29.Location = new Point(501, 207);
            button29.Name = "button29";
            button29.Size = new Size(80, 65);
            button29.TabIndex = 31;
            button29.Text = "(";
            button29.UseVisualStyleBackColor = false;
            //button29.Click += new System.EventHandler(button29_Click);
            // 
            // button30
            // 
            button30.BackColor = SystemColors.ButtonFace;
            button30.Dock = DockStyle.Fill;
            button30.Location = new Point(3, 3);
            button30.Name = "button30";
            button30.Size = new Size(77, 62);
            button30.TabIndex = 32;
            button30.Text = "Sin";
            button30.UseVisualStyleBackColor = false;
            //button30.Click += new System.EventHandler(button30_Click);
            // 
            // button14
            // 
            button14.BackColor = SystemColors.ButtonFace;
            button14.Dock = DockStyle.Fill;
            button14.Location = new Point(418, 139);
            button14.Name = "button14";
            button14.Size = new Size(77, 62);
            button14.TabIndex = 16;
            button14.Text = "*";
            button14.UseVisualStyleBackColor = false;
            //button14.Click += new System.EventHandler(button14_Click);
            // 
            // button12
            // 
            button12.BackColor = SystemColors.ButtonFace;
            button12.Dock = DockStyle.Fill;
            button12.Location = new Point(418, 207);
            button12.Name = "button12";
            button12.Size = new Size(77, 65);
            button12.TabIndex = 14;
            button12.Text = "/";
            button12.UseVisualStyleBackColor = false;
            //button12.Click += new System.EventHandler(button12_Click);
            // 
            // button17
            // 
            button17.BackColor = SystemColors.ButtonFace;
            button17.Dock = DockStyle.Fill;
            button17.Location = new Point(335, 207);
            button17.Name = "button17";
            button17.Size = new Size(77, 65);
            button17.TabIndex = 19;
            button17.Text = "=";
            button17.UseVisualStyleBackColor = false;
            button17.Click += new System.EventHandler(button17_Click);
            // 
            // button20
            // 
            button20.BackColor = SystemColors.ButtonFace;
            button20.Dock = DockStyle.Fill;
            button20.Location = new Point(335, 139);
            button20.Name = "button20";
            button20.Size = new Size(77, 62);
            button20.TabIndex = 22;
            button20.Text = "9";
            button20.UseVisualStyleBackColor = false;
            //button20.Click += new System.EventHandler(button20_Click);
            // 
            // button21
            // 
            button21.BackColor = SystemColors.ButtonFace;
            button21.Dock = DockStyle.Fill;
            button21.Location = new Point(252, 139);
            button21.Name = "button21";
            button21.Size = new Size(77, 62);
            button21.TabIndex = 23;
            button21.Text = "8";
            button21.UseVisualStyleBackColor = false;
            //button21.Click += new System.EventHandler(button21_Click);
            // 
            // button18
            // 
            button18.BackColor = SystemColors.ButtonFace;
            button18.Dock = DockStyle.Fill;
            button18.Location = new Point(252, 207);
            button18.Name = "button18";
            button18.Size = new Size(77, 65);
            button18.TabIndex = 20;
            button18.Text = "0";
            button18.UseVisualStyleBackColor = false;
            //button18.Click += new System.EventHandler(button18_Click);
            // 
            // button19
            // 
            button19.BackColor = SystemColors.ButtonFace;
            button19.Dock = DockStyle.Fill;
            button19.Location = new Point(169, 207);
            button19.Name = "button19";
            button19.Size = new Size(77, 65);
            button19.TabIndex = 21;
            button19.Text = ".";
            button19.UseVisualStyleBackColor = false;
            //button19.Click += new System.EventHandler(button19_Click);
            // 
            // button22
            // 
            button22.BackColor = SystemColors.ButtonFace;
            button22.Dock = DockStyle.Fill;
            button22.Location = new Point(169, 139);
            button22.Name = "button22";
            button22.Size = new Size(77, 62);
            button22.TabIndex = 24;
            button22.Text = "7";
            button22.UseVisualStyleBackColor = false;
            //button22.Click += new System.EventHandler(button22_Click);
            // 
            // button33
            // 
            button33.BackColor = SystemColors.ButtonFace;
            button33.Dock = DockStyle.Fill;
            button33.Location = new Point(86, 139);
            button33.Name = "button33";
            button33.Size = new Size(77, 62);
            button33.TabIndex = 37;
            button33.Text = "Exp";
            button33.UseVisualStyleBackColor = false;
            //button33.Click += new System.EventHandler(button33_Click);
            // 
            // button32
            // 
            button32.BackColor = SystemColors.ButtonFace;
            button32.Dock = DockStyle.Fill;
            button32.Location = new Point(86, 207);
            button32.Name = "button32";
            button32.Size = new Size(77, 65);
            button32.TabIndex = 36;
            button32.Text = "+/-";
            button32.UseVisualStyleBackColor = false;
            //button32.Click += new System.EventHandler(button32_Click);
            // 
            // button11
            // 
            button11.BackColor = SystemColors.ButtonFace;
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(3, 207);
            button11.Name = "button11";
            button11.Size = new Size(77, 65);
            button11.TabIndex = 13;
            button11.Text = "Sqrt";
            button11.UseVisualStyleBackColor = false;
            //button11.Click += new System.EventHandler(button11_Click);
            // 
            // button34
            // 
            button34.BackColor = SystemColors.ButtonFace;
            button34.Dock = DockStyle.Fill;
            button34.Location = new Point(3, 139);
            button34.Name = "button34";
            button34.Size = new Size(77, 62);
            button34.TabIndex = 38;
            button34.Text = "Tan";
            button34.UseVisualStyleBackColor = false;
            //button34.Click += new System.EventHandler(button34_Click);
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(3, 71);
            button6.Name = "button6";
            button6.Size = new Size(77, 62);
            button6.TabIndex = 33;
            button6.Text = "Cos";
            button6.UseVisualStyleBackColor = false;
            //button6.Click += new System.EventHandler(button6_Click);
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ButtonFace;
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(86, 71);
            button9.Name = "button9";
            button9.Size = new Size(77, 62);
            button9.TabIndex = 11;
            button9.Text = "ln";
            button9.UseVisualStyleBackColor = false;
            //button9.Click += new System.EventHandler(button9_Click);
            // 
            // button25
            // 
            button25.BackColor = SystemColors.ButtonFace;
            button25.Dock = DockStyle.Fill;
            button25.Location = new Point(169, 71);
            button25.Name = "button25";
            button25.Size = new Size(77, 62);
            button25.TabIndex = 27;
            button25.Text = "4";
            button25.UseVisualStyleBackColor = false;
            //button25.Click += new System.EventHandler(button25_Click);
            // 
            // button24
            // 
            button24.BackColor = SystemColors.ButtonFace;
            button24.Dock = DockStyle.Fill;
            button24.Location = new Point(252, 71);
            button24.Name = "button24";
            button24.Size = new Size(77, 62);
            button24.TabIndex = 26;
            button24.Text = "5";
            button24.UseVisualStyleBackColor = false;
            //button24.Click += new System.EventHandler(button24_Click);
            // 
            // button23
            // 
            button23.BackColor = SystemColors.ButtonFace;
            button23.Dock = DockStyle.Fill;
            button23.Location = new Point(335, 71);
            button23.Name = "button23";
            button23.Size = new Size(77, 62);
            button23.TabIndex = 25;
            button23.Text = "6";
            button23.UseVisualStyleBackColor = false;
            //button23.Click += new System.EventHandler(button23_Click);
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(418, 71);
            button5.Name = "button5";
            button5.Size = new Size(77, 62);
            button5.TabIndex = 7;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = false;
            //button5.Click += new System.EventHandler(button5_Click);
            // 
            // button26
            // 
            button26.BackColor = SystemColors.ButtonFace;
            button26.Dock = DockStyle.Fill;
            button26.Location = new Point(501, 71);
            button26.Name = "button26";
            button26.Size = new Size(80, 62);
            button26.TabIndex = 28;
            button26.Text = "1/x";
            button26.UseVisualStyleBackColor = false;
            //button26.Click += new System.EventHandler(button26_Click);
            // 
            // button27
            // 
            button27.BackColor = SystemColors.ButtonFace;
            button27.Dock = DockStyle.Fill;
            button27.Location = new Point(501, 3);
            button27.Name = "button27";
            button27.Size = new Size(80, 62);
            button27.TabIndex = 29;
            button27.Text = "%";
            button27.UseVisualStyleBackColor = false;
            //button27.Click += new System.EventHandler(button27_Click);
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(418, 3);
            button4.Name = "button4";
            button4.Size = new Size(77, 62);
            button4.TabIndex = 6;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = false;
            //button4.Click += new System.EventHandler(button4_Click);
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(335, 3);
            button3.Name = "button3";
            button3.Size = new Size(77, 62);
            button3.TabIndex = 5;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            //button3.Click += new System.EventHandler(button3_Click);
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(252, 3);
            button2.Name = "button2";
            button2.Size = new Size(77, 62);
            button2.TabIndex = 4;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            //button2.Click += new System.EventHandler(button2_Click);
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(169, 3);
            button1.Name = "button1";
            button1.Size = new Size(77, 62);
            button1.TabIndex = 3;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            //button1.Click += new System.EventHandler(button1_Click);
            // 
            // button15
            // 
            button15.BackColor = SystemColors.ButtonFace;
            button15.Dock = DockStyle.Fill;
            button15.Location = new Point(86, 3);
            button15.Name = "button15";
            button15.Size = new Size(77, 62);
            button15.TabIndex = 17;
            button15.Text = "Log";
            button15.UseVisualStyleBackColor = false;
            //button15.Click += new System.EventHandler(button15_Click);
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ButtonFace;
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(501, 139);
            button10.Name = "button10";
            button10.Size = new Size(80, 62);
            button10.TabIndex = 12;
            button10.Text = ")";
            button10.UseVisualStyleBackColor = false;
            //button10.Click += new System.EventHandler(button10_Click);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            result = 0;
            expression = new StringBuilder(" ");
            expression.Append(richTextBox1.Text);
            try
            {
                ExpressionEvaluation exp = new ExpressionEvaluation();
                result = exp.evaluate(expression.ToString());
                richTextBox1.Text = result.ToString();
            }
            catch (Exception etc)
            { richTextBox1.Text = etc.ToString(); }
        }


    }



   
}
