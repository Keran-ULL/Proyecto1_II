using UnityEngine;

public class CambioColor : MonoBehaviour
{
    public int framesEspera = 120;
    private float[] valores = new float[3];
    private Renderer rend;
    private int contadorFrames = 0;

    void Start()
    {
        rend = GetComponent<Renderer>();
        for (int i = 0; i < valores.Length; i++)
        {
            valores[i] = Random.Range(0.0f, 1.0f);
        }
        Color nuevoColor = new Color(valores[0], valores[1], valores[2]);
        rend.material.color = nuevoColor;
    }

    void Update()
    {
        contadorFrames++;
        if (contadorFrames >= framesEspera) {
            contadorFrames = 0;
            int indice = Random.Range(0, valores.Length);
            valores[indice] = Random.value;
            Color nuevoColor = new Color(valores[0], valores[1], valores[2]);
            rend.material.color = nuevoColor;
        }
    }
}
