﻿namespace Chapter._10
{
    public class AccountDetailFrame : Frame, ActionListener, WindowListener
    {
		DetailFrame _detailDisplay;
		private TextField _display = new TextField(10);

        public AccountDetailFrame() { }

        public void ActionPerformed(ActionEvent actionEvent)
        {
            string source = actionEvent.GetActionCommand();
            PerformCommand(source);
        }

		public void PerformCommand(string source)
		{
		    if (source.Equals("project activity"))
		    {
		        SetDescription();
		        string accountDescription = GetAccountSymbol();

		        accountDescription += ": ";

		        accountDescription += "basic account";
		        SetDisplayText(accountDescription);
		    }
		}

		protected virtual void SetDescription()
		{
		    _detailDisplay = new DetailFrame();
		    _detailDisplay.SetDescription(GetDetailText() + " " + GetProjectionText());
		    _detailDisplay.Show();
		}

		protected virtual string GetAccountSymbol()
		{
			return _detailDisplay.GetAccountSymbol();
		}

		protected virtual void SetDisplayText(string accountDescription)
		{
			_display.SetText(accountDescription);
		}

        private string GetDetailText()
        {
            return string.Empty;
        }

        private string GetProjectionText()
        {
            return string.Empty;
        }

        public void WindowActivated(WindowEvent e)
        {

        }

        public void WindowClosed(WindowEvent e)
        {

        }

        public void WindowClosing(WindowEvent e)
        {

        }

        public void WindowDeactivated(WindowEvent e)
        {

        }

        public void WindowDeiconified(WindowEvent e)
        {

        }

        public void WindowIconified(WindowEvent e)
        {

        }

        public void WindowOpened(WindowEvent e)
        {

        }
    }
}