using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barriers : MonoBehaviour
{
    public Sprite lowDamaged;
    public Sprite middleDamaged;
    public Sprite highDamaged;
    public BoxCollider2D boxCollider;
    public Rigidbody2D rigidbody;

    int barrierDamage = 0;
    

    // Update is called once per frame
    void Update()
    {
        BarrierSpriteChanger();
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Enemy Projectile" || collision.gameObject.tag == "Bullet")
        {
            BarrierHealth();
            
        }
    }

    public void BarrierHealth() {


        barrierDamage += 1;
        
    }

    public void BarrierSpriteChanger()
    {
        
        if (barrierDamage >= 2 && barrierDamage < 4)
        {
            this.gameObject.GetComponent<SpriteRenderer > ().sprite = lowDamaged;
            Debug.Log("low damaged");
        }
        else if(barrierDamage >= 4 && barrierDamage < 6 )
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = middleDamaged;
            Debug.Log("middle damaged");
        }
        else if(barrierDamage >= 6 && barrierDamage < 8)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = highDamaged;
            Debug.Log("high damaged");
        }
        else if(barrierDamage >= 8 )
        {
            //Destroy(gameObject);
            // Destroy(boxCollider);
            Destroy(rigidbody);
            Destroy(boxCollider);
            Destroy(gameObject);
            
            boxCollider.isTrigger = false;
            
            Debug.Log("destroyed");
        }

    }
}
