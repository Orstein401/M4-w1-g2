using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBuilder : MonoBehaviour
{
    //[SerializeField] GameObject cuboPrefab;
    ////righe colonne
    //[SerializeField] private float rowLine;
    //[SerializeField] private float colLine;
    //[SerializeField] private float heightLine;

    ////spazio tra le righe
    //[SerializeField] private float spaceRow;
    //[SerializeField] private float spaceCol;
    //[SerializeField] private float spaceHeight;


    //private void Start()
    //{
    //    for (int i = 0; i < rowLine; i++)
    //    {
    //        for (int j = 0; j < colLine; j++)
    //        {
    //            for (int k = 0; k < heightLine; k++)
    //            {
    //                GameObject panello = Instantiate(cuboPrefab, transform);
    //                panello.transform.position = new Vector3(gameObject.transform.position.x + spaceRow * i, gameObject.transform.position.y + spaceHeight * k, gameObject.transform.position.z + spaceCol * j);
    //            }
    //        }
    //    }

    //}

    [SerializeField] private float SizeCube;
    [SerializeField] GameObject cuboPrefab;


    [SerializeField] private float spaceRow;
    [SerializeField] private float spaceCol;
    [SerializeField] private float spaceHeight;

    private void Start()
    {
        for (int i = 0; i < SizeCube; i++)
        {
            for (int j = 0; j < SizeCube; j++)
            {
                for (int k = 0; k < SizeCube; k++)
                {
                    if (k<1||i<1||k<1)
                    {
                        GameObject panello = Instantiate(cuboPrefab, transform);
                        panello.transform.position = new Vector3(gameObject.transform.position.x + spaceRow * i, gameObject.transform.position.y + spaceHeight * k, gameObject.transform.position.z + spaceCol * j);
                    }
                   
                }
            }
        }
    }
}
