using Chapter._10;

namespace LegacyCode.Tests.Chapter
{
    public class TestingAccountDetailFrame : AccountDetailFrame
    {
        private string _displayText;
        private string _accountSymbol;

        protected override string GetAccountSymbol()
        {
            return _accountSymbol;
        }

        public void SetAccountSymbol(string symbol)
        {
            _accountSymbol = symbol;
        }

        public string GetDisplayText()
        {
            return _displayText;
        }

        protected override void SetDisplayText(string text)
        {
            _displayText = text;
        }

        protected override void SetDescription()
        {

        }
    }
}