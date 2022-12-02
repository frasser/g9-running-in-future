using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    public EnergyBar energyBar;
    public GameObject energy;

    [SerializeField] private AudioSource collectingSFX;

    public int countEnergy;

    void Start()
    {
        energyBar = FindObjectOfType<EnergyBar>();
        countEnergy = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            countEnergy += 1;
            collectingSFX.Play();

            energyBar.isEnergyIncreasing = true;

            Destroy(gameObject);
        }
    }
}

