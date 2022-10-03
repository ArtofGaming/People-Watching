using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assigner : MonoBehaviour
{
    public GameObject person;
    public People peep;

    void DressUp()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        person = this.gameObject;
        peep = this.gameObject.GetComponent<People>();
        peep.hat = Resources.Load<Accessory>("Accessory/Hat1") as Accessory;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
