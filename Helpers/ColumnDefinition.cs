using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System.Helpers
{
    public class ColumnDefinition
    {
        public string HeaderText { get; set; }
        public string DataPropertyName { get; set; }
        public int Width { get; set; } = 100;
    }
}
