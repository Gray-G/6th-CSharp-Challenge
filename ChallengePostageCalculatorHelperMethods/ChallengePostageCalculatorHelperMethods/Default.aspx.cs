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
            ValuesExist();
            calculateVolume(out volume);
            resultLabel.Text = calculateCost();
        }

        //Are there values in the textboxes?
        private void ValuesExist()
        {
            
        }

        //Can we parse those values into height, width?
        private void calculateVolume(out object volume)
        {
            
        }

        //Calculated the volume * shipping method
        private string calculateCost()
        {
            
        }
    }
}