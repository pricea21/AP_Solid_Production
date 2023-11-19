using System.Collections.Generic;
using UnityEngine;

public class Switcher : MonoBehaviour
{
    public List<GameObject> ChangeableObjects;

    private List<IChangeable> _changeableObjects = new List<IChangeable>();

    private void Start()
    {
        foreach (var changeable in ChangeableObjects)
        {
            _changeableObjects.Add(changeable.GetComponent<IChangeable>());
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            foreach (var changeable in _changeableObjects)
            {
                changeable.Next();
            }
        }
    }
}

public interface IChangeable
{
    void Next();
}
