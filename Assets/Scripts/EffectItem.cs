using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EffectItem : MonoBehaviour
{

    public float RotationY;
    public float RotationZ;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


    private void FixedUpdate()
    {
        gameObject.transform.Rotate(new Vector3(0, RotationY, RotationZ));
    }

}
