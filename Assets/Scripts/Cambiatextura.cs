using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cambiatextura : MonoBehaviour
{

    public Texture[] texturas;
    public float intervaloCambio = 3.21f, tActual, tInicial;
    private Renderer rend;
    private int indice = 0;

    void Start(){
        rend = GetComponent<Renderer>();
        rend.material.mainTexture = texturas[0];
        tInicial = Time.time;
    }
      void Update(){
          if (texturas.Length == 0) return;
          if (tActual <= intervaloCambio) {
              tActual = Time.time - tInicial;
          }else{ //Fin de ciclo
              tInicial = Time.time;
              tActual = 0;
              if (indice < texturas.Length - 1){
                  indice++;
              }else{
                  indice = 0;
              }
          }
          rend.material.mainTexture = texturas[indice];
      }
    

}
