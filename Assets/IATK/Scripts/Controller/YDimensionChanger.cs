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
	[AddComponentMenu("IATK/Scripts/Controller/YDimensionChanger")]
	public class YDimensionChanger : MonoBehaviour
	{
        [SerializeField]
        private Visualisation vis;


        public void updateHotelDimension()
        {
            // get Current yDimension from the current Visualisation instance and set attribute Hotels
            DimensionFilter yDimension = vis.yDimension;
            if(yDimension.Attribute != "Hotels")
            {
                yDimension.Attribute = "Hotels";
            }


            // upDate Visualisation
            vis.updateViewProperties(AbstractVisualisation.PropertyType.Y);
        }

        public void updateHotelGarniDimension()
        {
            // get Current yDimension from the current Visualisation instance and set attribute Hotel Garni
            DimensionFilter yDimension = vis.yDimension;
            if (yDimension.Attribute != "Hotel garni")
            {
                yDimension.Attribute = "Hotel garni";
            }


            // upDate Visualisation
            vis.updateViewProperties(AbstractVisualisation.PropertyType.Y);
        }

        public void updateHostelsDimension()
        {
            // get Current yDimension from the current Visualisation instance and set attribute Youth Hostels
            DimensionFilter yDimension = vis.yDimension;
            if (yDimension.Attribute != "Youth Hostels")
            {
                yDimension.Attribute = "Youth Hostels";
            }


            // upDate Visualisation
            vis.updateViewProperties(AbstractVisualisation.PropertyType.Y);
        }

        public void updateInnDimension()
        {
            // get Current yDimension from the current Visualisation instance and set attribute Inn
            DimensionFilter yDimension = vis.yDimension;
            if (yDimension.Attribute != "Inn")
            {
                yDimension.Attribute = "Inn";
            }


            // upDate Visualisation
            vis.updateViewProperties(AbstractVisualisation.PropertyType.Y);
        }

        public void updatePensionDimension()
        {
            // get Current yDimension from the current Visualisation instance and set attribute Pensions
            DimensionFilter yDimension = vis.yDimension;
            if (yDimension.Attribute != "Pensions")
            {
                yDimension.Attribute = "Pensions";
            }


            // upDate Visualisation
            vis.updateViewProperties(AbstractVisualisation.PropertyType.Y);
        }

        public void updateOtherDimension()
        {
            // get Current yDimension from the current Visualisation instance and set attribute Others
            DimensionFilter yDimension = vis.yDimension;
            if (yDimension.Attribute != "Others")
            {
                yDimension.Attribute = "Others";
            }


            // upDate Visualisation
            vis.updateViewProperties(AbstractVisualisation.PropertyType.Y);
        }

    }

}
