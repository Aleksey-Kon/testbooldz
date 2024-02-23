using UnityEngine;
public class camera : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    private Vector3 _v3;  
    void Start () 
    {        
        _v3 = transform.position - _player.transform.position;
    }
    void Update() 
    {        
        transform.position = Vector3.Lerp(transform.position, _player.transform.position + _v3, Time.deltaTime * 2f);
    }
}