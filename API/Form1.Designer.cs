
namespace API
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
            btnBuscar = new Button();
            listView1 = new ListView();
            id = new ColumnHeader();
            NomeMun = new ColumnHeader();
            UF = new ColumnHeader();
            Regiao = new ColumnHeader();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.System;
            btnBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(345, 340);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(77, 27);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { id, NomeMun, UF, Regiao });
            listView1.Location = new Point(38, 31);
            listView1.Name = "listView1";
            listView1.Size = new Size(729, 285);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // id
            // 
            id.Text = "ID Mun";
            // 
            // NomeMun
            // 
            NomeMun.Text = "Municipio";
            NomeMun.Width = 200;
            // 
            // UF
            // 
            UF.Text = "Estado";
            // 
            // Regiao
            // 
            Regiao.Text = "Regiao";
            Regiao.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(btnBuscar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Municipius do IBGE";
            ResumeLayout(false);
        }



        #endregion

        private Button btnBuscar;
        private ListView listView1;
        private ColumnHeader id;
        private ColumnHeader NomeMun;
        private ColumnHeader UF;
        private ColumnHeader Regiao;
    }
}
