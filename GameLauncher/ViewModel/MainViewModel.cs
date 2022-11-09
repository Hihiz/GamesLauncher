using GameLauncher.View;
using System.Windows.Controls;

namespace GameLauncher.ViewModel
{
    internal class MainViewModel : ViewModedBase
    {
        private Page CurrentPage = new WowPage();

        public Page CurPage
        {
            get => CurrentPage;
            set => CurrentPage = value;
        }

    }
}
