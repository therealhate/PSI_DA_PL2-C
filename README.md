```markdown
# Sistema de Gestão da Cantina

## Descrição

Este projeto visa a criação de um sistema de gestão para a cantina de uma escola. O sistema permite administrar os menus e reservas da cantina, carregar o saldo dos clientes e efetuar a faturação das reservas. As principais funcionalidades incluem:

1. Exclusivo uso por Funcionários da Cantina.
2. Carregamento de saldo e realização de reservas pelos Funcionários.
3. Lista de pratos categorizados como Carne, Peixe ou Vegetariano.
4. Menus diários com pratos de cada tipo e vários extras.
5. Preços diferentes para Estudantes e Professores.
6. Preços adicionais para extras selecionados.
7. Visualização semanal dos menus, com possibilidade de escolher a semana.
8. Gestão de funcionários e clientes.
9. Persistência de dados em uma base de dados SQL Server a usar Entity Framework.

## Modelo de Dados

O modelo de dados do sistema é composto pelas seguintes entidades:

- **Funcionário**: Administra o sistema e realiza operações como carregar saldo e fazer reservas.
- **Cliente**: Pode ser do tipo Estudante ou Professor.
- **Prato**: Categorizado como Carne, Peixe ou Vegetariano.
- **Extra**: Itens adicionais que podem ser incluídos nos menus.
- **Menu**: Inclui pratos de cada tipo e vários extras.
- **Reserva**: Anota as reservas feitas pelos clientes.
- **Multa**: Valores para diferentes tempos de atraso na reserva.

## Funcionalidades

### Formulário Principal

- Menu de acesso às diversas funcionalidades.
- Alteração do funcionário utilizando o programa.
- Visualização da semana atual com menus diários.
- Navegação entre semanas.
- Acesso ao formulário de reservas.

### Formulário de Reservas

- Efetuar uma reserva: escolher prato e extras, selecionar cliente, gerar ficheiro de texto e fatura em PDF.
- Marcar reserva como efetuada: listar reservas e permitir marcar uma delas como utilizada.

### Formulário de Pratos

- Visualizar todos os pratos disponíveis.

### Formulário de Extras

- Visualizar todos os extras disponíveis.

### Formulário de Multas

- Visualizar todos os tempos disponíveis.

### Formulário de Gestão de Clientes

- Visualizar todos os clientes.

### Formulário de Menu

- Criar novo menu para um diaespecífico.
- Adicionar e eliminar pratos e extras ativos.

### Formulário de Funcionários

- Visualizar todos os funcionários.

## Regras de Negócio

1. Cada cliente pode efetuar uma reserva de um prato por dia e até três extras.
2. Saldo do cliente deve ser ajustado após reserva.
3. Reservas feitas fora do período de multa devem ser inseridas com a respectiva multa.
4. Talões de reserva devem ser gravados em ficheiros de texto.
5. Faturas devem ser criadas em formato PDF e enviadas por email.

## Persistência de Dados

Todos os dados são armazenados em uma base de dados relacional SQL Server a usar Entity Framework para garantir a integridade e persistência.

## Instruções de Instalação

1. **Pré-requisitos**:
   - .NET Framework
   - SQL Server
   - Entity Framework

3. **Compilação e Execução**:
   - Abra o projeto no Visual Studio.
   - Compile e execute o projeto.
   - Use a interface do usuário para interagir com o sistema.

## Utilização

1. **Login**:
   - Funcionários devem fazer login para acessar o sistema.
2. **Gestão de Menus**:
   - Crie e visualize menus semanais.
3. **Realização de Reservas**:
   - Selecione pratos e extras, insira a reserva e gere a fatura.
4. **Carregamento de Saldo**:
   - Carregue o saldo dos clientes.
```
