using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    private float _rotationSpeed = 90.0f;
    [SerializeField]
    private float _minYPos = -10.0f;

    private void Update()
    {
        transform.eulerAngles += new Vector3(0.0f, _rotationSpeed, 0.0f) * Time.deltaTime;

        // O bien:
        // transform.eulerAngles += Vector3.up * _rotationSpeed * Time.deltaTime;
        // ya que Vector3.up es (0, 1, 0) y al multiplicar por un escalar s€lo tendr∑ efecto
        // sobre la Y, al ser el resto de componentes 0

        // O bien:
        //transform.Rotate(new Vector3(0.0f, _rotationSpeed * Time.deltaTime, 0.0f));

        if (transform.position.y <= _minYPos)
        {
            Destroy(gameObject);
        }
    }
}

