namespace Tarea1.Tarea3
{
    partial class Estructura
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NombreProductLabel = new System.Windows.Forms.Label();
            this.ProductoSelectLabel = new System.Windows.Forms.Label();
            this.NombreProductoTextBox = new System.Windows.Forms.TextBox();
            this.ProductSeleccionTextBox = new System.Windows.Forms.TextBox();
            this.SelecionLabel = new System.Windows.Forms.Label();
            this.ProductoComboBox = new System.Windows.Forms.ComboBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductoComboBox);
            this.groupBox1.Controls.Add(this.SelecionLabel);
            this.groupBox1.Controls.Add(this.ProductSeleccionTextBox);
            this.groupBox1.Controls.Add(this.NombreProductoTextBox);
            this.groupBox1.Controls.Add(this.ProductoSelectLabel);
            this.groupBox1.Controls.Add(this.NombreProductLabel);
            this.groupBox1.Location = new System.Drawing.Point(33, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // NombreProductLabel
            // 
            this.NombreProductLabel.AutoSize = true;
            this.NombreProductLabel.Location = new System.Drawing.Point(6, 34);
            this.NombreProductLabel.Name = "NombreProductLabel";
            this.NombreProductLabel.Size = new System.Drawing.Size(90, 13);
            this.NombreProductLabel.TabIndex = 0;
            this.NombreProductLabel.Text = "Nombre Producto";
            // 
            // ProductoSelectLabel
            // 
            this.ProductoSelectLabel.AutoSize = true;
            this.ProductoSelectLabel.Location = new System.Drawing.Point(243, 64);
            this.ProductoSelectLabel.Name = "ProductoSelectLabel";
            this.ProductoSelectLabel.Size = new System.Drawing.Size(118, 13);
            this.ProductoSelectLabel.TabIndex = 1;
            this.ProductoSelectLabel.Text = "Producto Seleccionado";
            // 
            // NombreProductoTextBox
            // 
            this.NombreProductoTextBox.Location = new System.Drawing.Point(9, 50);
            this.NombreProductoTextBox.Name = "NombreProductoTextBox";
            this.NombreProductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.NombreProductoTextBox.TabIndex = 2;
            // 
            // ProductSeleccionTextBox
            // 
            this.ProductSeleccionTextBox.Location = new System.Drawing.Point(246, 80);
            this.ProductSeleccionTextBox.Name = "ProductSeleccionTextBox";
            this.ProductSeleccionTextBox.Size = new System.Drawing.Size(115, 20);
            this.ProductSeleccionTextBox.TabIndex = 3;
            // 
            // SelecionLabel
            // 
            this.SelecionLabel.AutoSize = true;
            this.SelecionLabel.Location = new System.Drawing.Point(6, 87);
            this.SelecionLabel.Name = "SelecionLabel";
            this.SelecionLabel.Size = new System.Drawing.Size(160, 13);
            this.SelecionLabel.TabIndex = 4;
            this.SelecionLabel.Text = "Seleccione el producto deseado";
            // 
            // ProductoComboBox
            // 
            this.ProductoComboBox.FormattingEnabled = true;
            this.ProductoComboBox.Location = new System.Drawing.Point(9, 115);
            this.ProductoComboBox.Name = "ProductoComboBox";
            this.ProductoComboBox.Size = new System.Drawing.Size(100, 21);
            this.ProductoComboBox.TabIndex = 5;
            this.ProductoComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductoComboBox_SelectedIndexChanged);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(67, 296);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 36);
            this.EliminarButton.TabIndex = 1;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(192, 288);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(92, 43);
            this.GuardarButton.TabIndex = 2;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(329, 296);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(77, 35);
            this.SalirButton.TabIndex = 3;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // Estructura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 385);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Estructura";
            this.Text = "Estructura";
            this.Load += new System.EventHandler(this.Estructura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SelecionLabel;
        private System.Windows.Forms.TextBox ProductSeleccionTextBox;
        private System.Windows.Forms.TextBox NombreProductoTextBox;
        private System.Windows.Forms.Label ProductoSelectLabel;
        private System.Windows.Forms.Label NombreProductLabel;
        private System.Windows.Forms.ComboBox ProductoComboBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button SalirButton;
    }
}