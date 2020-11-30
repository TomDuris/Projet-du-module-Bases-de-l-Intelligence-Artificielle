using System;
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

        public Affichage()
        {
            InitializeComponent();
        }

        //Le bouton A* lance l'agorithme de recherche avant d'afficher les paramètres clés dans le form
        private void button3_Click(object sender, EventArgs e)
        {
            //paramètres
            Node Point_Initial = new Node(Convert.ToDouble(X_init.Text), Convert.ToDouble(Y_init.Text));
            Node Point_final = new Node(Convert.ToDouble(X_final.Text), Convert.ToDouble(Y_final.Text));
            Node.Pf_x = Convert.ToDouble(X_final.Text);
            Node.Pf_y = Convert.ToDouble(Y_final.Text);
            Node.distance_Noeud = Convert.ToDouble(tBDistanceNoeud.Text);
            Node.Zone_voisinage = Convert.ToDouble(tBZoneVoisin.Text);

            listBox1.Items.Add("( " + Convert.ToString(Point_Initial.P_x) + ", " + Convert.ToString(Point_Initial.P_y)+ ")");
            Point_Initial.cas = Convert.ToChar(cbChoixVent.SelectedItem.ToString());
            SearchTree g = new SearchTree();
           
            //Lancement de la recherche
            List<GenericNode> solution = g.RechercheSolutionAEtoile(Point_Initial);
            MessageBox.Show(Convert.ToString(solution.Count));
            Node N1 = Point_Initial;

            for (int i=0; i < solution.Count; i++)
            {
                Node N2 = (Node)solution[i];
                soluce.Add(N2);
                listBox1.Items.Add("( " + N2.P_x + ", " + N2.P_y + ")");
                N1 = N2;
                if (i == solution.Count-1)
                    tpsNavigation.Text = Convert.ToString(solution[i].GetGCost());


            }
            g.GetSearchTree(treeView1);
            tBNfermes.Text = Convert.ToString(g.L_Fermes.Count);
            tBNouverts.Text = Convert.ToString(g.L_Ouverts.Count);

        }
        public int PositionX_Noeud(GenericNode N)
        {
            Node NI = (Node)N;
            int Px = Convert.ToInt32(NI.P_x);
            return  Px;
        }
        public int PositionY_Noeud(GenericNode N)
        {
            Node NI = (Node)N;
            int Py = Convert.ToInt32(NI.P_y);
            return Py;
        }

        
        private void Simulations(object sender, EventArgs e)
        {
            Graphics t = Mer.CreateGraphics();
            Pen redPen = new Pen(Color.Red);
            redPen.Width = 3F;
            Node NI = (Node)soluce.ElementAt(0);
            Point pos_depart = new Point(Convert.ToInt32(NI.P_x), (300- Convert.ToInt32(NI.P_y)+1));
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
            Mer.Invalidate();
            listBox1.Items.Clear();
            listBoxgraphe.Items.Clear();
            soluce.Clear();
        }
    }
}
