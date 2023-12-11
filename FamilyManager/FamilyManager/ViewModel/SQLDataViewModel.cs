using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using FamilyManager.Utilities.Command;
using FamilyManager.Model;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using FamilyManager.Applications.RevitCommand;
using System.Windows.Forms;

namespace FamilyManager.ViewModel
{
    public class SQLDataViewModel : INotifyPropertyChanged
    {
        Document document = SQLData.document;

        SQLDatabaseConnect sqlConnection = new SQLDatabaseConnect();

        #region Constructor 

        public SQLDataViewModel()
        {
            // implement the logic of code here.

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChange([CallerMemberName] string propertyName = null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region public properties 

        public MyCommand CreateSQLTableCommand { get; set; }
        public MyCommand ExportDataCommand { get; set; }
        public MyCommand ImportDataCommand { get; set; }

        #endregion

        #region public methods 

        public void CreateSQLTableCommandExcute(object parameter)
        {
            // implement the logic of code here.

        }


        public void ExportDataCommandExcute(object parameter)
        {
            // implement the logic of code here.
        }


        public void ImportDataCommandExcute(object parameter)
        {

            // implement the logic of code here.
        }


        public bool CreateSQLTableCommandCanExcute(object parameter)
        {
            return true;
        }

        public bool ExportDataCommandCanExcute(object parameter)
        {
            return true;
        }

        public bool ImportDataCommandCanExcute(object parameter)
        {
            return true;
        }
        #endregion


        #region Private Methods

        private bool TableExists (string database, string name)
        {
            // implement the logic of code here.
            
            return true;

        }

        #endregion

    }
}
