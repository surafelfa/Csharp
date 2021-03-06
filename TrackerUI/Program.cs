﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TrackerUI.GlobalConfig.InitializeConncetions(DatabaseType.sql);
            //Application.Run(new CreateTournamentForm());
            Application.Run(new TournamentDashBoardForm());
        }
    }
}
