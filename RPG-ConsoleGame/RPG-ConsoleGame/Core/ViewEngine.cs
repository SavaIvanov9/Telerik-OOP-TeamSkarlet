﻿namespace RPG_ConsoleGame.Core
{
    public delegate void OnMenuClickHandler(string selectedValue);

    public class ViewEngine
    {
        public event OnMenuClickHandler OnMenuClick;

        protected virtual void OnClick(string value)
        {
            if (OnMenuClick != null)
            {
                OnMenuClick(value);
            }
        }

        public void DrawMenu()
        {
            // .. draw and ReadLine()

            OnClick("New Game");
        }
    }
}
