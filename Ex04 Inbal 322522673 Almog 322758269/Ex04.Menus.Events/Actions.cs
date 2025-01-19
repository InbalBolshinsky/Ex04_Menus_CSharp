using System;

namespace Ex04.Menus.Events
{
    public delegate void ItemSelectedDelegate();
    public class ActionItem : MenuItem
    {
        // $G$ CSS-999 (-10) Class name should match the file name.
        public event ItemSelectedDelegate ItemSelected;

        public ActionItem(string i_Title) : base(i_Title)
        {
        }

        public override void Execute()
        {
            DoWhenSelected();
        }

        protected virtual void DoWhenSelected()
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

