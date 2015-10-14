using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Data.Json;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AniConApp.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AniConMonthView : Page
    {
        public List<Month> Year = new List<Month>();

        public AniConMonthView()
        {
            this.InitializeComponent();

            Resources.Values.ToList();


            Month August = new Month();
            AniconValues Abunai = new AniconValues("Abunai", "Koningshof Veldhoven");
            August.Items.Add(Abunai);
            this.Year.Add(August);



            var aniCons = (CollectionViewSource)Resources["src"];

            //JsonObject aniConsYear = new JsonObject();
            //JsonArray Year = new JsonArray();
            //aniConsYear.Add("2015", Year);
            //JsonObject August = new JsonObject();
            //Year.Add(August);
            //JsonObject Years = new JsonObject();
            //JsonObject Years = new JsonObject();
            //JsonArray Months = new JsonArray();
            //JsonObject August = new JsonObject();
            ////Years.Add("August", August);
            //Months.Add(August);
            //JsonObject Abunai = new JsonObject();
            //Abunai.Add("Name", JsonValue.CreateStringValue("Abunai"));
            //Abunai.Add("Location", JsonValue.CreateStringValue("Koningshof Veldhoven"));
            //Abunai.Add("Month", JsonValue.CreateStringValue("August"));
            //August.Add("Abunai", Abunai);
            //Years.Add("Months", Months);
            
            
            


        }

        private ObservableCollection<Month> _groups = new ObservableCollection<Month>();
        public ObservableCollection<Month> Groups
        {
            get { return this._groups; }
        }




    }

    public class AniconValues
    {
        public AniconValues(String Name,String Location)
        {
            this.Name = Name;
            this.Location = Location;
        }

        public string Name { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return Name.ToString();
        }
    }


    public class Month
    {
        public Month()
        {
            this.Items = new ObservableCollection<AniconValues>();
        }

        public ObservableCollection<AniconValues> Items { get; private set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
