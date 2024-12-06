using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BirdCollision : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Environment")
        {
            
        }
        else if (other.gameObject.tag == "Checkpoint")
        {
            score +=1;
            scoreText.text = score.ToString();
        }
    }
}
