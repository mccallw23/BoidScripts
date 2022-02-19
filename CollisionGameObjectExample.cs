using UnityEngine;
public class CollisionGameObjectExample : MonoBehaviour
{

    Vector3 scaleChange = new Vector3(-0.05f, -0.05f, -0.05f);

    public GameObject obj;
    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
    if(obj.transform.localScale.y > 0.1f){
            obj.transform.localScale += scaleChange;
    }
    else
    {
        obj.transform.localScale = new Vector3(2,2,2);
    }
    }
}