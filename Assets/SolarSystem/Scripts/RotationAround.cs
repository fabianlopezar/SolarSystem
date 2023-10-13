using UnityEngine;

public class RotationAround : MonoBehaviour
{ 
    public Transform _centerRotation; // Referencia al objeto alrededor del cual quieres rotar
    public float _speedRotation = 30.0f; // Velocidad de rotaci�n en grados por segundo

    void Update()
    {
        // Calcula el �ngulo de rotaci�n actual
        float angulo = _speedRotation * Time.deltaTime;

        // Utiliza RotateAround para girar el objeto alrededor del centro de rotaci�n
        transform.RotateAround(_centerRotation.position, Vector3.up, angulo);
    }


}
