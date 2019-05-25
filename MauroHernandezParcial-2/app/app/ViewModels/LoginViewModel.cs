
namespace app.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Windows.Input;
    using Services;
    using Xamarin.Forms;
    //using Models;
    using Views;

    public class LoginViewModel : BaseViewModel
    {
        #region Attributes
        string notes;
        bool isrunning;
        bool isenabled;

        public LoginViewModel()
        {
        }
        #endregion

        #region Properties
        public string Notes
        {
            get
            {
                return this.notes;
            }
            set
            {
                SetValue(ref this.notes, value);
            }
        }

        private void SetValue(ref string notes, string value)
        {
            throw new NotImplementedException();
        }

        public bool IsRunning
        {
            get
            {
                return this.isrunning;
            }
            set
            {
                SetValue(ref this.isrunning, value);
            }

        }
        public bool IsEnabled
        {
            get
            {
                return this.isenabled;
            }
            set
            {
                SetValue(ref this.isenabled, value);
            }
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(cmdLogin);
            }
        }

        private async void cmdLogin()
        {
            if (String.IsNullOrEmpty(Notes))
            {
                await App.Current.MainPage.DisplayAlert("Notes empty",
                                "Please enter your note",
                                "Accept");
                return;
            }


            IsRunning = true;
            IsEnabled = false;

        }

        }
    #endregion
}
