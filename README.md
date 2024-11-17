# MediaMetricsPro
![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/viniqsoares/MediaMetricsPro/.github%2Fworkflows%2Fci.yml?branch=main)
[![SonarCloud](https://github.com/viniqsoares/MediaMetricsPro/actions/workflows/analyze.yml/badge.svg?branch=main)](https://github.com/viniqsoares/MediaMetricsPro/actions/workflows/analyze.yml)
![Sonar Coverage](https://img.shields.io/sonar/coverage/viniqsoares_MediaMetricsPro?server=https%3A%2F%2Fsonarcloud.io)

# Objetivo
Projeto tem como objetivo centralizar todas as informações oriundas de ações de marketing com a finalidade de facilitar a tomada de decisão nas futuras campanhas.

# Tecnologias
- Minimal API
- .Net 8
- Entity Framework 9.0
- Docker
- Postgresql 


# Pontos de Atenção

## Banco de Dados
Sempre efetuar as migrações atualizando o arquivo Scrit/Script.sql que deve ser utilizado como base para a geração da base de dados no docker

Entrar na camadada de infrastructura do EF
> cd src/MediaMetricsPro.Infrastructure.Database.EF

Gerando o arquivo de script
> dotnet ef migrations script -s ../MediaMetricsPro.Api -o Scipts/scipt.sql

Gerando a migração
> dotnet ef migrations add InitialMigratiom

Atualizando banco 
> dotnet ef database update