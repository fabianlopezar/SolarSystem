using System.Collections;
using UnityEngine;

public class RandomGeneratorElements : MonoBehaviour
{
    public Transform pos;
    public GameObject[] objsInstaciados;
    public GameObject obj1;
    public bool t=true;

    
    void Start()
    {
        StartCoroutine(Iniciar1());
    }
      void Update()
    {
        
    }
    public GameObject instanciarObjs()
    {
        int n = Random.Range(0, objsInstaciados.Length);
        GameObject obj = Instantiate(objsInstaciados[n], pos.position, objsInstaciados[n].transform.rotation);
        return obj;
    }
    IEnumerator Iniciar1()
    {
    
        while (t)
        {
            yield return new WaitForSeconds(3);
            obj1 = instanciarObjs();
        }
        yield return null;

    }
    public void StopObjects()
    {
      
        t = false;
    }
}
