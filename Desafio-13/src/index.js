// Função que calcula o saldo de vitórias e determina o nível
function calcularNivel(vitorias, derrotas) {
    // Calcula o saldo de rankeadas
    let saldoVitorias = vitorias - derrotas;
    
    // Determina o nível com base nas vitórias
    let nivel;
    
    if (vitorias < 10) {
        nivel = "Ferro";
    } else if (vitorias >= 10 && vitorias <= 20) {
        nivel = "Bronze";
    } else if (vitorias >= 21 && vitorias <= 50) {
        nivel = "Prata";
    } else if (vitorias >= 51 && vitorias <= 80) {
        nivel = "Ouro";
    } else if (vitorias >= 81 && vitorias <= 90) {
        nivel = "Diamante";
    } else if (vitorias >= 91 && vitorias <= 100) {
        nivel = "Lendário";
    } else if (vitorias >= 101) {
        nivel = "Imortal";
    }
    
    // Retorna um objeto com o saldo e o nível
    return { saldoVitorias, nivel };
}

// Exemplo de uso
let resultado = calcularNivel(75, 20);
console.log(`O Herói tem de saldo de ${resultado.saldoVitorias} está no nível de ${resultado.nivel}`);

// Testando com outros valores
let resultado2 = calcularNivel(15, 5);
console.log(`O Herói tem de saldo de ${resultado2.saldoVitorias} está no nível de ${resultado2.nivel}`);

let resultado3 = calcularNivel(7, 3);
console.log(`O Herói tem de saldo de ${resultado3.saldoVitorias} está no nível de ${resultado3.nivel}`);