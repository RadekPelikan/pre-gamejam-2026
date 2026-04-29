using UnityEngine;

public class CarMovementScript : MonoBehaviour
{
    public int _carMovementSpeedX;
    public int _carMovementSpeedY;
    public int _carMovementSpeedZ;
    private Vector3 _carMovement;
    private float _beforePositionX;
    private bool isInicialized = false;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _carMovement = new Vector3(_carMovementSpeedX, _carMovementSpeedY, _carMovementSpeedZ);
        transform.Translate(_carMovement * Time.deltaTime);

        //ApplyRotation();
    }

    /*public void ApplyRotation()
    {
        float _currentPositionX = transform.position.x;

        if (!isInicialized)
        {
            _beforePositionX = _currentPositionX;
            isInicialized = true;
        }

        // Auto se pohybuje doprava
        if (_currentPositionX > _beforePositionX)
        {
            transform.Rotate(0, 0.2f, 0);
        } else if (_currentPositionX < _beforePositionX) //Auto se pohybuje doleva
        {
            transform.Rotate(0, -0.2f, 0);
        }

        _beforePositionX = _currentPositionX;
    }*/
}
