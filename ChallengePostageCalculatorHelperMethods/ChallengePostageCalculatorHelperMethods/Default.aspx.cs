using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostageCalculatorHelperMethods
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void handleChange(object sender, EventArgs e)
        {
            performCalculation();
        }

        private void performCalculation()
        {
            if (!valuesExist()) return;

            int volume = 0;
            if (!tryGetVolume(out volume)) return;

            double postageMultiplier = getPostageMultiplier();
            double totalCost = volume * postageMultiplier;

            resultLabel.Text = $"Your shipping cost is {totalCost:C}.";
        }

        // Are there values in the textboxes?
        private bool valuesExist()
        {
            if (widthTextBox.Text.Trim().Length == 0
                || heightTextBox.Text.Trim().Length == 0)
                return false;

            if (!groundRadioButton.Checked
                && !airRadioButton.Checked
                && !nextDayRadioButton.Checked)
                return false;

            return true;
        }

        // Can we parse those values into height, width?
        private bool tryGetVolume(out int volume)
        {
            volume = 0;
            int width = 0;
            int height = 0;
            int length = 0;

            if (!int.TryParse(widthTextBox.Text.Trim(), out width)) return false;
            if (!int.TryParse(heightTextBox.Text.Trim(), out height)) return false;
            if (!int.TryParse(lengthTextBox.Text.Trim(), out length)) length = 1;

            volume = height * width * length;

            return true;
        }

        // Return cost multiplier for shipping type
        private double getPostageMultiplier()
        {
            if (groundRadioButton.Checked) return .15;
            else if (airRadioButton.Checked) return .25;
            else if (nextDayRadioButton.Checked) return .45;
            else return 0;
        }
    }
}