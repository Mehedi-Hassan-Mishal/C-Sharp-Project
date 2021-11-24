using System;
using System.Collections.Generic;
using DigitalVotingSystem.View;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalVotingSystem
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
            Application.Run(new SignIn());
            //Application.Run(new administrationHome());
            //  Application.Run(new Vote());

           // Application.Run(new CandidatesList());
        }
    }
}
