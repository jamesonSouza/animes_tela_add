namespace AnimesBackEnd
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTempId = new System.Windows.Forms.TextBox();
            this.cmbTemporada = new System.Windows.Forms.ComboBox();
            this.temporadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtUrlEpisodios = new System.Windows.Forms.TextBox();
            this.txtIdEpisodio = new System.Windows.Forms.TextBox();
            this.episodioComIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeleta = new System.Windows.Forms.Button();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnObter = new System.Windows.Forms.Button();
            this.txtNumEpisodio = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtUrlVideo = new System.Windows.Forms.TextBox();
            this.txtUrlImage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.episodioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvEpisodio = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlImageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlVideoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numEpsodioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.episodioComIDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temporadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.episodioComIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.episodioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpisodio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.episodioComIDBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtTempId);
            this.groupBox1.Controls.Add(this.cmbTemporada);
            this.groupBox1.Controls.Add(this.txtUrlEpisodios);
            this.groupBox1.Controls.Add(this.txtIdEpisodio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnDeleta);
            this.groupBox1.Controls.Add(this.btnAtualiza);
            this.groupBox1.Controls.Add(this.btnIncluir);
            this.groupBox1.Controls.Add(this.btnObter);
            this.groupBox1.Controls.Add(this.txtNumEpisodio);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.txtUrlVideo);
            this.groupBox1.Controls.Add(this.txtUrlImage);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtTempId
            // 
            this.txtTempId.Enabled = false;
            this.txtTempId.Location = new System.Drawing.Point(319, 20);
            this.txtTempId.Name = "txtTempId";
            this.txtTempId.Size = new System.Drawing.Size(83, 20);
            this.txtTempId.TabIndex = 19;
            // 
            // cmbTemporada
            // 
            this.cmbTemporada.DataSource = this.temporadaBindingSource;
            this.cmbTemporada.FormattingEnabled = true;
            this.cmbTemporada.Location = new System.Drawing.Point(99, 20);
            this.cmbTemporada.Name = "cmbTemporada";
            this.cmbTemporada.Size = new System.Drawing.Size(213, 21);
            this.cmbTemporada.TabIndex = 18;
            this.cmbTemporada.SelectedIndexChanged += new System.EventHandler(this.cmbTemporada_SelectedIndexChanged);
            // 
            // temporadaBindingSource
            // 
            this.temporadaBindingSource.DataSource = typeof(AnimesBackEnd.Temporada);
            // 
            // txtUrlEpisodios
            // 
            this.txtUrlEpisodios.Location = new System.Drawing.Point(182, 62);
            this.txtUrlEpisodios.Name = "txtUrlEpisodios";
            this.txtUrlEpisodios.Size = new System.Drawing.Size(251, 20);
            this.txtUrlEpisodios.TabIndex = 17;
            this.txtUrlEpisodios.Text = "https://animeson.herokuapp.com/animes/episodios";
            // 
            // txtIdEpisodio
            // 
            this.txtIdEpisodio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.episodioComIDBindingSource, "Id", true));
            this.txtIdEpisodio.Location = new System.Drawing.Point(99, 62);
            this.txtIdEpisodio.Name = "txtIdEpisodio";
            this.txtIdEpisodio.Size = new System.Drawing.Size(63, 20);
            this.txtIdEpisodio.TabIndex = 16;
            // 
            // episodioComIDBindingSource
            // 
            this.episodioComIDBindingSource.DataSource = typeof(AnimesBackEnd.EpisodioComID);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Id ep";
            // 
            // btnDeleta
            // 
            this.btnDeleta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleta.Location = new System.Drawing.Point(527, 188);
            this.btnDeleta.Name = "btnDeleta";
            this.btnDeleta.Size = new System.Drawing.Size(146, 39);
            this.btnDeleta.TabIndex = 14;
            this.btnDeleta.Text = "Deletar episodio";
            this.btnDeleta.UseVisualStyleBackColor = true;
            this.btnDeleta.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualiza.Location = new System.Drawing.Point(527, 132);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(146, 39);
            this.btnAtualiza.TabIndex = 13;
            this.btnAtualiza.Text = "Atualizar episodio";
            this.btnAtualiza.UseVisualStyleBackColor = true;
            this.btnAtualiza.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncluir.Location = new System.Drawing.Point(527, 87);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(146, 39);
            this.btnIncluir.TabIndex = 12;
            this.btnIncluir.Text = "Incluir Episodio";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnObter
            // 
            this.btnObter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObter.Location = new System.Drawing.Point(527, 28);
            this.btnObter.Name = "btnObter";
            this.btnObter.Size = new System.Drawing.Size(146, 39);
            this.btnObter.TabIndex = 11;
            this.btnObter.Text = "Obter episodio Id";
            this.btnObter.UseVisualStyleBackColor = true;
            this.btnObter.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumEpisodio
            // 
            this.txtNumEpisodio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.episodioComIDBindingSource, "NumEpsodio", true));
            this.txtNumEpisodio.Location = new System.Drawing.Point(99, 185);
            this.txtNumEpisodio.Name = "txtNumEpisodio";
            this.txtNumEpisodio.Size = new System.Drawing.Size(63, 20);
            this.txtNumEpisodio.TabIndex = 6;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.episodioComIDBindingSource, "Descricao", true));
            this.txtDescricao.Location = new System.Drawing.Point(99, 149);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(334, 20);
            this.txtDescricao.TabIndex = 5;
            // 
            // txtUrlVideo
            // 
            this.txtUrlVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrlVideo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.episodioComIDBindingSource, "UrlVideo", true));
            this.txtUrlVideo.Location = new System.Drawing.Point(99, 123);
            this.txtUrlVideo.Name = "txtUrlVideo";
            this.txtUrlVideo.Size = new System.Drawing.Size(334, 20);
            this.txtUrlVideo.TabIndex = 4;
            // 
            // txtUrlImage
            // 
            this.txtUrlImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrlImage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.episodioComIDBindingSource, "UrlImage", true));
            this.txtUrlImage.Location = new System.Drawing.Point(99, 97);
            this.txtUrlImage.Name = "txtUrlImage";
            this.txtUrlImage.Size = new System.Drawing.Size(334, 20);
            this.txtUrlImage.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "UrlVideo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Episodio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UrlImage";
            // 
            // episodioBindingSource1
            // 
            this.episodioBindingSource1.DataSource = typeof(AnimesBackEnd.Episodio);
            // 
            // dgvEpisodio
            // 
            this.dgvEpisodio.AllowUserToDeleteRows = false;
            this.dgvEpisodio.AllowUserToOrderColumns = true;
            this.dgvEpisodio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEpisodio.AutoGenerateColumns = false;
            this.dgvEpisodio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEpisodio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.urlImageDataGridViewTextBoxColumn,
            this.urlVideoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.numEpsodioDataGridViewTextBoxColumn});
            this.dgvEpisodio.DataSource = this.episodioComIDBindingSource;
            this.dgvEpisodio.Location = new System.Drawing.Point(4, 253);
            this.dgvEpisodio.Name = "dgvEpisodio";
            this.dgvEpisodio.ReadOnly = true;
            this.dgvEpisodio.Size = new System.Drawing.Size(695, 186);
            this.dgvEpisodio.TabIndex = 1;
            this.dgvEpisodio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEpisodio_CellContentClick);
            this.dgvEpisodio.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgvEpisodio_SortCompare);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // urlImageDataGridViewTextBoxColumn
            // 
            this.urlImageDataGridViewTextBoxColumn.DataPropertyName = "UrlImage";
            this.urlImageDataGridViewTextBoxColumn.HeaderText = "UrlImage";
            this.urlImageDataGridViewTextBoxColumn.Name = "urlImageDataGridViewTextBoxColumn";
            this.urlImageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urlVideoDataGridViewTextBoxColumn
            // 
            this.urlVideoDataGridViewTextBoxColumn.DataPropertyName = "UrlVideo";
            this.urlVideoDataGridViewTextBoxColumn.HeaderText = "UrlVideo";
            this.urlVideoDataGridViewTextBoxColumn.Name = "urlVideoDataGridViewTextBoxColumn";
            this.urlVideoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numEpsodioDataGridViewTextBoxColumn
            // 
            this.numEpsodioDataGridViewTextBoxColumn.DataPropertyName = "NumEpsodio";
            this.numEpsodioDataGridViewTextBoxColumn.HeaderText = "NumEpsodio";
            this.numEpsodioDataGridViewTextBoxColumn.Name = "numEpsodioDataGridViewTextBoxColumn";
            this.numEpsodioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // episodioComIDBindingSource1
            // 
            this.episodioComIDBindingSource1.DataSource = typeof(AnimesBackEnd.EpisodioComID);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 442);
            this.Controls.Add(this.dgvEpisodio);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Episodios formulario";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temporadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.episodioComIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.episodioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpisodio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.episodioComIDBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumEpisodio;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtUrlVideo;
        private System.Windows.Forms.TextBox txtUrlImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleta;
        private System.Windows.Forms.Button btnAtualiza;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnObter;
        private System.Windows.Forms.DataGridView dgvEpisodio;
        private System.Windows.Forms.TextBox txtIdEpisodio;
        private System.Windows.Forms.Label label7;
       // private System.Windows.Forms.DataGridViewTextBoxColumn urlIVideoDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn numEpisodioDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtUrlEpisodios;
        private System.Windows.Forms.BindingSource episodioBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbTemporada;
        private System.Windows.Forms.BindingSource temporadaBindingSource;
        private System.Windows.Forms.TextBox txtTempId;
        private System.Windows.Forms.BindingSource episodioComIDBindingSource;
        private System.Windows.Forms.BindingSource episodioComIDBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlImageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlVideoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numEpsodioDataGridViewTextBoxColumn;
    }
}