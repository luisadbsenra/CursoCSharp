using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.Controle;
using CursoCSharp.Classe;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosFuncoes;
using CursoCSharp.ErroExc;
using CursoCSharp.API;

namespace CursoCSharp {
    class Program {

        // passar parametros no terminal - string[] args
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()  {
                // fundamentos
                { "Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                { "Comentários - Fundamentos", Comentarios.Executar1},
                { "Variaveis e Constantes - Fundamentos", VariaveisEConstate.variaveis},
                { "Inferencia (declarar) - Fundamentos", Inferencia.twoMain},
                { "Interpolação (variaveis) - Fundamentos", Interpolação.Do},
                { "Notação Ponto - Fundamentos", NotacaoPonto.fazer},
                { "Lendo dados do CMD - Fundamentos", LendoDados.doo},
                { "Formatando Números - Fundamentos", FormatandoNumero.realizar},
                { "Conversões - Fundamentos", Conversoes.Make},
                { "Operadores Aritimético - Fundamentos", OperadoresAritmeticos.made},
                { "Operadores Relacinais - Fundamentos", OperadoresRelacionais.fazer},
                { "Operadores Lógicos - Fundamentos", OperadoresLógicos.DO},
                { "Operadores Atribuição - Fundamentos", OperadoresAtribuicao.exe},
                { "Operadores Unários - Fundamentos", OperadoresUnários.dotex},
                { "Operadores Tenarios - Fundamentos", OperadorTenario.opdot},
                // estruturas de controle
                { "If/Else - Controle", UsingIfElse.executar},
                { "Elif - Controle", Elif.dodo},
                { "Switch - Controle", sswitch.ex},
                { "While - Controle", wwhile.exe},
                { "Do While - Controle", dowhile.ece},
                { "For - Controle", foor.doda},
                { "Foreach - Controle", fforeach.name},
                { "Break - Controle", breeak.bb},
                // classes e metodos
                { "Membro - Classes", Membros.ex},
              //  { "Construtor - Classes", Construtor.},
                { "Metodos com Retorno - Classes", MetodosRetorno.Exe},
                { "Metodos Estatico - Classes", MetodosEstaticos.Exe},
                { "Atributos Estatico - Classes", AtributoEstatico.Exe},
                { "Desafio - Classes", DesafioAtributo.Ex},
                { "Params - Classes", Parametros.exe},
                { "Params No - Classes", ParamNo.Exe},
                { "GetSet - Classes", GetSet.ex},
                { "Propiedade - Classes", Propi.Ex},
                { "Readonly - Classes e Métodos", Readonly.Executar},
                { "Enumeração - Classes e Métodos", ExemploEnum.executar},
                { "Struct - Classes e Métodos", ExemploStruct.Execu},
                { "Struct e Classes - Classes e Métodos", StructClasse.Exe},
                { "Valor e Referência - Classes e Métodos", ValorRef.ec},
                { "Paramentro por Referência - Classes e Métodos", ParamRed.Som},
                { "Parametro Padrão - Classes e Métodos", ParamPad.Exe},
                // Coleções

                { "Array - Colecoes", AArray.exe},
                { "Lista - Colecoes", Lista.exe},
                { "ArrayList - Colecoes", ArrayLista.exe},
                { "Set - Coleções", ColocoesSet.exe},
                { "Queue Fila - Coleções", FilaQueue.Exe},
                { "Igualdade - Coleções", Igualdade.ex},
                { "Stack - Coleções", aStack.exe},
                { "Dictionary - Coleções", ColDict.Exe},


                // OO
                {"Herança - Orientação ao Objeto", Heranca.Executar},
                {"Construtor this - Orientação ao Objeto", ConstrutorThis.Exe},
                {"Parametros - Orientação ao Objeto", Polimorfismo.Exe},
                {"Abstract - Orientação ao Objeto", Abstrato.Abs},
                {"Interface - Orientação ao Objeto", Interfacew.Exe},
                {"Sealed - Orientação ao Objeto", Sealed.A},

                // Métodos e Funções
                {"Lambda - Metodos e Funções", Lambdaa.wxe},
                {"Delegate - Metodos e Funções", LambdaDel.exee},
                {"Delegate Anônimo - Metodos e Funções", DelAno.exeee},
                {"Delegate Paramatro - Metodos e Funções", DelPar.Exe},
                {"Metodos de Extensão - Metodos e Funções", MetodoExt.Exe},


                // Erros e Exeções
                {"Exeções - Erros", ExceErro.Exe},
                {"Exeções Erro - Erros", ExecoesPerso.Exec},


                //API
                {"Diretorios - API", First.Exe},
                {"Lendo - API", LendoArquivos.Exe},


            }); ;

            central.SelecionarEExecutar();
        }
    }
}