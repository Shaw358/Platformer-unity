using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finallS : MonoBehaviour
{
    // Start is called before the first frame update
    public void level1()
    {
        SceneManager.LoadScene("level1");
    }
    public void level2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void level3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void Restart()
    {
        SceneManager.LoadScene("Home");
    }
}
