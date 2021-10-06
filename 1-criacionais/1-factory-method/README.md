## Propósito
---
O Factory Method é um padrão criacional de projeto que fornece uma interface para criar objetos em uma superclasse, mas permite que as subclasses alterem o tipo de objetos que serão criados.

### Problema
---
Imagine que você está criando uma aplicação de gerenciamento de logística. A primeira versão da sua aplicação pode lidar apenas com o transporte de caminhões, portanto a maior parte do seu código fica dentro da classe Caminhão.

Depois de um tempo, sua aplicação se torna bastante popular. Todos os dias você recebe dezenas de solicitações de empresas de transporte marítimo para incorporar a logística marítima na aplicação.

<div align="center">
<img src="https://refactoring.guru/images/patterns/diagrams/factory-method/problem1-pt-br.png"></img>
</div>

Boa notícia, certo? Mas e o código? Atualmente, a maior parte do seu código é acoplada à classe Caminhão. Adicionar Navio à aplicação exigiria alterações em toda a base de código. Além disso, se mais tarde você decidir adicionar outro tipo de transporte à aplicação, provavelmente precisará fazer todas essas alterações novamente.

Como resultado, você terá um código bastante sujo, repleto de condicionais que alteram o comportamento da aplicação, dependendo da classe de objetos de transporte.

### Solução
---
O padrão Factory Method sugere que você substitua chamadas diretas de construção de objetos (usando o operador new) por chamadas para um método fábrica especial. Não se preocupe: os objetos ainda são criados através do operador new, mas esse está sendo chamado de dentro do método fábrica. Objetos retornados por um método fábrica geralmente são chamados de produtos.
<div align="center">
  <img src="https://refactoring.guru/images/patterns/diagrams/factory-method/solution1.png"></img>
</div>

À primeira vista, essa mudança pode parecer sem sentido: apenas mudamos a chamada do construtor de uma parte do programa para outra. No entanto, considere o seguinte: agora você pode sobrescrever o método fábrica em uma subclasse e alterar a classe de produtos que estão sendo criados pelo método.

Porém, há uma pequena limitação: as subclasses só podem retornar tipos diferentes de produtos se esses produtos tiverem uma classe ou interface base em comum. Além disso, o método fábrica na classe base deve ter seu tipo de retorno declarado como essa interface.

<div align="center">
  <img src="https://refactoring.guru/images/patterns/diagrams/factory-method/solution2-pt-br.png"></img>
</div>

Por exemplo, ambas as classes Caminhão e Navio devem implementar a interface Transporte, que declara um método chamado entregar. Cada classe implementa esse método de maneira diferente: caminhões entregam carga por terra, navios entregam carga por mar. O método fábrica na classe LogísticaViária retorna objetos de caminhão, enquanto o método fábrica na classe LogísticaMarítima retorna navios.

<div align="center">
  <img src="https://refactoring.guru/images/patterns/diagrams/factory-method/solution3-pt-br.png"></img>
</div>

O código que usa o método fábrica (geralmente chamado de código cliente) não vê diferença entre os produtos reais retornados por várias subclasses. O cliente trata todos os produtos como um Transporte abstrato. O cliente sabe que todos os objetos de transporte devem ter o método entregar, mas como exatamente ele funciona não é importante para o cliente.

### Estrutura
---

<div align="center">
  <img src="https://refactoring.guru/images/patterns/diagrams/factory-method/structure.png"></img>
</div>

1 - O Produto declara a interface, que é comum a todos os objetos que podem ser produzidos pelo criador e suas subclasses.

2 - Produtos Concretos são implementações diferentes da interface do produto.

3 - A classe Criador declara o método fábrica que retorna novos objetos produto. É importante que o tipo de retorno desse método corresponda à interface do produto.

Você pode declarar o método fábrica como abstrato para forçar todas as subclasses a implementar suas próprias versões do método. Como alternativa, o método fábrica base pode retornar algum tipo de produto padrão.

Observe que, apesar do nome, a criação de produtos não é a principal responsabilidade do criador. Normalmente, a classe criadora já possui alguma lógica de negócio relacionada aos produtos. O método fábrica ajuda a dissociar essa lógica das classes concretas de produtos. Aqui está uma analogia: uma grande empresa de desenvolvimento de software pode ter um departamento de treinamento para programadores. No entanto, a principal função da empresa como um todo ainda é escrever código, não produzir programadores.

4 - Criadores Concretos sobrescrevem o método fábrica base para retornar um tipo diferente de produto.

Observe que o método fábrica não precisa criar novas instâncias o tempo todo. Ele também pode retornar objetos existentes de um cache, um conjunto de objetos, ou outra fonte.

