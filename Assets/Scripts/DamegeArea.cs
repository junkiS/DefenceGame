using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamegeArea : MonoBehaviour {


    void OnTriggerExit2D(Collider2D damege)
    {

        Destroy(damege.gameObject);
        Debug.Log("Damege Area");
    }
}
