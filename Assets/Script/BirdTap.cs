using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdTap : MonoBehaviour 
{
    public float ySpeed;
    public float yTarget;
    public GameObject soundBounce;
    
    private Animator animator;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    private void Update()
    {
        transform.Translate(0, ySpeed, 0);
        ySpeed = Mathf.Lerp(ySpeed, yTarget, 0.25f);
        
        // Check for touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); // Get the first touch
            
            if (touch.phase == TouchPhase.Began) // When finger first touches the screen
            {
                Instantiate(soundBounce, transform.position, transform.rotation);
                ySpeed = 0.50f;
                
                if (animator != null)
                {
                    animator.SetBool("Fly", true);
                }
            }
            else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled) // When finger is lifted
            {
                if (animator != null)
                {
                    animator.SetBool("Fly", false);
                }
            }
    }

     #if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(soundBounce, transform.position, transform.rotation);
            ySpeed = 0.50f;
            
            if (animator != null)
            {
                animator.SetBool("Fly", true);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (animator != null)
            {
                animator.SetBool("Fly", false);
            }
        }
        #endif
    
    }}