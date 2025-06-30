using System.Collections.Generic;
using System;
using Wisej.Web;

namespace EventCalendar.Class
{
    public class ButtonManager
    {

        private BindingNavigator _navigator;
        private Dictionary<string, Button> _buttons;

        public ButtonManager(BindingNavigator navigator)
        {
            _navigator = navigator;
            _buttons = new Dictionary<string, Button>();

            foreach (var item in _navigator.Controls)
            {
                if (item is Button button)
                {
                    _buttons[button.Name] = button;
                    button.Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // non deve eseguire le istruzioni che seguono quando il pulsante premuto è diverso da btnNext, btnPrevious, btnFirst, btnLast
            if (sender is Button clickedButton)
            {
                if (clickedButton.Name == "btnNext" || clickedButton.Name == "btnPreviews" || clickedButton.Name == "btnFirst" || clickedButton.Name == "btnLast")
                {
                    return;
                }

                if (clickedButton.Name == "btnDelete")
                {
                    return;
                }

                if (clickedButton.Name == "btnSave")
                {
                    return;
                }

                HandleButtonClick(clickedButton);
            }
        }

        internal void HandleButtonClick(Button clickedButton)
        {
            foreach (var button in _buttons.Values)
            {
                button.Enabled = true; // Abilita tutti i pulsanti
            }

            switch (clickedButton.Name)
            {

                case "btnAdd":
                    clickedButton.Enabled = false;

                    foreach (var button in _buttons.Values)
                    {
                        button.Enabled = false; // Abilita tutti i pulsanti
                    }

                    EnableButton("btnUndo");
                    EnableButton("btnSave");

                    break;
                case "btnDelete":
                    foreach (var button in _buttons.Values)
                    {
                        button.Enabled = true; // Abilita tutti i pulsanti
                    }
                    clickedButton.Enabled = false;


                    break;
                case "btnEdit":
                    foreach (var button in _buttons.Values)
                    {
                        button.Enabled = false; // Abilita tutti i pulsanti
                    }

                    EnableButton("btnUndo");
                    EnableButton("btnSave");

                    break;
                case "btnUndo":
                    foreach (var button in _buttons.Values)
                    {
                        button.Enabled = true; // Abilita tutti i pulsanti
                    }
                    clickedButton.Enabled = false;
                    DisableButton("btnSave");
                    DisableButton("btnUndo");
                    break;
                case "btnSave":
                    //abilita tutti i pulsanti

                    foreach (var button in _buttons.Values)
                    {
                        button.Enabled = true; // Abilita tutti i pulsanti
                    }
                    DisableButton("btnSave");
                    DisableButton("btnUndo");
                    break;
                case "btnRefresh":

                    foreach (var button in _buttons.Values)
                    {
                        button.Enabled = true; // Abilita tutti i pulsanti
                    }
                    DisableButton("btnSave");
                    DisableButton("btnUndo");
                    break;
                default:
                    foreach (var button in _buttons.Values)
                    {
                        button.Enabled = true; // Abilita tutti i pulsanti
                    }
                    break;

            }
        }

        internal void DisableButton(string buttonName)
        {
            if (_buttons.TryGetValue(buttonName, out Button button))
            {
                button.Enabled = false;
            }
        }

        internal void EnableButton(string buttonName)
        {
            if (_buttons.TryGetValue(buttonName, out Button button))
            {
                button.Enabled = true;
            }
        }
    }
}
