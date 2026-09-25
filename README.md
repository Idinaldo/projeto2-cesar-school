# SAMU DataFlow

## Sobre

O Centro de Inteligência Epidemiológica (CIE) do Recife apresentou-nos a seguinte dor através da cadeira <strong>Projeto 2</strong>: analisamos um grande volume de dados manualmente.

A partir dessa dor, começamos a trabalhar em uma solução para automatizar e estruturar esse processo. Este repositório é um dos meios utilizados para disponibilizar os produtos da nossa solução, concentrando principalmente sua parte técnica.

<strong>Mais detalhes sobre o problema estão disponíveis no [nosso site](https://sites.google.com/cesar.school/samu-dataflow-projeto-2-ciber/).</strong>

## Requisitos

### Funcionais

O sistema deve ser capaz de:

1. Importar arquivos .xlsx
2. Validar dados
3. Tratar de registros inválidos ou duplicados
4. Gerar logs de seu funcionamento
5. Persistir dados tratados
6. Expor dados tratados

### Não Funcionais

Algumas condições que afetam o design do sistema foram impostas, entre elas:

- Utilização de C#
- PostgreSQL como banco de dados
- Integração com Airflow
- Utilização de Docker

## Diagrama de Classes

![diagrama de classes](./diagrama-de-classes.png)
