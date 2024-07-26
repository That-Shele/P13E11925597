using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13E11925597.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string num1;
        [ObservableProperty]
        private string num2;
        [ObservableProperty]
        private string resultado;

        [RelayCommand]
        private void Sumar()
        {
            if (double.TryParse(Num1, out double num1) && double.TryParse(Num2, out double num2))
            {
                Resultado = "La suma es : " + (num1 + num2).ToString();
            }
            else
            {
                Resultado = "Ingrese datos numéricos";
            }
        }
    }
}
