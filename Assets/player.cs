using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    float vertical, horizontal;
    public float playerSpeed;
    private float horizontalScreenLimit = 5f;
    private float verticalScreenLimit = 3.8f;

    private bool isDead;

    public GameManagerScript gameManager;
    // Start is called before the first frame update
    void Start()
    {
        playerSpeed = 6f;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    
     void Movement()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * Time.deltaTime * playerSpeed);
        if (transform.position.x > horizontalScreenLimit)
        {
            transform.position = new Vector3(horizontalScreenLimit, transform.position.y, 0);
        }
        if (transform.position.x <= -horizontalScreenLimit)
        {
            transform.position = new Vector3(-horizontalScreenLimit, transform.position.y, 0);
        }
        if (transform.position.y < -verticalScreenLimit)
        {
            transform.position = new Vector3(transform.position.x, -verticalScreenLimit, 0);
        }
        else if (transform.position.y >= verticalScreenLimit)
        {
            transform.position = new Vector3(transform.position.x, verticalScreenLimit, 0);
        }
    }
     private void OnTriggerEnter2D(Collider2D whatIHit)
    {
        if (whatIHit.tag == "enemy" || !isDead)
        {
            Destroy(this.gameObject);
            Debug.Log("Dead");
            gameManager.gameOver();
            isDead = true;
        }
    }           
}