using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField] private KeyCode keyR;
    [SerializeField] private KeyCode keyE;
    [SerializeField] private KeyCode keyQ;

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if(Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if(Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene(0);
        }
    }
}
