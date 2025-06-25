using UnityEngine;

public class TesteClerigo : MonoBehaviour
{
    public Clerigo clerigo1;
    public Clerigo clerigo2;

    void Start()
    {
        // Inicializando o primeiro clérigo
        clerigo1.AtribuirNome("Luz Sagrada");
        clerigo1.AtribuirEnergia(80);
        clerigo1.AtribuirForca(15);
        clerigo1.AtribuirVelocidade(6.5f);
        clerigo1.AtribuirArma("Martelo Sagrado");
        clerigo1.AtribuirHabilidadeEspecial("Cura Divina");

        // Inicializando o segundo clérigo
        clerigo2.AtribuirNome("Guardião da Fé");
        clerigo2.AtribuirEnergia(70);
        clerigo2.AtribuirForca(18);
        clerigo2.AtribuirVelocidade(5.8f);
        clerigo2.AtribuirArma("Cajado de Luz");
        clerigo2.AtribuirHabilidadeEspecial("Benção de Cura");

        // Mostrando informações no console
        Debug.Log("== CLÉRIGO 1 ==");
        Debug.Log($"Nome: {clerigo1.Nome()}");
        Debug.Log($"Energia: {clerigo1.Energia()}");
        Debug.Log($"Força: {clerigo1.Forca()}");
        Debug.Log($"Velocidade: {clerigo1.Velocidade()}");
        Debug.Log($"Arma: {clerigo1.Arma()}");
        Debug.Log($"Habilidade: {clerigo1.HabilidadeEspecial()}");

        Debug.Log("== CLÉRIGO 2 ==");
        Debug.Log($"Nome: {clerigo2.Nome()}");
        Debug.Log($"Energia: {clerigo2.Energia()}");
        Debug.Log($"Força: {clerigo2.Forca()}");
        Debug.Log($"Velocidade: {clerigo2.Velocidade()}");
        Debug.Log($"Arma: {clerigo2.Arma()}");
        Debug.Log($"Habilidade: {clerigo2.HabilidadeEspecial()}");

        // Comparar e usar habilidades
        clerigo1.CompararComOutro(clerigo2);
        clerigo1.UsarHabilidade();
        clerigo2.UsarHabilidade();
    }
}