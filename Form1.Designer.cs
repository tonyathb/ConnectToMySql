
namespace ConnectToMySql
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddNewMinion = new System.Windows.Forms.Button();
            this.btnUpdMinion = new System.Windows.Forms.Button();
            this.btnDeleteMinion = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(23, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(321, 429);
            this.listBox1.TabIndex = 0;
            // 
            // btnAddNewMinion
            // 
            this.btnAddNewMinion.Location = new System.Drawing.Point(809, 65);
            this.btnAddNewMinion.Name = "btnAddNewMinion";
            this.btnAddNewMinion.Size = new System.Drawing.Size(364, 66);
            this.btnAddNewMinion.TabIndex = 1;
            this.btnAddNewMinion.Text = "Add New Minion";
            this.btnAddNewMinion.UseVisualStyleBackColor = true;
            this.btnAddNewMinion.Click += new System.EventHandler(this.btnAddNewMinion_Click);
            // 
            // btnUpdMinion
            // 
            this.btnUpdMinion.Location = new System.Drawing.Point(809, 163);
            this.btnUpdMinion.Name = "btnUpdMinion";
            this.btnUpdMinion.Size = new System.Drawing.Size(364, 66);
            this.btnUpdMinion.TabIndex = 2;
            this.btnUpdMinion.Text = "Update Minion By ID";
            this.btnUpdMinion.UseVisualStyleBackColor = true;
            this.btnUpdMinion.Click += new System.EventHandler(this.btnUpdMinion_Click);
            // 
            // btnDeleteMinion
            // 
            this.btnDeleteMinion.Location = new System.Drawing.Point(809, 258);
            this.btnDeleteMinion.Name = "btnDeleteMinion";
            this.btnDeleteMinion.Size = new System.Drawing.Size(364, 66);
            this.btnDeleteMinion.TabIndex = 3;
            this.btnDeleteMinion.Text = "Delete Minion By ID";
            this.btnDeleteMinion.UseVisualStyleBackColor = true;
            this.btnDeleteMinion.Click += new System.EventHandler(this.btnDeleteMinion_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(809, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(364, 66);
            this.button2.TabIndex = 4;
            this.button2.Text = "Select Minion-Vilain Names";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(477, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(477, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 22);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(477, 185);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 22);
            this.textBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Town";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(484, 286);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(689, 18);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(112, 36);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "Find by Id";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 450);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDeleteMinion);
            this.Controls.Add(this.btnUpdMinion);
            this.Controls.Add(this.btnAddNewMinion);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Minions from minionsDB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAddNewMinion;
        private System.Windows.Forms.Button btnUpdMinion;
        private System.Windows.Forms.Button btnDeleteMinion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnFind;
    }
}

