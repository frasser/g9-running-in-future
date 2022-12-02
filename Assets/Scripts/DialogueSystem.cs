using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueSystem : MonoBehaviour
{
    public GameObject dialogueBox;

    private void OnTriggerExit(Collider other)
    {
            dialogueBox.SetActive(false);
    }
}
