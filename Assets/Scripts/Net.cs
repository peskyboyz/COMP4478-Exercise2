using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Net : MonoBehaviour
{
    Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("right") || Input.GetKey(KeyCode.D))
        {
            if (tr.position.x < 35f) tr.position += new Vector3(1.25f, 0f, 0f);
        }
        if (Input.GetKey("left") || Input.GetKey(KeyCode.A))
        {
            if (tr.position.x > -35f) tr.position += new Vector3(-1.25f, 0f, 0f);
        }
    }
}
