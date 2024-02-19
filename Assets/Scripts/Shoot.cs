using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {


    public float bulletSpeed;
    public Rigidbody2D rb;

	void Update () {

        rb.AddForce(new Vector2(bulletSpeed, 0));
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "PlayerRed")
        {
            coll.gameObject.GetComponent<PlayerRed>().TakeDamage();
        }

        if(coll.gameObject.tag == "PlayerBlue")
        {
            coll.gameObject.GetComponent<PlayerBlue>().TakeDamage();
        }
    }

    
}
