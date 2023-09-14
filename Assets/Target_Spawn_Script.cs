using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Spawn_Script : MonoBehaviour
{

    public GameObject target;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    void Start()
    {
        spawnTarget();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnTarget();
            timer = 0;
        }

    }

void spawnTarget()
{
    if (GameObject.FindGameObjectsWithTag("Target").Length >= 4)
    {
        return;
    }

    float lowestPoint = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + heightOffset;
    float highestPoint = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - heightOffset;
    float xPosition = transform.position.x;

    Vector3 spawnPosition = new Vector3(xPosition, Random.Range(lowestPoint, highestPoint), 0);
    Instantiate(target, spawnPosition, transform.rotation);
}
}
