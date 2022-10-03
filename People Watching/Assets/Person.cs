using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : IPerson
{
    public float WalkSpeed
    {
        get { return _config.WalkSpeed; }
    }
    private readonly PersonConfig _config;
    public Person(PersonConfig personConfig)
    {
        _config = personConfig;
    }
}
