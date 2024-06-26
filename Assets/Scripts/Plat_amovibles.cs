using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Plat_amovibles : MonoBehaviour
{
    public int vitesse;
    Vector3 cible_pos;
    //la cible de la prochaine position. 
    public Transform point1;
    public Transform point2; 
    // Start is called before the first frame update
    void Start()
    {
        cible_pos = point1.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, cible_pos, vitesse*Time.deltaTime);
        if (Vector3.Distance(transform.position, cible_pos) < 0.1f)
        //permet de calculer la distance entre la plateforme et la cible, le 0.1f est la marge d'erreur
        {
            cible_pos = cible_pos == point1.position ? point2.position : point1.position;
            //condition ? expression_if_true : expression_if_false
            //Permet d'ecrire de facon concise une condition if-else au lieu de faire if(cible_pos tatata) alors tititi sinon tututu
        }
    
    }
}
