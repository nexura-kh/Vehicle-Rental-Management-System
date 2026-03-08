using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Rental_Management_System.Helpers;

namespace Vehicle_Rental_Management_System.Interfaces {
    public interface IManagementService {
        string Title { get; }
        List<ColumnDefinition> GetColumns();
        DataTable GetData();
        bool CanAdd { get; }
        bool CanEdit { get; }
        bool CanDelete { get; }
        void ShowAddDialog(IWin32Window owner);
        void ShowEditDialog(IWin32Window owner, object selectedId);
        void DeleteRecord(object selectedId);
    }
}   