using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{

    public GameObject arCamera;
    public GameObject smoke;
    public AudioSource shotSound;

    // Start is called before the first frame update
    public void Shoot()
    {
        RaycastHit hit;

        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if(hit.transform.tag == "GoodDuck" || hit.transform.tag == "BadDuck")
            {
                Destroy(hit.transform.gameObject);

                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
                if (hit.transform.tag == "GoodDuck")
                {
                    ScoreScript.scoreVal += 1;
                }
                else if (hit.transform.tag == "BadDuck")
                {
                    ScoreScript.scoreVal -= 1;
                }
            }
        }
    }
    public void playSoundEffect()
    {
        shotSound.Play();
    }
}
