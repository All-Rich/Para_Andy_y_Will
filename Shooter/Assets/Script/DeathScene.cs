using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScene : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J)) 
        {

            SceneManager.LoadScene("Nivel_1");
        
        }

        if (Input.GetKeyDown(KeyCode.K))
        {

            Application.Quit();

        }
    }
}
