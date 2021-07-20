
namespace TareaNum8
{
    partial class Mesa
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
            this.BtnMesaAnadirOrd = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxCantidadPersonas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltemale = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnAddOrden = new System.Windows.Forms.Button();
            this.TableViewOrden = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlatoFuerte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableViewOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.931035F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.47127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.71264F));
            this.tableLayoutPanel1.Controls.Add(this.BtnMesaAnadirOrd, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TableViewOrden, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.375F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.75711F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.01138F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // BtnMesaAnadirOrd
            // 
            this.BtnMesaAnadirOrd.BackColor = System.Drawing.Color.LightPink;
            this.BtnMesaAnadirOrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMesaAnadirOrd.Location = new System.Drawing.Point(685, 3);
            this.BtnMesaAnadirOrd.Name = "BtnMesaAnadirOrd";
            this.BtnMesaAnadirOrd.Size = new System.Drawing.Size(112, 58);
            this.BtnMesaAnadirOrd.TabIndex = 0;
            this.BtnMesaAnadirOrd.Text = "Agregar Nueva Orden";
            this.BtnMesaAnadirOrd.UseVisualStyleBackColor = false;
            this.BtnMesaAnadirOrd.Click += new System.EventHandler(this.BtnMesaAnadirOrd_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.cbxCantidadPersonas, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbltemale, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(66, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(613, 58);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // cbxCantidadPersonas
            // 
            this.cbxCantidadPersonas.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxCantidadPersonas.FormattingEnabled = true;
            this.cbxCantidadPersonas.Location = new System.Drawing.Point(309, 32);
            this.cbxCantidadPersonas.Name = "cbxCantidadPersonas";
            this.cbxCantidadPersonas.Size = new System.Drawing.Size(228, 28);
            this.cbxCantidadPersonas.TabIndex = 0;
            this.cbxCantidadPersonas.SelectedIndexChanged += new System.EventHandler(this.cbxCantidadPersonas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(147, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de personas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltemale
            // 
            this.lbltemale.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.lbltemale, 2);
            this.lbltemale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltemale.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbltemale.Location = new System.Drawing.Point(3, 0);
            this.lbltemale.Name = "lbltemale";
            this.lbltemale.Size = new System.Drawing.Size(607, 29);
            this.lbltemale.TabIndex = 2;
            this.lbltemale.Text = "Manejar";
            this.lbltemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnCancelOrder, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAddOrden, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(66, 353);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(613, 94);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.Red;
            this.btnCancelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelOrder.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCancelOrder.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelOrder.Location = new System.Drawing.Point(3, 3);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(300, 41);
            this.btnCancelOrder.TabIndex = 0;
            this.btnCancelOrder.Text = "Cancelar";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnAddOrden
            // 
            this.btnAddOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddOrden.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAddOrden.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddOrden.Location = new System.Drawing.Point(309, 3);
            this.btnAddOrden.Name = "btnAddOrden";
            this.btnAddOrden.Size = new System.Drawing.Size(301, 41);
            this.btnAddOrden.TabIndex = 1;
            this.btnAddOrden.Text = "Guardar";
            this.btnAddOrden.UseVisualStyleBackColor = false;
            this.btnAddOrden.Click += new System.EventHandler(this.btnAddOrden_Click);
            // 
            // TableViewOrden
            // 
            this.TableViewOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableViewOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Entrada,
            this.PlatoFuerte,
            this.Bebida,
            this.Postre});
            this.TableViewOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableViewOrden.Location = new System.Drawing.Point(66, 67);
            this.TableViewOrden.Name = "TableViewOrden";
            this.TableViewOrden.RowHeadersWidth = 51;
            this.TableViewOrden.RowTemplate.Height = 29;
            this.TableViewOrden.Size = new System.Drawing.Size(613, 280);
            this.TableViewOrden.TabIndex = 4;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Entrada
            // 
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.MinimumWidth = 6;
            this.Entrada.Name = "Entrada";
            this.Entrada.Width = 125;
            // 
            // PlatoFuerte
            // 
            this.PlatoFuerte.HeaderText = "Plato Fuerte";
            this.PlatoFuerte.MinimumWidth = 6;
            this.PlatoFuerte.Name = "PlatoFuerte";
            this.PlatoFuerte.Width = 125;
            // 
            // Bebida
            // 
            this.Bebida.HeaderText = "Bebida";
            this.Bebida.MinimumWidth = 6;
            this.Bebida.Name = "Bebida";
            this.Bebida.Width = 125;
            // 
            // Postre
            // 
            this.Postre.HeaderText = "Postre";
            this.Postre.MinimumWidth = 6;
            this.Postre.Name = "Postre";
            this.Postre.Width = 125;
            // 
            // Mesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Mesa";
            this.Text = "Mesa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mesa_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mesa_FormClosed);
            this.Load += new System.EventHandler(this.Mesa_Load);
            this.VisibleChanged += new System.EventHandler(this.Mesa_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableViewOrden)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnMesaAnadirOrd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cbxCantidadPersonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltemale;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnAddOrden;
        private System.Windows.Forms.DataGridView TableViewOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlatoFuerte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postre;
    }
}