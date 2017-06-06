namespace Chapter._10
{
    internal class TextField
    {
        private int _size;
        private string _text;

        public TextField(int size)
        {
            _size = size;
        }

        public void SetText(string text)
        {
            _text = text;
        }
    }
}