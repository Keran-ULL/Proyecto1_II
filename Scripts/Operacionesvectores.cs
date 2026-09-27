using UnityEngine;

public class OperacionesVectores : MonoBehaviour
{
    [Header("Vectores")]
    public Vector3 vectorA = new Vector3(1.0f, 0.0f, 0.0f);
    public Vector3 vectorB = new Vector3(1.0f, 0.0f, 0.0f);

    [Header("Resultados")]
    public float magnitudA;
    public float magnitudB;
    public float angulo;       
    public float distancia;
    public string masAlto;

    private Vector3 ultimoA;
    private Vector3 ultimoB;

    void Start()
    {
        Calcular();
        MostrarEnConsola();
    }

    void Update()
    {
        if (vectorA != ultimoA || vectorB != ultimoB) {
            Calcular();
            MostrarEnConsola();
        }
    }

    void Calcular()
    {
        // 1. Magnitud 
        magnitudA = vectorA.magnitude;
        magnitudB = vectorB.magnitude;

        // 2. Ángulo entre ambos
        angulo = Vector3.Angle(vectorA, vectorB);

        // 3. Distancia
        distancia = Vector3.Distance(vectorA, vectorB);

        // 4. La altura 
        if (vectorA.y > vectorB.y) masAlto = "El vector A está más alto";
        else if (vectorB.y > vectorA.y) masAlto = "El vector B está más alto";
        else masAlto = "Ambos vectores están a la misma altura";
        ultimoA = vectorA;
        ultimoB = vectorB;
    }

    void MostrarEnConsola()
    {
        Debug.Log("Magnitud de A: " + magnitudA);
        Debug.Log("Magnitud de B: " + magnitudB);
        Debug.Log("Ángulo entre A y B: " + angulo + "°");
        Debug.Log("Distancia entre A y B: " + distancia);
        Debug.Log(masAlto);
    }
}
