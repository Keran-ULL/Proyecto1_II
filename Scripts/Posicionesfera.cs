using UnityEngine;

public class PosicionEsfera : MonoBehaviour
{
    public Vector3 posicion;
    private Transform miTransform;

    void Start()
    {
        Debug.Log("Posición (transform): " + transform.position);
    }

    void Update()
    {
        posicion = transform.position;
    }

    // Dibuja el texto sobre la vista 
    void OnGUI()
    {
        GUIStyle estilo = new GUIStyle(GUI.skin.label);
        estilo.fontSize = 24;
        estilo.normal.textColor = Color.white;
        GUI.Label(new Rect(20, 20, 600, 40), "Posición de la esfera: " + posicion, estilo);
    }
}
