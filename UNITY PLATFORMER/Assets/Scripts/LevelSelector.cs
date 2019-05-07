using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        SceneManager.LoadScene("LevelSelector");
    }

}
