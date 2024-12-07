using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellScript : MonoBehaviour {

    public GameObject wallL;
    public GameObject wallR;
    public GameObject wallU;
    public GameObject wallD;

    private void Start()
    {
        wallD.AddComponent<PolygonCollider2D>();
        wallR.AddComponent<PolygonCollider2D>();
        wallL.AddComponent<PolygonCollider2D>();
        wallU.AddComponent<PolygonCollider2D>();

        wallD.AddComponent<Rigidbody2D>();
        wallR.AddComponent<Rigidbody2D>();
        wallL.AddComponent<Rigidbody2D>();
        wallU.AddComponent<Rigidbody2D>();

        wallD.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        wallR.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        wallL.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        wallU.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
    }

    private void AddCompoenent()
    {
        wallD.AddComponent<PolygonCollider2D>();
        wallR.AddComponent<PolygonCollider2D>();
        wallL.AddComponent<PolygonCollider2D>();
        wallU.AddComponent<PolygonCollider2D>();
    }
}
