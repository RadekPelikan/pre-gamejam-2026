using UnityEngine;
using System.Linq;

public class CarMovementScript : MonoBehaviour
{
    [SerializeField]private int _carMovementSpeedX;
    //public int _carMovementSpeedY;
    [SerializeField]private int _carMovementSpeedZ;
    [SerializeField]private float _carAverageSpeed;
    [SerializeField]private float _carRotationSpeed;
    private Vector3 _carMovement;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _carMovement = new Vector3(_carMovementSpeedX, 0, _carMovementSpeedZ);
        transform.Translate(_carMovement * Time.deltaTime);
        _carAverageSpeed = (_carMovementSpeedX + 0 + _carMovementSpeedZ) / 3f;

         ApplyRotation();
    }

    public void ApplyRotation()
    {
        // Auto se pohybuje doprava
        if (_carMovementSpeedX > 0)
        {
            transform.Rotate(0, _carAverageSpeed / _carRotationSpeed, 0);
        } else if (_carMovementSpeedX < 0) //Auto se pohybuje doleva
        {
            transform.Rotate(0, -_carAverageSpeed / _carRotationSpeed, 0);
        }
    }
}
