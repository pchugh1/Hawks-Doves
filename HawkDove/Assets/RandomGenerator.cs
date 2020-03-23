using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomGenerator : MonoBehaviour
{
    public TMP_InputField HawkInputField;
    public TMP_InputField DoveInputField;
    public TMP_InputField FoodInputField;
    public TMP_InputField EnergyValueFoodInputField;
    public TMP_InputField EnergyLossInjuryInputField;
    public TMP_InputField DeathThresholdInputField;
    public TMP_InputField ReproductionThresholdInputField;
    public TMP_InputField FoodExpirationTimeInputField;

    public GameObject dove;
    public GameObject hawk;
    public GameObject food;

    private Vector3 Min;
    private Vector3 Max;

    private float _xAxis;
    private float _yAxis;
    private float _zAxis;

    private Vector3 _randomPosition;
    public bool _canInstantiate;

    private void Start()
    {
        SetRanges();
    }

    private void Update()
    {


    }

    public void onStart()
    {

        for (int i = 0; i < int.Parse(HawkInputField.text); i++)
        {
            InstantiateRandomObjects(hawk);
        }
        for (int j = 0; j < int.Parse(DoveInputField.text); j++)
        {
            InstantiateRandomObjects(dove);
        }
        for (int k = 0; k < int.Parse(FoodInputField.text); k++)
        {
            InstantiateRandomObjects(food);
        }
    }

    public void onStop()
    {
        Destroy(this.gameObject);
    }

    private void SetRanges()
    {
        Min = new Vector3(0, 0, 0);
        Max = new Vector3(2, 2, 0);
    }
    private void InstantiateRandomObjects(GameObject gameObject)
    {
        _xAxis = UnityEngine.Random.Range(Min.x, Max.x);
        _yAxis = UnityEngine.Random.Range(Min.y, Max.y);
        _zAxis = 0;
        _randomPosition = new Vector3(_xAxis, _yAxis, _zAxis);
        if (_canInstantiate)
        {
            Instantiate(gameObject, _randomPosition, Quaternion.identity);
        }

    }
}