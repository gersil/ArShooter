using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{

    public GameObject arCamera;
    public GameObject smoke;

    // Start is called before the first frame update
    public void Shoot()
    {
        RaycastHit hit;

        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if(hit.transform.name == "RubberDuck_Pond_MOBILE(Clone)" || hit.transform.name == "RubberDuck_White_MOBILE(Clone)" || hit.transform.name == "RubberDuck_Yellow_MOBILE(Clone)")
            {
                Destroy(hit.transform.gameObject);

                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));

            }
        }
    }

}
