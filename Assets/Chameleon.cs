using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Chameleon : MonoBehaviour
{
    public Material Band1;
    public Material Band2;
    public Material Band3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void w1ColourSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if (buttonName == "BLACKButton")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            Band1.color = myColor;
        }

        else if (buttonName == "BLUEButton")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#043273", out myColor);
            Band1.color = myColor;
        }
    }

    public void w2ColourSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if (buttonName == "BLACKButton")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            Band2.color = myColor;
        }

        else if (buttonName == "REDButton")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#740202", out myColor);
            Band2.color = myColor;
        }
    }

    public void w3ColourSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if (buttonName == "SILVERButton")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#c0c0c0", out myColor);
            Band3.color = myColor;
        }

        else if (buttonName == "GOLDButton")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#ffd700", out myColor);
            Band3.color = myColor;
        }
    }
}
