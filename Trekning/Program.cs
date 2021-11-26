using System;
using System.Windows.Forms;

namespace Trekning
{
    static class Program
    {
        static public TrekningData trekningDataSet = new TrekningData();
        static public Resultat resultat = new Resultat();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //Application.Run(new FormPerson());
      }
   }
}
