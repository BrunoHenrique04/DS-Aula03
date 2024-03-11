using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula03Colecoes.Models.Enuns;

namespace Aula03Colecoes.Models
{
public class Funcionario
{ 

//Atributos

public  int Id {get; set;}
public string Nome { get; set; } = string.Empty;
public string Cpf { get; set; } = string.Empty;
public DateTime Datadeadimissao { get; set; }
public decimal Salario { get; set; }
public TipofuncionarioEnum Tipofuncionario{ get; set; }

//Metodos
public void Reajustarsalario()
{
    Salario = Salario + (Salario * 10/100);
}
public decimal CalcularDescontoVT(decimal percentual)
{
    decimal desconto = this.Salario * percentual/100;
    return desconto;
}

public string ExibirPeriodoExeperiencia()
{
    string periodoExeperiencia = 
    string.Format("Periodo de Exeperiencia: {0} até {1}", Datadeadimissao, Datadeadimissao.AddMonths(3));
    return periodoExeperiencia;
}
}
}