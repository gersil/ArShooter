using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckScript : MonoBehaviour
{
    private float factor;
    private Vector3 direction;
    private float startTime;
    public GameObject particle;

    private void Start()
    {
        startTime = Time.time;

    }
    // Update is called once per frame
    void Update()
    {
        if (name.Contains("Yellow"))
        {
            factor = 0.2f;
            direction = new Vector3(0, 0, 1);
        } else if (name.Contains("White"))
        {
            factor = 0.5f;
            direction = new Vector3(0, 1, 1);

        }
        else if (name.Contains("Pond"))
        {
            factor = 1f;
            direction = new Vector3(1, 1, 1);

        }
        else if (name.Contains("Red"))
        {
            factor = 0.8f;
            direction = new Vector3(-1, 0, 1);

        }

        transform.Translate(direction * Time.deltaTime * factor);

        float timeElapsed = Time.time - startTime;
        if (timeElapsed >= 8)
        {

            Destroy(transform.gameObject);

            Instantiate(particle, transform.gameObject.transform.position, transform.gameObject.transform.rotation);

        }

    }
}
