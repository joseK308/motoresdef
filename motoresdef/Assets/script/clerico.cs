using UnityEngine;

public class Clerigo : Personagem
{
    [SerializeField] private string arma = "Martelo Sagrado";
    [SerializeField] private string habilidadeEspecial = "Cura Divina";
    
    public void AtribuirArma(string arma)
    {
        this.arma = arma;
    }

    public void AtribuirHabilidadeEspecial(string habilidade)
    {
        this.habilidadeEspecial = habilidade;
    }
    
    public string Arma()
    {
        return this.arma;
    }

    public string HabilidadeEspecial()
    {
        return this.habilidadeEspecial;
    }
    
    public void UsarHabilidade()
    {
        Debug.Log($"{Nome()} usa {habilidadeEspecial} com seu {arma}!");
    }
}