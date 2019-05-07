using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class box : MonoBehaviour
{
    public bool chip = false;
    // Start is called before the first frame update
    private void FixedUpdate()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(chip == true)
        {

            SceneManager.LoadScene("Home");
        }
    }
}
