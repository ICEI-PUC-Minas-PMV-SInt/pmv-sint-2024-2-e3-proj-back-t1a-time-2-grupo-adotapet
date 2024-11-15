# Especificações do Projeto


## Personas

*Narcisa Neves*, tem 30 anos, é vendedora de imóveis e mãe solo. Gosta de passar seu tempo livre lendo e vendo vídeos engraçados de animais na internet. Sempre quis adotar um gatinho para usa filha mas nunca conseguiu achar alguém que estivesse doando um filhote.

*Ellen Queiroz*, tem 45 anos, é chefe executiva em uma ONG de proteção de animais. Gosta de ler e de participar de coletiva de impressa com ONGS parceiras. Hoje encontra muita dificuldade de encontrar de forma rápida novas famílias para os animais resgatados.

*José Lopes*, tem 41 anos, é assistente veterinário e provedor de lar temporário para animais resgatados. Gosta de passar o tempo livre com fotografia e se voluntariando em abrigo de animais. Como tem como projeto pessoal regatar e cuidar de animais de rua até que estejam saudáveis e prontos para adoção, José muitas vezes encontra dificuldade para achar pessoas dispostas a realizarem a adoção desses animais.

*Maria Antônia*, tem 55 anos, é dona de casa e cabelereira. Gosta de fazer crochê e se sente muito sozinha. Como sempre amou animais e nunca teve a oportunidade de ter um, hoje busca um pet para fazer companhia mas está tendo muita dificuldade para encontrar algum animal para adotar.

*Edson Souza*, tem 45 anos, é mecânico. Gosta de passar o tempo livre jogando futebol e xadrez. Deseja melhorar sua comunidade local criando um abrigo de animais e por consequência, precisará de uma forma prática de compartilhar os animais que já estão prontos para serem adotados.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

| EU COMO... `PERSONA`          | QUERO/PRECISO ... `FUNCIONALIDADE`                                                                                   | PARA ... `MOTIVO/VALOR`                                                                                                                          |
| ----------------------------- | -------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| Nacisa (Usuário comum)        | Uma forma segura e prática para adotar um filhote de gato.                                                           | Para realizar o sonho da minha filha.                                                                                                            |
| Nacisa (Usuário comum)        | Saber um pouco melhor sobre as características do animal.                                                            | Para saber se é um animal calmo e não agressivo para estar no mesmo ambiente que uma criança.                                                    |
| Ellen Queiroz (Usuário comum) | Facilitar que a ONG que faço parte possa ter o contato entre os doadores de pets de forma mais rápida e responsável. | Para que o trabalho da ONG possa ser mais expressivo e possamos salvar mais animais em situação de risco.                                        |
| Ellen Queiroz (Usuário comum) | Buscar por animais que precisam urgentemente de cuidados e de um novo lar.                                           | Para realizar um dos principais objetivos da ONG que é proteger os animais.                                                                      |
| José Lopes (Usuário comum)    | Um meio de compartilhar a adoção dos animais que resgato.                                                            | Muitas vezes fico com mais animais do que posso cuidar por conta da falta de meios para compartilhar os animais que já estão prontos para adoção |
| Maria Antônia (Usuário comum) | Encontrar uma forma de conseguir adotar um pet.                                                                      | Para ter a companhia de um alegre cachorro no dia a dia.                                                                                         |
| Edson Souza (Usuário comum)   | Uma forma eficiente e segura de adotar pets.                                                                         | Abrir e manter um abrigo de pets em sua comunidade local.                                                                                        |
| Edson Souza (Usuário comum)   | Uma forma de compartilhar os pets disponíveis para adoção em seu abrigo.                                             | Continuar seu objetivo de facilitar a adoção de pets em sua comunidade local.                                                                    |


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
| RF-12  | O site deve possuir um Administrador onde analisa as publicações denunciadas, e faz a exclusão.                                                                     | Alta           |

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

| ID | Atores   | Casos de Uso         | Descrição                                                                                                          |
| -- | -------- | -------------------- | ------------------------------------------------------------------------------------------------------------------ |
| 01 | Adotante | Fazer Login          | O adotante e o Doador devem realizar o login da sua conta no site.                                                 |
| 02 | Adotante | Verificar cadastro   | Será realizado uma verificação para confirmação de cadastro.                                                       |
| 03 | Adotante | Exibir erro de login | Caso o usuário não tenha cadastro na plataforma, ele deverá se direcionar para a página de cadastro.               |
| 04 | Adotante | Realizar Cadastro    | Caso o usuário queira adotar ou anunciar mas não tem cadastro, o mesmo precisa realizar o cadastro para prosseguir.|
| 05 | Adotante | Ver Anúncios         | O usuário obtendo cadastro ou não, ele consegue somente visualizar os anúncios.                                    |
| 06 | Adotante | Adotar pet           | Com o login efetuado, o usuário poderá clicar no anúncio e então visualizar mais informações sobre o animal.       |
| 07 | Adotante | Entrar em contato    | O usuário que tem interesse no animal desejado, poderá entrar em contato com o doador e prosseguir com a adoção.   |
| 08 | Adotante | Favoritar anúncio    | O usuário tem a possibilidade de favoritar um anúncio caso queira visualizar o mesmo anúncio mais tarde.           |
| 09 | Adotante | Inserir anúncio      | O doador pode inserir um anúncio normalmente depois de ter realizado o login e portando todos os dados do animal.  |
| 10 | Adotante | Apagar anúncio       | Caso o doador conseguiu realizar uma adoção, poderá apagar o anúncio a qualquer momento.                           |
| 11 | Administrador | Excluir anúncio dos usuários  | O administrador pode analisar e excluir anúncios de qualquer usuário do sistema.                     |


  




![diagrama de casos de uso corrigido](https://github.com/user-attachments/assets/d117616a-bf13-4332-a702-a4695000d9a2)
