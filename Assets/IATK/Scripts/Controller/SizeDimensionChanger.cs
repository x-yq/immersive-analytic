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
	[AddComponentMenu("IATK/Scripts/Controller/SizeDimensionChanger")]
	public class SizeDimensionChanger : MonoBehaviour
	{
		[SerializeField]
		private Visualisation vis;

		private AbstractVisualisation visObject;

		public void updateMaxRainFall()
        {
			// get current colourDimension from the current visualisation instance and set attribute to Max Rain Fall
			visObject = vis.theVisualizationObject;
			string sizeDimension = vis.sizeDimension;
			if (sizeDimension != "Monthly max. of daily rain fall")
			{
				vis.sizeDimension = "Monthly max. of daily rain fall";
			}

			// upDate Visualisation
			visObject.UpdateVisualisation(AbstractVisualisation.PropertyType.Size);
		}

		public void updateSumRainFall()
		{
			// get current colourDimension from the current visualisation instance and set attribute to sum Rain Fall
			visObject = vis.theVisualizationObject;
			string sizeDimension = vis.sizeDimension;
			if (sizeDimension != "Monthly sum of rain fall")
			{
				vis.sizeDimension = "Monthly sum of rain fall";
			}

			// upDate Visualisation
			visObject.UpdateVisualisation(AbstractVisualisation.PropertyType.Size);
		}

		public void updateMeanWindForce()
		{
			// get current colourDimension from the current visualisation instance and set attribute to Mean Wind Force
			visObject = vis.theVisualizationObject;
			string sizeDimension = vis.sizeDimension;
			if (sizeDimension != "Monthly mean of the daily wind force")
			{
				vis.sizeDimension = "Monthly mean of the daily wind force";
			}

			// upDate Visualisation
			visObject.UpdateVisualisation(AbstractVisualisation.PropertyType.Size);
		}

		public void updateMaxWindPeak()
		{
			// get current colourDimension from the current visualisation instance and set attribute to Max Wind Peak
			visObject = vis.theVisualizationObject;
			string sizeDimension = vis.sizeDimension;
			if (sizeDimension != "Monthly max. of the daily wind peak")
			{
				vis.sizeDimension = "Monthly max. of the daily wind peak";
			}

			// upDate Visualisation
			visObject.UpdateVisualisation(AbstractVisualisation.PropertyType.Size);
		}
	}
}
