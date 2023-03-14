using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    Main main;
    Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        main = GameObject.Find("Scripts").GetComponent<Main>();
    }

    void FixedUpdate()
    {
        tr.position -= new Vector3(0f, 0.5f, 0f);

        if (tr.position.y < -20f) Destroy(this.gameObject);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Net")
        {
            Destroy(this.gameObject);
            main.ScoreAdd();
        }
    }
}
