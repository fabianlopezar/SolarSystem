using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operaciones : MonoBehaviour
{
    private Transform targetTransform;

    private void Start()
    {
        // Obtén la referencia al Transform del objeto que deseas transformar
        targetTransform = transform;
    }

    public void Translate(float x, float y, float z)
    {
        // Calcula y aplica la matriz de traslación
        Vector3 translation = new Vector3(x, y, z);
        targetTransform.Translate(translation);
    }

    public void RotateX(float angle)
    {
        // Calcula y aplica la rotación en el eje X
        targetTransform.Rotate(Vector3.right, angle);
    }

    public void RotateY(float angle)
    {
        // Calcula y aplica la rotación en el eje Y
        targetTransform.Rotate(Vector3.up, angle);
    }

    public void RotateZ(float angle)
    {
        // Calcula y aplica la rotación en el eje Z
        targetTransform.Rotate(Vector3.forward, angle);
    }

    public void Scale(float scaleX, float scaleY, float scaleZ)
    {
        // Calcula y aplica la escala
        Vector3 scale = new Vector3(scaleX, scaleY, scaleZ);
        targetTransform.localScale = scale;
    }
}


