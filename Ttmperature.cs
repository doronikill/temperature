using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ttmperature : MonoBehaviour
{
    public Ttmperature playerTemperature;
    public TextMeshProUGUI temperaturaText;
    public void UpdateTemperaturaText()
    {
        float roudTemperature = Mathf.Round(playerTemperature.CurrentTemperature * 10.0f) * 0.
            temperatureText.text = roudTemperature.ToString();
    }
}
