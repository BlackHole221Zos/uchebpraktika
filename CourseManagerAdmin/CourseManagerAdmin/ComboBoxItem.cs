namespace CourseManagerAdmin
{
    public class ComboBoxItem
    {
        public int Id { get; }
        public string Text { get; }

        public ComboBoxItem(int id, string text)
        {
            Id = id;
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
