namespace ExercicioIdade.Models;

public class Pessoa{

    // Definindo Propriedades

    private string _nome;
    public string Nome
    {
        get { return _nome; }
        set { _nome = value.ToUpper(); }
    }

    private int _idade;
    public int Idade
    {
        get { return _idade; }
        set {

            if(value >= 0 ){

                _idade = value;
            }
            else {
                this._idade = 0;
            }
        }
    }

    // Definindo Construtores

    public Pessoa(){

    }

    public Pessoa(string nomePessoa, int idadePessoa){
        this.Nome = nomePessoa; // minha propriedade nome começa vazia
        this.Idade = idadePessoa; // minha propriedade idade começar zerada
    }

    // Definindo Metodos ou Funções

    public void ExibirDados(){
        Console.WriteLine($"O mais velho é A primeira pessoa {this.Nome} com a idade de {this.Idade}");
    
    }
}