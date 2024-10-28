using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            string currentSceneName = SceneManager.GetActiveScene().name;

            if(currentSceneName == "MainScene")
            {
                SceneManager.LoadScene("Scenes/DoubleThrustScene");
            }
            else if(currentSceneName == "DoubleThrustScene")
            {
                SceneManager.LoadScene("Scenes/SpeargunScene");
            }
            else
            {
                SceneManager.LoadScene("Scenes/MainScene");
            }
        }
        
    }

}
