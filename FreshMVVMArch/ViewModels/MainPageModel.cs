using System;
using FreshMvvm;
using Xamarin.Forms;

namespace FreshMVVMArch
{
    public class MainPageModel : FreshBasePageModel
    {

        #region Default Override functions  
        public override void Init(object initData)
        {
            base.Init(initData);
            MainPageLabel = "Welcome to Fresh Mvvm Tutorial!";
        }

        public override void ReverseInit(object returnedData)
        {
            base.ReverseInit(returnedData);
        }

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
        }

        protected override void ViewIsDisappearing(object sender, EventArgs e)
        {
            base.ViewIsDisappearing(sender, e);
        }
        #endregion

        #region Commands  
        public Command GotoSecondPageCommand
        {
            get=> new Command(async () =>
                {
                    await CoreMethods.PushPageModel<SecondPageModel>();
                    //MainPageLabel = "raise on property raise test";
                });
            
        }
        #endregion

        #region Properties  
        string _mainPageLabel = string.Empty;
        public string MainPageLabel
        {
            get
            {
                return _mainPageLabel;
            }
            set
            {
                if (_mainPageLabel != value)
                {
                    _mainPageLabel = value;
                    RaisePropertyChanged(nameof(MainPageLabel));
                }
            }
        }
        #endregion

    }
}
