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

namespace Grapecity.Internship.Assignment.Calculator.WindowsForm
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
        private Button buttonMR;
        private Button buttonMS;
        private Button buttonClear;
        private Button buttonBackSpace;
        private Button buttonMPlus;
        private Button buttonOne;
        private Button buttonTwo;
        private Button buttonThree;
        private Button buttonSqrt;
        private Button buttonReciprocal;
        private Button buttonTan;
        private Button buttonFour;
        private Button buttonCos;
        private Button buttonNegate;
        private Button buttonSin;
        private Button buttonExp;
        private Button buttonBracketO;
        private Button buttonLog;
        private Button buttonLn;
        private Button buttonFive;
        private Button buttonPercent;
        private Button buttonBracketC;
        private Button buttonSix;
        private Button buttonMul;
        private Button buttonSeven;
        private Button buttonEight;
        private Button buttonDec;
        private Button buttonZero;
        private Button buttonEquals;
        private Button buttonDivide;
        private Button buttonNine;
        private Button buttonPlus;
        private Button buttonMinus;
        StringBuilder expression;
        double result;
        private bool flag;

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
            tableLayoutPanel1.Controls.Add(buttonMR, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonMS, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonMPlus, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonClear, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonBackSpace, 4, 0);
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
            tableLayoutPanel2.Controls.Add(buttonOne, 2, 0);
            tableLayoutPanel2.Controls.Add(buttonTwo, 3, 0);
            tableLayoutPanel2.Controls.Add(buttonThree, 4, 0);
            tableLayoutPanel2.Controls.Add(buttonSqrt, 0, 3);
            tableLayoutPanel2.Controls.Add(buttonReciprocal, 6, 1);
            tableLayoutPanel2.Controls.Add(buttonTan, 0, 2);
            tableLayoutPanel2.Controls.Add(buttonFour, 2, 1);
            tableLayoutPanel2.Controls.Add(buttonCos, 0, 1);
            tableLayoutPanel2.Controls.Add(buttonNegate, 1, 3);
            tableLayoutPanel2.Controls.Add(buttonSin, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonExp, 1, 2);
            tableLayoutPanel2.Controls.Add(buttonBracketO, 6, 3);
            tableLayoutPanel2.Controls.Add(buttonLog, 1, 0);
            tableLayoutPanel2.Controls.Add(buttonLn, 1, 1);
            tableLayoutPanel2.Controls.Add(buttonFive, 3, 1);
            tableLayoutPanel2.Controls.Add(buttonPercent, 6, 0);
            tableLayoutPanel2.Controls.Add(buttonBracketC, 6, 2);
            tableLayoutPanel2.Controls.Add(buttonSix, 4, 1);
            tableLayoutPanel2.Controls.Add(buttonSeven, 2, 2);
            tableLayoutPanel2.Controls.Add(buttonEight, 3, 2);
            tableLayoutPanel2.Controls.Add(buttonNine, 4, 2);
            tableLayoutPanel2.Controls.Add(buttonDec, 2, 3);
            tableLayoutPanel2.Controls.Add(buttonZero, 3, 3);
            tableLayoutPanel2.Controls.Add(buttonEquals, 4, 3);
            tableLayoutPanel2.Controls.Add(buttonDivide, 5, 3);
            tableLayoutPanel2.Controls.Add(buttonMul, 5, 2);
            tableLayoutPanel2.Controls.Add(buttonPlus, 5, 0);
            tableLayoutPanel2.Controls.Add(buttonMinus, 5, 1);
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
            buttonMR = new Button();
            buttonMS = new Button();
            buttonClear = new Button();
            buttonBackSpace = new Button();
            buttonMPlus = new Button();
            buttonBracketO = new Button();
            buttonSin = new Button();
            buttonMul = new Button();
            buttonDivide = new Button();
            buttonEquals = new Button();
            buttonNine = new Button();
            buttonEight = new Button();
            buttonZero = new Button();
            buttonDec = new Button();
            buttonSeven = new Button();
            buttonExp = new Button();
            buttonNegate = new Button();
            buttonSqrt = new Button();
            buttonTan = new Button();
            buttonCos = new Button();
            buttonLn = new Button();
            buttonFour = new Button();
            buttonFive = new Button();
            buttonSix = new Button();
            buttonMinus = new Button();
            buttonReciprocal = new Button();
            buttonPercent = new Button();
            buttonPlus = new Button();
            buttonThree = new Button();
            buttonTwo = new Button();
            buttonOne = new Button();
            buttonLog = new Button();
            buttonBracketC = new Button();

            buttonMR.BackColor = SystemColors.ButtonFace;
            buttonMR.Dock = DockStyle.Fill;
            buttonMR.Location = new Point(3, 3);
            buttonMR.Name = "buttonMR";
            buttonMR.Size = new Size(110, 59);
            buttonMR.TabIndex = 10;
            buttonMR.Text = "MR";
            buttonMR.Margin = new Padding(1);
            buttonMR.UseVisualStyleBackColor = false;
            // 
            // buttonMS
            // 
            buttonMS.BackColor = SystemColors.ButtonFace;
            buttonMS.Dock = DockStyle.Fill;
            buttonMS.Location = new Point(119, 3);
            buttonMS.Name = "buttonMS";
            buttonMS.Size = new Size(110, 59);
            buttonMS.TabIndex = 18;
            buttonMS.Text = "MS";
            buttonMS.UseVisualStyleBackColor = false;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.ButtonFace;
            buttonClear.Dock = DockStyle.Fill;
            buttonClear.Location = new Point(351, 3);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(110, 59);
            buttonClear.TabIndex = 30;
            buttonClear.Text = "C/CE";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += new EventHandler(ClearButton);
            // 
            // buttonBackSpace
            // 
            buttonBackSpace.BackColor = SystemColors.ButtonFace;
            buttonBackSpace.Dock = DockStyle.Fill;
            buttonBackSpace.Location = new Point(467, 3);
            buttonBackSpace.Name = "buttonBackSpace";
            buttonBackSpace.Size = new Size(114, 59);
            buttonBackSpace.TabIndex = 34;
            buttonBackSpace.Text = "<-";
            buttonBackSpace.UseVisualStyleBackColor = false;
            //buttonBackSpace.Click += new System.EventHandler(button7_Click);
            // 
            // buttonMPlus
            // 
            buttonMPlus.BackColor = SystemColors.ButtonFace;
            buttonMPlus.Dock = DockStyle.Fill;
            buttonMPlus.Location = new Point(235, 3);
            buttonMPlus.Name = "buttonMPlus";
            buttonMPlus.Size = new Size(110, 59);
            buttonMPlus.TabIndex = 35;
            buttonMPlus.Text = "M+";
            buttonMPlus.UseVisualStyleBackColor = false;
            // 
            // buttonBracketO
            // 
            buttonBracketO.BackColor = SystemColors.ButtonFace;
            buttonBracketO.Dock = DockStyle.Fill;
            buttonBracketO.Location = new Point(501, 207);
            buttonBracketO.Name = "buttonBracketO";
            buttonBracketO.Size = new Size(80, 65);
            buttonBracketO.TabIndex = 31;
            buttonBracketO.Text = "(";
            buttonBracketO.UseVisualStyleBackColor = false;
            buttonBracketO.Click += new System.EventHandler(onButtonClickOperator);
            // 
            // buttonSin
            // 
            buttonSin.BackColor = SystemColors.ButtonFace;
            buttonSin.Dock = DockStyle.Fill;
            buttonSin.Location = new Point(3, 3);
            buttonSin.Name = "buttonSin";
            buttonSin.Size = new Size(77, 62);
            buttonSin.TabIndex = 32;
            buttonSin.Text = "Sin";
            buttonSin.UseVisualStyleBackColor = false;
            buttonSin.Click += new System.EventHandler(trigoClick);
            // 
            // buttonMul
            // 
            buttonMul.BackColor = SystemColors.ButtonFace;
            buttonMul.Dock = DockStyle.Fill;
            buttonMul.Location = new Point(418, 139);
            buttonMul.Name = "buttonMul";
            buttonMul.Size = new Size(77, 62);
            buttonMul.TabIndex = 16;
            buttonMul.Text = "*";
            buttonMul.UseVisualStyleBackColor = false;
            buttonMul.Click += new System.EventHandler(onButtonClickOperator);
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = SystemColors.ButtonFace;
            buttonDivide.Dock = DockStyle.Fill;
            buttonDivide.Location = new Point(418, 207);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(77, 65);
            buttonDivide.TabIndex = 14;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += new System.EventHandler(onButtonClickOperator);
            // 
            // buttonEquals
            // 
            buttonEquals.BackColor = SystemColors.ButtonFace;
            buttonEquals.Dock = DockStyle.Fill;
            buttonEquals.Location = new Point(335, 207);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(77, 65);
            buttonEquals.TabIndex = 19;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = false;
            buttonEquals.Click += new System.EventHandler(onEqualsClick);
            // 
            // buttonNine
            // 
            buttonNine.BackColor = SystemColors.ButtonFace;
            buttonNine.Dock = DockStyle.Fill;
            buttonNine.Location = new Point(335, 139);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(77, 62);
            buttonNine.TabIndex = 22;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = false;
            buttonNine.Click += new System.EventHandler(onButtonClick);
            // 
            // buttonEight
            // 
            buttonEight.BackColor = SystemColors.ButtonFace;
            buttonEight.Dock = DockStyle.Fill;
            buttonEight.Location = new Point(252, 139);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(77, 62);
            buttonEight.TabIndex = 23;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = false;
            buttonEight.Click += new System.EventHandler(onButtonClick);
            // 
            // buttonZero
            // 
            buttonZero.BackColor = SystemColors.ButtonFace;
            buttonZero.Dock = DockStyle.Fill;
            buttonZero.Location = new Point(252, 207);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(77, 65);
            buttonZero.TabIndex = 20;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = false;
            buttonZero.Click += new System.EventHandler(onButtonClick);
            // 
            // buttonDec
            // 
            buttonDec.BackColor = SystemColors.ButtonFace;
            buttonDec.Dock = DockStyle.Fill;
            buttonDec.Location = new Point(169, 207);
            buttonDec.Name = "buttonDec";
            buttonDec.Size = new Size(77, 65);
            buttonDec.TabIndex = 21;
            buttonDec.Text = ".";
            buttonDec.UseVisualStyleBackColor = false;
            buttonDec.Click += new System.EventHandler(onButtonClick);
            // 
            // buttonSeven
            // 
            buttonSeven.BackColor = SystemColors.ButtonFace;
            buttonSeven.Dock = DockStyle.Fill;
            buttonSeven.Location = new Point(169, 139);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(77, 62);
            buttonSeven.TabIndex = 24;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = false;
            buttonSeven.Click += new System.EventHandler(onButtonClick);
            // 
            // buttonExp
            // 
            buttonExp.BackColor = SystemColors.ButtonFace;
            buttonExp.Dock = DockStyle.Fill;
            buttonExp.Location = new Point(86, 139);
            buttonExp.Name = "buttonExp";
            buttonExp.Size = new Size(77, 62);
            buttonExp.TabIndex = 37;
            buttonExp.Text = "^";
            buttonExp.UseVisualStyleBackColor = false;
            buttonExp.Click += new System.EventHandler(onButtonClickOperator);
            // 
            // buttonNegate
            // 
            buttonNegate.BackColor = SystemColors.ButtonFace;
            buttonNegate.Dock = DockStyle.Fill;
            buttonNegate.Location = new Point(86, 207);
            buttonNegate.Name = "buttonNegate";
            buttonNegate.Size = new Size(77, 65);
            buttonNegate.TabIndex = 36;
            buttonNegate.Text = "+/-";
            buttonNegate.UseVisualStyleBackColor = false;
            //buttonNegate.Click += new System.EventHandler(button32_Click);
            // 
            // buttonSqrt
            // 
            buttonSqrt.BackColor = SystemColors.ButtonFace;
            buttonSqrt.Dock = DockStyle.Fill;
            buttonSqrt.Location = new Point(3, 207);
            buttonSqrt.Name = "buttonSqrt";
            buttonSqrt.Size = new Size(77, 65);
            buttonSqrt.TabIndex = 13;
            buttonSqrt.Text = "Sqrt";
            buttonSqrt.UseVisualStyleBackColor = false;
            buttonSqrt.Click += new System.EventHandler(trigoClick);
            // 
            // buttonTan
            // 
            buttonTan.BackColor = SystemColors.ButtonFace;
            buttonTan.Dock = DockStyle.Fill;
            buttonTan.Location = new Point(3, 139);
            buttonTan.Name = "buttonTan";
            buttonTan.Size = new Size(77, 62);
            buttonTan.TabIndex = 38;
            buttonTan.Text = "Tan";
            buttonTan.UseVisualStyleBackColor = false;
            buttonTan.Click += new System.EventHandler(trigoClick);
            // 
            // buttonCos
            // 
            buttonCos.BackColor = SystemColors.ButtonFace;
            buttonCos.Dock = DockStyle.Fill;
            buttonCos.Location = new Point(3, 71);
            buttonCos.Name = "buttonCos";
            buttonCos.Size = new Size(77, 62);
            buttonCos.TabIndex = 33;
            buttonCos.Text = "Cos";
            buttonCos.UseVisualStyleBackColor = false;
            buttonCos.Click += new System.EventHandler(trigoClick);
            // 
            // buttonLn
            // 
            buttonLn.BackColor = SystemColors.ButtonFace;
            buttonLn.Dock = DockStyle.Fill;
            buttonLn.Location = new Point(86, 71);
            buttonLn.Name = "buttonLn";
            buttonLn.Size = new Size(77, 62);
            buttonLn.TabIndex = 11;
            buttonLn.Text = "ln";
            buttonLn.UseVisualStyleBackColor = false;
            buttonLn.Click += new System.EventHandler(trigoClick);
            // 
            // buttonFour
            // 
            buttonFour.BackColor = SystemColors.ButtonFace;
            buttonFour.Dock = DockStyle.Fill;
            buttonFour.Location = new Point(169, 71);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(77, 62);
            buttonFour.TabIndex = 27;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = false;
            buttonFour.Click += new System.EventHandler(onButtonClick);
            // 
            // buttonFive
            // 
            buttonFive.BackColor = SystemColors.ButtonFace;
            buttonFive.Dock = DockStyle.Fill;
            buttonFive.Location = new Point(252, 71);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(77, 62);
            buttonFive.TabIndex = 26;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = false;
            buttonFive.Click += new System.EventHandler(onButtonClick);
            // 
            // buttonSix
            // 
            buttonSix.BackColor = SystemColors.ButtonFace;
            buttonSix.Dock = DockStyle.Fill;
            buttonSix.Location = new Point(335, 71);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(77, 62);
            buttonSix.TabIndex = 25;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = false;
            buttonSix.Click += new System.EventHandler(onButtonClick);
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = SystemColors.ButtonFace;
            buttonMinus.Dock = DockStyle.Fill;
            buttonMinus.Location = new Point(418, 71);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(77, 62);
            buttonMinus.TabIndex = 7;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += new System.EventHandler(onButtonClickOperator);
            // 
            // buttonReciprocal
            // 
            buttonReciprocal.BackColor = SystemColors.ButtonFace;
            buttonReciprocal.Dock = DockStyle.Fill;
            buttonReciprocal.Location = new Point(501, 71);
            buttonReciprocal.Name = "buttonReciprocal";
            buttonReciprocal.Size = new Size(80, 62);
            buttonReciprocal.TabIndex = 28;
            buttonReciprocal.Text = "1/x";
            buttonReciprocal.UseVisualStyleBackColor = false;
            buttonReciprocal.Click += new System.EventHandler(trigoClick);
            // 
            // buttonPercent
            // 
            buttonPercent.BackColor = SystemColors.ButtonFace;
            buttonPercent.Dock = DockStyle.Fill;
            buttonPercent.Location = new Point(501, 3);
            buttonPercent.Name = "buttonPercent";
            buttonPercent.Size = new Size(80, 62);
            buttonPercent.TabIndex = 29;
            buttonPercent.Text = "%";
            buttonPercent.UseVisualStyleBackColor = false;
            buttonPercent.Click += new System.EventHandler(onButtonClickOperator);
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = SystemColors.ButtonFace;
            buttonPlus.Dock = DockStyle.Fill;
            buttonPlus.Location = new Point(418, 3);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(77, 62);
            buttonPlus.TabIndex = 6;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += new System.EventHandler(onButtonClickOperator);
            // 
            // buttonThree
            // 
            buttonThree.BackColor = SystemColors.ButtonFace;
            buttonThree.Dock = DockStyle.Fill;
            buttonThree.Location = new Point(335, 3);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(77, 62);
            buttonThree.TabIndex = 5;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = false;
            buttonThree.Click += new System.EventHandler(onButtonClick);
            // 
            // buttonTwo
            // 
            buttonTwo.BackColor = SystemColors.ButtonFace;
            buttonTwo.Dock = DockStyle.Fill;
            buttonTwo.Location = new Point(252, 3);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(77, 62);
            buttonTwo.TabIndex = 4;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = false;
            buttonTwo.Click += new System.EventHandler(onButtonClick);
            // 
            // buttonOne
            // 
            buttonOne.BackColor = SystemColors.ButtonFace;
            buttonOne.Dock = DockStyle.Fill;
            buttonOne.Location = new Point(169, 3);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(77, 62);
            buttonOne.TabIndex = 3;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = false;
            buttonOne.Click += new System.EventHandler(onButtonClick);
            // 
            // buttonLog
            // 
            buttonLog.BackColor = SystemColors.ButtonFace;
            buttonLog.Dock = DockStyle.Fill;
            buttonLog.Location = new Point(86, 3);
            buttonLog.Name = "buttonLog";
            buttonLog.Size = new Size(77, 62);
            buttonLog.TabIndex = 17;
            buttonLog.Text = "Log";
            buttonLog.UseVisualStyleBackColor = false;
            buttonLog.Click += new System.EventHandler(trigoClick);
            // 
            // buttonBracketC
            // 
            buttonBracketC.BackColor = SystemColors.ButtonFace;
            buttonBracketC.Dock = DockStyle.Fill;
            buttonBracketC.Location = new Point(501, 139);
            buttonBracketC.Name = "buttonBracketC";
            buttonBracketC.Size = new Size(80, 62);
            buttonBracketC.TabIndex = 12;
            buttonBracketC.Text = ")";
            buttonBracketC.UseVisualStyleBackColor = false;
            buttonBracketC.Click += new System.EventHandler(onButtonClickOperator);

        }

        private void onEqualsClick(object sender, EventArgs e)
        {
            result = 0;
            flag = true;
            expression = new StringBuilder(" ");
            expression.Append(richTextBox1.Text);
            try
            {
                ExpressionEvaluation exp = new ExpressionEvaluation();
                result = exp.Evaluate(expression.ToString());
                richTextBox1.Text = result.ToString();
            }
            catch (Exception etc)
            { richTextBox1.Text = etc.ToString(); }
            
        }

        private void onButtonClickOperator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((richTextBox1.Text == "0" || richTextBox1.Text == "") && button.Text == "-")
            {
                richTextBox1.Text = "0 - ";
                flag = false;
            }
            else if (flag == true)
            {
                richTextBox1.Text = richTextBox1.Text + " " + button.Text + " ";
                flag = false;
            }
            else
                richTextBox1.Text = richTextBox1.Text + " " + button.Text + " ";


        }
        private void onButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (richTextBox1.Text == "0" || flag == true)
            {
                richTextBox1.Text = button.Text;
                flag = false;
            }
            else
                richTextBox1.Text = richTextBox1.Text + button.Text;
        }

        private void ClearButton(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void trigoClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (richTextBox1.Text == "0" || flag == true)
            {
                richTextBox1.Text = button.Text +  " ( ";
                flag = false;
            }
            else
                richTextBox1.Text = richTextBox1.Text + button.Text + " ( ";
        }

    }
 
}
