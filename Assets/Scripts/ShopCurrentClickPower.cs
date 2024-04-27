using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopClickPower : MonoBehaviour
{

    public ClickerScript ClickerScript;
    public TextMeshProUGUI CurrentPower;

    // Update is called once per frame
    void Update()
    {
        CurrentPower.text = ClickerScript.clickPower.ToString();
    }
}
