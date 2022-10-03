using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPersonConfig", menuName = "Person/Config", order = 1)]
public class PersonConfig : ScriptableObject, IPerson
{
    [Range(0, 20)]
    [SerializeField] private float walkSpeed;
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
