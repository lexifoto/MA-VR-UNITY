using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxCapture : MonoBehaviour
{
    private int numberOfBalls;
    public GameObject winState;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Balls")
        {
            numberOfBalls++;
            Debug.Log("Number Of Balls =" + numberOfBalls);
            if (numberOfBalls > 3)
            {
                winState.SetActive(true);
            }
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Balls")
        {
            numberOfBalls--;
            Debug.Log("Number of Balls = " + numberOfBalls);
            if (numberOfBalls <3 ) 
            {
                winState.SetActive(false);
            }
        }

    }
}
