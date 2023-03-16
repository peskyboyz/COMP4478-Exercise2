using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    Main main;
    Transform tr;
    public GameObject explosionPrefab;
    private float timer = 1;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        main = GameObject.Find("Scripts").GetComponent<Main>();
    }

    void FixedUpdate()
    {
        //tr.position -= new Vector3(0f, 0.5f, 0f);

        if (tr.position.y < -20f) Destroy(this.gameObject);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Net")
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            waitForDestroy();
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            main.GameOver = true;
        }
    }
    IEnumerator waitForDestroy()
    {
        yield return new WaitForSecondsRealtime(timer);
    }
}
