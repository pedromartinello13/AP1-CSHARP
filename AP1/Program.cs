using System;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            // Solicitar informações ao usuário
            Console.WriteLine("Digite o seu nome:"); // Solicita o nome do usuário
            string nome = Console.ReadLine(); // Lê o nome digitado pelo usuário e armazena na variável 'nome'

            Console.WriteLine("Digite a sua idade:");
            int idade;
            // Loop de validação para garantir que a idade seja um número inteiro positivo
            while (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
            {
                Console.WriteLine("Idade inválida. Por favor, digite novamente:"); // Solicita uma nova entrada de idade caso seja inválida
            }

            Console.WriteLine("Digite sua altura (em metros):");
            double altura;
            // Loop de validação para garantir que a altura seja um número positivo
            while (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0)
            {
                Console.WriteLine("Altura inválida. Por favor, digite novamente:"); // Solicita uma nova entrada de altura caso seja inválida
            }

            Console.WriteLine("Digite o seu peso (em quilogramas):");
            double peso;
            // Loop de validação para garantir que o peso seja um número positivo
            while (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0)
            {
                Console.WriteLine("Peso inválido. Por favor, digite novamente:"); // Solicita uma nova entrada de peso caso seja inválido
            }

            // Calcular IMC
            double imc = peso / (altura * altura); // Calcula o IMC usando a fórmula: peso / (altura * altura)

            // Determinar categoria de IMC
            string categoriaIMC;
            if (imc < 18.5)
                categoriaIMC = "Abaixo do peso"; // Define a categoria de IMC como "Abaixo do peso" se o IMC for menor que 18.5
            else if (imc < 25)
                categoriaIMC = "Normal"; // Define a categoria de IMC como "Normal" se o IMC estiver entre 18.5 e 25
            else if (imc < 30)
                categoriaIMC = "Sobrepeso"; // Define a categoria de IMC como "Sobrepeso" se o IMC estiver entre 25 e 30
            else
                categoriaIMC = "Obeso"; // Define a categoria de IMC como "Obeso" se o IMC for maior ou igual a 30

            // Determinar faixa etária
            string faixaEtaria;
            if (idade < 10)
                faixaEtaria = "Criança"; // Define a faixa etária como "Criança" se a idade for menor que 10 anos
            else if (idade <= 20)
                faixaEtaria = "Adolescente"; // Define a faixa etária como "Adolescente" se a idade estiver entre 10 e 20 anos
            else if (idade <= 60)
                faixaEtaria = "Adulto"; // Define a faixa etária como "Adulto" se a idade estiver entre 20 e 60 anos
            else
                faixaEtaria = "Idoso"; // Define a faixa etária como "Idoso" se a idade for maior que 60 anos

            // Exibir relatório
            Console.WriteLine($"Relatório para {nome}:");
            Console.WriteLine($"Idade: {idade} anos"); // Exibe a idade do usuário
            Console.WriteLine($"IMC: {imc:F2} ({categoriaIMC})"); // Exibe o IMC e sua categoria
            Console.WriteLine($"Faixa etária: {faixaEtaria}"); // Exibe a faixa etária do usuário
            
            // Perguntar se deseja gerar outro relatório
            Console.WriteLine("\nDeseja gerar um novo relatório? (s/n)"); // Pergunta se o usuário deseja gerar outro relatório
        } while (Console.ReadLine().Trim().ToLower() == "s"); // Verifica se o usuário deseja gerar outro relatório e continua o loop se a resposta for "s"
    }
}
