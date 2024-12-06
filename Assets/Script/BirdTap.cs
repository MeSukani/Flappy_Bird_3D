using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdTap : MonoBehaviour
{

   public float ySpeed;
   public float yTarget;
   public GameObject soundBounce;

    private void Update()
    {
        transform.Translate(0,ySpeed,0);
        ySpeed = Mathf.Lerp(ySpeed,yTarget,0.25f);

        if (Input.GetKeyDown("space"))
        {
            Instantiate(soundBounce,transform.position, transform.rotation);
            ySpeed = 0.50f;
        }
    }

}
