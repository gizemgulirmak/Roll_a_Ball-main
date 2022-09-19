using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControll : MonoBehaviour
{
    public float speed;
    private Rigidbody mybody;
    public int puan;
    public int ObjeSayisi;
    public Text puantext;
    public Text oyunbittitext;

    
    // Start is called before the first frame update
    void Start()
    {
        mybody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
     

        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 vector = new Vector3(yatay, 0, dikey);

        mybody.AddForce(vector*speed);

    }
     void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        puan++;
        puantext.text = "Puan:" + puan;

        if (puan == ObjeSayisi)
        {
            oyunbittitext.gameObject.SetActive(true);
        }

    }
}
