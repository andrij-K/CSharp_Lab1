using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using Kurbatov01.Annotations;

namespace Kurbatov01
{
    class Main : INotifyPropertyChanged
    {
       
        private readonly string[] zodiacs = 
            {"Capricorn", "Aquarius", "Pisces", "Aries", "Taurus","Gemini","Cancer","Leo", "Virgo", "Libra", "Scorpio","Sagittarius"};
        private readonly string[] zodiacsChina =
            {"Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Sheep", "Monkey", "Rooster", "Dog", "Pig"};
        private string zodiacRes;
        private string zodiacChinaRes;
        private RelayCommand<object> _signInCommand;
        private static readonly DateTime Today = DateTime.Today;
        private int _age;
        private DateTime _birthDate = Today;

        public string Age => $"Age: {_age}";

        public DateTime BirthDate
        {
            get => _birthDate;
            set
            {
                _birthDate = value;
                if (Today.DayOfYear == _birthDate.DayOfYear)
                {
                    MessageBox.Show("Happy birthday!");
                }
                //_age = (DateTime.Today - _birthDate).Days/ 365;
                int _days = (DateTime.Today - _birthDate).Days;
                if (_days<0||_age > 135)
                {
                    MessageBox.Show("Invalid input");
                    return;
                }
                
            }
        }
        
       

     
        private string CountZodiac()
        {
            var day = _birthDate.Day;
            switch (BirthDate.Month)
            {
                case 12 when day >= 22: 
                //dec-jan
                case 1 when day <= 20:
                    return zodiacs[0];
                case 1 when day >= 21:
                //jan-feb
                case 2 when day <= 18:
                    return zodiacs[1];
                case 2 when day >= 19:
                //feb-march
                case 3 when day <= 20:
                    return zodiacs[2];
                case 3 when day >= 21:
                //march-apr
                case 4 when day <= 20:
                    return zodiacs[3];
                case 4 when day >= 21:
                // apr-may
                case 5 when day <= 20:
                    return zodiacs[4];
                case 5 when day >= 21:
                //may-june
                case 6 when day <= 21:
                    return zodiacs[5];
                case 6 when day >= 22:
                //june-july
                case 7 when day <= 22:
                    return zodiacs[6];
                case 7 when day >= 23:
                //july-aug
                case 8 when day <= 23:
                    return zodiacs[7];
                case 8 when day >= 24:
                //aug-sept
                case 9 when day <= 23:
                    return zodiacs[8];
                case 9 when day >= 24:
                //sept-oct
                case 10 when day <= 23:
                    return zodiacs[9];
                case 10 when day >= 24:
                //oct-nov
                case 11 when day <= 22:
                    return zodiacs[10];
                default:
                    return zodiacs[11];
            }
        }

        

       

        private string CountChinaZodiac()
        {
            switch (_birthDate.Year)
            {
                case 1912:
                case 1924:
                case 1936:
                case 1948:
                case 1960:
                case 1972:
                case 1984:
                case 1996:
                case 2008:
                    return zodiacsChina[0];
                case 1913:
                case 1925:
                case 1937:
                case 1949:
                case 1961:
                case 1973:
                case 1985:
                case 1997:
                case 2009:
                    return zodiacsChina[1];
                case 1914:
                case 1926:
                case 1938:
                case 1950:
                case 1962:
                case 1974:
                case 1986:
                case 1998:
                case 2010:
                    return zodiacsChina[2];
                case 1915:
                case 1927:
                case 1939:
                case 1951:
                case 1963:
                case 1975:
                case 1987:
                case 1999:
                case 2011:
                    return zodiacsChina[3];
                case 1916:
                case 1928:
                case 1940:
                case 1952:
                case 1964:
                case 1976:
                case 1988:
                case 2000:
                case 2012:
                    return zodiacsChina[4];
                case 1917:
                case 1929:
                case 1941:
                case 1953:
                case 1965:
                case 1977:
                case 1989:
                case 2001:
                case 2013:
                    return zodiacsChina[5];
                case 1918:
                case 1930:
                case 1942:
                case 1954:
                case 1966:
                case 1978:
                case 1990:
                case 2002:
                case 2014:
                    return zodiacsChina[6];
                case 1919:
                case 1931:
                case 1945:
                case 1955:
                case 1967:
                case 1979:
                case 1991:
                case 2003:
                case 2015:
                    return zodiacsChina[7];
                case 1920:
                case 1932:
                case 1944:
                case 1956:
                case 1968:
                case 1980:
                case 1992:
                case 2004:
                case 2016:
                    return zodiacsChina[8];
                case 1921:
                case 1933:
                case 1957:
                case 1969:
                case 1981:
                case 1993:
                case 2005:
                case 2017:
                    return zodiacsChina[9];
                case 1922:
                case 1934:
                case 1946:
                case 1958:
                case 1970:
                case 1982:
                case 1994:
                case 2006:
                case 2018:
                    return zodiacsChina[10];
                default:
                    return zodiacsChina[11];
            }
        }



        public string Zodiac
        {
            get => $"Western zodiac: {zodiacRes}";
            set
            {
                zodiacRes = value;
                OnPropertyChanged();
            }
        }

        public string ZodiacChina
        {
            get => $"Chinese zodiac: {zodiacChinaRes}";
            set
            {
                zodiacChinaRes = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand<object> RunButton
        {
            get
            {
                return _signInCommand ?? (_signInCommand = new RelayCommand<object>(
                           Results, o => CanExecuteCommand()));
            }
        }
        private async void Results(object obj)
        {
            await Task.Run(() =>
                {
                    _age = (DateTime.Today - _birthDate).Days / 365;
                    OnPropertyChanged(nameof(Age));
                    Zodiac = CountZodiac();
                    ZodiacChina = CountChinaZodiac();
                }
            );
        }
        private bool CanExecuteCommand()
        {
            return !string.IsNullOrWhiteSpace(_birthDate.ToString());
        }

       

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

        #endregion
}

