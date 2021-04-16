using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGirl : MonoBehaviour
{
    private DialogManagerScript DMS;
    public Transform Girl;
    public Transform Book;
    public float Speed;

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        DMS = GameObject.FindGameObjectWithTag("DialogManager").GetComponent<DialogManagerScript>();
        Book.transform.gameObject.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (DMS.DickonsIndex == 1)
        {
            Girl.Translate(Speed, 0, 0);
        }

        if (DMS.DevilIndex == 3)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            Book.transform.gameObject.active = true;
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
}
