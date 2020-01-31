namespace visualCADO.NET
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.Label();
            this.addBttn = new System.Windows.Forms.Button();
            this.deleteBttn = new System.Windows.Forms.Button();
            this.modifyBttn = new System.Windows.Forms.Button();
            this.goToEstancias = new System.Windows.Forms.Button();
            this.goToEstudiantes = new System.Windows.Forms.Button();
            this.goToResidencias = new System.Windows.Forms.Button();
            this.goToUniversidades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(106, 51);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(641, 300);
            this.dataGrid.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.name.Location = new System.Drawing.Point(326, 24);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(135, 15);
            this.name.TabIndex = 1;
            this.name.Text = "Borja David Gómez Alayón";
            // 
            // addBttn
            // 
            this.addBttn.Location = new System.Drawing.Point(510, 392);
            this.addBttn.Name = "addBttn";
            this.addBttn.Size = new System.Drawing.Size(75, 23);
            this.addBttn.TabIndex = 2;
            this.addBttn.Text = "Añadir";
            this.addBttn.UseVisualStyleBackColor = true;
            // 
            // deleteBttn
            // 
            this.deleteBttn.Location = new System.Drawing.Point(672, 392);
            this.deleteBttn.Name = "deleteBttn";
            this.deleteBttn.Size = new System.Drawing.Size(75, 23);
            this.deleteBttn.TabIndex = 3;
            this.deleteBttn.Text = "Eliminar";
            this.deleteBttn.UseVisualStyleBackColor = true;
            this.deleteBttn.Click += new System.EventHandler(this.deleteBttn_Click);
            // 
            // modifyBttn
            // 
            this.modifyBttn.Location = new System.Drawing.Point(591, 392);
            this.modifyBttn.Name = "modifyBttn";
            this.modifyBttn.Size = new System.Drawing.Size(75, 23);
            this.modifyBttn.TabIndex = 4;
            this.modifyBttn.Text = "Modificar";
            this.modifyBttn.UseVisualStyleBackColor = true;
            // 
            // goToEstancias
            // 
            this.goToEstancias.Location = new System.Drawing.Point(12, 51);
            this.goToEstancias.Name = "goToEstancias";
            this.goToEstancias.Size = new System.Drawing.Size(75, 23);
            this.goToEstancias.TabIndex = 5;
            this.goToEstancias.Text = "Estancias";
            this.goToEstancias.UseVisualStyleBackColor = true;
            this.goToEstancias.Click += new System.EventHandler(this.goToEstancias_Click);
            // 
            // goToEstudiantes
            // 
            this.goToEstudiantes.Location = new System.Drawing.Point(12, 80);
            this.goToEstudiantes.Name = "goToEstudiantes";
            this.goToEstudiantes.Size = new System.Drawing.Size(75, 23);
            this.goToEstudiantes.TabIndex = 6;
            this.goToEstudiantes.Text = "Estudiantes";
            this.goToEstudiantes.UseVisualStyleBackColor = true;
            this.goToEstudiantes.Click += new System.EventHandler(this.goToEstudiantes_Click);
            // 
            // goToResidencias
            // 
            this.goToResidencias.Location = new System.Drawing.Point(12, 109);
            this.goToResidencias.Name = "goToResidencias";
            this.goToResidencias.Size = new System.Drawing.Size(75, 23);
            this.goToResidencias.TabIndex = 7;
            this.goToResidencias.Text = "Residencias";
            this.goToResidencias.UseVisualStyleBackColor = true;
            this.goToResidencias.Click += new System.EventHandler(this.goToResidencias_Click);
            // 
            // goToUniversidades
            // 
            this.goToUniversidades.Location = new System.Drawing.Point(12, 138);
            this.goToUniversidades.Name = "goToUniversidades";
            this.goToUniversidades.Size = new System.Drawing.Size(75, 23);
            this.goToUniversidades.TabIndex = 8;
            this.goToUniversidades.Text = "Universidades";
            this.goToUniversidades.UseVisualStyleBackColor = true;
            this.goToUniversidades.Click += new System.EventHandler(this.goToUniversidades_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goToUniversidades);
            this.Controls.Add(this.goToResidencias);
            this.Controls.Add(this.goToEstudiantes);
            this.Controls.Add(this.goToEstancias);
            this.Controls.Add(this.modifyBttn);
            this.Controls.Add(this.deleteBttn);
            this.Controls.Add(this.addBttn);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button addBttn;
        private System.Windows.Forms.Button deleteBttn;
        private System.Windows.Forms.Button modifyBttn;
        private System.Windows.Forms.Button goToEstancias;
        private System.Windows.Forms.Button goToEstudiantes;
        private System.Windows.Forms.Button goToResidencias;
        private System.Windows.Forms.Button goToUniversidades;
    }
}

