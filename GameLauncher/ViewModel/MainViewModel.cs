using GalaSoft.MvvmLight.Command;
using GameLauncher.View;
using GameLauncher.View.Resources;
using System.Windows.Controls;
using System.Windows.Input;

namespace GameLauncher.ViewModel
{
    internal class MainViewModel : ViewModedBase
    {
        private Page Wow = new WowPage();
        private Page HS = new HSPage();
        private Page OW = new OWPage();
        private Page W3 = new W3Page();
        private Page D3 = new D3Page();
        private Page HOTS = new HOTSPage();
        private Page SC2 = new SC2Page();
        private Page SC = new SCPage();

        private Page CurrentPage = new WowPage();

        public Page CurPage
        {
            get => CurrentPage;
            set => CurrentPage = value;
        }

        public ICommand OpenHSPage
        {
            get
            {
                return new RelayCommand(() => CurPage = HS);
            }
        }
        public ICommand OpenWOWPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Wow);
            }
        }
        public ICommand OpenOWPage
        {
            get
            {
                return new RelayCommand(() => CurPage = OW);
            }
        }
        public ICommand OpenW3Page
        {
            get
            {
                return new RelayCommand(() => CurPage = W3);
            }
        }
        public ICommand OpenD3Page
        {
            get
            {
                return new RelayCommand(() => CurPage = D3);
            }
        }
        public ICommand OpenHOTSPage
        {
            get
            {
                return new RelayCommand(() => CurPage = HOTS);
            }
        }
        public ICommand OpenSC2Page
        {
            get
            {
                return new RelayCommand(() => CurPage = SC2);
            }
        }
        public ICommand OpenSCPage
        {
            get
            {
                return new RelayCommand(() => CurPage = SC);
            }
        }
    }
}
