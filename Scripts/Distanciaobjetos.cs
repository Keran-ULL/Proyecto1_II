using UnityEngine;

public class DistanciaObjetos : MonoBehaviour
{
    public string etiquetaCubo = "cubo";
    public string etiquetaCilindro = "cilindro";
    public float distanciaCubo;
    public float distanciaCilindro;

    private GameObject elCubo;
    private GameObject elCilindro;

    void Start()
    {
        elCubo = GameObject.FindWithTag(etiquetaCubo);
        elCilindro = GameObject.FindWithTag(etiquetaCilindro);

        CalcularDistancias();
    }

    void Update()
    {
        float nuevaCubo = Vector3.Distance(transform.position, elCubo.transform.position);
        float nuevaCilindro = Vector3.Distance(transform.position, elCilindro.transform.position);

        if (nuevaCubo != distanciaCubo || nuevaCilindro != distanciaCilindro)
        {
            CalcularDistancias();
        }
    }

    void CalcularDistancias()
    {
        Transform tCubo = elCubo.GetComponent<Transform>();
        Transform tCilindro = elCilindro.transform;   

        distanciaCubo = Vector3.Distance(transform.position, tCubo.position);
        distanciaCilindro = Vector3.Distance(transform.position, tCilindro.position);

        Debug.Log("Distancia de la esfera al cubo: " + distanciaCubo);
        Debug.Log("Distancia de la esfera al cilindro: " + distanciaCilindro);
    }
}
