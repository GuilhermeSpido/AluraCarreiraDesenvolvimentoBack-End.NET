//1 Crie uma classe chamada Passagem que tenha:
//Uma propriedade pública Passageiro.
//Uma propriedade pública Destino.
//Um construtor que obrigue o preenchimento dessas informações na criação do objeto.


Passagem passagem = new Passagem("Guilherme Duarte Spido", "Caxias do Sul");

Console.WriteLine($"{passagem.Passageiro} - {passagem.Destino}");


//2 Você foi contratado(a) para desenvolver um sistema de operações bancárias.
//Cada conta precisa ter um número e um saldo inicial. E, deve existir um método para realizar depósitos, recebendo o valor a ser depositado como parâmetro.

//Crie uma classe chamada ContaBancaria que tenha:

//Uma propriedade pública NumeroConta.
//Uma propriedade pública Saldo.
//Um método Depositar(double valor) que adicione o valor ao saldo existente.
//Depois, crie uma instância da classe, realize um depósito e exiba o saldo atualizado.

ContaBancaria conta = new(123,500);
Console.WriteLine($"{conta.SaldoInicial}");
conta.DepositarDinheiro(100);
Console.WriteLine($"{conta.SaldoInicial}");


//3 Crie uma classe chamada Funcionario que tenha:

//Uma propriedade pública Nome.
//Uma propriedade pública Cargo.
//Um construtor que receba nome e cargo como parâmetros obrigatórios.
//Um método chamado Promover(string novoCargo) que atualize o cargo do funcionário, somente se o novo cargo for diferente do atual. Se for o mesmo, exiba uma mensagem de erro informando que a promoção não pode ocorrer.
//Depois, crie uma instância da classe, exiba os dados iniciais, promova o funcionário e exiba os dados atualizados.

Funcionario funcionario = new("Guilherme","clt");
funcionario.Cargo = funcionario.PromoverTeste("clt");
Console.WriteLine(funcionario.Cargo);


//4 Crie uma classe chamada Retangulo que tenha:

//Duas propriedades públicas: Altura e Largura.
//Um método chamado CalcularArea() que retorne a área do retângulo (altura × largura).
//Depois, crie um objeto da classe, atribua os valores e mostre o resultado da área na tela.

Retangulo retangulo = new(2,4);
Console.WriteLine(retangulo.CalcularArea);


//5 Crie uma classe chamada Filme que tenha:

//Propriedades públicas Titulo e ClassificacaoEtaria (int).
//Um método chamado PodeAssistir(int idadeUsuario) que retorna true se a idade for maior ou igual à classificação etária, e false caso contrário.
//Um método ExibirResultado(int idadeUsuario) que exiba uma mensagem amigável informando se o usuário pode ou não assistir ao filme.

Filme filme = new();
filme.Titulo = "teste";
filme.ClassificacaoEtaria = 16;
Console.WriteLine(filme.ExibirResultado(13));


//6 Crie uma classe chamada Produto com:

//Propriedade pública Nome.
//Campo privado quantidadeEstoque.
//Um construtor que receba o nome e a quantidade inicial.
//Um método público Retirar(int quantidade) que:
//Reduz a quantidade apenas se houver estoque suficiente.
//Exiba uma mensagem indicando o sucesso ou a falha da operação.
//Um método ExibirEstoque() para mostrar a quantidade atual.
try
{
    Produto produto = new("Guilherme",-1);
    int num = 10;
    if(produto.Retirar(num) > 1)
    Console.WriteLine(produto.MostarEstoque);
}
catch
{
    Console.WriteLine("sefodeu");
}


public class Produto
{
    public Produto(string nome, int qtdInicial)
    {
        this.Nome = nome;
        if (qtdInicial > 0)
            this.QntEstoque = qtdInicial;
        else
            throw new Exception("Inserir valor > 0");
    }
    public string Nome { get; set; }
    private int QntEstoque;
    
    public int Retirar(int quantidade) => QntEstoque >= quantidade ? QntEstoque = QntEstoque-quantidade : QntEstoque = -1;

    public string MostarEstoque => $"{QntEstoque} e {Nome} ";
}


public class Filme
{
    public string Titulo { get; set; }
    public int ClassificacaoEtaria { get; set; }

    public bool PodeAssistir(int idadeUsuario) => idadeUsuario >= ClassificacaoEtaria ? true : false;
    public string ExibirResultado(int idadeUsuario) => PodeAssistir((int)idadeUsuario) ? $"VC TEM IDADE {idadeUsuario} SUFICIENTE PARA ASSISTIR" : $"VC COM {idadeUsuario} NÁO TEM IDADE PARA ASSISITR" ; 
}


public class Retangulo
{ 
    public Retangulo(double altura, double largura)
    {
        this.Altura = altura;
        this.Largura = largura;
    }
    public double Altura { get; set; }
    public double Largura { get; set; }
    public double CalcularArea => Altura * Largura;

}



public class Funcionario
{
    public Funcionario(string nome,string cargo)
    {
        this.Nome = nome;
        this.Cargo = cargo;
    }

    public string Nome { get; set; }
    public string Cargo { get; set; }

    public string PromoverTeste(string novoCargo) => Cargo != novoCargo ? Cargo = novoCargo : Cargo + $" n atualizo";

    public void Promover(string novoCargo)
    {
        if (Cargo != novoCargo)
        {
            this.Cargo = novoCargo;
        }
    }

}


public class ContaBancaria
{
    public ContaBancaria(int numero, decimal saldoInicial)
    {
        this.Numero = numero; 
        this.SaldoInicial = saldoInicial;
    }
    public int Numero { get; set; }
    public decimal SaldoInicial { get; set; }

    public void DepositarDinheiro(decimal valor)
    {
        this.SaldoInicial += valor;
    }

}

public class Passagem
{
    public Passagem(string passageiro,string destino)
    {
        this.Passageiro = passageiro;
        this.Destino = destino;
    }

    public string Passageiro { get; set; }
    public string Destino { get; set; }

}
