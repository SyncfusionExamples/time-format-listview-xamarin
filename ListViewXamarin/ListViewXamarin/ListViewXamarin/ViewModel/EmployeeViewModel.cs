
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewXamarin
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        #region Properties

        public ObservableCollection<Employee> EmployeeInfo { get; set; }
        #endregion

        #region Constructor

        public EmployeeViewModel()
        {
            EmployeeInfo = new ObservableCollection<Employee>();
            PopulateData();
        }

        public void PopulateData()
        {
            Random r = new Random();
            
            for (int i = 0; i < 25; i++)
            {
                var employee = new Employee();
                employee.EmployeeImage = ImageSource.FromResource("ListViewXamarin.Images.Image" + i + ".png");
                employee.EmployeeName = EmployeeNames[i];
                employee.Designation = Designations[r.Next(0, 3)];
                employee.CheckIn = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,r.Next(0,23),r.Next(0,59),r.Next(0,59));
                EmployeeInfo.Add(employee);
            }
        }

        #endregion

        #region Fields
        string[] Designations = new string[] { "Manager", "Scrum Master", "Engineer" };

        string[] EmployeeNames = new string[] {
            "Kyle",
            "Gina",
            "Irene",
            "Katie",
            "Jack",
            "Liz",
            "Zeke",
            "Noah",
            "Pete",
            "Bill",
            "Daniel",
            "Frank",
            "Brenda",
            "Danielle",
            "Fiona",
            "Howard",
            "Jack",
            "Larry",
            "Holly",
            "Jennifer",
            "Liz",
            "Pete",
            "Steve",
            "Vince",
            "Zeke",
            "Aiden",
            "Jackson",
            "Mason",
            "Liam",
            "Jacob",
            "Jayden",
            "Ethan",
            "Noah",
            "Lucas",
            "Logan",
            "Caleb",
            "Caden",
            "Jack",
            "Ryan",
            "Connor",
            "Michael",
            "Elijah",
            "Brayden",
            "Benjamin",
            "Nicholas",
            "Alexander",
            "William",
            "Matthew",
            "James",
            "Landon",
            "Nathan",
            "Dylan",
            "Evan",
            "Luke",
            "Andrew",
            "Gabriel",
            "Gavin",
            "Joshua",
            "Owen",
            "Daniel",
            "Carter",
            "Tyler",
            "Cameron",
            "Christian",
            "Wyatt",
            "Henry",
            "Eli",
            "Joseph",
            "Max",
            "Isaac",
            "Samuel",
            "Anthony",
            "Grayson",
            "Zachary",
            "David",
            "Christopher",
            "John",
            "Isaiah",
            "Levi",
            "Jonathan",
            "Oliver",
            "Chase",
            "Cooper" ,
            "Tristan",
            "Colton",
            "Austin",
            "Colin",
            "Charlie",
            "Dominic",
            "Parker",
            "Hunter",
            "Thomas",
            "Alex",
            "Ian",
            "Jordan",
            "Cole",
            "Julian",
            "Aaron",
            "Carson",
            "Miles",
            "Blake",
            "Brody",
            "Adam",
            "Sebastian",
            "Adrian",
            "Nolan",
            "Sean",
            "Riley",
            "Bentley",
            "Xavier",
            "Hayden",
            "Jeremiah",
            "Jason",
            "Jake",
            "Asher",
            "Micah",
            "Jace",
            "Brandon",
            "Josiah",
            "Hudson",
            "Nathaniel",
            "Bryson",
            "Ryder",
            "Justin",
            "Bryce",
        };

        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}