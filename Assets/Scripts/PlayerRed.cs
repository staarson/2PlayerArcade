using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRed : MonoBehaviour {

    public float r_Speed;
    public Rigidbody2D r_rb;

    public int hp;

    void FixedUpdate()
    {

        #region Move

        float x = Input.GetAxis("Horizontal2") * r_Speed;
        r_rb.AddForce(new Vector2(x, 0));

        #endregion

    }

    public void TakeDamage()
    {

        GetComponent<PlayerBlue>().hp -= 1;

    }

}
