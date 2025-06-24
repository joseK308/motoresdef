using System;
using UnityEngine;

public class personagem : MonoBehaviour
{
   [SerializeField]
    private string nome;
    [SerializeField]
    private int energia;
    [SerializeField]
    private int forca;
    [SerializeField]
    private int velocidade;

    public void AtribuirNome(string nome)
    {
        this.nome = name;
    }

    public string Nome()
    {
        return this.nome;
    }

    
    public void AtribuirEnergia(int energia)
    {
        this.energia = energia;
    }

    public int Energia()
    {
        return this.energia;
    }

    public void AtribuirForca(int forca)
    {
        this.forca = forca;
    }

    public int Forca()
    {
        return this.forca;
    }


    public void AtribuirVelocidade(int velocidade)
    {
        this.velocidade = velocidade;
    }

    public int Velocidade()
    {
        return this.velocidade;
    }

    public string comparevelocidade(personagem outro)
    {
        if (this.velocidade > outro.Velocidade())
            return $"{this.nome} é mais rapido que {outro.nome}.";
        else if (this.velocidade < outro.Velocidade())
            return $"{outro.nome} é minimo que {this.nome}.";
        else
            return $"{this.nome} e {outro.nome} tem a mesma velocidade";
    }

}