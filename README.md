# ONG Animal

Olá! <br>
<br>
Este repositório refere-se ao trabalho de projeto de software e consiste em um sistema de gerenciamento para Ong's de animais. O projeto utiliza a linguagem de programação C# e banco de dados Sql Server. <br>
Nossa solution possui quatro projetos: <br>
- **ONG**: nosso backend, contendo separados em folders as entidades de dominío, repositorios e serviços;
- **API**: api REST do projeto que acessa o backend;
- **Presentation**: frontend MVC da aplicação, e;
- **Util**: que possui nosso client de acesso a API.<br>
Para iniciar o projeto faça clone com: 
`git clone https://github.com/Alice-Scholze/OngAnimal.git`<br>
Abra o `Package Manage Console`, selecione o projeto `ONG` e o sete como setup, após, rode o comando `Update-Database` para atualizar o banco de dados (caso queira ver a execução dos scripts rode o comando adicionando a tag -verbose da seguinte maneira `Update-Database -verbose`).<br>
Após criar/atualizar o banco de dados basta setar os projetos `Presentation` e `API` como setup e rodar a aplicação! :D