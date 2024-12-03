using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    RaycastHit hit;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 10, Color.red);

        GunFire();
    }

    private void GunFire()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, LayerMask.GetMask());
            if(hit.collider != null)
            {
                Debug.Log("Hit! : " + hit.collider.name);
                // Instantiate()
            }
        }
    }
}
