
namespace ListaConvidados
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.convidadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.convidadosDataSet = new ListaConvidados.convidadosDataSet();
            this.convidadoTableAdapter = new ListaConvidados.convidadosDataSetTableAdapters.convidadoTableAdapter();
            this.dgConvidado = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcompanhante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAcompanhantes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.convidadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convidadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConvidado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 41);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(195, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(76, 65);
            this.mtxtTelefone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxtTelefone.Mask = "(00)00000-0000";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(85, 20);
            this.mtxtTelefone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(402, 39);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(129, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(663, 39);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(120, 37);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar Convidado";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(663, 90);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 37);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // convidadoBindingSource
            // 
            this.convidadoBindingSource.DataMember = "convidado";
            this.convidadoBindingSource.DataSource = this.convidadosDataSet;
            // 
            // convidadosDataSet
            // 
            this.convidadosDataSet.DataSetName = "convidadosDataSet";
            this.convidadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // convidadoTableAdapter
            // 
            this.convidadoTableAdapter.ClearBeforeFill = true;
            // 
            // dgConvidado
            // 
            this.dgConvidado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConvidado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colEmail,
            this.colTelefone,
            this.colAcompanhante});
            this.dgConvidado.Location = new System.Drawing.Point(31, 159);
            this.dgConvidado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgConvidado.Name = "dgConvidado";
            this.dgConvidado.RowHeadersWidth = 62;
            this.dgConvidado.RowTemplate.Height = 28;
            this.dgConvidado.Size = new System.Drawing.Size(813, 200);
            this.dgConvidado.TabIndex = 13;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 8;
            this.colID.Name = "colID";
            this.colID.Width = 150;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.MinimumWidth = 8;
            this.colNome.Name = "colNome";
            this.colNome.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "E-mail";
            this.colEmail.MinimumWidth = 8;
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 150;
            // 
            // colTelefone
            // 
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.MinimumWidth = 8;
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.Width = 150;
            // 
            // colAcompanhante
            // 
            this.colAcompanhante.HeaderText = "Acompanhantes";
            this.colAcompanhante.MinimumWidth = 8;
            this.colAcompanhante.Name = "colAcompanhante";
            this.colAcompanhante.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Acompanhantes";
            // 
            // cbAcompanhantes
            // 
            this.cbAcompanhantes.FormattingEnabled = true;
            this.cbAcompanhantes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbAcompanhantes.Location = new System.Drawing.Point(402, 63);
            this.cbAcompanhantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAcompanhantes.Name = "cbAcompanhantes";
            this.cbAcompanhantes.Size = new System.Drawing.Size(41, 21);
            this.cbAcompanhantes.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 392);
            this.Controls.Add(this.cbAcompanhantes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgConvidado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtTelefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Convidados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.convidadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convidadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConvidado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnLimpar;
        private convidadosDataSet convidadosDataSet;
        private System.Windows.Forms.BindingSource convidadoBindingSource;
        private convidadosDataSetTableAdapters.convidadoTableAdapter convidadoTableAdapter;
        private System.Windows.Forms.DataGridView dgConvidado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcompanhante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAcompanhantes;
    }
}

