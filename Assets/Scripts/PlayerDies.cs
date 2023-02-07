using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDies : MonoBehaviour
{
    [SerializeField] private Animator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnimator.SetTrigger("Death");
            Debug.Log("Space key was pressed.");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            playerAnimator.ResetTrigger("Death");
            Debug.Log("Space key was released.");
        }
    }
}
