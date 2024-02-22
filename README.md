# UniRota
Uma aplicação web para serviços de carona universitário.


Funcionalidades
 - Cadastro de usuário
    > Permite que um usuário se registre no sistema fornecendo informações pessoais básicas.
        > Escopo:
            Nome
            E-mail
            Senha
            Telefone
            Endereço

 - Cadastro do veículo (Carro e Moto)
    > Permite que um usuário registre um veículo no sistema.
        > Escopo:
            Marca
            Modelo
            Ano
            Placa
            Cor
            Capacidade de passageiros

 - Criação de grupos de carona (Precisa ter um veículo cadastrado)
    > Permite que um usuário crie um grupo de carona.
        > Escopo:
            Título do Grupo
            Descrição
            Data e Hora de Partida
            Local de Partida
            Destino
            Veículo Associado

 - Listagem de grupos de carona
    > Lista todos os grupos de carona disponíveis.
        > Escopo:
            Título do Grupo
            Data e Hora de Partida
            Local de Partida
            Destino
            Veículo Associado

 - Chat do grupo de carona
    > Permite que os membros de um grupo de carona se comuniquem entre si.
        > Escopo:
            Enviar Mensagem
            Receber Mensagem
            Notificação de Mensagem Nova

 - Listagem de chats de grupos participantes
    > Lista todos os chats dos grupos dos quais o usuário é membro.
        > Escopo:
            Nome do Grupo
            Última Mensagem Recebida

 - Solicitação para entrar em um grupo de carona
    > Permite que um usuário solicite ingresso em um grupo de carona.
        > Escopo:
            Nome do Grupo
            Mensagem de Solicitação

 - Possibilidade de convidar para grupos
    > Permite que um membro do grupo convide outros usuários para ingressar no grupo.
        > Escopo:
            Nome do Grupo
            E-mail do Usuário Convidado
            Mensagem de Convite

Tomada de decisões
 - Seleção de tecnologias e frameworks
  - C#/ASP.NET MVC - Pois é a tecnologia que o grupo tem mais experiência.
  - SQLite - Pois é uma aplicação de pequena escala