### Pseudocódigo
---
Este exemplo ilustra como o Factory Method pode ser usado para criar elementos de interface do usuário multiplataforma sem acoplar o código do cliente às classes de UI concretas.

<div align="center">
  <img src="https://refactoring.guru/images/patterns/diagrams/factory-method/example.png"></img>
</div>

A classe base diálogo usa diferentes elementos da UI do usuário para renderizar sua janela. Em diferentes sistemas operacionais, esses elementos podem parecer um pouco diferentes, mas ainda devem se comportar de forma consistente. Um botão no Windows ainda é um botão no Linux.

Quando o método fábrica entra em ação, você não precisa reescrever a lógica da caixa de diálogo para cada sistema operacional. Se declararmos um método fábrica que produz botões dentro da classe base da caixa de diálogo, mais tarde podemos criar uma subclasse de caixa de diálogo que retorna botões no estilo Windows do método fábrica. A subclasse herda a maior parte do código da caixa de diálogo da classe base, mas, graças ao método fábrica, pode renderizar botões estilo Windows na tela.

Para que esse padrão funcione, a classe base da caixa de diálogo deve funcionar com botões abstratos: uma classe base ou uma interface que todos os botões concretos seguem. Dessa forma, o código da caixa de diálogo permanece funcional, independentemente do tipo de botão com o qual ela trabalha.

Obviamente, você também pode aplicar essa abordagem a outros elementos da UI. No entanto, com cada novo método fábrica adicionado à caixa de diálogo, você se aproxima do padrão Abstract Factory. Não se preocupe, falaremos sobre esse padrão mais tarde.

### Como implementar
---

<div align="center">
  <img src="https://www.devmedia.com.br/imagens/msdnmagazine/padprofactmethfig01.JPG"></img>
</div>

- Produto (Cadastro): define a interface de objetos que o método fábrica cria.

- ProdutoConcreto (MeuCadastro): implementa a interface de Produto.

- Criador (Sistema): declara o método fábrica, o qual retorna um objeto do tipo Produto. Criador também pode definir uma implementação por omissão do método factory que retorna por omissão um objeto ProdutoConcreto.

- CriadorConcreto (MeuSistema): redefine o método-fábrica para retornar a uma instância de um ProdutoConcreto.

---
1. Faça todos os produtos implementarem a mesma interface. Essa interface deve declarar métodos que fazem sentido em todos os produtos.

2. Adicione um método fábrica vazio dentro da classe criadora. O tipo de retorno do método deve corresponder à interface comum do produto.

3. No código da classe criadora, encontre todas as referências aos construtores de produtos. Um por um, substitua-os por chamadas ao método fábrica, enquanto extrai o código de criação do produto para o método fábrica.

Pode ser necessário adicionar um parâmetro temporário ao método fábrica para controlar o tipo de produto retornado.

Neste ponto, o código do método fábrica pode parecer bastante feio. Pode ter um grande operador switch que escolhe qual classe de produto instanciar. Mas não se preocupe, resolveremos isso em breve.

4. Agora, crie um conjunto de subclasses criadoras para cada tipo de produto listado no método fábrica. Sobrescreva o método fábrica nas subclasses e extraia os pedaços apropriados do código de construção do método base.

5. Se houver muitos tipos de produtos e não fizer sentido criar subclasses para todos eles, você poderá reutilizar o parâmetro de controle da classe base nas subclasses.
Por exemplo, imagine que você tenha a seguinte hierarquia de classes: a classe base Correio com algumas subclasses: CorreioAéreo e CorreioTerrestre; as classes Transporte são Avião, Caminhão e Trem. Enquanto a classe CorreioAéreo usa apenas objetos Avião, o CorreioTerrestre pode funcionar com os objetos Caminhão e Trem. Você pode criar uma nova subclasse (por exemplo, CorreioFerroviário) para lidar com os dois casos, mas há outra opção. O código do cliente pode passar um argumento para o método fábrica da classe CorreioTerrestre para controlar qual produto ele deseja receber.

3. Se, após todas as extrações, o método fábrica base ficar vazio, você poderá torná-lo abstrato. Se sobrar algo, você pode tornar isso em um comportamento padrão do método.

### Prós
---
- Você evita acoplamentos firmes entre o criador e os produtos concretos.

- Princípio de responsabilidade única. Você pode mover o código de criação do produto para um único local do programa, facilitando a manutenção do código.

- Princípio aberto/fechado. Você pode introduzir novos tipos de produtos no programa sem quebrar o código cliente existente.

### Contras
---
- O código pode se tornar mais complicado, pois você precisa introduzir muitas subclasses novas para implementar o padrão. O melhor cenário é quando você está introduzindo o padrão em uma hierarquia existente de classes criadoras.


https://github.com/fabiosilvalima/FSL.eBook.RWP.ED2.DesignPatterns