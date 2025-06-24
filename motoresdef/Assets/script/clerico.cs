using UnityEngine;
[System.Serializable]
public class clerico : personagem
{ 
    [SerializeField]
    private string armaespecial = "Martelo sagrado";
    [SerializeField]
    private string habilidadeespecial = "cura divina";


    public void armaEspecial()
    {
        this.armaespecial = "Martelo sagrado";
    }

    public string ArmaEspecial()
    {
        return this.armaespecial;
    }

    public void habilidadeEspecial()
    {
        this.habilidadeespecial = "cura divina";
    }

    public string HabilidadeEspecial()
    {
        return this.habilidadeespecial;
    }
    
    
}
