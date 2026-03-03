using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Rental_Management_System.Helpers;

namespace Vehicle_Rental_Management_System.Interfaces
{
    public interface IManagementService
    {
        string Title { get; }

        List<ColumnDefinition> GetColumns();

        DataTable GetData();

        void ShowAddDialog(IWin32Window owner);

        void DeleteRecord(object selectedId);
    }
}
