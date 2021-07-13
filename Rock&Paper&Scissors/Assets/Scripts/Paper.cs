using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : MonoBehaviour
{
    public GameObject run;
    public GameObject target;

    public static float speed=0.8f;

    private Vector2 screenBounds;
    public Rigidbody2D spawnEd;
    public Rigidbody2D newSpawn;
    void Start()
    {
       
        screenBounds = newSpawn.transform.position;
    }

    void FixedUpdate()
    {
        target = GameObject.FindWithTag("Rock");
        run = GameObject.FindWithTag("Scissors");
        if (target)
        {
            transform.position += (target.transform.position - transform.position).normalized * Time.deltaTime * speed;
        }
        else if (!target)
        { }

        if (run)
        {
            transform.position -= (run.transform.position - transform.position).normalized * Time.deltaTime * speed;
        }
        else if (!run)
        { }

        if (target.gameObject == null || run.gameObject == null)
        {
            Debug.Log("Papirüs kaldý tek");
        }
    }

   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Scissors")
        {
            if (gameObject != null)
            {
                Destroy(gameObject);
            }
            // gameObject.SetActive(false);      
        }

        if (collision.gameObject.tag == "Rock")
        {
           Rigidbody2D clone = (Rigidbody2D)Instantiate(spawnEd, screenBounds,Quaternion.identity);
            //GameObject a = Instantiate(SpawnEd) as GameObject;
            //a.transform.position = new Vector2(screenBounds.x, screenBounds.y);
        }
    }
   */
}
