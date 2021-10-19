using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        if(player.transform.position.y < -4.56f)
        {
            SceneManager.LoadScene("GameOverScene");
        }

    }

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
