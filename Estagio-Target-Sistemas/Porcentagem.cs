using System;


  public class Ficha
  {
    //Declaração dos atributos de Ficha
    public string estado;
    public double faturamento;
    public double porcentagem;


    public Ficha(string estado, double faturamento)
    {
        this.estado = estado;
        this.faturamento = faturamento;
    }

    //Métodos da classe Ficha
    //Imprimir retorna qual a porcentagem de participação na venda referente a região em questão 
    public void Imprimir(){
        Console.WriteLine ("O(os) Estado(s) {0} possuem participação de {1:N2}% no faturamento mensal da empresa.", this.estado, this.porcentagem);
    }

    //PorceCalculo calcula qual é a porcentagem.
    public void PorceCalculo(double total_fat)
    {        
        this.porcentagem = 100 * this.faturamento/ total_fat;
        this.Imprimir();
    }
  }

  public class Program {
    public static void Main (string[] args) {
      //Intanciamento de cada Estado 
      Ficha e1 = new Ficha("SP", 67836.43);
      Ficha e2 = new Ficha("RJ", 36678.66);
      Ficha e3 = new Ficha("MG", 29229.88);
      Ficha e4 = new Ficha("ES", 27165.48);
      Ficha e5 = new Ficha("OUTROS", 19849.53);
      
      //Cáculo do valor total do faturamento mensal
      var total = e1.faturamento + e2.faturamento + e3.faturamento + e4.faturamento + e5.faturamento;

      //Calculo e impressão da porcentagem de cada Estado
      e1.PorceCalculo(total);
      e2.PorceCalculo(total);
      e3.PorceCalculo(total);
      e4.PorceCalculo(total);   
      e5.PorceCalculo(total);
    }
  }
