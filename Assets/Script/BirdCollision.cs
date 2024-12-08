using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BirdCollision : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score;
    public bool objectNameSt;

    public void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag != null)
        {
            //Debug.Log(other.gameObject.name);
            objectNameSt = other.gameObject.name.Contains("Tree");
            if (other.gameObject.tag == "Environment" || objectNameSt == true)
            {
                //Debug.Log("Collided");
                if (!GameStateManager.Instance.isGameOver)
                {
                    GameStateManager.Instance.GameOver();
                }
            }

            else if (other.gameObject.tag == "Checkpoint")
            {
                score += 1;
                //scoreText.text = score.ToString();
            }
        }
    }
}
