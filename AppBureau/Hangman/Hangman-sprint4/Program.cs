using System;
using System.Windows.Forms;

namespace Hangman_sprint1
{
    /// <summary>
    /// Classe Program
    /// Point d'entrée principal de l'application.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Méthode permettant de mettre en route l'application et d'ouvrir FrmHangman
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmHangman());
        }
    }
}
