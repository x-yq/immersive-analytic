using System;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

namespace IATK
{
	[AddComponentMenu("IATK/Scripts/Controller/ColourDimensionChanger")]
	public class ColourDimensionChanger : MonoBehaviour
	{
		[SerializeField]
		private Visualisation vis;

		private AbstractVisualisation visObject;

		public void updateMeanAirTemp()
		{
			// get current colourDimension from the current visualisation instance and set attribute to Mean of daily air temperature
			visObject = vis.theVisualizationObject;
			string colourDimension = vis.colourDimension;
			if(colourDimension != "Monthly Mean of the daily Airtemperature")
            {
				vis.colourDimension = "Monthly Mean of the daily Airtemperature";
			}

			// upDate Visualisation
			visObject.UpdateVisualisation(AbstractVisualisation.PropertyType.Colour);
		}

		public void updateMeanMaxAirTemp()
        {
			// get current colourDimension from the current visualisation instance and set attribute Monthly mean max of daily air temperatue
			visObject = vis.theVisualizationObject;
			string colourDimension = vis.colourDimension;
			if(colourDimension != "Monthly mean of the daily max. of the airtemperature")
            {
				vis.colourDimension = "Monthly mean of the daily max. of the airtemperature";
			}

			// update Visualisation
			visObject.UpdateVisualisation(AbstractVisualisation.PropertyType.Colour);
        }

		public void updateMeanMinAirTemp()
        {
			// get current colourDimension from the current visualisation instance and set attribute Monthly mean min of daily air temperatue
			visObject = vis.theVisualizationObject;
			string colourDimension = vis.colourDimension;
			if (colourDimension != "Monthly mean of the daily min. of the air temperature")
			{
				vis.colourDimension = "Monthly mean of the daily min. of the air temperature";
			}

			// update Visualisation
			visObject.UpdateVisualisation(AbstractVisualisation.PropertyType.Colour);

		}

		public void updateSunDuration()
		{
			// get current colourDimension from the current visualisation instance and set attribute Monthly max sun duration
			visObject = vis.theVisualizationObject;
			string colourDimension = vis.colourDimension;
			if (colourDimension != "Monthly sum of sunshine duration")
			{
				vis.colourDimension = "Monthly sum of sunshine duration";
			}

			// update Visualisation
			visObject.UpdateVisualisation(AbstractVisualisation.PropertyType.Colour);

		}
	}

}