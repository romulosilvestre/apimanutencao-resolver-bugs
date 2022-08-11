namespace VoeAirlines.Entities;

public class Manutencao{
    public Manutencao(DateTime dataHora, string observacao, int aeronaveId)
    {
        
        DataHora = dataHora;
        Observacao = observacao;
        AeronaveId = aeronaveId;
    }

    //Gera Construtor desses aqui
    public int Id { get; set; }
   public DateTime DataHora { get; set; }

   public string Observacao { get; set; }
   public int AeronaveId { get; set; }
   
   //Não gera construtor
   public Aeronave Aeronave { get; set; }=null!;



}

