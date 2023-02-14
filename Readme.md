# Projeto para estudos e revisão de conceitos nos fundamentos em CSharp

Passos para projetar uma nova solução seguindo a Orientação a Objetos:

PARTE 1 - Estrutura inicial

1. Definição de objetivos. "Qual problema será resolvido com meu aplicativo?".

2. Separação de contéudos e organização de pastas (contextos), armazenando os arquivos ".cs".

3. Organização Lógica, definindo o namespace dentro dos arquivos ".cs".

4. Criar uma classe base abstrata para agregar as Propriedades
   e Métodos comuns entre as demais classes da solução.

5. Fazer a herança nas classes filhas.

6. Organizar o Program.cs, definindo a namespace e fazendo
   pequenos testes com os objetos das classes.

PARTE 2 - Modelagem

1. Procure utilizar GUIDs (identificador universal) para identificar objetos.

2. Adicione propriedades e métodos específicos para modelar cada classe.

3. Para relacionamentos um-para-muitos (1:N), crie uma propriedade Lista,
   com um tipo complexo.
   Ex: 1 Curso possui muitos Módulos. Posso criar uma lista
   para guardar as informações de cada módulo.

```csharp
 public IList<Modulo> Modulos {get; set;}
```

4. Utilize o método construtor para inicializar as propriedades,
   evitando problemas com exceção de valores nulos.

5. Crie Enumeradores quando precisar limitar a seleção de opções.
   Ex: Nível (baixo, médio, alto, muito alto)

6. Crie um expression body quando uma propriedade só utiliza o método
   "get", e retorna apenas uma linha. Ex:

```csharp
public int QtdTotalDeCursosNaCarreira => Items.Count
```

PARTE 3 - Melhoria contínua

1. Utilize os construtores a favor, preenchendo as informações basicas ao criar objetos.

2. Evite redundância, herde as propriedades das classes pai, passando parametros com a instrução base.

3. Trate as exceções, mas evite o encerramento do programa em caso de falha. Crie um Contexto de Notificação.
