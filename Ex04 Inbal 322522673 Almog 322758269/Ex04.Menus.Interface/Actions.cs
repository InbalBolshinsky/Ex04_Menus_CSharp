namespace Ex04.Menus.Interfaces
{
    public class ActionItem : MenuItem, IMenuAction
    {
        private readonly IMenuAction r_Action;

        public ActionItem(string i_Title, IMenuAction i_Action) : base(i_Title)
        {
            r_Action = i_Action;
        }

        public override void Execute()
        {
            r_Action.Execute();
        }
    }
}
