namespace Chapter._10.Unmodified
{
    public class DetailFrame
    {
        private string _description;
        private string _accountSymbol = string.Empty;

        public DetailFrame()
        {
        }

        public void SetDescription(string description)
        {
            _description = description;
        }

        public void Show()
        {

        }

        public string GetAccountSymbol()
        {
            return _accountSymbol;
        }
    }
}