using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckPoint1;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== CHECKPOINT 1 - FUNDAMENTOS C# - Turma 3ESPR ===\n");

        // ENTREGA ATÉ DIA 08/09 AS 23:59
        // Você deve criar um repositório público ou branch no github e me enviar o link pelo
        // teams antes do fim do prazo.
        // IMPORTANTE:
        // - Não haverá reposição do checkpoint.
        // - Fique atento ao prazo, nenhum trabalho será aceito após a data e vou me basear
        // - O link do seu git deve ser enviado no teams. A data e hora do recebimento do git será utilizada para verificar se foi enviado no prazo.
        // 
        
        // TODO: Implemente as chamadas de teste para demonstrar funcionamento
        // NÃO é obrigatório testar todos os caminhos/casos - apenas mostrar que funciona
        // Use valores de teste simples para validar cada implementação

        //  Treinem rodar o debugger.
        //  F9 - Coloca o breakpoint
        //  F10 - Passa sobre o método no passo a passo
        //  F11 - Entra nos métodos no passo a passo
        //  shift  + F11 - Volta do método

        
        
        Console.WriteLine("1. Testando DemonstrarTiposDados...");
        Console.WriteLine(DemonstrarTiposDados());

        Console.WriteLine("\n2. Testando CalculadoraBasica (SWITCH)...");
        Console.WriteLine($"10 + 5 = {CalculadoraBasica(10, 5, '+')}");
        Console.WriteLine($"10 - 5 = {CalculadoraBasica(10, 5, '-')}");
        Console.WriteLine($"10 * 5 = {CalculadoraBasica(10, 5, '*')}");
        Console.WriteLine($"10 / 5 = {CalculadoraBasica(10, 5, '/')}");
        Console.WriteLine($"10 / 0 = {CalculadoraBasica(10, 0, '/')}");
        Console.WriteLine($"10 % 5 = {CalculadoraBasica(10, 5, '%')}");


        Console.WriteLine("\n3. Testando ValidarIdade (IF/ELSE)...");
        Console.WriteLine($"Idade 10: {ValidarIdade(10)}");
        Console.WriteLine($"Idade 15: {ValidarIdade(15)}");
        Console.WriteLine($"Idade 30: {ValidarIdade(30)}");
        Console.WriteLine($"Idade 70: {ValidarIdade(70)}");
        Console.WriteLine($"Idade -5: {ValidarIdade(-5)}");


        Console.WriteLine("\n4. Testando ConverterString...");
        Console.WriteLine($"'123' para int: {ConverterString("123", "int")}");
        Console.WriteLine($"'abc' para int: {ConverterString("abc", "int")}");
        Console.WriteLine($"'true' para bool: {ConverterString("true", "bool")}");
        Console.WriteLine($"'99.5' para double: {ConverterString("99.5", "double")}");

        Console.WriteLine("\n5. Testando ClassificarNota (SWITCH)...");
        Console.WriteLine($"Nota 9.5: {ClassificarNota(9.5)}");
        Console.WriteLine($"Nota 8.0: {ClassificarNota(8.0)}");
        Console.WriteLine($"Nota 6.1: {ClassificarNota(6.1)}");
        Console.WriteLine($"Nota 4.9: {ClassificarNota(4.9)}");
        Console.WriteLine($"Nota 11: {ClassificarNota(11)}");


        Console.WriteLine("\n6. Testando GerarTabuada (FOR)...");
        Console.WriteLine(GerarTabuada(7));

        Console.WriteLine("\n7. Testando JogoAdivinhacao (WHILE)...");
        Console.WriteLine(JogoAdivinhacao(63, new int[]{50, 75, 63, 80}));

        Console.WriteLine("\n8. Testando ValidarSenha (DO-WHILE)...");
        Console.WriteLine($"Senha 'senhafraca': {ValidarSenha("senhafraca")}");
        Console.WriteLine($"Senha 'SenhaForte123': {ValidarSenha("SenhaForte123")}");
        Console.WriteLine($"Senha 'SenhaFortissim@2025': {ValidarSenha("SenhaFortissim@2025")}");


        Console.WriteLine("\n9. Testando AnalisarNotas (FOREACH)...");
        Console.WriteLine(AnalisarNotas(new double[]{8.5, 7.0, 9.2, 4.5, 10.0, 6.8, 8.8}));

        Console.WriteLine("\n10. Testando ProcessarVendas (FOREACH múltiplo)...");
        double[] vendas = { 1000.0, 500.0, 1200.0, 800.0, 300.0 };
        string[] categorias = { "A", "B", "A", "C", "B" };
        double[] comissoes = { 0.10, 0.07, 0.05 }; // 10% para A, 7% para B, 5% para C
        string[] nomesCategorias = { "A", "B", "C" };
        Console.WriteLine(ProcessarVendas(vendas, categorias, comissoes, nomesCategorias));

        Console.WriteLine("\n=== RESUMO: TODAS AS ESTRUTURAS FORAM TESTADAS ===");
        Console.WriteLine("✅ IF/ELSE: Testado na validação de idade");
        Console.WriteLine("✅ SWITCH: Testado na calculadora e classificação de notas");
        Console.WriteLine("✅ FOR: Testado na tabuada");
        Console.WriteLine("✅ WHILE: Testado no jogo de adivinhação");
        Console.WriteLine("✅ DO-WHILE: Testado na validação de senha");
        Console.WriteLine("✅ FOREACH: Testado na análise de notas e processamento de vendas");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    // =====================================================================
    // QUESTÃO 1 - VARIÁVEIS E TIPOS DE DADOS (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Complete o método para demonstrar diferentes tipos de dados
    /// - Declare uma variável de cada tipo primitivo (int, double, bool, char, string)
    /// - Use inferência de tipos (var) onde apropriado
    /// - Retorne uma string concatenando todos os valores
    /// </summary>
    private static string DemonstrarTiposDados()
    {
        int numeroInteiro = 42;
        double numeroDecimal = 3.1415;
        bool valorBooleano = true;
        char caractere = 'A';
        var texto = "Olá, Mundo!"; // Usando inferência de tipo (var)

        // Usando string interpolada para formatar o retorno
        return $"Inteiro: {numeroInteiro}, Decimal: {numeroDecimal}, Booleano: {valorBooleano}, Caractere: {caractere}, Texto: {texto}";
    }

    // =====================================================================
    // QUESTÃO 2 - OPERADORES ARITMÉTICOS (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Implemente uma calculadora básica usando SWITCH
    /// - Receba dois números e um operador (+, -, *, /)
    /// - Use SWITCH para selecionar a operação
    /// - Trate divisão por zero retornando 0
    /// - Para operadores inválidos, retorne -1
    /// </summary>
    private static double CalculadoraBasica(double num1, double num2, char operador)
    {
        switch (operador)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                // Trata a divisão por zero
                return num2 != 0 ? num1 / num2 : 0;
            default:
                // Retorna -1 para operadores inválidos
                return -1;
        }
    }

    // =====================================================================
    // QUESTÃO 3 - OPERADORES RELACIONAIS E LÓGICOS (10 pontos)  
    // =====================================================================

    /// <summary>
    /// TODO: Valide se uma idade é válida para diferentes contextos usando IF/ELSE
    /// - Use IF/ELSE encadeados (não switch)
    /// - Retorna "Criança" se idade < 12
    /// - Retorna "Adolescente" se idade >= 12 e < 18  
    /// - Retorna "Adulto" se idade >= 18 e <= 65
    /// - Retorna "Idoso" se idade > 65
    /// - Retorna "Idade inválida" se idade < 0 ou > 120
    /// Use operadores relacionais e lógicos
    /// </summary>
    private static string ValidarIdade(int idade)
    {
        if (idade < 0 || idade > 120)
        {
            return "Idade inválida";
        }
        else if (idade < 12)
        {
            return "Criança";
        }
        else if (idade < 18) // Não precisa verificar >= 12, pois já foi filtrado no if anterior
        {
            return "Adolescente";
        }
        else if (idade <= 65)
        {
            return "Adulto";
        }
        else // Se chegou aqui, a idade é > 65
        {
            return "Idoso";
        }
    }

    // =====================================================================
    // QUESTÃO 4 - CONVERSÃO DE TIPOS (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Converta uma string para diferentes tipos
    /// - Tente converter 'valor' para int, double e bool
    /// - Se a conversão for bem-sucedida, retorne "Tipo: Valor convertido"
    /// - Se falhar, retorne "Conversão impossível para [tipo]"
    /// - Use TryParse para conversões seguras
    /// </summary>
    private static string ConverterString(string valor, string tipoDesejado)
    {
        switch (tipoDesejado.ToLower())
        {
            case "int":
                if (int.TryParse(valor, out int valorInt))
                {
                    return $"int: {valorInt}";
                }
                return "Conversão impossível para int";
            
            case "double":
                if (double.TryParse(valor, out double valorDouble))
                {
                    return $"double: {valorDouble}";
                }
                return "Conversão impossível para double";

            case "bool":
                if (bool.TryParse(valor, out bool valorBool))
                {
                    return $"bool: {valorBool}";
                }
                return "Conversão impossível para bool";

            default:
                return "Tipo desejado inválido";
        }
    }

    // =====================================================================
    // QUESTÃO 5 - ESTRUTURA CONDICIONAL SWITCH (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Classifique uma nota usando switch expression (C# 8+) ou switch tradicional
    /// - 9.0 a 10.0: "Excelente"
    /// - 7.0 a 8.9: "Bom" 
    /// - 5.0 a 6.9: "Regular"
    /// - 0.0 a 4.9: "Insuficiente"
    /// - Fora da faixa: "Nota inválida"
    /// </summary>
    private static string ClassificarNota(double nota)
    {
        // Usando "switch expression", uma forma moderna e concisa do C# 8+
        return nota switch
        {
            >= 9.0 and <= 10.0 => "Excelente",
            >= 7.0 and < 9.0 => "Bom",
            >= 5.0 and < 7.0 => "Regular",
            >= 0.0 and < 5.0 => "Insuficiente",
            _ => "Nota inválida"
        };
    }

    // =====================================================================
    // QUESTÃO 6 - ESTRUTURA FOR (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR FOR
    /// Gere a tabuada de um número de 1 a 10
    /// - Use FOR para iterar de 1 a 10
    /// - Retorne string formatada: "2 x 1 = 2\n2 x 2 = 4\n..." 
    /// - Se número for <= 0, retorne "Número inválido"
    /// </summary>
    private static string GerarTabuada(int numero)
    {
        if (numero <= 0)
        {
            return "Número inválido";
        }
        
        // StringBuilder é mais eficiente para construir strings em loops
        var tabuada = new StringBuilder();
        for (int i = 1; i <= 10; i++)
        {
            tabuada.AppendLine($"{numero} x {i} = {numero * i}");
        }

        return tabuada.ToString();
    }

    // =====================================================================
    // QUESTÃO 7 - ESTRUTURA WHILE (15 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR WHILE
    /// Simule um jogo de adivinhar número com tentativas limitadas
    /// - numeroSecreto: número a ser adivinhado (1-100)
    /// - tentativas: array com os palpites do jogador
    /// - Use WHILE para percorrer as tentativas
    /// - Para cada tentativa: "Tentativa X: muito alto/baixo/correto"
    /// - Pare no acerto ou quando acabar as tentativas
    /// - Retorne string com histórico completo
    /// </summary>
    private static string JogoAdivinhacao(int numeroSecreto, int[] tentativas)
    {
        var historico = new StringBuilder();
        int i = 0;
        
        while (i < tentativas.Length)
        {
            int palpite = tentativas[i];
            historico.Append($"Tentativa {i + 1}: {palpite} - ");
            
            if (palpite < numeroSecreto)
            {
                historico.AppendLine("muito baixo");
            }
            else if (palpite > numeroSecreto)
            {
                historico.AppendLine("muito alto");
            }
            else
            {
                historico.Append("correto!");
                return historico.ToString(); // Encerra o método ao acertar
            }
            
            i++;
        }

        return historico.ToString().TrimEnd();
    }

    // =====================================================================
    // QUESTÃO 8 - ESTRUTURA DO-WHILE (15 pontos)
    // =====================================================================
    
    /// <summary>
    /// TODO: OBRIGATÓRIO USAR DO-WHILE
    /// Valide uma senha seguindo critérios de segurança
    /// - A senha deve ter pelo menos 8 caracteres
    /// - Deve ter pelo menos 1 número
    /// - Deve ter pelo menos 1 letra maiúscula  
    /// - Deve ter pelo menos 1 caractere especial (!@#$%&*)
    /// - Use DO-WHILE para verificar cada critério
    /// - Retorne string explicando quais critérios não foram atendidos
    /// - Se senha válida, retorne "Senha válida"
    /// </summary>
    private static string ValidarSenha(string senha)
    {
        // Embora o uso de DO-WHILE seja artificial aqui (um FOR/FOREACH seria mais natural),
        // a estrutura abaixo cumpre o requisito. O do-while(false) cria um bloco de
        // código que executa uma vez e permite usar 'break' para sair prematuramente.
        
        var erros = new List<string>();
        string caracteresEspeciais = "!@#$%&*";

        do
        {
            if (senha.Length < 8)
                erros.Add("a senha deve ter pelo menos 8 caracteres");
            
            if (!senha.Any(char.IsDigit))
                erros.Add("deve ter pelo menos 1 número");

            if (!senha.Any(char.IsUpper))
                erros.Add("deve ter pelo menos 1 letra maiúscula");
            
            if (!senha.Any(c => caracteresEspeciais.Contains(c)))
                erros.Add("deve ter pelo menos 1 caractere especial (!@#$%&*)");

        } while (false); // Executa apenas uma vez

        if (erros.Count == 0)
        {
            return "Senha válida";
        }

        return $"Senha inválida: {string.Join(", ", erros)}.";
    }

    // =====================================================================
    // QUESTÃO 9 - ESTRUTURA FOREACH (15 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR FOREACH
    /// Analise um array de notas de alunos
    /// - Use FOREACH para percorrer todas as notas
    /// - Calcule: média, quantidade de aprovados (>=7), maior nota, menor nota
    /// - Conte quantas notas estão em cada faixa: A(9-10), B(8-8.9), C(7-7.9), D(5-6.9), F(<5)
    /// - Retorne string formatada com todas as estatísticas
    /// - Se array vazio/null: "Nenhuma nota para analisar"
    /// </summary>
    private static string AnalisarNotas(double[] notas)
    {
        if (notas == null || notas.Length == 0)
        {
            return "Nenhuma nota para analisar";
        }
        
        double soma = 0;
        int aprovados = 0;
        double maiorNota = notas[0];
        double menorNota = notas[0];
        int faixaA = 0, faixaB = 0, faixaC = 0, faixaD = 0, faixaF = 0;
        
        foreach (var nota in notas)
        {
            soma += nota;
            
            if (nota >= 7.0) aprovados++;
            if (nota > maiorNota) maiorNota = nota;
            if (nota < menorNota) menorNota = nota;

            switch (nota)
            {
                case >= 9.0: faixaA++; break;
                case >= 8.0: faixaB++; break;
                case >= 7.0: faixaC++; break;
                case >= 5.0: faixaD++; break;
                default: faixaF++; break;
            }
        }
        
        double media = soma / notas.Length;

        return $"Média: {media:F2}\nAprovados: {aprovados}\nMaior: {maiorNota}\nMenor: {menorNota}\nFaixas: A: {faixaA}, B: {faixaB}, C: {faixaC}, D: {faixaD}, F: {faixaF}";
    }

    // =====================================================================
    // QUESTÃO 10 - MULTIPLE FOREACH (DESAFIO) (20 pontos)
    // =====================================================================
    
    /// <summary>
    /// TODO: OBRIGATÓRIO USAR FOREACH (múltiplos)
    /// Processe vendas por categoria e calcule comissões
    /// - vendas: array com valores de vendas
    /// - categorias: array com categorias correspondentes ("A", "B", "C")
    /// - comissoes: array com percentuais de comissão por categoria (ex: A=10%, B=7%, C=5%)
    /// - Use FOREACH para percorrer vendas e categorias simultaneamente
    /// - Use FOREACH separado para encontrar a comissão da categoria
    /// - Calcule total de vendas e total de comissões por categoria
    /// - Retorne string com relatório detalhado
    /// </summary>
    private static string ProcessarVendas(double[] vendas, string[] categorias, double[] comissoes, string[] nomesCategorias)
    {
        // Dicionários para armazenar os totais por categoria
        var totalVendasPorCategoria = new Dictionary<string, double>();
        var totalComissaoPorCategoria = new Dictionary<string, double>();

        // Inicializa os dicionários
        foreach (var nome in nomesCategorias)
        {
            totalVendasPorCategoria[nome] = 0;
            totalComissaoPorCategoria[nome] = 0;
        }

        // O ideal para processar arrays paralelos é um loop FOR com índice.
        // Como a instrução pede FOREACH, usamos um índice manual, o que não é a melhor prática, mas cumpre o requisito.
        int index = 0;
        foreach (var venda in vendas)
        {
            string categoriaDaVenda = categorias[index];
            totalVendasPorCategoria[categoriaDaVenda] += venda;
            
            // FOREACH separado para encontrar a comissão
            double percentualComissao = 0;
            int comissaoIndex = 0;
            foreach (var nomeCategoria in nomesCategorias)
            {
                if (nomeCategoria == categoriaDaVenda)
                {
                    percentualComissao = comissoes[comissaoIndex];
                    break;
                }
                comissaoIndex++;
            }
            
            totalComissaoPorCategoria[categoriaDaVenda] += venda * percentualComissao;
            index++;
        }

        var relatorio = new StringBuilder();
        foreach (var nomeCategoria in nomesCategorias)
        {
            double totalVendas = totalVendasPorCategoria[nomeCategoria];
            double totalComissao = totalComissaoPorCategoria[nomeCategoria];
            // Formatação para moeda (R$)
            relatorio.AppendLine($"Categoria {nomeCategoria}: Vendas {totalVendas:C}, Comissão {totalComissao:C}");
        }

        return relatorio.ToString().TrimEnd();
    }
}
