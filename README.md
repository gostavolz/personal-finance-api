# Personal Finance API

Uma API REST completa e robusta desenvolvida em **C# / .NET** para controle e gerenciamento de finanças pessoais. O projeto fornece um CRUD completo de transações financeiras e gera relatórios consolidados automáticos.

## 🚀 Tecnologias Utilizadas

* **.NET / ASP.NET Core Web API** — Estrutura principal da aplicação baseada em Controllers.
* **Entity Framework Core** — ORM para mapeamento e persistência de dados.
* **SQLite** — Banco de dados relacional leve para armazenamento local de transações.
* **LINQ (Language Integrated Query)** — Utilizado para consultas eficientes e geração de resumos financeiros.

## 🛠️ Funcionalidades principais

* **CRUD de Transações:** Cadastro, listagem, atualização e remoção de receitas (`Income`) e despesas (`Expense`).
* **Resumo Financeiro Semanal/Mensal:** Endpoint inteligente que calcula automaticamente o total de entradas, total de saídas e o saldo final da conta corrente.
* **Banco de Dados Automatizado:** Migrações gerenciadas via Entity Framework Core CLI.

## 🗂️ Estrutura do Projeto

* `Controllers/` — Endpoints da API que gerenciam as requisições HTTP.
* `Data/` — Contexto do Entity Framework Core (`AppDbContext`) e configurações do banco.
* `Models/` — Classes de domínio que definem a estrutura da tabela `Transaction`.
* `Migrations/` — Histórico de evolução e versionamento das tabelas do banco de dados.

---
Desenvolvido como o 5º projeto do meu portfólio de C#.
