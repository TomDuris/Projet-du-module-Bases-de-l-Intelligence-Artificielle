﻿namespace Pluscourtchemin
{
    partial class Affichage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Affichage));
            this.X_init = new System.Windows.Forms.TextBox();
            this.X_final = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button3 = new System.Windows.Forms.Button();
            this.Y = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.Y_init = new System.Windows.Forms.TextBox();
            this.Y_final = new System.Windows.Forms.TextBox();
            this.Vent = new System.Windows.Forms.Label();
            this.Mer = new System.Windows.Forms.PictureBox();
            this.cbChoixVent = new System.Windows.Forms.ComboBox();
            this.Simulation = new System.Windows.Forms.Button();
            this.listBoxgraphe = new System.Windows.Forms.ListBox();
            this.tpsNavigation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nettoyage = new System.Windows.Forms.Button();
            this.tBNouverts = new System.Windows.Forms.TextBox();
            this.tBNfermes = new System.Windows.Forms.TextBox();
            this.lNOuverts = new System.Windows.Forms.Label();
            this.lNfermes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lPrecision = new System.Windows.Forms.Label();
            this.tBPrecision = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Mer)).BeginInit();
            this.SuspendLayout();
            // 
            // X_init
            // 
            this.X_init.Location = new System.Drawing.Point(49, 132);
            this.X_init.Name = "X_init";
            this.X_init.Size = new System.Drawing.Size(100, 20);
            this.X_init.TabIndex = 1;
            this.X_init.Text = "100";
            this.X_init.TextChanged += new System.EventHandler(this.X_init_TextChanged);
            // 
            // X_final
            // 
            this.X_final.Location = new System.Drawing.Point(169, 132);
            this.X_final.Name = "X_final";
            this.X_final.Size = new System.Drawing.Size(100, 20);
            this.X_final.TabIndex = 2;
            this.X_final.Text = "200";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Point initial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Point final";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(787, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 355);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(942, 111);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(154, 369);
            this.treeView1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(49, 490);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 51);
            this.button3.TabIndex = 8;
            this.button3.Text = "Lancer la Simulation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(29, 175);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(14, 13);
            this.Y.TabIndex = 10;
            this.Y.Text = "Y";
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(29, 139);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(14, 13);
            this.X.TabIndex = 11;
            this.X.Text = "X";
            // 
            // Y_init
            // 
            this.Y_init.Location = new System.Drawing.Point(49, 168);
            this.Y_init.Name = "Y_init";
            this.Y_init.Size = new System.Drawing.Size(100, 20);
            this.Y_init.TabIndex = 12;
            this.Y_init.Text = "200";
            // 
            // Y_final
            // 
            this.Y_final.Location = new System.Drawing.Point(169, 168);
            this.Y_final.Name = "Y_final";
            this.Y_final.Size = new System.Drawing.Size(100, 20);
            this.Y_final.TabIndex = 13;
            this.Y_final.Text = "100";
            // 
            // Vent
            // 
            this.Vent.AutoSize = true;
            this.Vent.Location = new System.Drawing.Point(61, 227);
            this.Vent.Name = "Vent";
            this.Vent.Size = new System.Drawing.Size(29, 13);
            this.Vent.TabIndex = 15;
            this.Vent.Text = "Vent";
            // 
            // Mer
            // 
            this.Mer.Image = ((System.Drawing.Image)(resources.GetObject("Mer.Image")));
            this.Mer.Location = new System.Drawing.Point(326, 103);
            this.Mer.Name = "Mer";
            this.Mer.Size = new System.Drawing.Size(400, 400);
            this.Mer.TabIndex = 16;
            this.Mer.TabStop = false;
            // 
            // cbChoixVent
            // 
            this.cbChoixVent.FormattingEnabled = true;
            this.cbChoixVent.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.cbChoixVent.Location = new System.Drawing.Point(123, 219);
            this.cbChoixVent.Name = "cbChoixVent";
            this.cbChoixVent.Size = new System.Drawing.Size(120, 21);
            this.cbChoixVent.TabIndex = 17;
            this.cbChoixVent.SelectedIndexChanged += new System.EventHandler(this.cbChoixVent_SelectedIndexChanged);
            // 
            // Simulation
            // 
            this.Simulation.Location = new System.Drawing.Point(83, 547);
            this.Simulation.Name = "Simulation";
            this.Simulation.Size = new System.Drawing.Size(105, 51);
            this.Simulation.TabIndex = 18;
            this.Simulation.Text = "Afficher simulation";
            this.Simulation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Simulation.UseMnemonic = false;
            this.Simulation.UseVisualStyleBackColor = true;
            this.Simulation.Click += new System.EventHandler(this.Simulations);
            // 
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(977, 526);
            this.listBoxgraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgraphe.Name = "listBoxgraphe";
            this.listBoxgraphe.Size = new System.Drawing.Size(100, 121);
            this.listBoxgraphe.TabIndex = 9;
            // 
            // tpsNavigation
            // 
            this.tpsNavigation.Location = new System.Drawing.Point(62, 327);
            this.tpsNavigation.Name = "tpsNavigation";
            this.tpsNavigation.Size = new System.Drawing.Size(141, 20);
            this.tpsNavigation.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Temps de navigation en heure";
            // 
            // Nettoyage
            // 
            this.Nettoyage.Location = new System.Drawing.Point(440, 526);
            this.Nettoyage.Name = "Nettoyage";
            this.Nettoyage.Size = new System.Drawing.Size(111, 30);
            this.Nettoyage.TabIndex = 21;
            this.Nettoyage.Text = "Nettoyer l\'image";
            this.Nettoyage.UseVisualStyleBackColor = true;
            this.Nettoyage.Click += new System.EventHandler(this.Nettoyage_Click);
            // 
            // tBNouverts
            // 
            this.tBNouverts.Location = new System.Drawing.Point(20, 387);
            this.tBNouverts.Name = "tBNouverts";
            this.tBNouverts.Size = new System.Drawing.Size(96, 20);
            this.tBNouverts.TabIndex = 22;
            // 
            // tBNfermes
            // 
            this.tBNfermes.Location = new System.Drawing.Point(143, 387);
            this.tBNfermes.Name = "tBNfermes";
            this.tBNfermes.Size = new System.Drawing.Size(100, 20);
            this.tBNfermes.TabIndex = 23;
            // 
            // lNOuverts
            // 
            this.lNOuverts.AutoSize = true;
            this.lNOuverts.Location = new System.Drawing.Point(30, 371);
            this.lNOuverts.Name = "lNOuverts";
            this.lNOuverts.Size = new System.Drawing.Size(82, 13);
            this.lNOuverts.TabIndex = 24;
            this.lNOuverts.Text = "Noeuds ouverts";
            // 
            // lNfermes
            // 
            this.lNfermes.AutoSize = true;
            this.lNfermes.Location = new System.Drawing.Point(151, 371);
            this.lNfermes.Name = "lNfermes";
            this.lNfermes.Size = new System.Drawing.Size(78, 13);
            this.lNfermes.TabIndex = 25;
            this.lNfermes.Text = "Noeuds fermés";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "PROJET INTELLIGENCE ARTIFICIELLE";
            // 
            // lPrecision
            // 
            this.lPrecision.AutoSize = true;
            this.lPrecision.Location = new System.Drawing.Point(61, 259);
            this.lPrecision.Name = "lPrecision";
            this.lPrecision.Size = new System.Drawing.Size(50, 13);
            this.lPrecision.TabIndex = 27;
            this.lPrecision.Text = "Precision";
            // 
            // tBPrecision
            // 
            this.tBPrecision.Location = new System.Drawing.Point(123, 252);
            this.tBPrecision.Name = "tBPrecision";
            this.tBPrecision.Size = new System.Drawing.Size(120, 20);
            this.tBPrecision.TabIndex = 28;
            // 
            // Affichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 612);
            this.Controls.Add(this.tBPrecision);
            this.Controls.Add(this.lPrecision);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lNfermes);
            this.Controls.Add(this.lNOuverts);
            this.Controls.Add(this.tBNfermes);
            this.Controls.Add(this.tBNouverts);
            this.Controls.Add(this.Nettoyage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tpsNavigation);
            this.Controls.Add(this.Simulation);
            this.Controls.Add(this.cbChoixVent);
            this.Controls.Add(this.Mer);
            this.Controls.Add(this.Vent);
            this.Controls.Add(this.Y_final);
            this.Controls.Add(this.Y_init);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.listBoxgraphe);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.X_final);
            this.Controls.Add(this.X_init);
            this.Name = "Affichage";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Affichage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox X_init;
        private System.Windows.Forms.TextBox X_final;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.TextBox Y_init;
        private System.Windows.Forms.TextBox Y_final;
        private System.Windows.Forms.Label Vent;
        private System.Windows.Forms.PictureBox Mer;
        private System.Windows.Forms.ComboBox cbChoixVent;
        private System.Windows.Forms.Button Simulation;
        private System.Windows.Forms.ListBox listBoxgraphe;
        private System.Windows.Forms.TextBox tpsNavigation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Nettoyage;
        private System.Windows.Forms.TextBox tBNouverts;
        private System.Windows.Forms.TextBox tBNfermes;
        private System.Windows.Forms.Label lNOuverts;
        private System.Windows.Forms.Label lNfermes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lPrecision;
        private System.Windows.Forms.TextBox tBPrecision;
    }
}

