using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ballCounter : MonoBehaviour
{
    private int numberOfBalls;
    public TextMeshPro ballCounterText;

    private void OnTriggerEnter(Collider possibleball)
    {
        if (possibleball.gameObject.tag == "Ball")
        {
            numberOfBalls++;
            //Destroy (possibleball.gameObject);
            Debug.Log("Ball Entered total balls = " + numberOfBalls);
            ballCounterText.text = "Balls:" + numberOfBalls;
            ballCounterText.color = new Color(
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                Random.Range(0f, 1f));
            
       
        }
    }
}
