namespace Chapter._10
{
    public class AccountDetailFrame : Frame, ActionListener, WindowListener
    {
        private TextField _display = new TextField(10);

        public AccountDetailFrame() { }

        public void ActionPerformed(ActionEvent actionEvent)
        {
            string source = actionEvent.GetActionCommand();
            if (source.Equals("project activity"))
            {
                DetailFrame detailDisplay = new DetailFrame();
                detailDisplay.SetDescription(GetDetailText() + " " + GetProjectionText());

                detailDisplay.Show();

                string accountDescription = detailDisplay.GetAccountSymbol();

                accountDescription += ": ";

                accountDescription += "basic account";

                _display.SetText(accountDescription);
            }
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