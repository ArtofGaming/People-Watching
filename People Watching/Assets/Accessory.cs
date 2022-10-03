using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewAccessory", menuName = "Accessory", order = 1)]

public class Accessory : ScriptableObject, IPerson
{
    [Range(1, 20)]
    [SerializeField] float walkSpeed;

    public GameObject accessoryPrefab;

    public float WalkSpeed
    {
        get { return walkSpeed; }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
