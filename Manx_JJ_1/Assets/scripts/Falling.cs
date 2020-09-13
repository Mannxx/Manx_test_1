using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UIElements;

public class Falling : MonoBehaviour
{ 
    private float speed = 1f;
    public Rigidbody2D box;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnbox", 1.0f, 2f);
    }

    void SpawnBox()
{ 
    int numBox = 3;
    int maxBox = 0;
    for (int i=0;i<numBox;i++)
    {
        int chanse;
        chanse =Random.Range(0,2);
        if(chanse==0 && maxBox <2)
        {
        Rigidbody2D instance = Instantiate(box, transform);
        instance.velocity=Vector2.down* speed;
        instance.transform.position=instance.transform.position+Vector3.right*i;

        maxBox+=1;
    }
    }
    
}
}
