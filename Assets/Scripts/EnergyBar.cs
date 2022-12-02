using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Image energyBarMask;
    private float barChangeSpeed = 0.15f;
    public float maxEnergy = 100f;
    private float currentEnergy;
    private bool isEnergyBarOn;
    public bool isEnergyIncreasing = false;

    void Start()
    {
        currentEnergy = maxEnergy;
        isEnergyBarOn = true;
        StartCoroutine(UpdateEnergyBar());
    }

    IEnumerator UpdateEnergyBar()
    {
        while (isEnergyBarOn)
        {
            if (isEnergyIncreasing)
            {
                currentEnergy += 1f;
            }
            if (!isEnergyIncreasing)
            {
                currentEnergy -= barChangeSpeed;
                if (currentEnergy <= 0)
                { 
                
                }
            }
            float fill = currentEnergy / maxEnergy;
            energyBarMask.fillAmount = fill;

            yield return new WaitForSeconds(0.02f);
        }
        yield return null;
    }
}
