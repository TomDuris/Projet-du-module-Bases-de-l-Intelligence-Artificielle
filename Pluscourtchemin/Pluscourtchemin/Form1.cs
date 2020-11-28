﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Pluscourtchemin
{
    public partial class Affichage : Form
    {
        static public double[,] matrice;
        static public int nbnodes = 400;
        public List<GenericNode> soluce = new List<GenericNode>();
        static public int numinitial;
        static public int numfinal;

        public Affichage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Node Point_Initial = new Node(Convert.ToInt32(X_init.Text), Convert.ToInt32(Y_init.Text));
            Node Point_final = new Node(Convert.ToInt32(X_final.Text), Convert.ToInt32(Y_final.Text));
            Node.Pf_x = Convert.ToInt32(X_final.Text);
            Node.Pf_y = Convert.ToInt32(Y_final.Text);

            //Node.precision = Convert.ToInt32(tBPrecision.Text);
            listBox1.Items.Add("( " + Convert.ToString(Point_Initial.P_x) + ", " + Convert.ToString(Point_Initial.P_y)+ ")");
            Point_Initial.cas = Convert.ToChar(cbChoixVent.SelectedItem.ToString());
            SearchTree g = new SearchTree();
            //Node2 N0 = new Node2();
            //N0.numero = numinitial;
            
            List<GenericNode> solution = g.RechercheSolutionAEtoile(Point_Initial);
            MessageBox.Show(Convert.ToString(solution.Count));
            //Node2 N1 = N0;
            Node N1 = Point_Initial;

            for (int i=1; i < solution.Count; i++)
            {
                Node N2 = (Node)solution[i];
                soluce.Add(N2);
                listBox1.Items.Add("( " + N2.P_x + ", " + N2.P_y + ")");
                N1 = N2;
                if (i == solution.Count - 1)
                    tpsNavigation.Text = Convert.ToString(solution[i].GetGCost());


            }
            g.GetSearchTree(treeView1);
            tBNfermes.Text = Convert.ToString(g.L_Fermes.Count);
            tBNouverts.Text = Convert.ToString(g.L_Ouverts.Count);

        }
        public int PositionX_Noeud(GenericNode N)
        {
            Node NI = (Node)N;
            return NI.P_x;
        }
        public int PositionY_Noeud(GenericNode N)
        {
            Node NI = (Node)N;
            return  NI.P_y;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            StreamReader monStreamReader = new StreamReader("graphe1.txt");

            // Lecture du fichier avec un while, évidemment !
            // 1ère ligne : "nombre de noeuds du graphe
            string ligne = monStreamReader.ReadLine();
            int i = 0;
            while (ligne[i] != ':') i++;
            string strnbnoeuds = "";
            i++; // On dépasse le ":"
            while (ligne[i] == ' ') i++; // on saute les blancs éventuels
            while (i < ligne.Length) { strnbnoeuds = strnbnoeuds + ligne[i];
                i++; 
            }
            nbnodes = Convert.ToInt32(strnbnoeuds);

            matrice = new double[nbnodes, nbnodes];
            for (i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;

            // Ensuite on a ls tructure suivante : 
            //  arc : n°noeud départ    n°noeud arrivée  valeur
            //  exemple 4 : 
            ligne = monStreamReader.ReadLine();
            while (ligne != null)
            {
                i = 0;
                while (ligne[i] != ':') i++;
                i++; // on passe le :
                while (ligne[i] == ' ') i++; // on saute les blancs éventuels
                string strN1 = "";
                while (ligne[i] != ' ')
                {
                    strN1 = strN1 + ligne[i];
                    i++;
                }
                int N1 = Convert.ToInt32(strN1);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strN2 = "";
                while (ligne[i] != ' ')
                {
                    strN2 = strN2 + ligne[i];
                    i++;
                }
                int N2 = Convert.ToInt32(strN2);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strVal = "";
                while ((i < ligne.Length) && (ligne[i] !=' '))
                {
                    strVal = strVal + ligne[i];
                    i++;
                }
                double val = Convert.ToDouble(strVal);

                matrice[N1, N2] = val;
                matrice[N2, N1] = val;
                listBoxgraphe.Items.Add(Convert.ToString(N1)
                   + "--->" + Convert.ToString(N2)
                   + "   : " + Convert.ToString(matrice[N1, N2]));            

                ligne = monStreamReader.ReadLine();
            }
            // Fermeture du StreamReader (obligatoire) 
            monStreamReader.Close();
        }

        private void Affichage_Load(object sender, EventArgs e)
        {

        }

        private void X_init_TextChanged(object sender, EventArgs e)
        {

        }

        private void Simulations(object sender, EventArgs e)
        {
            Pen redPen = new Pen(Color.Red);
            redPen.Width = 3F;
            Graphics t = Mer.CreateGraphics();
            Node NI = (Node)soluce.ElementAt(0);
            Point pos_depart = new Point(NI.P_x, (300-NI.P_y+1));
            foreach (GenericNode N in soluce)
            {
                listBox1.Items.Add(N);
                int a = PositionX_Noeud(N);
                Point pos_arrivee = new Point(PositionX_Noeud(N),(300- PositionY_Noeud(N)+1));
                t.DrawLine(redPen, pos_depart, pos_arrivee);

                pos_depart = pos_arrivee;
            }
        }

        private void Nettoyage_Click(object sender, EventArgs e)
        {
            Graphics t = Mer.CreateGraphics();
            t.Clear(Color.Blue);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbChoixVent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
