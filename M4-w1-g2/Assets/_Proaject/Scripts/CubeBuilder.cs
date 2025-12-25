using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBuilder : MonoBehaviour
{

    [SerializeField] private float SizeCube;
    [SerializeField] GameObject cuboPrefab;


    [SerializeField] private float space;


    private void Start()
    {
        for (int i = 0; i < SizeCube; i++)
        {
            for (int j = 0; j < SizeCube; j++)
            {
                for (int k = 0; k < SizeCube; k++)
                {
                            if (k<=0||k>=SizeCube-1||i==0||i>=SizeCube-1 || j == 0 || j >= SizeCube - 1)
                            {
                                GameObject panello = Instantiate(cuboPrefab, transform);
                                panello.transform.position = new Vector3(gameObject.transform.position.x + space * i, gameObject.transform.position.y + space * k, gameObject.transform.position.z + space * j);
                            }       
                   
                }
            }
        }
    }
}
