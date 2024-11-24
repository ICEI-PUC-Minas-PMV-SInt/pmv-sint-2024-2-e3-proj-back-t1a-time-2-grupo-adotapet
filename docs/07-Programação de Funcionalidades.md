# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descritas por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos os artefatos criados (código fonte) além das estruturas de dados utilizadas e as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

# Criação de telas

## Anúncios

Feito por: Beatriz Iglesias

Descrição: Criei um CRUD simples de anúncios com o intuito de me familiarizar com o framework, a tabela Anuncios criada é meramente ilustrativa com campos fictícios.
Achei o framework bem simples de usar e a geração automática de views acelera bastante o desenvolvimento, não tive difivuldades na utilização da ferramenta.

- Home de anúncios

  ![Diagrama ER Adota Pet](img/home-anuncios.png)

- Listagem de anúncios

  ![Diagrama ER Adota Pet](img/list-anuncios.png)

- Detalhes de anúncio

  ![Diagrama ER Adota Pet](img/editar-anuncios.png)

- Criar  anúncio

  ![Diagrama ER Adota Pet](img/criar-anuncios.png)


## Login

Feito por: Leandro Tavares

Descrição: Tive dificuldades com a conexão com o banco de dados devido a string de conexão da vídeo aula não funcionar no meu projeto. 
Achei interessante a praticidade do framework do MVC, pois acelera a produção do projeto. 

- Tela de Login

  ![Diagrama ER Adota Pet](img/tela-login.png)


## Usuários

Feito por: Vinícius Mendes

Descrição: CRUD em MVC que interage com a tabela "Usuarios" do banco de dados "AdotaPet". Já estava familiarizado com o MVC em JS, de início, achei o código e estrutura em C#
um pouco poluídos, mas logo me acostumei. Adorei a praticidade do .NET, excelente para produtividade.


- Listagem de usuários

  ![Diagrama ER Adota Pet](img/listagem-usuarios.png)

- Detalhes de usuário

  ![Diagrama ER Adota Pet](img/detalhes-usuario.png)

- Cadastrar usuário

  ![Diagrama ER Adota Pet](img/cadastrar-usuario.png)

- Editar Usuário
  
  ![Diagrama ER Adota Pet](img/editar-usuario.png)

- Excluir Usuário

  ![Diagrama ER Adota Pet](img/excluir-usuario.png)


# Funcionalidades por tipo de perfil

A tabela abaixo descreve quais atividades podem ser executadas por cada tipo de perfil.

|                                              | Usuário comum | Administrador |
| -------------------------------------------- | ------------- | ------------- |
| Publicar anúncio                             | Sim           | Sim           |
| Editar anúncio                               | Sim           | Sim           |
| Deletar anúncio                              | Sim           | Sim           |
| Visualizar detalhes do anúncio               | Sim           | Sim           |
| Editar perfil                                | Sim           | Sim           |
| Excluir perfil                               | Sim           | Sim           |
| Curtir anúncio                               | Sim           | Sim           |
| Denunciar anúncio                            | Sim           | Sim           |
| Deletar anúncio publicado por outro usuário  | Não           | Sim           |

# Padrões de Projeto

## Padrões de Projeto GoF

- Singleton: um padrão de design criacional que permite garantir que uma classe tenha apenas uma instância, enquanto fornece um ponto de acesso global a essa instância.
- Decorator: um padrão de design estrutural que permite anexar novos comportamentos aos objetos, colocando-os dentro de objetos especiais do invólucro que contêm os comportamentos.
- Composite: um padrão de design estrutural que permite a combinação de componentes menores, como views parciais e layouts, para formar uma interface.
- Visitor: um padrão de design comportamental que permite separar algoritmos dos objetos nos quais eles operam.
  
## Padrões de indentação e formatação

- Indentação de 2 espaços.
- Preferência a guard clauses sempre que possivel.
- Linhas em branco para separar métodos longos.



