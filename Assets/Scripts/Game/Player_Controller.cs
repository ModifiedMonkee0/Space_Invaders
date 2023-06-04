using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float moveSpeed = 5;
    public float hInput;
    public GameObject projectilePrefab;
    private Animator animator;
    public float fireRate;
    float nextFire;
    // Start is called before the first frame update
    void Start()
    {
        animator =this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
        hInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * hInput* moveSpeed * Time.deltaTime);

        
        if (Input.GetButtonDown("Fire1"))
        {
            if(Time.time> nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            }
           
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetInteger("Speed", 1);
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetInteger("Speed", -1);
        }
        else
        {
            animator.SetInteger("Speed", 0);
        }
        

    }
}
