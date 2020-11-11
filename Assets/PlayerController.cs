using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator playerAnim;

    float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            playerAnim.SetBool("isStrafe", true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.SetBool("isStrafe", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnim.SetTrigger("isAttack");
        }
    }

}

        
    
      
    
