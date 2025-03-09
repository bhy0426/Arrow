using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    RaycastHit hit;
    public GameObject bulletObject;
    public GameObject bulletSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 10, Color.red);
        Shoot();

        //GunFire();
    }

    private void Shoot()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletObject);
            bullet.transform.position = bulletSpawnPoint.transform.position;
            //bullet.transform.LookAt();
            //bullet.GetComponent<Rigidbody>().AddForce()
        }
    }

    //private void gunfire()
    //{
    //    if(input.getmousebuttondown(0)) 
    //    {
    //        physics.raycast(transform.position, transform.forward, out hit, mathf.infinity);
    //        if(hit.collider != null)
    //        {
    //            debug.log("hit! : " + hit.collider.name);
    //            gameobject bullet = instantiate(bulletobject);
    //            bullet.transform.position = hit.point; // raycasthit.point 레이캐스팅이 감지된 위치
    //        }
    //    }
    //}
}
