using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public float Speed;
    public float NewSpeed;
    private Rigidbody2D RB;
    private MoveBoy MB;
    private SpriteRenderer SR;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        MB = GameObject.FindGameObjectWithTag("Book").GetComponent<MoveBoy>();
        SR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0, Speed, 0);
        RB.velocity = new Vector2(0, Speed);
        if (MB.IsFalling)
        {
            Speed = NewSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Book")
        {
            SR.color = Color.red;
            Destroy(collision.gameObject);
        }
        
    }
}
