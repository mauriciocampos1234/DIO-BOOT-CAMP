// Classe que representa um Herói
class Heroi {
  constructor(nome, idade, tipo) {
    this.nome = nome;
    this.idade = idade;
    this.tipo = tipo;
  }

  atacar() {
    let ataque = "";

    switch (this.tipo.toLowerCase()) {
      case "mago":
        ataque = "usou magia";
        break;
      case "guerreiro":
        ataque = "usou espada";
        break;
      case "monge":
        ataque = "usou artes marciais";
        break;
      case "ninja":
        ataque = "usou shuriken";
        break;
      default:
        ataque = "atacou de forma desconhecida";
    }

    console.log(`O ${this.tipo} atacou usando ${ataque}`);
  }
}

// Criando alguns heróis para exemplo
const herois = [
  new Heroi("Merlin", 150, "mago"),
  new Heroi("Arthas", 35, "guerreiro"),
  new Heroi("Lee", 28, "monge"),
  new Heroi("Hanzo", 30, "ninja"),
];

// Laço para executar o ataque de cada herói
for (let heroi of herois) {
  heroi.atacar();
}
