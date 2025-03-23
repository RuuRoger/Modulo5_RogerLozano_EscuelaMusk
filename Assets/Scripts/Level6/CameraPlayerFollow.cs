using UnityEngine;

public class CameraPlayerFollow : MonoBehaviour
{
    [Header("Object")]
    [SerializeField] private GameObject _player;
    [SerializeField] private float _offsetX;

    void Update()
    {
        // Actualizamos solo la posici�n X de la c�mara
        transform.position = new Vector3(_player.transform.position.x + _offsetX, transform.position.y, transform.position.z);

    }


}
