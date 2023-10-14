
using UnityEngine;

public class Rotation1 : MonoBehaviour
{
    public float angle=1.5f;

    // Start is called before the first frame update
    void Start()
    {
     
    }
    
    // Update is called once per framejfosfdfdf
    void Update()
    {
        angle += Time.deltaTime * 5;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
    }
}
