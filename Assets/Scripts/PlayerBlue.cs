using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlue : MonoBehaviour {

    public float b_Speed;
    public Rigidbody2D b_rb;

    public int hp;

    public GameObject bulletclone;
    public GameObject bulletPrefab;
    public Transform playerTransform;

	void FixedUpdate () {

        #region Move

        float x = Input.GetAxis("Horizontal1") * b_Speed;
        b_rb.AddForce(new Vector2(x, 0));

        #endregion

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //bulletclone = Instantiate(bulletPrefab, playerTransform.position, playerTransform.rotation);
        }
    }

    public void TakeDamage()
    {

        GetComponent<PlayerRed>().hp -= 1;

    }

}
