using System;
using UnityEngine;

public class personagem : MonoBehaviour
{
    private string nome;
    private int energia;
    private int forca;
    private int velocidade;

    public void AtribuirNome(string Nome)
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


    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
}
