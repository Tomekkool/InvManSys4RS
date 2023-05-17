using InvManSys4RS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvManSys4RS
{
    class Crud
    {
        public string Read(string table)
        {
            string mes = "";
            string readLine = "";
            List<string> listRead = new List<string>();

            using (var context = new LibraryDb1Context())
            {
                var borrowers = context.Borrowers.ToList();
                foreach (var borrower in borrowers)
                {
                    readLine=$"BorrowerID: {borrower.BorrowerId}| Name: {borrower.Name}| Email: {borrower.Email}| TotalBorrowedBooks: {borrower.TotalBorrowedBooks}";
                    listRead.Add(readLine);
                }

                StringBuilder sb = new StringBuilder();
                foreach (string item in listRead)
                {
                    sb.AppendLine(item);
                }

                mes = sb.ToString();

              
            }

            //string TestMessage = $"You pressed the read button with {table} chosen maaan";          
            return mes;
        }
    }
}
