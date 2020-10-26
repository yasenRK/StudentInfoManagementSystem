using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace StudentInfoManagementSystem.ViewModels
{
    public class LogInViewModel : ViewModelBase
    {

        // 用户名
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                this.RaisePropertyChanged(()=>UserName);
            }
        }

        public LogInViewModel()
        {

            LogInCommand = new RelayCommand(LogIn);
            CancelCommand = new RelayCommand(Cancel);
            RoleSelectionChanedCommand = new RelayCommand(RoleSelectionChanged);
            PasswordChangedCommand = new RelayCommand(PasswordChanged);

        }



        private void PasswordChanged()
        {
            
        }

        private void RoleSelectionChanged()
        {
            throw new NotImplementedException();
        }

        private void Cancel()
        {
            throw new NotImplementedException();
        }

        private void LogIn()
        {
            




        }


        #region Commands

        public RelayCommand LogInCommand { get; set; }
        public RelayCommand CancelCommand { get; set; }
        public RelayCommand RoleSelectionChanedCommand { get; set; }
        public RelayCommand PasswordChangedCommand { get; set; }


        #endregion






    }
}
