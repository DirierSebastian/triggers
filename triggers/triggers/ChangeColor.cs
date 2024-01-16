using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace triggers
{
    public class ChangeColor : TriggerAction<Button>
    {
        protected override void Invoke(Button btn)
        {
            btn.BackgroundColor = Color.SkyBlue;
            btn.Text = "DreamTeam";
        }
    }
}
