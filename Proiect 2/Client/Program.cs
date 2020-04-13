using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    static class Program
    {
        /// <summary>
        /// Nume si prenume: Rauleac Robert
        /// Laborator: Marti 12-14
        /// Tema laborator: MyPhotos
        /// Data predare proiect: 17.11.2016
        /// Declaratie: Declar pe propria raspundere ca acest proiect nu a fost
        /// copiat din alte surse
        /// Bibliografie, surse de inspiratie:https://www.w3schools.com/sql/default.asp 
        ///
        ///                                      https://stackoverflow.com/ 
        ///
        ///                                      https://docs.microsoft.com/en-us/dotnet/csharp/getting-started/introduction-to-the-csharp-language-and-the-net-framework 
        ///
        ///                                      https://dotnet.microsoft.com/learn/dotnet/in-browser-tutorial/1 
        ///
        ///                                      https://www.guru99.com/c-sharp-access-database.html 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
