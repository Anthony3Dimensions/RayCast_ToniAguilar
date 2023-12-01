using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoMcQueen : MonoBehaviour
{
    // Start is called before the first frame update
    Camera _camera;
    Vector3 pos = new Vector3(200, 200, 0);
    RaycastHit _hit;
    
    void Start()
    {
        _camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetButtonDown("Fire1"))
        {
           RayCastTest(); 
        }

        /*if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider != null)
            {
                hit.collider.enabled = false;
            }
        }*/
    }

    void RayCastTest()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if(hit.transform.gameObject.layer == 3)
            {
                Debug.Log(hit.transform.name);
            }

            else if(hit.transform.gameObject.layer == 6)
            {
                Debug.Log(hit.transform.name);
            }
        
            else if(hit.transform.gameObject.layer == 7)
            {
                Debug.Log(hit.transform.name);
            }
        }
    }

    void Movement()
    {
        /*Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            Debug.DrawLine(Camera.main.transform.position, hit.point);
        }*/
    }

    void FixedUpdate()
    {
        /*Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, 100))
        {
            Debug.DrawLine(ray.origin, hit.point);
        }*/
    }


}
