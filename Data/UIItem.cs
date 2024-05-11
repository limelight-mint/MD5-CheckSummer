using LLM.MD5_CheckSummer.Handlers;

namespace LLM.MD5_CheckSummer.Data
{
    //base UI Item piece to call ShowElements(true/false) from presenter
    public interface UIItem
    {
        public Button Button { get; }

        public Presenter.UIPage CorrespondingPage { get; }

        public void ShowElements(bool state);
    }
}
