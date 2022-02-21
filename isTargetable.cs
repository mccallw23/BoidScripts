using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isTargetable : MonoBehaviour
{

    public Rigidbody rb;
    public bool isTargetableBool;
    // Start is called before the first frame update
    void Start()
    {
        isTargetableBool = false;
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((this.transform.position - this.transform.parent.position).sqrMagnitude < 1)
        {
            isTargetableBool = false;
            rb.useGravity = false;
            

        }
        else 
        {isTargetableBool = true;
        rb.useGravity = true;}
        
    }


public Vector3 scaleChange = new Vector3(-.03f,-.03f,-.03f);
     
     private void OnTriggerEnter(Collider other)
    {
      
        
        this.transform.localScale += scaleChange;
        
        if(this.transform.localScale.x < .03)
        {
            this.transform.position = this.transform.parent.position;
            this.transform.localScale = new Vector3(.2f,.2f,.2f);
            rb.useGravity = false;

        }
    }
}
