using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.final_project
{
    class Borrower
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }

        public Borrower (string FullName, string Email, string Mobile)
        {
            this.FullName = FullName;
            this.Email = Email;
            this.Mobile = Mobile;
        }
    }
}
