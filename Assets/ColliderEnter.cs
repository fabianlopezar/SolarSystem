using UnityEngine;

public class ColliderEnter : MonoBehaviour
{
    int contador = 0;
   
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Volumen"))
        {
            contador++;
            Debug.Log("Contador: "+contador);
        }
    }
}
