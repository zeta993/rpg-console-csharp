# 🧙 RPG Básico Console - C#

Um pequeno RPG em modo console desenvolvido em C# com o objetivo de praticar Programação Orientada a Objetos (POO).

---

## 📖 Sobre o Projeto

Este projeto foi criado principalmente para estudar e praticar conceitos como:

- Herança  
- Encapsulamento  
- Polimorfismo  
- Estruturas condicionais  
- Loops  
- Interação com o usuário  
- Lógica de combate  

No jogo, o jogador pode escolher:

- Nome  
- Classe  
- Caminho  

Após isso, enfrenta um inimigo com atributos gerados aleatoriamente a cada partida.

---

## 🧱 Estrutura do Código

O projeto é dividido nas seguintes classes:

- `Personagem` → Classe abstrata com os principais atributos e métodos.
- `Jogador` → Classe filha responsável por instanciar o jogador.
- `Inimigo` → Classe filha responsável por instanciar o inimigo.
- `Principal` → Classe onde ocorre toda a execução do jogo.

---

## ⚔️ Sistema de Combate

O combate é baseado em turnos:

- A maior velocidade define quem começa.
- Enquanto ambos estiverem vivos, o combate continua.

### Ações disponíveis:

- **Ataque:** gera dano com base na classe e nos equipamentos.
- **Ataque forte:** gera dano aumentado, porém consome vida.
- **Curar:** recupera uma quantidade aleatória de vida.
- **Defender:** aplica um escudo que reduz o dano recebido.

---

## 🚀 Futuras Atualizações

Este projeto faz parte da minha jornada de aprendizado em C#.  
Pretendo futuramente implementar:

- Melhorias no sistema de combate  
- Múltiplos inimigos  
- Sistema de níveis  
- Melhor organização do código  
- Novos caminhos e eventos  

---

## 👨‍💻 Autor

Desenvolvido por **Zeta993**