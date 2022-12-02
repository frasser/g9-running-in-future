using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Image energyBarMask;
    private float barChangeSpeed = 0.1f;
    public float maxEnergy = 100f;
    private float currentEnergy;
    private bool isEnergyBarOn;
    public bool isEnergyIncreasing = false;

    public Hoverboard hoverboard;
    public GameObject canvasGameOver;

    void Start()
    {
        currentEnergy = maxEnergy;
        isEnergyBarOn = true;
        StartCoroutine(UpdateEnergyBar());
        hoverboard = FindObjectOfType<Hoverboard>();
    }

    IEnumerator UpdateEnergyBar()
    {
        while (isEnergyBarOn)
        {
            if (isEnergyIncreasing)
            {
                currentEnergy += 15f;
                isEnergyIncreasing = false;
            }
            if (!isEnergyIncreasing)
            {
                currentEnergy -= barChangeSpeed;
                if (currentEnergy <= 0)
                {
                    hoverboard.isTunnOff = true;
                    currentEnergy = 0;
                    canvasGameOver.SetActive(true);
         
                }
            }
            float fill = currentEnergy / maxEnergy;
            energyBarMask.fillAmount = fill;

            yield return new WaitForSeconds(0.02f);
        }
        yield return null;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
