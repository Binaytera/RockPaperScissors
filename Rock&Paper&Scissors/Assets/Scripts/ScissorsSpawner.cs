using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorsSpawner : MonoBehaviour
{
    private Vector2 screenBounds;
    public GameObject spawnEd;
    void Start()
    {
        screenBounds = Camera.main.ScreenToViewportPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        // float x = Random.Range(5f, 10f);
        float x = 1f;
        float b = Random.Range(-2.30f, 2.30f);

        for (int i = 0; i < x; i++)
        {
            Debug.Log("Makas=" + x.ToString());
            screenBounds = new Vector2(b, transform.position.y);
            GameObject clone = (GameObject)Instantiate(spawnEd, screenBounds, Quaternion.identity);
            // GameObject a = Instantiate(SpawnEd) as GameObject;
            // a.transform.position = new Vector2(-screenBounds.x,-screenBounds.y);
        }
    }
}
