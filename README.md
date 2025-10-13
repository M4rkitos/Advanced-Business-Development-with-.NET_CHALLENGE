# EasyAccess

## Definição do Projeto
Objetivo do Projeto: O EasyAccess visa resolver os desafios de gestão de vagas de visitantes e reservas de áreas comuns em condomínios residenciais. Ele automatiza processos, garante equidade através de um sistema de sorteio justo e otimiza a receita do condomínio.

Escopo: A primeira versão (MVP) do EasyAccess incluirá os seguintes módulos:
Gestão de Vagas: Reserva online de vagas de visitantes com um sistema de cobrança progressiva.
Reserva de Áreas Comuns: Agendamento de salão de festas, churrasqueiras e quadras.
Sistema de Sorteio Pseudo Aleatório: Mecanismo para alocação justa de áreas comuns em datas de alta demanda (feriados).

## Requisitos Funcionais e Não Funcionais:

## Funcionais:
Permitir que moradores consultem a disponibilidade de vagas e áreas comuns em tempo real.
Permitir a reserva de vagas e áreas comuns com confirmação instantânea.
Calcular e exibir o custo das vagas de visitantes com base no tempo de uso.
Executar o algoritmo de sorteio para datas especiais.
Enviar notificações de confirmação de reserva.

## Não Funcionais:
Disponibilidade: A plataforma deve estar disponível 99,9% do tempo.
Desempenho: As páginas devem carregar em menos de 3 segundos.
Segurança: Utilizar autenticação segura (ex: JWT) e criptografia de dados em trânsito e em repouso.
Escalabilidade: A arquitetura deve suportar um crescimento de até 1000 condomínios e 50.000 usuários sem degradação de performance.
Usabilidade: A interface deve ser intuitiva e fácil de usar para todos os moradores.

