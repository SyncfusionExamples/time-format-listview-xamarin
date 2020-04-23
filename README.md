# How to show time in Xamarin.Forms ListView (SfListView)

You can show time in Xamarin.Forms [SfListView](https://help.syncfusion.com/xamarin/listview/overview?) by using [StringFormat](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/data-binding/string-formatting) in binding.

You can also refer the following article.

https://www.syncfusion.com/kb/11438/how-to-show-time-in-xamarin-forms-listview-sflistview

**XAML**

Binding **CheckIn** DateTime property to Label and applied **StringFormat**.
``` xml
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
                 xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                 xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms"
                 x:Class="ListViewXamarin.MainPage" Padding="{OnPlatform iOS='0,40,0,0'}">
 
    <ContentPage.Content>
        <StackLayout>
            <syncfusion:SfListView x:Name="listView" ItemSpacing="1" AutoFitMode="Height" ItemsSource="{Binding EmployeeInfo}">
                <syncfusion:SfListView.ItemTemplate >
                    <DataTemplate>
                        <Grid RowSpacing="0">
                            <Grid.RowDefinitions>
                                <RowDefinition Height="*" />
                                <RowDefinition Height="1" />
                            </Grid.RowDefinitions>
                            <Grid RowSpacing="0">
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="70" />
                                    <ColumnDefinition Width="*" />
                                    <ColumnDefinition Width="100" />
                                </Grid.ColumnDefinitions>
                                <Image Source="{Binding EmployeeImage}" VerticalOptions="Center" HorizontalOptions="Center"
                                       HeightRequest="50" WidthRequest="50"/>
                                <Grid Grid.Column="1">
                                    <Label HorizontalOptions="StartAndExpand" VerticalOptions="CenterAndExpand" Text="{Binding EmployeeName}" FontSize="20"/>
                                    <Label HorizontalOptions="StartAndExpand" VerticalOptions="CenterAndExpand" Text="{Binding Designation}" Grid.Row="1" FontSize="13" TextColor="Gold"/>
                                </Grid>
                                <Label Grid.Column="2" HorizontalOptions="StartAndExpand" VerticalOptions="CenterAndExpand" Text="{Binding CheckIn, StringFormat='{0:hh:mm tt}'}"/>
                            </Grid>
                            <StackLayout Grid.Row="1" BackgroundColor="Black"/>
                        </Grid>
                    </DataTemplate>
                </syncfusion:SfListView.ItemTemplate>
            </syncfusion:SfListView>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>
```
**C#**

Defining **CheckIn** property in **Model**.
``` c#
namespace ListViewXamarin
{
    public class Employee : INotifyPropertyChanged
    {
        private DateTime checkIn;
 
        public Employee()
        {
 
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
```
**C#**

**DateTime** Property population in **ViewModel**.
``` c#
namespace ListViewXamarin
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Employee> EmployeeInfo { get; set; }
 
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
                employee.CheckIn = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,r.Next(0,23),r.Next(0,59),r.Next(0,59));
                EmployeeInfo.Add(employee);
            }
        }
 
        public event PropertyChangedEventHandler PropertyChanged;
 
        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
```
**Output**

![TimeDisplayListView](https://github.com/SyncfusionExamples/time-format-listview-xamarin/blob/master/ScreenShots/TimeDisplayListView.png)
