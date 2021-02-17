namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.cbComputerFirst = new System.Windows.Forms.CheckBox();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn20);
            this.panel1.Controls.Add(this.btn22);
            this.panel1.Controls.Add(this.btn21);
            this.panel1.Controls.Add(this.btn10);
            this.panel1.Controls.Add(this.btn12);
            this.panel1.Controls.Add(this.btn11);
            this.panel1.Controls.Add(this.btn00);
            this.panel1.Controls.Add(this.btn02);
            this.panel1.Controls.Add(this.btn01);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 0;
            // 
            // btn20
            // 
            this.btn20.BackColor = System.Drawing.Color.White;
            this.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn20.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20.Location = new System.Drawing.Point(3, 198);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(100, 100);
            this.btn20.TabIndex = 6;
            this.btn20.UseVisualStyleBackColor = false;
            this.btn20.Click += new System.EventHandler(this.btnCases_Click);
            // 
            // btn22
            // 
            this.btn22.BackColor = System.Drawing.Color.White;
            this.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn22.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn22.Location = new System.Drawing.Point(197, 198);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(100, 100);
            this.btn22.TabIndex = 8;
            this.btn22.UseVisualStyleBackColor = false;
            this.btn22.Click += new System.EventHandler(this.btnCases_Click);
            // 
            // btn21
            // 
            this.btn21.BackColor = System.Drawing.Color.White;
            this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn21.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn21.Location = new System.Drawing.Point(100, 198);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(100, 100);
            this.btn21.TabIndex = 7;
            this.btn21.UseVisualStyleBackColor = false;
            this.btn21.Click += new System.EventHandler(this.btnCases_Click);
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.White;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(3, 100);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(100, 100);
            this.btn10.TabIndex = 3;
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.Click += new System.EventHandler(this.btnCases_Click);
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.White;
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.Location = new System.Drawing.Point(197, 100);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(100, 100);
            this.btn12.TabIndex = 5;
            this.btn12.UseVisualStyleBackColor = false;
            this.btn12.Click += new System.EventHandler(this.btnCases_Click);
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.White;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.Location = new System.Drawing.Point(100, 100);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(100, 100);
            this.btn11.TabIndex = 4;
            this.btn11.UseVisualStyleBackColor = false;
            this.btn11.Click += new System.EventHandler(this.btnCases_Click);
            // 
            // btn00
            // 
            this.btn00.BackColor = System.Drawing.Color.White;
            this.btn00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn00.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn00.Location = new System.Drawing.Point(3, 2);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(100, 100);
            this.btn00.TabIndex = 0;
            this.btn00.UseVisualStyleBackColor = false;
            this.btn00.Click += new System.EventHandler(this.btnCases_Click);
            // 
            // btn02
            // 
            this.btn02.BackColor = System.Drawing.Color.White;
            this.btn02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn02.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn02.Location = new System.Drawing.Point(197, 2);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(100, 100);
            this.btn02.TabIndex = 2;
            this.btn02.UseVisualStyleBackColor = false;
            this.btn02.Click += new System.EventHandler(this.btnCases_Click);
            // 
            // btn01
            // 
            this.btn01.BackColor = System.Drawing.Color.White;
            this.btn01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn01.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn01.Location = new System.Drawing.Point(100, 2);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(100, 100);
            this.btn01.TabIndex = 1;
            this.btn01.UseVisualStyleBackColor = false;
            this.btn01.Click += new System.EventHandler(this.btnCases_Click);
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.Location = new System.Drawing.Point(15, 389);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(294, 46);
            this.btnRecommencer.TabIndex = 1;
            this.btnRecommencer.Text = "Recommencer";
            this.btnRecommencer.UseVisualStyleBackColor = true;
            this.btnRecommencer.Click += new System.EventHandler(this.InitialisationPlateau);
            // 
            // cbComputerFirst
            // 
            this.cbComputerFirst.AutoSize = true;
            this.cbComputerFirst.Checked = true;
            this.cbComputerFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbComputerFirst.Location = new System.Drawing.Point(15, 327);
            this.cbComputerFirst.Name = "cbComputerFirst";
            this.cbComputerFirst.Size = new System.Drawing.Size(150, 17);
            this.cbComputerFirst.TabIndex = 2;
            this.cbComputerFirst.Text = "Ordinateur joue en premier";
            this.cbComputerFirst.UseVisualStyleBackColor = true;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(12, 357);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(173, 13);
            this.lblTotalCount.TabIndex = 3;
            this.lblTotalCount.Text = "Nombre de dispositions calculées : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 451);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.cbComputerFirst);
            this.Controls.Add(this.btnRecommencer);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btnRecommencer;
        private System.Windows.Forms.CheckBox cbComputerFirst;
        private System.Windows.Forms.Label lblTotalCount;
    }
}

