# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

## Objetivo do Plano de Testes
- Definir a estratégia e os critérios para a execução dos testes de software no sistema AdotaPet.
- Garantir que os requisitos do sistema sejam atendidos e que o software esteja livre de defeitos.

## Escopo dos Testes
O que será testado:
- Validação de formulários.
- Comunicação e otimização da interface com a API.
- Desempenho e latência da API.
- Comunicação da API com o banco de dados.
- Validação das tabelas no banco de dados.
- Criptografia das credenciais cadastradas.

## Abordagem de Testes
Técnicas de Testes:
- Testes automatizados.
- Testes manuais.
<a/>

Nível de Testes:
- Teste Unitário.
- Teste de Sistema.
- Teste de Aceitação.

## Recursos Necessários
Ambiente de Teste:
- SQL Server Express LocalDB
- Visual Studio
- .NET SDK 8.0
<a/>

Ferramentas de Teste:
- XUnit.net

## Casos de Teste

Login:
- Objetivo: Verificar se o login é feito corretamente.
- Passos: Inserir o email e senha válidos e pressionar "Entrar".
- Resultado Esperado: O usuário é redirecionado para a página inicial.

Cadastro:
- Objetivo: Verificar se o cadastro de usuários é feito corretamente.
- Passos: Preencher os campos do formulário e pressionar "Cadastrar".
- Resultado Esperado: O usuário é cadastrado e redirecionado à página inicial.

Pesquisa:
- Objetivo: Verificar se a pesquisa por filtros é realizada corretamente.
- Passos: Selecionar cada filtro e pressionar “Pesquisar”.
- Resultado Esperado: Uma lista de anúncios filtrados corretamente é mostrada ao usuário.

Criar anúncio:
- Objetivo: Verificar se a criação de anúncios é realizada corretamente.
- Passos: Preencher cada campo do formulário de criação de anúncio e pressionar “Criar anúncio”.
- Resultado Esperado: O anúncio é criado e o usuário é redirecionado para “Meus anúncios”.

Editar anúncio:
- Objetivo: Verificar se a edição de anúncios é realizada corretamente.
- Passos: Preencher cada campo do formulário de edição de anúncio e pressionar “Editar anúncio”.
- Resultado Esperado: O anúncio é editado e o usuário é redirecionado para “Meus anúncios”.

Criptografia:
- Objetivo: Verificar se os dados são criptografados ao serem adicionados ao banco de dados.
- Passos: Cadastrar alguém e verificar no banco de dados se os dados críticos estão criptografados.
- Resultado Esperado: Os dados críticos estão protegidos por criptografia.

Banco de dados:
- Objetivo: Verificar se as tabelas estão configuradas corretamente.          
- Passos: Inserir a força dados de tipo incorreto nas colunas.
- Resultado Esperado: Dados incorretos são barrados da inserção no banco de dados.

Servidor (API):
- Objetivo: Verificar se a latência e a performance estão adequadas.         
- Passos: Consultar os dados de latência, uso de memória e CPU na dashboard do provedor.
- Resultado Esperado: API apresenta performance adequada.

Servidor (API) com Interface:
- Objetivo: Verificar se a API responde as requisições da interface.         
- Passos: Verificar se os dados da resposta estão corretos e quantas vezes uma requisição é feita   por ação na interface.
- Resultado Esperado: API responde corretamente sem ser consultada desnecessariamente.


## Critérios de Conclusão

Critérios de Sucesso:
- Todos os testes de alta prioridade foram executados com sucesso.
- Todos os defeitos críticos foram resolvidos.
- O sistema atende a todos os requisitos funcionais e não funcionais.

Critérios de Falha:
- Casos de testes com falhas críticas não resolvidas.
- Testes importantes não executados devido a falta de recursos.

## Relatórios de Testes
Formato dos Relatórios:
- Relatório final de testes com o status dos testes realizados, defeitos identificados e status final.
<a/>

Métricas de Teste:
- Percentual de casos de teste executados.
- Número de defeitos encontrados e sua severidade.
- Tempo gasto em cada fase de teste.
