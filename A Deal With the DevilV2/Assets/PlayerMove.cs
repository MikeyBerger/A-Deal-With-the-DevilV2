using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D RB;
    public Transform Pos1;
    public Transform Pos2;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (transform.position == transform.position || transform.position == Pos2.position)
        {
            transform.position = Pos1.position;
        }

        if (transform.position == Pos1.position)
        {
            transform.position = Pos2.position;
        }
        */
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Left")
        {
            transform.localScale =  new Vector3(-transform.localScale.x, transform.localScale.y, 1);
            //transform.Translate(Speed * -1, 0, 0);
            RB.velocity = new Vector2(-Speed, 0);
        }
        else if(collision.gameObject.tag == "Right")
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, 1);
            //transform.localScale = transform.localScale * -1;
            //transform.Translate(Speed, 0, 0);
            RB.velocity = new Vector2(Speed, 0);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Left")
        {
            transform.localScale = transform.localScale * -1;
            //transform.Translate(Speed * -1, 0, 0);
            RB.velocity = new Vector2(-Speed, 0);
        }
        else if (collision.gameObject.tag == "Right")
        {
            transform.localScale = transform.localScale * -1;
            //transform.Translate(Speed, 0, 0);
            RB.velocity = new Vector2(Speed, 0);
        }
    }
}
