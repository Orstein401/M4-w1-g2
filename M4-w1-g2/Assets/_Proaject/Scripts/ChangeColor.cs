using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering;

public class ChangeColor : MonoBehaviour
{
    ColorManager colorManager;
    MeshRenderer mr;

    Camera Maincamera;
    [SerializeField] private float distance = 100f;
    private void Awake()
    {
        //mr = GetComponent<MeshRenderer>();
        colorManager = FindAnyObjectByType<ColorManager>();
    }
    private void Start()
    {
        Maincamera = Camera.main;
    }

    public void CambiaStoColore()
    {
        Ray rayDir = Maincamera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(rayDir.origin, rayDir.direction * 1000, Color.yellow);

        if (Physics.Raycast(rayDir, out RaycastHit hitInfo))
        {
            if (hitInfo.collider.gameObject.CompareTag("Panello"))
            {
                //ChangeColor panello= hitInfo.collider.gameObject.GetComponent<ChangeColor>();
                //panello.mr.material.color = colorManager.color;
                mr=hitInfo.collider.gameObject.GetComponent<MeshRenderer>();
                mr.material.color = colorManager.color;

            }

        }
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            mr.material.SetColor("_BaseColor", Color.white);
        }

        if (Input.GetMouseButtonDown(0))
        {
            CambiaStoColore();
        }
    }
}
