using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassScorePoint : MonoBehaviour
{
   
    private void OntriggerEnter(Collider other)
    {
        GameManager.singleton.AddScore(1);
    }


}
