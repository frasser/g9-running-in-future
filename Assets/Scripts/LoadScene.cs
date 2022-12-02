using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

    }
    public void LoadLevel(string nameLevel)
    {
        SceneManager.LoadScene(nameLevel);
    }
}
