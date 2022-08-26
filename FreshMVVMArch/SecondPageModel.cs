using System;
using FreshMvvm;

namespace FreshMVVMArch
{
    public class SecondPageModel : FreshBasePageModel
    {


        #region Default Override functions  
        public override void Init(object initData)
        {
            base.Init(initData);
            SecondPageLabel = "Second page :)";
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

        public SecondPageModel()
        {
        }


        string _secondPageLabel = string.Empty;
        #region Properties  
        public string SecondPageLabel
        {
            get=> this._secondPageLabel;
            
            set
            {
                if (this._secondPageLabel != value)
                {
                    this._secondPageLabel = value;
                    RaisePropertyChanged(nameof(SecondPageLabel));
                }
            }
        }
        #endregion
    }
}
