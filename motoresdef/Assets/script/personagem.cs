using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField] private string nome;
    [SerializeField] private int energia;
    [SerializeField] private int forca;
    [SerializeField] private float velocidade;

    // Setters
    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public void AtribuirEnergia(int energia)
    {
        this.energia = energia;
    }

    public void AtribuirForca(int forca)
    {
        this.forca = forca;
    }

    public void AtribuirVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    // Getters
    public string Nome()
    {
        return this.nome;
    }

    public int Energia()
    {
        return this.energia;
    }

    public int Forca()
    {
        return this.forca;
    }

    public float Velocidade()
    {
        return this.velocidade;
    }

    // Comparação simples entre dois personagens
    public void CompararComOutro(Personagem outro)
    {
        Debug.Log($"{nome} VS {outro.Nome()}");
        Debug.Log($"{nome} - Energia: {energia}, Força: {forca}, Velocidade: {velocidade}");
        Debug.Log($"{outro.Nome()} - Energia: {outro.Energia()}, Força: {outro.Forca()}, Velocidade: {outro.Velocidade()}");

        if (forca > outro.Forca())
            Debug.Log($"{nome} é mais forte que {outro.Nome()}");
        else if (forca < outro.Forca())
            Debug.Log($"{outro.Nome()} é mais forte que {nome}");
        else
            Debug.Log($"{nome} e {outro.Nome()} têm a mesma força.");
    }
}