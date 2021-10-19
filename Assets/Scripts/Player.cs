using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpforce;
    public GameObject player;
    private Rigidbody rb;
    private Animation thisAnimation;

    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (player.transform.position.y < 3.65f)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                thisAnimation.Play();
                rb.velocity += Vector3.up * jumpforce;
            }
        }

    }
}
