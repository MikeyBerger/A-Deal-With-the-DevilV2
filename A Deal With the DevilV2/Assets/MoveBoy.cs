using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoy : MonoBehaviour
{
    public float Speed;
    public float BoxSpeed;
    private Transform BS;
    public bool IsFalling = false;
    private Rigidbody2D RB;

    // Start is called before the first frame update
    void Start()
    {
        BS = GameObject.FindGameObjectWithTag("Box").GetComponent<Transform>();
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Speed, 0, 0);
        RB.velocity = new Vector2(Speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Speed = 0;
        //transform.Translate(0, 0, 0);
        RB.velocity = Vector2.zero;
        //BS.Speed = BoxSpeed;
        IsFalling = true;
    }
}
