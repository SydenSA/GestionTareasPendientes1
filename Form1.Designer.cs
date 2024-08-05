namespace GestionTareasPendientes1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregarTarea = new Button();
            btnEliminarTarea = new Button();
            label1 = new Label();
            lstTareas = new ListBox();
            txtTarea = new TextBox();
            SuspendLayout();
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.Location = new Point(325, 53);
            btnAgregarTarea.Name = "btnAgregarTarea";
            btnAgregarTarea.Size = new Size(135, 43);
            btnAgregarTarea.TabIndex = 2;
            btnAgregarTarea.Text = "Agregar tarea";
            btnAgregarTarea.UseVisualStyleBackColor = true;
            btnAgregarTarea.Click += btnAgregarTarea_Click;
            // 
            // btnEliminarTarea
            // 
            btnEliminarTarea.Location = new Point(325, 330);
            btnEliminarTarea.Name = "btnEliminarTarea";
            btnEliminarTarea.Size = new Size(135, 52);
            btnEliminarTarea.TabIndex = 4;
            btnEliminarTarea.Text = "Eliminar tarea";
            btnEliminarTarea.UseVisualStyleBackColor = true;
            btnEliminarTarea.Click += btnEliminarTarea_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 27);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingresar tareas:";
            // 
            // lstTareas
            // 
            lstTareas.FormattingEnabled = true;
            lstTareas.ItemHeight = 15;
            lstTareas.Location = new Point(124, 99);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(499, 214);
            lstTareas.TabIndex = 3;
            lstTareas.SelectedIndexChanged += lstTareas_SelectedIndexChanged;
            // 
            // txtTarea
            // 
            txtTarea.Location = new Point(231, 24);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(355, 23);
            txtTarea.TabIndex = 1;
            txtTarea.TextChanged += txtTarea_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTarea);
            Controls.Add(lstTareas);
            Controls.Add(label1);
            Controls.Add(btnEliminarTarea);
            Controls.Add(btnAgregarTarea);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarTarea;
        private Button btnEliminarTarea;
        private Label label1;
        private ListBox lstTareas;
        private TextBox txtTarea;
    }
}
