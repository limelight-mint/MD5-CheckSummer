using MD5_CheckSummer.Data;

namespace MD5_CheckSummer.Handlers
{
    //class to present our UI in a nicely and clean way
    //basically we just divide and conquer, instead of making a mess in Program.cs which is just a point of enter, not a god class, u know
    public partial class Presenter
    {
        private UIItem[] datas;

        public enum UIPage
        {
            Menu = 0,
            Comparer,
            Encoder
        }

        public Presenter(UIItem[] datas) => this.datas = datas;

        public void ShowUI(UIPage ui)
        {
            foreach (var data in datas)
            {
                data.ShowElements(data.CorrespondingPage == ui);
            }
        }
    }
}
