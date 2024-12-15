using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdObstacle : MonoBehaviour
{
   public float sendTimer = 1.5f;
   public float frequency = 2;
   public float position;
   public GameObject myObstacle;
   public GameObject mainCharacter;

    void Update()
    {
        if (GameStateManager.Instance.isGameStarted == true)
        {
            sendTimer -= Time.deltaTime;
            if (sendTimer <= 0)
            {
                position = Random.Range(-1f, 5f);
                transform.position = new Vector3(0, position, -23.5f);
                Instantiate(myObstacle, transform.position, transform.rotation);
                sendTimer = frequency;
            }

            if (mainCharacter != null)
            {
                Time.timeScale = 1;
            }

            else
            {
                Time.timeScale = 0;
            }
        }
    }
}
