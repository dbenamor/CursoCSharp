using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferências - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritiméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternário - Fundamentos", OperadorTernario.Executar},
                //Estrutuda de controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura IF / Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura IF / Else / If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de Controle", EstruturaForeach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},
                //Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Constutores - Classes e Métodos", Construtores.Executar},
                {"Métodos com retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Read Only - Classes e Métodos", ReadOnly.Executar},
                {"Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parâmetros Por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parâmetros com valor padrão- Classes e Métodos", ParametroPadrao.Executar},
                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},
                //OO
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", construtorThis.Executar},
                {"Encapsulamento This - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo This - OO", Polimorfismo.Executar},
                {"Abstract This - OO", Abstract.Executar},
                {"Interface This - OO", Interface.Executar},
                {"Sealed This - OO", Sealed.Executar},
                //Métodos e funções
                {"Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Delegate Lambda - Métodos e Funções", DelegateLambda.Executar},
                {"Usando Delegate - Métodos e Funções", UsandoDelegate.Executar},
                {"Delgate com Funções Anôminas - Métodos e Funções", DelgateFuncAnomina.Executar},
                {"Delegates Como Parâmetros - Métodos e Funções", DelegatesComoParametros.Executar},
                {"Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},
                //Execções
                {"Primeira Exceção - Execções", PrimeiraExcecao.Executar},
                {"Execeções personalizadas - Execções", ExcecoesPersonalizadas.Executar},
                //API
                {"Primeiro Arquiivo - Usando API", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - Usando API", LendoArquivos.Executar},
                {"Exemplo FileInfo - Usando API", ExemploFileInfo.Executar},
                {"Diretórios - Usando API", Diretorios.Executar},
                {"Exemplo Directory Info - Usando API", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Usando API", ExemploPath.Executar},
                {"Exemplo DateTime - Usando API", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - Usando API", ExemploTimeSpan.Executar},
                //Tópicos Avançados
                {"LINQ #01 - Tópicos Avançados", LINQ1.Executar},
                {"LINQ #02 - Tópicos Avançados", LINQ2.Executar},
                {"Nullables - Tópicos Avançados", Nullables.Executar},
                {"Dynamic - Tópicos Avançados", Dynamics.Executar},
                {"Generics - Tópicos Avançados", Genericos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}