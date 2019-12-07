namespace WireMath
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtbxExpression = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGraph = new System.Windows.Forms.Button();
			this.txtbxResult = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.anglLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.xYBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Location = new System.Drawing.Point(12, 36);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(422, 349);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// txtbxExpression
			// 
			this.txtbxExpression.BackColor = System.Drawing.Color.DimGray;
			this.txtbxExpression.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtbxExpression.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtbxExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbxExpression.ForeColor = System.Drawing.Color.White;
			this.txtbxExpression.Location = new System.Drawing.Point(0, 0);
			this.txtbxExpression.Name = "txtbxExpression";
			this.txtbxExpression.Size = new System.Drawing.Size(175, 20);
			this.txtbxExpression.TabIndex = 1;
			this.txtbxExpression.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Cambria Math", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(0, -1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 106);
			this.label1.TabIndex = 2;
			// 
			// btnGraph
			// 
			this.btnGraph.BackColor = System.Drawing.Color.DarkGreen;
			this.btnGraph.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnGraph.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnGraph.FlatAppearance.BorderSize = 0;
			this.btnGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGraph.ForeColor = System.Drawing.Color.White;
			this.btnGraph.Location = new System.Drawing.Point(0, 157);
			this.btnGraph.Name = "btnGraph";
			this.btnGraph.Size = new System.Drawing.Size(270, 34);
			this.btnGraph.TabIndex = 3;
			this.btnGraph.Text = "Graph";
			this.btnGraph.UseVisualStyleBackColor = false;
			this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
			// 
			// txtbxResult
			// 
			this.txtbxResult.Location = new System.Drawing.Point(2, 307);
			this.txtbxResult.Name = "txtbxResult";
			this.txtbxResult.Size = new System.Drawing.Size(100, 20);
			this.txtbxResult.TabIndex = 5;
			this.txtbxResult.Visible = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(15, 84);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(65, 26);
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.anglLabel);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(314, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(444, 418);
			this.panel1.TabIndex = 9;
			// 
			// anglLabel
			// 
			this.anglLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.anglLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.anglLabel.Location = new System.Drawing.Point(0, 393);
			this.anglLabel.Name = "anglLabel";
			this.anglLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.anglLabel.Size = new System.Drawing.Size(442, 23);
			this.anglLabel.TabIndex = 2;
			this.anglLabel.Text = "X = 0, Y = 0, Z = 0";
			this.anglLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.DimGray;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(442, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "Graph";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Controls.Add(this.btnGraph);
			this.panel2.Location = new System.Drawing.Point(21, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(272, 193);
			this.panel2.TabIndex = 10;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Silver;
			this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Location = new System.Drawing.Point(0, 123);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(270, 34);
			this.button3.TabIndex = 14;
			this.button3.Text = "Reset";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// panel5
			// 
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.label4);
			this.panel5.Location = new System.Drawing.Point(15, 52);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(65, 26);
			this.panel5.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 24);
			this.label4.TabIndex = 0;
			this.label4.Text = "Angles";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.DimGray;
			this.panel4.Controls.Add(this.txtbxExpression);
			this.panel4.ForeColor = System.Drawing.Color.White;
			this.panel4.Location = new System.Drawing.Point(80, 84);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(175, 26);
			this.panel4.TabIndex = 10;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DimGray;
			this.panel3.Controls.Add(this.xYBox);
			this.panel3.Location = new System.Drawing.Point(80, 52);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(175, 26);
			this.panel3.TabIndex = 9;
			// 
			// xYBox
			// 
			this.xYBox.BackColor = System.Drawing.Color.DimGray;
			this.xYBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.xYBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xYBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xYBox.ForeColor = System.Drawing.Color.White;
			this.xYBox.Location = new System.Drawing.Point(0, 0);
			this.xYBox.Name = "xYBox";
			this.xYBox.Size = new System.Drawing.Size(175, 25);
			this.xYBox.TabIndex = 10;
			this.xYBox.Text = "x,y,z";
			this.xYBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.DimGray;
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(270, 33);
			this.label3.TabIndex = 1;
			this.label3.Text = "Parameters";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(178, 336);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "Up";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(202, 307);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 13;
			this.button2.Text = "Right";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(770, 448);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtbxResult);
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WireMath";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbxExpression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.TextBox txtbxResult;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xYBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label anglLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

