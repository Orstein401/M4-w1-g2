using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    [SerializeField] ColorManager colorManager;
    MeshRenderer mr;

    

    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
    }
    private void OnMouseDown()
    {
        colorManager.color = mr.material.color;
        colorManager.SetColorManager(mr.material.color);
    }

    //private void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        Debug.Log("è stato premuto il tasto sinistro");
    //        Ray rayDir= Maincamera.ScreenPointToRay(Maincamera.transform.position);
    //        Debug.DrawRay(rayDir.origin, rayDir.direction * 100, Color.yellow);
    //        if (Physics.Raycast(Maincamera.transform.position, rayDir.direction, distance))
    //        {
    //            Debug.Log("ho colpito");
    //        }
    //        //if(Physics.Raycast(transform.position,Vector3.down, out RaycastHit hitInfo, distance))
    //        //{
    //        //    Debug.Log("qualcosa ha colpito");
    //        //    if (hitInfo.collider.gameObject.name == "Pannello")
    //        //    {
    //        //        Debug.Log("solo i panelli");
    //        //        colorManager.color = mr.material.color;
    //        //        colorManager.SetColorManager(mr.material.color);
    //        //    }
    //        //}


    //    }
}

