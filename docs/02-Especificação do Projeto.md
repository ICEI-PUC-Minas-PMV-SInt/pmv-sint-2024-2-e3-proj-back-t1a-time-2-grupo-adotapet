# Especificações do Projeto


## Personas

Narcisa Neves, tem 30 anos, é vendedora de imóveis e mãe solo. Gosta de passar seu tempo livre lendo e vendo vídeos engraçados de animais na internet. Sempre quis adotar um gatinho para usa filha mas nunca conseguiu achar alguém que estivesse doando um filhote.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

| QUERO/PRECISO ...                                   | PARA ...                                                   |
| --------------------------------------------------- | ---------------------------------------------------------- |
| EU COMO...                                          |
| Nacisa (Usuário comum) | Uma forma segura e prática para adotar um filhote de gato. | Para realizar o sonho da minha filha. |


## Requisitos

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir e as prioridades foram definidas após diversas discussões entres os envolvidos no projeto.

### Requisitos Funcionais

| **ID** | **Descrição do Requisito**                                                                                                                                          | **Prioridade** |
| ------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------- |
| RF-01  | O site deve apresentar na tela principal uma lista de pets e consultar uma API, que está em desenvolvimento, para obter essa lista de pets disponíveis para adoção. | Alta           |
| RF-02  | Para cada postagem haverá uma imagem e descrição correspondente animal disponível para adoção. Com imagem, descrição e motivo para adoção.                          | Alta           |
| RF-03  | O site deve oferecer um filtro de pesquisa para melhorar a experiencia do usuário ao buscar o pet desejado.                                                         | Média          |
| RF-04  | O site deve possuir um campo para visualizar a informação de contato de quem está oferecendo o pet para adoção.                                                     | Alta           |
| RF-05  | O site deve permitir o compartilhamento da publicação sobre a adoção de um pet.                                                                                     | Baixa          |
| RF-06  | O site deve permitir salvar o anúncio do pet como favorito.                                                                                                         | Média          |
| RF-07  | O site deve permitir visualizar os pets marcados como favorito.                                                                                                     | Média          |
| RF-08  | O site deve permitir que o usuário possa criar anúncio de adoção de pet.                                                                                            | Alta           |
| RF-09  | O site deve possuir quantidade de favoritos para os anúncios de pet.                                                                                                | Baixa          |
| RF-10  | O site deve possuir uma tela que permite o usuário se cadastrar                                                                                                     | Alta           |
| RF-11  | O site deve possuir uma tela de login, permitindo o usuário a autenticar em sua conta cadastrada.                                                                   | Alta           |

### Requisitos não Funcionais

| **ID** | **Descrição do Requisito**                                                                                                          | **Prioridade** |
| ------ | ----------------------------------------------------------------------------------------------------------------------------------- | -------------- |
| RNF-01 | A aplicação deve ser publicada em um ambiente acessível publicamente na Internet ([Repl.it](http://Repl.it), GitHub Pages, Heroku); | Alta           |
| RNF-02 | A aplicação deverá ser responsiva, permitindo a visualização em celulares e outros dispositivos de forma adequada.                  | Alta           |
| RNF-03 | A aplicação deve ter bom nível de contraste entre os elementos da tela em conformidade                                              | Média          |
| RNF-04 | A aplicação deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge)                   | Alta           |
| RNF-05 | A aplicação deve ser escalável para suportar quantidade massiva de acesso.                                                          | Alta           |
| RNF-06 | A aplicação deve usar serviço de object storage para armazenar arquivos estáticos.                                                  | Alta           |


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 25/11/2024.     |
|02| O aplicativo deve se restringir às tecnologias básicas da Web no Frontend, utilizando a biblioteca ReactJs. |
|03| O aplicativo deve se restringir à linguagem C# no Backend.                                                  |
|04| A equipe não pode subcontratar o desenvolvimento do trabalho.                                               |
|05| Usar apenas o GitHub como repositório remoto.                                                               |
|06| Usar metodologia de Scrum para o desenvolvimento do projeto.                                                |

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 
