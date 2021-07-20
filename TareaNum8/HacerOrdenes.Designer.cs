
namespace TareaNum8
{
    partial class HacerOrdenes
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNameClient = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblPlatFuert = new System.Windows.Forms.Label();
            this.lblBebida = new System.Windows.Forms.Label();
            this.lblPostre = new System.Windows.Forms.Label();
            this.CbxEntrada = new System.Windows.Forms.ComboBox();
            this.CbxPlatFuert = new System.Windows.Forms.ComboBox();
            this.CbxBebida = new System.Windows.Forms.ComboBox();
            this.CbxPostre = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.lblTema = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelarGen = new System.Windows.Forms.Button();
            this.BtnAddGet = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.125F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTema, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblNameClient, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblEntrada, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPlatFuert, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblBebida, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblPostre, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.CbxEntrada, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.CbxPlatFuert, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.CbxBebida, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.CbxPostre, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.TxtNombre, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(111, 67);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(573, 277);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblNameClient
            // 
            this.lblNameClient.AutoSize = true;
            this.lblNameClient.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNameClient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameClient.Location = new System.Drawing.Point(127, 0);
            this.lblNameClient.Name = "lblNameClient";
            this.lblNameClient.Size = new System.Drawing.Size(156, 55);
            this.lblNameClient.TabIndex = 0;
            this.lblNameClient.Text = "Nombre de cliente:";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblEntrada.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEntrada.Location = new System.Drawing.Point(210, 55);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(73, 55);
            this.lblEntrada.TabIndex = 0;
            this.lblEntrada.Text = "Entrada:";
            // 
            // lblPlatFuert
            // 
            this.lblPlatFuert.AutoSize = true;
            this.lblPlatFuert.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPlatFuert.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlatFuert.Location = new System.Drawing.Point(180, 110);
            this.lblPlatFuert.Name = "lblPlatFuert";
            this.lblPlatFuert.Size = new System.Drawing.Size(103, 55);
            this.lblPlatFuert.TabIndex = 0;
            this.lblPlatFuert.Text = "Plato fuerte:";
            this.lblPlatFuert.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBebida
            // 
            this.lblBebida.AutoSize = true;
            this.lblBebida.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBebida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBebida.Location = new System.Drawing.Point(217, 165);
            this.lblBebida.Name = "lblBebida";
            this.lblBebida.Size = new System.Drawing.Size(66, 55);
            this.lblBebida.TabIndex = 0;
            this.lblBebida.Text = "Bebida:";
            // 
            // lblPostre
            // 
            this.lblPostre.AutoSize = true;
            this.lblPostre.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPostre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPostre.Location = new System.Drawing.Point(222, 220);
            this.lblPostre.Name = "lblPostre";
            this.lblPostre.Size = new System.Drawing.Size(61, 57);
            this.lblPostre.TabIndex = 0;
            this.lblPostre.Text = "Postre:";
            // 
            // CbxEntrada
            // 
            this.CbxEntrada.Dock = System.Windows.Forms.DockStyle.Left;
            this.CbxEntrada.FormattingEnabled = true;
            this.CbxEntrada.Location = new System.Drawing.Point(289, 58);
            this.CbxEntrada.Name = "CbxEntrada";
            this.CbxEntrada.Size = new System.Drawing.Size(227, 28);
            this.CbxEntrada.TabIndex = 1;
            // 
            // CbxPlatFuert
            // 
            this.CbxPlatFuert.Dock = System.Windows.Forms.DockStyle.Left;
            this.CbxPlatFuert.FormattingEnabled = true;
            this.CbxPlatFuert.Location = new System.Drawing.Point(289, 113);
            this.CbxPlatFuert.Name = "CbxPlatFuert";
            this.CbxPlatFuert.Size = new System.Drawing.Size(227, 28);
            this.CbxPlatFuert.TabIndex = 1;
            // 
            // CbxBebida
            // 
            this.CbxBebida.Dock = System.Windows.Forms.DockStyle.Left;
            this.CbxBebida.FormattingEnabled = true;
            this.CbxBebida.Location = new System.Drawing.Point(289, 168);
            this.CbxBebida.Name = "CbxBebida";
            this.CbxBebida.Size = new System.Drawing.Size(227, 28);
            this.CbxBebida.TabIndex = 1;
            // 
            // CbxPostre
            // 
            this.CbxPostre.Dock = System.Windows.Forms.DockStyle.Left;
            this.CbxPostre.FormattingEnabled = true;
            this.CbxPostre.Location = new System.Drawing.Point(289, 223);
            this.CbxPostre.Name = "CbxPostre";
            this.CbxPostre.Size = new System.Drawing.Size(227, 28);
            this.CbxPostre.TabIndex = 1;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtNombre.Location = new System.Drawing.Point(289, 3);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(227, 27);
            this.TxtNombre.TabIndex = 2;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTema.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTema.Location = new System.Drawing.Point(111, 0);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(573, 64);
            this.lblTema.TabIndex = 1;
            this.lblTema.Text = "Generar Orden";
            this.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnCancelarGen, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnAddGet, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(111, 350);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.375F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.625F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(573, 97);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnCancelarGen
            // 
            this.btnCancelarGen.BackColor = System.Drawing.Color.Red;
            this.btnCancelarGen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelarGen.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCancelarGen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarGen.Location = new System.Drawing.Point(3, 3);
            this.btnCancelarGen.Name = "btnCancelarGen";
            this.btnCancelarGen.Size = new System.Drawing.Size(280, 51);
            this.btnCancelarGen.TabIndex = 0;
            this.btnCancelarGen.Text = "Cancelar";
            this.btnCancelarGen.UseMnemonic = false;
            this.btnCancelarGen.UseVisualStyleBackColor = false;
            this.btnCancelarGen.Click += new System.EventHandler(this.btnCancelarGen_Click);
            // 
            // BtnAddGet
            // 
            this.BtnAddGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnAddGet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddGet.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnAddGet.Location = new System.Drawing.Point(289, 3);
            this.BtnAddGet.Name = "BtnAddGet";
            this.BtnAddGet.Size = new System.Drawing.Size(281, 51);
            this.BtnAddGet.TabIndex = 1;
            this.BtnAddGet.Text = "Guardar";
            this.BtnAddGet.UseVisualStyleBackColor = false;
            this.BtnAddGet.Click += new System.EventHandler(this.BtnAddGet_Click);
            // 
            // HacerOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HacerOrdenes";
            this.Text = "HacerOrdenes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HacerOrdenes_FormClosed);
            this.Load += new System.EventHandler(this.HacerOrdenes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblNameClient;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblPlatFuert;
        private System.Windows.Forms.Label lblBebida;
        private System.Windows.Forms.Label lblPostre;
        private System.Windows.Forms.ComboBox CbxEntrada;
        private System.Windows.Forms.ComboBox CbxPlatFuert;
        private System.Windows.Forms.ComboBox CbxBebida;
        private System.Windows.Forms.ComboBox CbxPostre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnCancelarGen;
        private System.Windows.Forms.Button BtnAddGet;
    }
}