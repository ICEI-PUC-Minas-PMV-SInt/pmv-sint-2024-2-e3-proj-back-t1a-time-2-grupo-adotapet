
# Metodologia

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Descreva aqui a metodologia de trabalho do grupo para atacar o problema. Definições sobre os ambiente de trabalho utilizados pela  equipe para desenvolver o projeto. Abrange a relação de ambientes utilizados, a estrutura para gestão do código fonte, além da definição do processo e ferramenta através dos quais a equipe se organiza (Gestão de Times).

## Relação de Ambientes de Trabalho

Os artefatos do projeto são desenvolvidos a partir de diversas plataformas e a relação dos ambientes com seu respectivo propósito é apresentada na tabela que se segue. 

| **Ambiente**                      | **Plataforma** | **Link de Acesso**                                                                                                                                                                                                  |
| --------------------------------- | -------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Repositório de código fonte       | GitHub         | [https://github.com/adotapetpuc](https://github.com/adotapetpuc)                                                                                                                                                    |
| Projeto de Interface e Wireframes | Figma          |  [https://www.figma.com/file/EtOqz9lBSnizx8QVr6c92J/AdotaPet?type=design&mode=design&t=zXovXbGReJVnXvQ9-0](https://www.figma.com/file/EtOqz9lBSnizx8QVr6c92J/AdotaPet?type=design&mode=design&t=zXovXbGReJVnXvQ9-0) |
| Kanban de tarefas                 | GitHub         |                                                                                                                                                                                                                     |


## Controle de Versão

Para gestão do código fonte do software desenvolvido pela equipe, o grupo utiliza um processo baseado no Git Flow abordado por Vietro (2015), mostrado na Figura a seguir. Desta forma, todas as manutenções no código são realizadas em branches separados, identificados como Main, Testing, Dev as branchs principais e cada nova branch é criada com a uma tag descritiva e sua descrição. Uma explicação rápida sobre este processo é apresentada no vídeo "The gitflow workflow - in less than 5 mins". 

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `testing`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `doc`: melhorias ou acréscimos à documentação
- `fix`: uma funcionalidade encontra-se com problemas
- `feat`: uma nova funcionalidade precisa ser introduzida

Discuta como a configuração do projeto foi feita na ferramenta de versionamento escolhida. Exponha como a gerência de tags, merges, commits e branchs é realizada. Discuta como a gerência de issues foi realizada.

> **Links Úteis**:
> - [Microfundamento: Gerência de Configuração](https://pucminas.instructure.com/courses/87878/)
> - [Tutorial GitHub](https://guides.github.com/activities/hello-world/)
> - [Git e Github](https://www.youtube.com/playlist?list=PLHz_AreHm4dm7ZULPAmadvNhH6vk9oNZA)
>  - [Comparando fluxos de trabalho](https://www.atlassian.com/br/git/tutorials/comparing-workflows)
> - [Understanding the GitHub flow](https://guides.github.com/introduction/flow/)
> - [The gitflow workflow - in less than 5 mins](https://www.youtube.com/watch?v=1SXpE08hvGs)

## Gerenciamento de Projeto

### Divisão de Papéis

Apresente a divisão de papéis entre os membros do grupo.

A equipe utiliza metodologias ágeis, tendo escolhido o Scrum como base para definição do processo de desenvolvimento. A equipe está organizada da seguinte maneira:
- Scrum Master: Beatriz Iglesias;
- Product Owner: Grupo AdotaPet;
- Equipe de Desenvolvimento: Beatriz Iglesias, Leandro Tavares, Vinícius Mendes;
- Equipe de Design: Vinícius Mendes.

> **Links Úteis**:
> - [11 Passos Essenciais para Implantar Scrum no seu Projeto](https://mindmaster.com.br/scrum-11-passos/)
> - [Scrum em 9 minutos](https://www.youtube.com/watch?v=XfvQWnRgxG0)
> - [Os papéis do Scrum e a verdade sobre cargos nessa técnica](https://www.atlassian.com/br/agile/scrum/roles)

### Processo

Para organização e distribuição das tarefas do projeto, a equipe está utilizando o recurso de gerenciamento de projeto oferecido pelo GitHub estruturado com as seguintes listas:  

Recursos: esta lista mantém template de tarefas recorrentes com as configurações padronizadas que todos devem seguir. O objetivo é permitir a cópia destes templates para agilizar a criação de novos cartões. 

Backlog: recebe as tarefas a serem trabalhadas e representa o Product Backlog. Todas as atividades identificadas no decorrer do projeto também devem ser incorporadas a esta lista. 

Para desenvolver: Esta lista representa o Sprint Backlog. Este é o Sprint atual que estamos trabalhando. 

Em desenvolvimento: Quando uma tarefa tiver sido iniciada, ela é movida para cá. 

Test: Checagem de Qualidade. Quando as tarefas são concluídas, eles são movidas para o “CQ”. No final da semana, eu revejo essa lista para garantir que tudo saiu perfeito. 

Feito: nesta lista são colocadas as tarefas que passaram pelos testes e controle de qualidade e estão prontos para ser entregues ao usuário. Não há mais edições ou revisões necessárias, ele está agendado e pronto para a ação. 

Impedimentos: Quando alguma coisa impede a conclusão da tarefa, ela é movida para esta lista juntamente com um comentário sobre o que está travando a tarefa. 
 
> **Links Úteis**:
> - [Planejamento e Gestáo Ágil de Projetos](https://pucminas.instructure.com/courses/87878/pages/unidade-2-tema-2-utilizacao-de-ferramentas-para-controle-de-versoes-de-software)
> - [Sobre quadros de projeto](https://docs.github.com/pt/issues/organizing-your-work-with-project-boards/managing-project-boards/about-project-boards)
> - [Project management, made simple](https://github.com/features/project-management/)
> - [Sobre quadros de projeto](https://docs.github.com/pt/github/managing-your-work-on-github/about-project-boards)
> - [Como criar Backlogs no Github](https://www.youtube.com/watch?v=RXEy6CFu9Hk)
> - [Tutorial Slack](https://slack.com/intl/en-br/)

### Ferramentas

As ferramentas empregadas no projeto são:

- Editor de código: Visual Studio Code.
- Ferramentas de comunicação: Discord e WhatsApp 
- Ferramentas de desenho de tela: Figma
- Ferramenta de versionamento de código: Github
- Ferramenta de gerenciamento do projeto: Kanban do Github

O editor de código foi escolhido porque ele possui uma integração com o sistema de versão, facilidade na usabilidade e na produtividade. As ferramentas de comunicação utilizadas foram escolhidas por serem fáceis e já utilizadas por todos. Já para os designs de tela foi utilizado o figma pela sua facilidade e pela possibilidade de todos contribuirem de forma simultânea.

 
> **Possíveis Ferramentas que auxiliarão no gerenciamento**: 
> - [Slack](https://slack.com/)
> - [Github](https://github.com/)
