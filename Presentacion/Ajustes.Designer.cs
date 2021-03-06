﻿namespace Presentacion
{
    partial class Ajustes
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
            this.gvDetails = new System.Windows.Forms.DataGridView();
            this.players = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numofCartons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAmountOfNumbers = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGameModes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAoB = new System.Windows.Forms.Label();
            this.lblAoP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoardAmounts = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarJugador = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDetails
            // 
            this.gvDetails.AllowUserToAddRows = false;
            this.gvDetails.AllowUserToDeleteRows = false;
            this.gvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.players,
            this.numofCartons});
            this.gvDetails.Location = new System.Drawing.Point(21, 24);
            this.gvDetails.Name = "gvDetails";
            this.gvDetails.ReadOnly = true;
            this.gvDetails.RowHeadersVisible = false;
            this.gvDetails.Size = new System.Drawing.Size(204, 310);
            this.gvDetails.TabIndex = 0;
            // 
            // players
            // 
            this.players.HeaderText = "Jugadores";
            this.players.Name = "players";
            this.players.ReadOnly = true;
            // 
            // numofCartons
            // 
            this.numofCartons.HeaderText = "Número de cartones";
            this.numofCartons.Name = "numofCartons";
            this.numofCartons.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtAmountOfNumbers);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbGameModes);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtBoardAmounts);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAgregarJugador);
            this.panel1.Location = new System.Drawing.Point(244, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 292);
            this.panel1.TabIndex = 4;
            // 
            // txtAmountOfNumbers
            // 
            this.txtAmountOfNumbers.Location = new System.Drawing.Point(25, 240);
            this.txtAmountOfNumbers.Name = "txtAmountOfNumbers";
            this.txtAmountOfNumbers.Size = new System.Drawing.Size(156, 20);
            this.txtAmountOfNumbers.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad de números";
            // 
            // cmbGameModes
            // 
            this.cmbGameModes.FormattingEnabled = true;
            this.cmbGameModes.Location = new System.Drawing.Point(25, 182);
            this.cmbGameModes.Name = "cmbGameModes";
            this.cmbGameModes.Size = new System.Drawing.Size(156, 21);
            this.cmbGameModes.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Modalidad de juego";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblAoB);
            this.panel2.Controls.Add(this.lblAoP);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(249, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 220);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.small;
            this.pictureBox1.Location = new System.Drawing.Point(13, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblAoB
            // 
            this.lblAoB.AutoSize = true;
            this.lblAoB.Location = new System.Drawing.Point(123, 46);
            this.lblAoB.Name = "lblAoB";
            this.lblAoB.Size = new System.Drawing.Size(13, 13);
            this.lblAoB.TabIndex = 10;
            this.lblAoB.Text = "0";
            // 
            // lblAoP
            // 
            this.lblAoP.AutoSize = true;
            this.lblAoP.Location = new System.Drawing.Point(123, 15);
            this.lblAoP.Name = "lblAoP";
            this.lblAoP.Size = new System.Drawing.Size(13, 13);
            this.lblAoP.TabIndex = 9;
            this.lblAoP.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total de cartones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total de jugadores:";
            // 
            // txtBoardAmounts
            // 
            this.txtBoardAmounts.Location = new System.Drawing.Point(29, 84);
            this.txtBoardAmounts.Name = "txtBoardAmounts";
            this.txtBoardAmounts.Size = new System.Drawing.Size(156, 20);
            this.txtBoardAmounts.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(29, 33);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(156, 20);
            this.txtUsername.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad de cartones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de usuario";
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.Image = global::Presentacion.Properties.Resources._1473411780_add_user;
            this.btnAgregarJugador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarJugador.Location = new System.Drawing.Point(40, 114);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(124, 23);
            this.btnAgregarJugador.TabIndex = 1;
            this.btnAgregarJugador.Text = "Agregar jugador";
            this.btnAgregarJugador.UseVisualStyleBackColor = true;
            this.btnAgregarJugador.Click += new System.EventHandler(this.btnAgregarJugador_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::Presentacion.Properties.Resources._1472354373_floppy;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(508, 322);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Presentacion.Properties.Resources._1472334897_f_cross_256;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(608, 322);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Ajustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 357);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gvDetails);
            this.Name = "Ajustes";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn players;
        private System.Windows.Forms.DataGridViewTextBoxColumn numofCartons;
        private System.Windows.Forms.Button btnAgregarJugador;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAoB;
        private System.Windows.Forms.Label lblAoP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoardAmounts;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGameModes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmountOfNumbers;
        private System.Windows.Forms.Label label5;
    }
}