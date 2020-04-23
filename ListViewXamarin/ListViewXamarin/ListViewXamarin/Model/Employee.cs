using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewXamarin
{
    public class Employee : INotifyPropertyChanged
    {
        private string employeeName;
        private string designation;
        private DateTime checkIn;
        private ImageSource image;

        public Employee()
        {

        }

        public string EmployeeName
        {
            get { return employeeName; }
            set
            {
                if (employeeName != value)
                {
                    employeeName = value;
                    this.RaisedOnPropertyChanged("EmployeeName");
                }
            }
        }

        public string Designation
        {
            get { return designation; }
            set
            {
                if (designation != value)
                {
                    designation = value;
                    this.RaisedOnPropertyChanged("Designation");
                }
            }
        }

        public DateTime CheckIn
        {
            get { return checkIn; }
            set
            {
                if (checkIn != value)
                {
                    checkIn = value;
                    this.RaisedOnPropertyChanged("CheckIn");
                }
            }
        }

        public ImageSource EmployeeImage
        {
            get { return this.image; }
            set
            {
                this.image = value;
                this.RaisedOnPropertyChanged("EmployeeImage");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }
    }
}