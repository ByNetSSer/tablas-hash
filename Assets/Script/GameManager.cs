using UnityEngine;
using Sirenix.OdinInspector;
using System.Xml.Serialization;

public class GameManager : MonoBehaviour
{
    public MyHashTable<string, object> myHashTable;
    public string nombre;
    public int debugQuantity;
    void Start()
    {
        
    }


    [Button]
    public void ShowHashCode()
    {
        Debug.Log("Hash code : " + (nombre.GetHashCode() & 0x7FFFFFFF));
    }
    [Button]
    public void ShowHashCodeClamped()
    {
        Debug.Log("Hash code : " + Mathf.Abs((nombre.GetHashCode() & 0x7FFFFFFF) % debugQuantity));
    }
    [Button]
    public void CreateHashTable()
    {
         myHashTable = new MyHashTable<string, object>(debugQuantity);
    }
    [Button]
    public void AddString()
    {
        myHashTable.Add(nombre, nombre);
    }
    [Button]
    public void ShowAllIndices()
    {
        if (myHashTable != null)
        {
            myHashTable.printAll();
        }
        
    }
    [Button]
    public void RemoveElement(string name)
    {
        myHashTable.Remove(name);
    }
}
