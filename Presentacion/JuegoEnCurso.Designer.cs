namespace Presentacion
{
    partial class JuegoEnCurso
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbUsedNumbers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBoards = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlFortuneBoards = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pbGameMode = new System.Windows.Forms.PictureBox();
            this.lblAmountOfPlaters = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAmountOfNumbers = new System.Windows.Forms.Label();
            this.lblNewNumber = new System.Windows.Forms.Label();
            this.btnBingoNumber = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameMode)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(470, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(370, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbUsedNumbers);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(362, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Juego actual";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbUsedNumbers
            // 
            this.lbUsedNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsedNumbers.FormattingEnabled = true;
            this.lbUsedNumbers.ItemHeight = 24;
            this.lbUsedNumbers.Location = new System.Drawing.Point(21, 46);
            this.lbUsedNumbers.Name = "lbUsedNumbers";
            this.lbUsedNumbers.Size = new System.Drawing.Size(320, 340);
            this.lbUsedNumbers.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lista de números";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.cmbUsers);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.pnlBoards);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(362, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Jugadores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(82, 12);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(121, 21);
            this.cmbUsers.TabIndex = 2;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::Presentacion.Properties.Resources._1477086992_user;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "     Usuario:";
            // 
            // pnlBoards
            // 
            this.pnlBoards.AutoScroll = true;
            this.pnlBoards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBoards.Location = new System.Drawing.Point(6, 39);
            this.pnlBoards.Name = "pnlBoards";
            this.pnlBoards.Size = new System.Drawing.Size(350, 389);
            this.pnlBoards.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnlFortuneBoards);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(362, 434);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Afortunados";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlFortuneBoards
            // 
            this.pnlFortuneBoards.AutoScroll = true;
            this.pnlFortuneBoards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFortuneBoards.Location = new System.Drawing.Point(6, 39);
            this.pnlFortuneBoards.Name = "pnlFortuneBoards";
            this.pnlFortuneBoards.Size = new System.Drawing.Size(350, 389);
            this.pnlFortuneBoards.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pbGameMode);
            this.panel1.Controls.Add(this.lblAmountOfPlaters);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(266, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 259);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Modalidad:";
            // 
            // pbGameMode
            // 
            this.pbGameMode.Location = new System.Drawing.Point(3, 90);
            this.pbGameMode.Name = "pbGameMode";
            this.pbGameMode.Size = new System.Drawing.Size(178, 164);
            this.pbGameMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGameMode.TabIndex = 3;
            this.pbGameMode.TabStop = false;
            // 
            // lblAmountOfPlaters
            // 
            this.lblAmountOfPlaters.AutoSize = true;
            this.lblAmountOfPlaters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOfPlaters.Location = new System.Drawing.Point(157, 15);
            this.lblAmountOfPlaters.Name = "lblAmountOfPlaters";
            this.lblAmountOfPlaters.Size = new System.Drawing.Size(15, 16);
            this.lblAmountOfPlaters.TabIndex = 1;
            this.lblAmountOfPlaters.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad de jugadores:";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(358, 430);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(94, 23);
            this.btnNewGame.TabIndex = 5;
            this.btnNewGame.Text = "Juego nuevo";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad de números: ";
            // 
            // lblAmountOfNumbers
            // 
            this.lblAmountOfNumbers.AutoSize = true;
            this.lblAmountOfNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOfNumbers.Location = new System.Drawing.Point(181, 332);
            this.lblAmountOfNumbers.Name = "lblAmountOfNumbers";
            this.lblAmountOfNumbers.Size = new System.Drawing.Size(15, 16);
            this.lblAmountOfNumbers.TabIndex = 7;
            this.lblAmountOfNumbers.Text = "0";
            // 
            // lblNewNumber
            // 
            this.lblNewNumber.AutoSize = true;
            this.lblNewNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewNumber.Location = new System.Drawing.Point(31, 374);
            this.lblNewNumber.Name = "lblNewNumber";
            this.lblNewNumber.Size = new System.Drawing.Size(25, 25);
            this.lblNewNumber.TabIndex = 9;
            this.lblNewNumber.Text = "0";
            // 
            // btnBingoNumber
            // 
            this.btnBingoNumber.Image = global::Presentacion.Properties.Resources.bingobutton;
            this.btnBingoNumber.Location = new System.Drawing.Point(36, 25);
            this.btnBingoNumber.Name = "btnBingoNumber";
            this.btnBingoNumber.Size = new System.Drawing.Size(210, 281);
            this.btnBingoNumber.TabIndex = 3;
            this.btnBingoNumber.UseVisualStyleBackColor = true;
            this.btnBingoNumber.Click += new System.EventHandler(this.button3_Click);
            // 
            // GameOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 465);
            this.Controls.Add(this.lblNewNumber);
            this.Controls.Add(this.lblAmountOfNumbers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBingoNumber);
            this.Controls.Add(this.tabControl1);
            this.Name = "GameOn";
            this.Text = "GameOn";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameMode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlBoards;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBingoNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAmountOfPlaters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbGameMode;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAmountOfNumbers;
        private System.Windows.Forms.Label lblNewNumber;
        private System.Windows.Forms.ListBox lbUsedNumbers;
        private System.Windows.Forms.Panel pnlFortuneBoards;
    }
}