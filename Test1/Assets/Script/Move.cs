using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct MyStruct
{
    [SerializeField]

    private float _speed;

    [SerializeField]

    private bool _examplebool;

    [SerializeField]

    private string _examplestring; //se puede inicializar a "" o a null
   
    [SerializeField]

    private List<Prueba> _prueba;

}

public class Move : MonoBehaviour
{
    [SerializeField]
    private MyStruct _struct;
   
    

    [HideInInspector]

    public float _exampleFloat = 0.0f;

    private void Start()
    {
      //_struct
    }
    private void Update()
    {
        //transform.position += new Vector3(_speed, 0.0f, 0.0f)* Time.deltaTime;
    }
  
}
