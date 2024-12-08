using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovment1 : MonoBehaviour
{
    public float life = 50;
    

    void Update()
    {
        if (GameStateManager.Instance.isGameStarted == true)
        {
            life -= Time.deltaTime;
            if (life <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                transform.Translate(0, 0, 2 * Time.deltaTime);
            }
        }
        else
        {
            Time.timeScale = 0;
        }
    }
}
