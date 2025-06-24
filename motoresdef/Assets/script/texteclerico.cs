using UnityEngine;

public class texteclerico : MonoBehaviour
{
    [SerializeField]
    public clerico clerico1;
    [SerializeField]
    public clerico clerico2;

    void Start()
    {
        clerico1 = new clerico();
        clerico1.Nome();
        clerico1.Energia();
        clerico1.Forca();
        clerico1.Velocidade();
        clerico1.ArmaEspecial();
        clerico1.HabilidadeEspecial();


        clerico2 = new clerico();
        clerico2.Nome();
        clerico2.Energia();
        clerico2.Forca();
        clerico2.Velocidade();
        clerico2.ArmaEspecial();
        clerico2.HabilidadeEspecial();

        Debug.Log($"clerico1: {clerico1.Nome()}, ArmaEspecial: {clerico1.ArmaEspecial()}, HabilidadeEspecial: {clerico1.HabilidadeEspecial()}");
        Debug.Log($"clerico2: {clerico2.Nome()}, ArmaEspecial: {clerico2.ArmaEspecial()},habilidadeEspecial: {clerico2.HabilidadeEspecial()}");

    }
}
