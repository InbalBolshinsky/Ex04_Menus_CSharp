namespace Ex04.Menus.Events
{
    public abstract class MenuItem
    {
        public string Title { get; }

        protected MenuItem(string i_Title)
        {
            Title = i_Title;
        }

        public abstract void Execute();
    }
}
