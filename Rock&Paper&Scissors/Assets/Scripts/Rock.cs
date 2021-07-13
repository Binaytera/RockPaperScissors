using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public GameObject run;
    public GameObject target;
    
    public static float speed=0.8f;

    private Vector2 screenBounds;
    public Rigidbody2D spawnEd;
    public Rigidbody2D newSpawn;
    void Start()
    {
       
        // screenBounds = Camera.main.ScreenToViewportPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        screenBounds = newSpawn.transform.position;
        
    }

    void FixedUpdate()
    {
        target = GameObject.FindWithTag("Scissors");
        run = GameObject.FindWithTag("Paper");
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
            Debug.Log("Tas kaldý tek");
        }
    }

   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Paper")
        {
            if (gameObject != null)
            {
                Destroy(gameObject);
            }       
           // gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "Scissors")
        {

            Rigidbody2D clone = (Rigidbody2D)Instantiate(spawnEd, screenBounds, Quaternion.identity);
            //GameObject a = Instantiate(SpawnEd) as GameObject;
            //a.transform.position = new Vector2(screenBounds.x, screenBounds.y);
        }
    }
   */
}
