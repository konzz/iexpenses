namespace WindowsFormsApplication1
{
    partial class List
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.trypList = new System.Windows.Forms.ListBox();
            this.edit = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trypList
            // 
            this.trypList.FormattingEnabled = true;
            this.trypList.ItemHeight = 16;
            this.trypList.Location = new System.Drawing.Point(12, 41);
            this.trypList.Name = "trypList";
            this.trypList.Size = new System.Drawing.Size(267, 196);
            this.trypList.TabIndex = 0;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(308, 41);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 1;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(308, 214);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 2;
            this.create.Text = "New";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 255);
            this.Controls.Add(this.create);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.trypList);
            this.Name = "List";
            this.Text = "List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox trypList;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button create;
    }
}

