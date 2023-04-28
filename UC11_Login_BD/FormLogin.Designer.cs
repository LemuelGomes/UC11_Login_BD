namespace UC11_Login_BD
{
    partial class FormLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.textBoxSENHA = new System.Windows.Forms.TextBox();
            this.textBoxUSUARIO = new System.Windows.Forms.TextBox();
            this.labelUSUARIO = new System.Windows.Forms.Label();
            this.labelSENHA = new System.Windows.Forms.Label();
            this.buttonENTRAR = new System.Windows.Forms.Button();
            this.buttonLIMPAR = new System.Windows.Forms.Button();
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.buttonFECHAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelERRO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSENHA
            // 
            this.textBoxSENHA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSENHA.Location = new System.Drawing.Point(109, 200);
            this.textBoxSENHA.Name = "textBoxSENHA";
            this.textBoxSENHA.PasswordChar = '●';
            this.textBoxSENHA.Size = new System.Drawing.Size(202, 21);
            this.textBoxSENHA.TabIndex = 0;
            // 
            // textBoxUSUARIO
            // 
            this.textBoxUSUARIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUSUARIO.Location = new System.Drawing.Point(109, 126);
            this.textBoxUSUARIO.Name = "textBoxUSUARIO";
            this.textBoxUSUARIO.Size = new System.Drawing.Size(202, 21);
            this.textBoxUSUARIO.TabIndex = 1;
            // 
            // labelUSUARIO
            // 
            this.labelUSUARIO.AutoSize = true;
            this.labelUSUARIO.BackColor = System.Drawing.Color.Transparent;
            this.labelUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUSUARIO.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelUSUARIO.Location = new System.Drawing.Point(180, 103);
            this.labelUSUARIO.Name = "labelUSUARIO";
            this.labelUSUARIO.Size = new System.Drawing.Size(71, 20);
            this.labelUSUARIO.TabIndex = 2;
            this.labelUSUARIO.Text = "Usuário";
            // 
            // labelSENHA
            // 
            this.labelSENHA.AutoSize = true;
            this.labelSENHA.BackColor = System.Drawing.Color.Transparent;
            this.labelSENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSENHA.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelSENHA.Location = new System.Drawing.Point(180, 177);
            this.labelSENHA.Name = "labelSENHA";
            this.labelSENHA.Size = new System.Drawing.Size(61, 20);
            this.labelSENHA.TabIndex = 3;
            this.labelSENHA.Text = "Senha";
            // 
            // buttonENTRAR
            // 
            this.buttonENTRAR.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonENTRAR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonENTRAR.FlatAppearance.BorderSize = 0;
            this.buttonENTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonENTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonENTRAR.ForeColor = System.Drawing.Color.White;
            this.buttonENTRAR.Image = global::UC11_Login_BD.Properties.Resources.btn_entrar;
            this.buttonENTRAR.Location = new System.Drawing.Point(109, 269);
            this.buttonENTRAR.Name = "buttonENTRAR";
            this.buttonENTRAR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonENTRAR.Size = new System.Drawing.Size(90, 30);
            this.buttonENTRAR.TabIndex = 4;
            this.buttonENTRAR.Text = "Entrar";
            this.buttonENTRAR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonENTRAR.UseVisualStyleBackColor = false;
            this.buttonENTRAR.Click += new System.EventHandler(this.buttonENTRAR_Click);
            // 
            // buttonLIMPAR
            // 
            this.buttonLIMPAR.BackColor = System.Drawing.Color.DimGray;
            this.buttonLIMPAR.FlatAppearance.BorderSize = 0;
            this.buttonLIMPAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLIMPAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLIMPAR.ForeColor = System.Drawing.Color.White;
            this.buttonLIMPAR.Image = global::UC11_Login_BD.Properties.Resources.limpar_limpo;
            this.buttonLIMPAR.Location = new System.Drawing.Point(233, 269);
            this.buttonLIMPAR.Name = "buttonLIMPAR";
            this.buttonLIMPAR.Size = new System.Drawing.Size(95, 30);
            this.buttonLIMPAR.TabIndex = 5;
            this.buttonLIMPAR.Text = "Limpar";
            this.buttonLIMPAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLIMPAR.UseVisualStyleBackColor = false;
            this.buttonLIMPAR.Click += new System.EventHandler(this.buttonLIMPAR_Click);
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.BackColor = System.Drawing.Color.Transparent;
            this.buttonCADASTRAR.FlatAppearance.BorderSize = 0;
            this.buttonCADASTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCADASTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCADASTRAR.ForeColor = System.Drawing.Color.Red;
            this.buttonCADASTRAR.Image = global::UC11_Login_BD.Properties.Resources.conecte_se;
            this.buttonCADASTRAR.Location = new System.Drawing.Point(150, 335);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(115, 39);
            this.buttonCADASTRAR.TabIndex = 6;
            this.buttonCADASTRAR.Text = "Cadastrar";
            this.buttonCADASTRAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCADASTRAR.UseVisualStyleBackColor = false;
            this.buttonCADASTRAR.Click += new System.EventHandler(this.buttonCADASTRAR_Click);
            // 
            // buttonFECHAR
            // 
            this.buttonFECHAR.BackColor = System.Drawing.Color.Transparent;
            this.buttonFECHAR.FlatAppearance.BorderSize = 0;
            this.buttonFECHAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFECHAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFECHAR.ForeColor = System.Drawing.Color.Red;
            this.buttonFECHAR.Location = new System.Drawing.Point(344, 378);
            this.buttonFECHAR.Name = "buttonFECHAR";
            this.buttonFECHAR.Size = new System.Drawing.Size(60, 24);
            this.buttonFECHAR.TabIndex = 7;
            this.buttonFECHAR.Text = "Sair";
            this.buttonFECHAR.UseVisualStyleBackColor = false;
            this.buttonFECHAR.Click += new System.EventHandler(this.buttonFECHAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Faça seu Login em nosso Aplicativo!";
            // 
            // labelERRO
            // 
            this.labelERRO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelERRO.BackColor = System.Drawing.Color.Transparent;
            this.labelERRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelERRO.ForeColor = System.Drawing.Color.Crimson;
            this.labelERRO.Location = new System.Drawing.Point(109, 226);
            this.labelERRO.Name = "labelERRO";
            this.labelERRO.Size = new System.Drawing.Size(202, 23);
            this.labelERRO.TabIndex = 9;
            this.labelERRO.Text = "Usuário e/ou Senha Incorretos!";
            this.labelERRO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BackgroundImage = global::UC11_Login_BD.Properties.Resources.Imagem_papeldeparede_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(416, 414);
            this.Controls.Add(this.labelERRO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFECHAR);
            this.Controls.Add(this.buttonCADASTRAR);
            this.Controls.Add(this.buttonLIMPAR);
            this.Controls.Add(this.buttonENTRAR);
            this.Controls.Add(this.labelSENHA);
            this.Controls.Add(this.labelUSUARIO);
            this.Controls.Add(this.textBoxUSUARIO);
            this.Controls.Add(this.textBoxSENHA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Tela de Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSENHA;
        private System.Windows.Forms.TextBox textBoxUSUARIO;
        private System.Windows.Forms.Label labelUSUARIO;
        private System.Windows.Forms.Label labelSENHA;
        private System.Windows.Forms.Button buttonENTRAR;
        private System.Windows.Forms.Button buttonLIMPAR;
        private System.Windows.Forms.Button buttonCADASTRAR;
        private System.Windows.Forms.Button buttonFECHAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelERRO;
    }
}

