using System;
using System.Collections.Generic;

namespace Form_Sae24_Stargate
{
    public static class SessionMission
    {
        public static string PlaneteSelectionnee { get; set; }
        public static string DateDepart { get; set; }
        public static string DateRetour { get; set; }
        public static string MatriculeChef { get; set; }
        public static int Budget { get; set; }
        public static int ObjectifDataBaz { get; set; }
        public static string FeuilleRoute { get; set; }
        public static int NbMembresTotal { get; set; }
        public static List<string> MembresSelectionnes { get; set; } = new List<string>();
        public static List<(int IdEspece, int Objectif)> ObjectifsCaptures { get; set; }
            = new List<(int, int)>();

        public static void Reinitialiser()
        {
            PlaneteSelectionnee = null;
            DateDepart = null;
            DateRetour = null;
            MatriculeChef = null;
            Budget = 0;
            ObjectifDataBaz = 0;
            FeuilleRoute = null;
            NbMembresTotal = 0;
            MembresSelectionnes.Clear();
            ObjectifsCaptures.Clear();
        }
    }
}