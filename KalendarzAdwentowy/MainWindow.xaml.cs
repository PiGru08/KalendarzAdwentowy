using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace KalendarzAdwentowy
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int day = int.Parse(button.Content.ToString());
            Date yesterday = Date.Today.AddDays();


            string[] zadania = new string[]
            {
                "Robienie świątecznych ozdób z papieru kolorowego.",
                "Zrobienie ciasteczek piernikowych.",
                "Pójście na spacer w poszukiwaniu świątecznych dekoracji.",
                "Napisanie listu do Świętego Mikołaja.",
                "Wykonanie kartki świątecznej.",
                "Posłuchanie kolęd.",
                "Zrobienie zdjęcia z choinką.",
                "Zrobienie dekoracji do domu.",
                "Wspólne przygotowanie gorącej czekolady.",
                "Obejrzenie świątecznego filmu.",
                "Zrobienie świątecznego kalendarza.",
                "Poczytanie książki o tematyce świątecznej.",
                "Przygotowanie listy prezentów dla bliskich.",
                "Ozdobienie pierników.",
                "Zorganizowanie wieczoru z grami planszowymi.",
                "Przygotowanie świątecznej herbaty.",
                "Posprzątanie pokoju i udekorowanie go na Święta.",
                "Zrobienie kartki świątecznej dla sąsiadów.",
                "Pójście na koncert kolęd.",
                "Przygotowanie świątecznego śniadania.",
                "Wykonanie ozdób na choinkę.",
                "Pomoc w pakowaniu prezentów.",
                "Podzielenie się swoją radością z innymi.",
                "Wieczór z opowieściami bożonarodzeniowymi."
            };
            if(day == 18 || day < 18)
            {
                MessageBox.Show(zadania[day]);
            }else 
            {
                MessageBox.Show("Złą datę wybrałeś!");
            }
 
            
        }
    }
}
