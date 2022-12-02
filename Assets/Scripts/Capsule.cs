using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    public EnergyBar energyBar;
    public GameObject energy;

    public int countEnergy;
    // Start is called before the first frame update
    void Start()
    {

        energyBar = FindObjectOfType<EnergyBar>();
        countEnergy = 0;
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            countEnergy += 1;
            //energy.SetActive(false);


            Debug.Log("Entro ->  " + countEnergy.ToString("f0"));

            energyBar.isEnergyIncreasing = true;

            Destroy(gameObject);
        }
    }
}

