using System;
using System.Collections.ObjectModel;
using exampleCollectionView.Model;

namespace exampleCollectionView.ViewModel
{
    public class MainPageViewModel : ViewModelBase
    {
        public ObservableCollection<Teste> Testes { get; }

        private int _rating;
        public int Rating
        {
            get { return _rating; }
            set => SetProperty(ref _rating, value);
        }

        public MainPageViewModel()
        {
            Testes = new ObservableCollection<Teste>();

            Testes.Add(new Teste
            {
                Nome = "God of War",
                SobreNome = "O bom da guerra"
            });

            Testes.Add(new Teste
            {
                Nome = "The last of us",
                SobreNome = "Nois que sobramus"
            });

            Testes.Add(new Teste
            {
                Nome = "Mario Kart 8",
                SobreNome = "Correndo com meus Amig..Inimigos"
            });

            Testes.Add(new Teste
            {
                Nome = "Super Mario Odyssey",
                SobreNome = "As viagens do Bigode"
            });

            Testes.Add(new Teste
            {
                Nome = "Halo",
                SobreNome = "E eu passei metiolate"
            });

        }
    }
}
