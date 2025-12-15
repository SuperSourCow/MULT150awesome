using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwesomeAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Animator animator = GetComponent<Animator>();
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("Color");
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("Scale");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("Rotation");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("Position");
        }
    }
}
