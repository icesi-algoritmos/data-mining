﻿namespace Interfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelURL = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.urlText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.codeData = new System.Windows.Forms.TextBox();
            this.filter = new System.Windows.Forms.Label();
            this.comboBoxFilters = new System.Windows.Forms.ComboBox();
            this.filterAdded = new System.Windows.Forms.Label();
            this.dataFilter = new System.Windows.Forms.Label();
            this.filters = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboDatoS = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.beforeButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.prediction = new System.Windows.Forms.Button();
            this.map = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURL.Location = new System.Drawing.Point(9, 26);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(119, 19);
            this.labelURL.TabIndex = 1;
            this.labelURL.Text = "Id base de datos";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(185)))), ((int)(((byte)(143)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(24, 403);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(140, 45);
            this.searchButton.TabIndex = 35;
            this.searchButton.Text = "Buscar Base de Datos";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // urlText
            // 
            this.urlText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(186)))), ((int)(((byte)(190)))));
            this.urlText.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlText.Location = new System.Drawing.Point(141, 23);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(200, 27);
            this.urlText.TabIndex = 36;
            this.urlText.Text = "ysq6-ri4e";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Codigo Unico Datos";
            // 
            // codeData
            // 
            this.codeData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(186)))), ((int)(((byte)(190)))));
            this.codeData.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeData.Location = new System.Drawing.Point(141, 66);
            this.codeData.Name = "codeData";
            this.codeData.Size = new System.Drawing.Size(200, 25);
            this.codeData.TabIndex = 38;
            this.codeData.Text = "oipJOeStVp83pvoG20CMSGiXe";
            // 
            // filter
            // 
            this.filter.AutoSize = true;
            this.filter.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.Location = new System.Drawing.Point(61, 22);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(49, 19);
            this.filter.TabIndex = 39;
            this.filter.Text = "Filtros";
            // 
            // comboBoxFilters
            // 
            this.comboBoxFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(186)))), ((int)(((byte)(190)))));
            this.comboBoxFilters.FormattingEnabled = true;
            this.comboBoxFilters.Location = new System.Drawing.Point(125, 19);
            this.comboBoxFilters.Name = "comboBoxFilters";
            this.comboBoxFilters.Size = new System.Drawing.Size(200, 27);
            this.comboBoxFilters.TabIndex = 40;
            this.comboBoxFilters.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // filterAdded
            // 
            this.filterAdded.AutoSize = true;
            this.filterAdded.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterAdded.Location = new System.Drawing.Point(15, 118);
            this.filterAdded.Name = "filterAdded";
            this.filterAdded.Size = new System.Drawing.Size(123, 19);
            this.filterAdded.TabIndex = 41;
            this.filterAdded.Text = "Filtros Añadidos";
            // 
            // dataFilter
            // 
            this.dataFilter.AutoSize = true;
            this.dataFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataFilter.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFilter.Location = new System.Drawing.Point(6, 62);
            this.dataFilter.Name = "dataFilter";
            this.dataFilter.Size = new System.Drawing.Size(113, 19);
            this.dataFilter.TabIndex = 42;
            this.dataFilter.Text = "Dato Para Filtro";
            // 
            // filters
            // 
            this.filters.AutoSize = true;
            this.filters.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filters.Location = new System.Drawing.Point(151, 118);
            this.filters.Name = "filters";
            this.filters.Size = new System.Drawing.Size(71, 19);
            this.filters.TabIndex = 44;
            this.filters.Text = "Sin filtros";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(185)))), ((int)(((byte)(143)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(229, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Buscar Datos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.searchData);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(20, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(458, 169);
            this.dataGridView.TabIndex = 46;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.urlText);
            this.groupBox1.Controls.Add(this.labelURL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.codeData);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 100);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base de datos ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboDatoS);
            this.groupBox3.Controls.Add(this.addButton);
            this.groupBox3.Controls.Add(this.filters);
            this.groupBox3.Controls.Add(this.dataFilter);
            this.groupBox3.Controls.Add(this.filterAdded);
            this.groupBox3.Controls.Add(this.comboBoxFilters);
            this.groupBox3.Controls.Add(this.filter);
            this.groupBox3.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 240);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // comboDatoS
            // 
            this.comboDatoS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(186)))), ((int)(((byte)(190)))));
            this.comboDatoS.FormattingEnabled = true;
            this.comboDatoS.Location = new System.Drawing.Point(125, 59);
            this.comboDatoS.Name = "comboDatoS";
            this.comboDatoS.Size = new System.Drawing.Size(200, 27);
            this.comboDatoS.TabIndex = 47;
            this.comboDatoS.SelectedIndexChanged += new System.EventHandler(this.comboDatoS_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(185)))), ((int)(((byte)(143)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(331, 44);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(65, 37);
            this.addButton.TabIndex = 46;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.beforeButton);
            this.groupBox4.Controls.Add(this.nextButton);
            this.groupBox4.Controls.Add(this.dataGridView);
            this.groupBox4.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(424, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(484, 235);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Page";
            // 
            // beforeButton
            // 
            this.beforeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(185)))), ((int)(((byte)(143)))));
            this.beforeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.beforeButton.Location = new System.Drawing.Point(371, 199);
            this.beforeButton.Name = "beforeButton";
            this.beforeButton.Size = new System.Drawing.Size(41, 24);
            this.beforeButton.TabIndex = 48;
            this.beforeButton.Text = "<";
            this.beforeButton.UseVisualStyleBackColor = false;
            this.beforeButton.Click += new System.EventHandler(this.beforeButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(185)))), ((int)(((byte)(143)))));
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nextButton.Location = new System.Drawing.Point(421, 199);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(39, 24);
            this.nextButton.TabIndex = 47;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.prediction);
            this.groupBox5.Controls.Add(this.map);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(434, 289);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(442, 262);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Informacion";
            // 
            // prediction
            // 
            this.prediction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(185)))), ((int)(((byte)(143)))));
            this.prediction.Enabled = false;
            this.prediction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prediction.Location = new System.Drawing.Point(123, 160);
            this.prediction.Name = "prediction";
            this.prediction.Size = new System.Drawing.Size(216, 48);
            this.prediction.TabIndex = 2;
            this.prediction.Text = "Predicciones sobre niveles de contaminación";
            this.prediction.UseVisualStyleBackColor = false;
            this.prediction.Click += new System.EventHandler(this.prediction_Click);
            // 
            // map
            // 
            this.map.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(185)))), ((int)(((byte)(143)))));
            this.map.Enabled = false;
            this.map.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.map.Location = new System.Drawing.Point(120, 80);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(235, 57);
            this.map.TabIndex = 1;
            this.map.Text = "Mapa de niveles de contaminación";
            this.map.UseVisualStyleBackColor = false;
            this.map.Click += new System.EventHandler(this.map_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "A continuación, seleccione la opción que desee visualizar:";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(185)))), ((int)(((byte)(143)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(229, 447);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(109, 23);
            this.deleteButton.TabIndex = 51;
            this.deleteButton.Text = "Eliminar filtros";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(920, 575);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Buscador";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeData;
        private System.Windows.Forms.Label filter;
        private System.Windows.Forms.ComboBox comboBoxFilters;
        private System.Windows.Forms.Label filterAdded;
        private System.Windows.Forms.Label dataFilter;
        private System.Windows.Forms.Label filters;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button prediction;
        private System.Windows.Forms.Button map;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDatoS;
        private System.Windows.Forms.Button beforeButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label3;
    }
}

