﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluscourtchemin
{
    class Node :GenericNode
    {
        public int P_x { get; set; }
        public int P_y { get; set; }
        public static int Pf_x { get; set; }
        public static int Pf_y { get; set; }
        public char cas = ' '; // à modifier en ‘b’ ou ‘c’ selon le choix de l’utilisateur
        public List<GenericNode> _Listsuccesseur;
        public int dy { get; set; }
        public int dx { get; set; }
        public static int distance_Noeud { get; set; }
        public static int Zone_voisinage { get; set; }
        public int precision;
        public Node( int px, int py)
        {
            P_x = px;
            P_y = py;
        }       
        public override List<GenericNode> GetListSucc()
        {
            distance_Noeud = 2;
            Zone_voisinage = 2;
            List<GenericNode> _Listsuccesseur = new List<GenericNode>();
            int P_X_PointDebut = P_x - distance_Noeud * Zone_voisinage;
            int P_Y_PointDebut = P_y - distance_Noeud * Zone_voisinage;
            int P_X_PointFin = P_x + distance_Noeud * Zone_voisinage;
            int P_Y_PointFin = P_y + distance_Noeud * Zone_voisinage;
            
            for (int  i = P_X_PointDebut; i <= P_X_PointFin; i += distance_Noeud )
            {
                for (int j = P_Y_PointDebut; j <=  P_Y_PointFin; j  += distance_Noeud)
                    if ((i != P_x || j!=P_y) && i >= 0 && j >= 0 && i <= Affichage.nbnodes && j <= Affichage.nbnodes)
                        _Listsuccesseur.Add(new Node(i,j));
        }
            return _Listsuccesseur; 
        }
        public override double CalculeHCost()
        {
            double Hcost = heuristique(P_x, P_y, Pf_x, Pf_y);
            return Hcost;
        }
        public override double GetArcCost(GenericNode N2)
        {
            Node nd = N2 as Node;
            double temps =  time_estimation(P_x, P_y, nd.P_x, nd.P_y);
            return temps;
        }
        public override bool IsEqual(GenericNode N2)
        {
            Node nd = N2 as Node;
            if (nd.P_x == P_x && nd.P_y == P_y)
                return true;
            else
                return false;
        }
        public override bool EndState()
        {
            if (P_x == Pf_x && P_y == Pf_y)
                return true;
            else
                return false;
        }
        public double time_estimation(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            if (distance > 10) return 1000000;
            double windspeed = get_wind_speed((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double winddirection = get_wind_direction((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double boatspeed;
            double boatdirection = Math.Atan2(y2 - y1, x2 - x1) * 180 / Math.PI;
            // On ramène entre 0 et 360
            if (boatdirection < 0) boatdirection = boatdirection + 360;
            // calcul de la différence angulaire
            double alpha = Math.Abs(boatdirection - winddirection);
            // On se ramène à une différence entre 0 et 180 :
            if (alpha > 180) alpha = 360 - alpha;
            if (alpha <= 45)
            {
                /* (0.6 + 0.3α / 45) v_v */
                boatspeed = (0.6 + 0.3 * alpha / 45) * windspeed;
            }
            else if (alpha <= 90)
            {
                /*v_b=(0.9-0.2(α-45)/45) v_v */
                boatspeed = (0.9 - 0.2 * (alpha - 45) / 45) * windspeed;
            }
            else if (alpha < 150)
            {
                /* v_b=0.7(1-(α-90)/60) v_v */
                boatspeed = 0.7 * (1 - (alpha - 90) / 60) * windspeed;
            }
            else
                return 1000000;
            // estimation du temps de navigation entre p1 et p2
            return (distance / boatspeed);
        }
        public double heuristique(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            if (distance > 10) return 1000000;
            double alpha = 45;
            double windspeed = 50;
            double boatspeed = (0.6 + 0.3 * alpha / 45) * windspeed;
            return (distance / boatspeed);
        }

        public double get_wind_speed(double x, double y)
        {
            if (cas == 'a')
                return 50;
            else if (cas == 'b')
                if (y > 150)
                    return 50;
                else return 20;
            else if (y > 150)
                return 50;
            else return 20;
        }
        public double get_wind_direction(double x, double y)
        {
            if (cas == 'a')
                return 30;
            else if (cas == 'b')
                if (y > 150)
                    return 180;
                else return 90;
            else if (y > 150)
                return 170;
            else return 65;
        }
        public override string ToString()
        {
            string description = "( "+ P_x + ",  " + P_y +" )";
            return description;
        }
    }
}
