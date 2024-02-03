# Unity Color Changer

## Descrição do Projeto

Este projeto foi desenvolvido com o objetivo de criar uma integração entre um projeto Unity3D e um servidor web local. A aplicação Unity3D acessa um endpoint web para obter informações sobre cores aleatórias e, em seguida, altera a cor de um objeto na cena com base nessa resposta.

## Requisitos do Sistema

- Unity3D instalado (versão 2022.3.19f1)
- Um servidor local (Strapi).

## Estrutura do Projeto

O repositório está organizado da seguinte maneira:

- **Servidor:** Contém o código fonte do servidor web que fornece informações sobre cores aleatórias.
- **Unity3D:** Inclui o projeto Unity3D que realiza solicitações ao servidor e atualiza a cor de um objeto na cena.

## Configuração

## Configuração do Ambiente

1. Clone o repositório para o seu sistema local.
2. Certifique-se de ter configurado e iniciado o servidor local.
3. Abra o projeto Unity3D usando o Unity Hub.

## Configuração do Endpoint Local

1. Abra um terminal e navegue até a pasta servidor do seu projeto.
2. Execute o comando npm install para instalar as dependências listadas no arquivo package.json.
3. Inicie o servidor com strapi develop.

## Configuração do Projeto Unity3D

1. Abra o projeto Unity3D localizado na pasta `Unity3D` no Unity Hub.
2. No explorador de projetos, navegue até a cena `SampleScene` localizada em `Assets/Scenes`.
3. Selecione o objeto que representa o elemento cuja cor será alterada (O cubo).

## Executando o Projeto

1. Certifique-se de que o servidor local esteja em execução.
2. Pressione o botão "Play" no Unity3D para iniciar a execução do projeto.
3. A cada segundo, a aplicação Unity fará uma solicitação ao endpoint local, obterá uma cor aleatória e alterará a cor do objeto na cena.

## Licença

Este projeto está sob a licença [MIT](LICENSE).
