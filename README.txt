# ⚔️ RPG de Console em C#

RPG simples desenvolvido em **C#** durante meus estudos de Programação Orientada a Objetos.

O projeto foi criado para colocar em prática conceitos fundamentais da linguagem através de um sistema de combate por turnos, utilizando classes, herança, encapsulamento, métodos, construtores, validação de entrada e geração de valores aleatórios.

---

## 🎮 Sobre o projeto

O jogador inicia escolhendo seu nome e uma das três classes disponíveis:

- 🥷 **Ninja** — menor poder e maior velocidade
- ⚔️ **Guerreiro** — atributos equilibrados
- 🛡️ **Tank** — maior poder e menor velocidade

Durante a jornada, o jogador também escolhe um caminho dentro do castelo. Dependendo da escolha, pode encontrar um equipamento que aumenta seu poder antes do combate.

Em seguida, o jogador enfrenta um inimigo com atributos gerados aleatoriamente.

A velocidade dos personagens determina quem realiza o primeiro turno.

---

## ⚔️ Sistema de combate

Durante seu turno, o jogador pode escolher diferentes ações:

- Ataque normal
- Ataque forte, causando mais dano em troca de vida
- Utilizar curativo
- Utilizar escudo

O inimigo possui suas próprias ações, selecionadas aleatoriamente durante o combate.

Entre elas estão:

- Atacar
- Recuperar vida
- Utilizar defesa
- Perder o turno

O combate continua até que a vida do jogador ou do inimigo chegue a zero.

---

## 🧠 Conceitos praticados

O projeto foi desenvolvido principalmente para praticar conceitos fundamentais de **C# e Programação Orientada a Objetos**, incluindo:

- Classes e objetos
- Classe abstrata
- Herança
- Encapsulamento
- Construtores
- Métodos
- Modificadores de acesso
- Estruturas condicionais
- `switch`
- Loops
- Validação de entrada com `TryParse`
- Geração de valores aleatórios com `Random`
- Interação com o usuário pelo console
- Passagem de objetos entre métodos
- Lógica de combate baseada em turnos

---

## 🏗️ Estrutura das classes

### `Base`

Classe abstrata responsável pelos atributos e comportamentos compartilhados entre jogador e inimigo.

Principais atributos:

- Vida
- Poder
- Velocidade
- Estado do personagem (vivo ou morto)

Também contém métodos utilizados para:

- Receber dano
- Recuperar vida
- Alterar atributos
- Equipar melhorias
- Consultar o estado atual do personagem

### `Jogador`

Herda da classe `Base`.

Responsável por armazenar o nome do jogador e definir seus atributos iniciais de acordo com a classe escolhida.

### `Inimigo`

Também herda de `Base`.

Seus atributos de vida, poder e velocidade são definidos aleatoriamente quando o objeto é criado.

### `Principal`

Responsável pelo fluxo principal do jogo:

1. Solicitação do nome
2. Escolha da classe
3. Criação do jogador e do inimigo
4. Escolha de caminho
5. Equipamento do personagem
6. Definição da ordem dos turnos
7. Execução do combate
8. Exibição do resultado da batalha

---

## 🛠️ Tecnologia utilizada

![C#](https://img.shields.io/badge/C%23-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)

---

## 📚 Contexto

Este foi um dos meus primeiros projetos desenvolvidos em **C#**, criado durante o aprendizado dos fundamentos da linguagem e de Programação Orientada a Objetos.

O código representa uma etapa da minha evolução nos estudos e será mantido no GitHub como registro dessa progressão.

---

## 👨‍💻 Autor

**Vinicius Dias**

Estudante de Análise e Desenvolvimento de Sistemas, com foco em desenvolvimento backend e C#/.NET.
