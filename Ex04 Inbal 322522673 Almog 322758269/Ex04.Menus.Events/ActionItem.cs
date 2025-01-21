using System;
namespace Ex04.Menus.Events
{
    public delegate void ItemSelectedDelegate();
    public class ActionItem : MenuItem
    {
        public event ItemSelectedDelegate ItemSelected;
        public ActionItem(string i_Title) : base(i_Title)
        {
        }

        public override void Execute()
        {
            OnSelection();
        }

        protected virtual void OnSelection()
        {
            if (ItemSelected != null)
            {
                ItemSelected.Invoke();
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}