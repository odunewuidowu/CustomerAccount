using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Entities
{
    public class TransactionDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 ID
        {
            get;
            set;
        }
        public Int64 TransactionID
        {
            get;
            set;
        }
        public Int64 AccountID
        {
            get;
            set;
        }
        public DateTime DateCreated
        {
            get;
            set;
        }
        public string TransactionType
        {
            get;
            set;
        }       
        public double Amount
        {
            get;
            set;
        }       
    }
}
