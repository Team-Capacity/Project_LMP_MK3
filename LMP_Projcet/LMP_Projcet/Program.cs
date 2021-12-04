using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryMgrProgram;
using LibraryMgrProgram.NonCustomerForm;
using LMP_Projcet.Customer;
using LMP_Projcet.NonCustomer;
using LMP_Projcet.Start;

namespace LMP_Projcet
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
            Application.Run(new MemberAddForm());
        }
    }
}
