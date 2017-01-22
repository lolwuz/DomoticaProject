using Intersoft.Crosslight.Drawing;
using Intersoft.Crosslight.UI.DataVisualization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChartingSample.Core
{
	public class StyleSelectors : IDataPointColorSelector
	{
        public ColorBase GetDataPointColor(object dependentValue,double independentValue)
		{
			SolidColor color = new SolidColor();

            if (Convert.ToDouble(independentValue) >= 0)
            {
                color.Color = Colors.Green;
            }
            else if (Convert.ToDouble(independentValue) < 0)
            {
                color.Color = Colors.Red;
            }

            if (Convert.ToString(dependentValue).Equals("00.00 - 06.00"))
            {
                color.Color = Colors.Blue;
            }
            else if (Convert.ToString(dependentValue).Equals("06.00 - 12.00"))
            {
                color.Color = Colors.Green;
            }
            else if (Convert.ToString(dependentValue).Equals("12.00 - 18.00"))
            {
                color.Color = Colors.Orange;
            }
            else if (Convert.ToString(dependentValue).Equals("18.00 - 24.00"))
            {
                color.Color = Colors.Red;
            }

			return color;
		}
	}
}
