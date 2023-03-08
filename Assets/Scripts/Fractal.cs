using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fractal : MonoBehaviour
{
    [SerializeField]
    private GameObject cubePrefab;

    [SerializeField]
    private int iteration;

    [SerializeField]
    private float size,newT = 0;

    List<GameObject> kelly = new List<GameObject>();
    void Start()
    {
       
        //  This statement create a game object given a prefab, position and rotation.
        Instantiate(cubePrefab, new Vector3(0, 0, 0),Quaternion.identity);
        cubePrefab.transform.localScale = new Vector3(size,size,size);
        newT = (size)+2;
        makeAgain(iteration);
    }
    void makeAgain(int iteration)
    {
        for (int i = 1; i < iteration; i++)
        {

            Instantiate(cubePrefab, new Vector3(newT, 0, 0), Quaternion.identity);
            cubePrefab.transform.localScale = new Vector3(size, size, size);
           kelly.Add(cubePrefab);
          
                foreach(var cubePrefab in kelly)
            {
                Destroy(cubePrefab);
            }


            newT += size*2;
        }

      
    }
    
}
