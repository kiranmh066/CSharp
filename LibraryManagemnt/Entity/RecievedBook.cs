using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementEntity
{
    public class RecievedBook
    {
        public int BookId { get; set; }

        public string BookName { get; set; }

        public DateTime DateRecieved { get; set; }

        public int UserId { get; set; }

        public string UserName { get; set; }

    }
}
