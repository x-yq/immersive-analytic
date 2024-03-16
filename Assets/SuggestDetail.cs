using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.Examples.Demos.EyeTracking;

public class SuggestDetail : MonoBehaviour
{
    public TMP_Text DescriptionText;
    public TMP_Text DetailText;
    private bool IsFocusOnDes;
    private bool IsFocusOnDet;

    void Start()
    {
       IsFocusOnDes = false;
        IsFocusOnDet = false;
    }

    public void StartFocusOnDes()
    {
        IsFocusOnDes=true;
    }
    public void StopFocusOnDes()
    {
        IsFocusOnDes=false;
    }
    public void StartFocusOnDet()
    {
        IsFocusOnDet=true;
    }
    public void StopFocusOnDet()
    {
        IsFocusOnDet=false;
    }

    public void Tip()
    {
        if (IsFocusOnDet)
        {
            DetailText.text = "Say Select to show the detail on demand";
        }
        if (IsFocusOnDes)
        {
            DescriptionText.text = "Say Open to show the description";
        }

    }


    public void TextSet()
    {
        DescriptionText.text = "Welcome to the Immersive Analytics I Visualisation!\n You can use simple rotation, resize and scaling gestures to scale the Barchart Visualisation in front of you. \n You can use the UIs on the table to help manipulate the Visualisations attributes and filtering. \n Use the voice command 'Select' to receive further information about a point visualisation. \n Voice commands such as 'zoom in' or 'Zoom out' are also available. ";
    }

    public void ClearText()
    {
        DescriptionText.SetText("");
        DetailText.SetText("");
    }

    public void Detail()
    {
        DetailText.SetText("Detail:\n  " +
            "Year: 2000\n" +
            "Month: 2\n" +
            "Monthly Mean of Cloud Coverage: 6\n" +
            "Monthly Mean of the daily Airtemperature: 4\n" +
   //"Monthly mean of the daily max. of the airtemperature: 7"
   //"Monthly mean of the daily min. of the air temperature: 1"
   //"Monthly mean of the daily wind force: 3",
   //"Monthly max. of the daily max. of the air temperature: 15",
   //"Monthly max. of the daily wind peak: 23"
   //"Monthly min. of the daily min. of the air temperature: -6"
   //"Monthly sum of sunshine duration: 50"
   //"Monthly sum of rain fall: 60"
   //"Monthly max. of daily rain fall: 10"
            "Hotels: 80365"
   );

    }

}
