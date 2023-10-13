using UnityEngine;

public class RotationAround : MonoBehaviour
{ 
    public Transform _centerRotation; // Referencia al objeto alrededor del cual quieres rotar
    public float _speedRotation = 30.0f; // Velocidad de rotación en grados por segundo

    void Update()
    {
        // Calcula el ángulo de rotación actual
        float angulo = _speedRotation * Time.deltaTime;

        // Utiliza RotateAround para girar el objeto alrededor del centro de rotación
        transform.RotateAround(_centerRotation.position, Vector3.up, angulo);
    }


}
