using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.Controle;

namespace CursoCSharp {
    class Program {
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


            });

            central.SelecionarEExecutar();
        }
    }
}