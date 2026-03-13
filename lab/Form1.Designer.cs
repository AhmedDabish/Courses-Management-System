namespace lab
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtDisplay;
        private Button btn7, btn8, btn9, btnDiv, btnCE;
        private Button btn4, btn5, btn6, btnMul, btnC;
        private Button btn1, btn2, btn3, btnSub, btnEq;
        private Button btn0, btnDot, btnAdd;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btn7 = new Button(); btn8 = new Button(); btn9 = new Button();
            btnDiv = new Button(); btnCE = new Button();
            btn4 = new Button(); btn5 = new Button(); btn6 = new Button();
            btnMul = new Button(); btnC = new Button();
            btn1 = new Button(); btn2 = new Button(); btn3 = new Button();
            btnSub = new Button(); btnEq = new Button();
            btn0 = new Button(); btnDot = new Button(); btnAdd = new Button();

            SuspendLayout();

            // ── Form settings ─────────────────────────────────────
            this.Text = "Calculator";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.AutoScaleMode = AutoScaleMode.None;
            this.ClientSize = new Size(360, 320);
            this.BackColor = Color.FromArgb(236, 233, 216);
            this.Name = "Form1";
            this.Load += Form1_Load;

            // ── Grid settings ─────────────────────────────────────
            int bw = 62, bh = 48, gap = 5, sx = 8, sy = 55;

            // ── Display ───────────────────────────────────────────
            txtDisplay.Location = new Point(sx, 10);
            txtDisplay.Size = new Size(bw * 5 + gap * 4, 38);
            txtDisplay.Font = new Font("Courier New", 18F);
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.ReadOnly = true;
            txtDisplay.BackColor = Color.White;
            txtDisplay.Text = "0";
            txtDisplay.TabStop = false;

            // ── Row 0 ─────────────────────────────────────────────
            MakeBtn(btn7, "7", 0, 0, 1, sx, sy, bw, bh, gap);
            MakeBtn(btn8, "8", 1, 0, 1, sx, sy, bw, bh, gap);
            MakeBtn(btn9, "9", 2, 0, 1, sx, sy, bw, bh, gap);
            MakeBtn(btnDiv, "/", 3, 0, 1, sx, sy, bw, bh, gap);
            MakeBtn(btnCE, "CE", 4, 0, 1, sx, sy, bw, bh, gap);

            // ── Row 1 ─────────────────────────────────────────────
            MakeBtn(btn4, "4", 0, 1, 1, sx, sy, bw, bh, gap);
            MakeBtn(btn5, "5", 1, 1, 1, sx, sy, bw, bh, gap);
            MakeBtn(btn6, "6", 2, 1, 1, sx, sy, bw, bh, gap);
            MakeBtn(btnMul, "*", 3, 1, 1, sx, sy, bw, bh, gap);
            MakeBtn(btnC, "C", 4, 1, 1, sx, sy, bw, bh, gap);

            // ── Row 2 ─────────────────────────────────────────────
            MakeBtn(btn1, "1", 0, 2, 1, sx, sy, bw, bh, gap);
            MakeBtn(btn2, "2", 1, 2, 1, sx, sy, bw, bh, gap);
            MakeBtn(btn3, "3", 2, 2, 1, sx, sy, bw, bh, gap);
            MakeBtn(btnSub, "-", 3, 2, 1, sx, sy, bw, bh, gap);

            // = spans rows 2 & 3
            btnEq.Text = "=";
            btnEq.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            btnEq.FlatStyle = FlatStyle.System;
            btnEq.Location = new Point(sx + 4 * (bw + gap), sy + 2 * (bh + gap));
            btnEq.Size = new Size(bw, bh * 2 + gap);
            btnEq.Click += Btn_Click;
            btnEq.TabStop = false;

            // ── Row 3 ─────────────────────────────────────────────
            MakeBtn(btn0, "0", 0, 3, 2, sx, sy, bw, bh, gap);
            MakeBtn(btnDot, ".", 2, 3, 1, sx, sy, bw, bh, gap);
            MakeBtn(btnAdd, "+", 3, 3, 1, sx, sy, bw, bh, gap);

            // ── Add all controls ──────────────────────────────────
            this.Controls.AddRange(new Control[] {
                txtDisplay,
                btn7, btn8, btn9, btnDiv, btnCE,
                btn4, btn5, btn6, btnMul, btnC,
                btn1, btn2, btn3, btnSub, btnEq,
                btn0, btnDot, btnAdd
            });

            ResumeLayout(false);
        }

        private void MakeBtn(Button b, string text, int col, int row, int colSpan,
                             int sx, int sy, int bw, int bh, int gap)
        {
            b.Text = text;
            b.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            b.FlatStyle = FlatStyle.System;
            b.Location = new Point(sx + col * (bw + gap), sy + row * (bh + gap));
            b.Size = new Size(bw * colSpan + gap * (colSpan - 1), bh);
            b.Click += Btn_Click;
            b.TabStop = false;
        }

        #endregion
    }
}