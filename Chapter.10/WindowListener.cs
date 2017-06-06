namespace Chapter._10
{
    public interface WindowListener
    {
        void WindowActivated(WindowEvent e);
        void WindowClosed(WindowEvent e);
        void WindowClosing(WindowEvent e);
        void WindowDeactivated(WindowEvent e);
        void WindowDeiconified(WindowEvent e);
        void WindowIconified(WindowEvent e);
        void WindowOpened(WindowEvent e);
    }
}