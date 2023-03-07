namespace RPA
{
    partial class Principal
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
            this.btn_mapear = new System.Windows.Forms.Button();
            this.btn_parar = new System.Windows.Forms.Button();
            this.btn_add_texto = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.lv_itens = new System.Windows.Forms.ListView();
            this.Step = new System.Windows.Forms.ColumnHeader();
            this.Tipoe = new System.Windows.Forms.ColumnHeader();
            this.Value = new System.Windows.Forms.ColumnHeader();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mapear
            // 
            this.btn_mapear.Location = new System.Drawing.Point(173, 46);
            this.btn_mapear.Name = "btn_mapear";
            this.btn_mapear.Size = new System.Drawing.Size(106, 43);
            this.btn_mapear.TabIndex = 0;
            this.btn_mapear.Text = "Mapear";
            this.btn_mapear.UseVisualStyleBackColor = true;
            this.btn_mapear.Click += new System.EventHandler(this.btn_mapear_Click);
            // 
            // btn_parar
            // 
            this.btn_parar.Location = new System.Drawing.Point(303, 46);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(106, 43);
            this.btn_parar.TabIndex = 1;
            this.btn_parar.Text = "Parar";
            this.btn_parar.UseVisualStyleBackColor = true;
            this.btn_parar.Visible = false;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // btn_add_texto
            // 
            this.btn_add_texto.Location = new System.Drawing.Point(173, 110);
            this.btn_add_texto.Name = "btn_add_texto";
            this.btn_add_texto.Size = new System.Drawing.Size(236, 32);
            this.btn_add_texto.TabIndex = 2;
            this.btn_add_texto.Text = "Adicionar Texto";
            this.btn_add_texto.UseVisualStyleBackColor = true;
            this.btn_add_texto.Click += new System.EventHandler(this.btn_add_texto_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(173, 163);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(236, 32);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_x.Location = new System.Drawing.Point(26, 46);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(26, 21);
            this.lbl_x.TabIndex = 4;
            this.lbl_x.Text = "X :";
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_y.Location = new System.Drawing.Point(26, 114);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(26, 21);
            this.lbl_y.TabIndex = 5;
            this.lbl_y.Text = "Y :";
            // 
            // lv_itens
            // 
            this.lv_itens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Step,
            this.Tipoe,
            this.Value});
            this.lv_itens.Location = new System.Drawing.Point(12, 243);
            this.lv_itens.Name = "lv_itens";
            this.lv_itens.Size = new System.Drawing.Size(470, 191);
            this.lv_itens.TabIndex = 6;
            this.lv_itens.UseCompatibleStateImageBehavior = false;
            this.lv_itens.View = System.Windows.Forms.View.Details;
            // 
            // Step
            // 
            this.Step.Text = "Etapa";
            this.Step.Width = 100;
            // 
            // Tipoe
            // 
            this.Tipoe.Text = "Tipo";
            // 
            // Value
            // 
            this.Value.Text = "Valor";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(173, 201);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(236, 32);
            this.btn_limpar.TabIndex = 7;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 456);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lv_itens);
            this.Controls.Add(this.lbl_y);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_add_texto);
            this.Controls.Add(this.btn_parar);
            this.Controls.Add(this.btn_mapear);
            this.Name = "Principal";
            this.Text = "RPA - Leozinho Automations";
            this.Deactivate += new System.EventHandler(this.Principal_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_mapear;
        private Button btn_parar;
        private Button btn_add_texto;
        private Button btn_start;
        private Label lbl_x;
        private Label lbl_y;
        private ListView lv_itens;
        private ColumnHeader Step;
        private ColumnHeader Tipoe;
        private ColumnHeader Value;
        private Button btn_limpar;
    }
}