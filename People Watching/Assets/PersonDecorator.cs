using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonDecorator : IPerson
{
    private readonly IPerson _decoratedPerson;
    private readonly Accessory _accessory;

    public PersonDecorator(IPerson person, Accessory accessory)
    {
        _decoratedPerson = person;
        _accessory = accessory;
    }

    public float WalkSpeed
    {
        get { return _decoratedPerson.WalkSpeed + _accessory.WalkSpeed; }
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
