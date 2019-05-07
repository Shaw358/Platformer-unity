using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class script : MonoBehaviour
{
    public int selector = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        string[] textmis = new string[4];
        textmis[0] = "";
        textmis[1] = "Your first mission will be to go to the civilian ship. The Cylons have already started hacking the local computers... maybe even the ones from the fleet fleet. You will have to find a chip to hinder their process and then proceed to the viper in the back to get the frack out. Best of luck";
        textmis[2] = "The hanger deck has been run over by the Cylons. Our vipers are grounded, we are under attack and completely defenseless! Kick them out, fast.";
        textmis[3] = "Test3";

        if (selector == 1)
        {
            GetComponent<TextMeshPro>().text = textmis[1];
        }
        else if (selector == 2)
        {
            GetComponent<TextMeshPro>().text = textmis[2];
        }
        else if (selector == 3)
        {
            GetComponent<TextMeshPro>().text = textmis[3];
        }
        else if(selector == 0)
        {
            GetComponent<TextMeshPro>().text = textmis[0];
        }
    }
}
