using UnityEngine;
using TMPro;
public class ColliderEnter : MonoBehaviour
{
    int contador = 0;
    public TMP_Text texto;
    public void Start()
    {
        texto.text = "" + contador;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Volumen"))
        {
            contador++;
            Debug.Log("Contador: "+contador);
            ActualizarUI();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        contador--;
        Debug.Log("Contador: " + contador);
        ActualizarUI();
    }
    public void ActualizarUI()
    {
        texto.text =""+ contador;
    }
}
