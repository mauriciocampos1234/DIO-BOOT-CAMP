// Atalho para comentar um trecho de código grande: shift + alt + a
// Atalho para desfazer um trecho de código grande: shift + alt + a
// Atalho para comentar uma linha de código: ctrl + /
// Atalho para desfazer o comentário: ctrl + shift + /
// Atalho para formatar o código: ctrl + shift + i


/* Esse trecho de código cria um objeto chamado STATE, que serve como um “centro de controle” para armazenar e organizar todas as informações importantes do jogo. 
Ele está dividido em três partes principais: view, values e actions.

A parte view contém referências para elementos do HTML que são usados na interface do jogo. 
Por exemplo, squares pega todos os elementos com a classe .square (provavelmente as casas do tabuleiro), 
enemy seleciona o inimigo atual, timeLeft mostra o tempo restante e score exibe a pontuação do jogador. 
Isso facilita a atualização visual do jogo, pois basta acessar esses elementos pelo state.

Na parte values, ficam as variáveis que controlam a lógica do jogo. gameVelocity define a velocidade do jogo em milissegundos, 
hitPosition guarda a posição do inimigo que deve ser acertada, result armazena a pontuação atual e curretTime (possível erro de digitação, 
  o correto seria currentTime) representa o tempo restante da partida.

Por fim, a parte actions armazena os identificadores dos intervalos criados com setInterval. timerId chama a função randomSquare a cada segundo para movimentar o inimigo, 
enquanto countDownTimerId chama a função countDown para diminuir o tempo do jogo. Guardar esses IDs permite parar os intervalos quando o jogo termina.

Esse padrão de organização ajuda a manter o código mais limpo e fácil de entender, pois separa claramente o que é visual, o que é lógica e o que são ações temporizadas. */
const state = {
  view: {
    squares: document.querySelectorAll(".square"),
    enemy: document.querySelector(".enemy"),
    timeLeft: document.querySelector("#time-left"),
    score: document.querySelector("#score"),
  },
  values: {
    gameVelocity: 1000,
    hitPosition: 0,
    result: 0,
    curretTime: 60,
  },
  actions: {
    timerId: setInterval(randomSquare, 1000),
    countDownTimerId: setInterval(countDown, 1000),
  },
};

/* A função countDown é responsável por controlar a contagem regressiva do tempo do jogo. 
A cada vez que ela é chamada, o valor de curretTime (tempo restante) dentro do objeto state é decrementado em 1. 
Em seguida, o valor atualizado é exibido na interface do usuário, atualizando o elemento HTML responsável por mostrar o tempo restante.

Se o tempo chegar a zero ou menos, a função executa um bloco condicional. 
Nesse caso, ela para os dois intervalos principais do jogo usando clearInterval: 
um que controla a contagem do tempo (countDownTimerId) e outro que movimenta o inimigo (timerId). 
Por fim, exibe um alerta informando que o jogo acabou e mostra a pontuação final do jogador. 
Essa abordagem garante que o jogo pare automaticamente quando o tempo se esgota, evitando que as funções continuem rodando em segundo plano. */
function countDown() {
  state.values.curretTime--;
  state.view.timeLeft.textContent = state.values.curretTime;

  if (state.values.curretTime <= 0) {
    clearInterval(state.actions.countDownTimerId);
    clearInterval(state.actions.timerId);
    alert("Game Over! O seu resultado foi: " + state.values.result);
  }
}

/* A função playSound é responsável por tocar um efeito sonoro no jogo. Ela recebe como parâmetro o nome do arquivo de áudio (sem a extensão). 
Dentro da função, é criado um novo objeto Audio, utilizando o caminho do arquivo de áudio correspondente na pasta ./src/audios e adicionando a extensão .m4a ao nome recebido.

Em seguida, o volume do áudio é ajustado para 0.2, o que significa que o som será reproduzido em 20% do volume máximo, evitando que fique muito alto para o usuário. 
Por fim, o método play() é chamado para iniciar a reprodução do som. Essa função facilita a inclusão de diferentes efeitos sonoros no jogo, 
bastando informar o nome do arquivo desejado ao chamá-la. */
function playSound(audioName) {
  let audio = new Audio(`./src/audios/${audioName}.m4a`);
  audio.volume = 0.2;
  audio.play();
}

/* A função randomSquare é responsável por movimentar o inimigo aleatoriamente pelo tabuleiro do jogo. 
Primeiro, ela percorre todos os elementos representados por squares e remove a classe "enemy" de cada um, garantindo que nenhum quadrado fique marcado como inimigo 
antes de escolher o novo.

Em seguida, a função gera um número aleatório entre 0 e 8 (assumindo que existem 9 quadrados no total) usando Math.random() e Math.floor(). 
Esse número é usado para selecionar um dos quadrados de forma aleatória. O quadrado escolhido recebe a classe "enemy", tornando-se o novo alvo visível para o jogador.

Por fim, o id do quadrado selecionado é armazenado em state.values.hitPosition. 
Isso permite que o jogo saiba qual quadrado deve ser acertado pelo jogador, facilitando a verificação de acertos e a atualização da pontuação. 
Essa abordagem garante que o inimigo mude de posição de forma imprevisível, tornando o jogo mais dinâmico e desafiador. */
function randomSquare() {
  state.view.squares.forEach((square) => {
    square.classList.remove("enemy");
  });

  let randomNumber = Math.floor(Math.random() * 9);
  let randomSquare = state.view.squares[randomNumber];
  randomSquare.classList.add("enemy");
  state.values.hitPosition = randomSquare.id;
}

/* A função addListenerHitBox adiciona um ouvinte de evento para cada quadrado do tabuleiro do jogo. 
Ela percorre todos os elementos armazenados em state.view.squares e, para cada um, registra um evento do tipo "mousedown" (quando o botão do mouse é pressionado).

Quando o jogador clica em um quadrado, a função verifica se o id desse quadrado corresponde ao valor armazenado em state.values.hitPosition, ou seja, 
se o jogador clicou exatamente no quadrado onde o inimigo está. Se for um acerto, a pontuação (state.values.result) é incrementada em 1, 
e o valor exibido na interface (state.view.score.textContent) é atualizado para refletir a nova pontuação.

Além disso, o hitPosition é definido como null, impedindo que o mesmo clique seja contado mais de uma vez até que o inimigo mude de posição. 
Por fim, a função playSound("hit") é chamada para tocar um efeito sonoro de acerto, tornando a experiência do jogo mais interativa e divertida. */
function addListenerHitBox() {
  state.view.squares.forEach((square) => {
    square.addEventListener("mousedown", () => {
      if (square.id === state.values.hitPosition) {
        state.values.result++;
        state.view.score.textContent = state.values.result;
        state.values.hitPosition = null;
        playSound("hit");
      }
    });
  });
}

/* O trecho apresentado define e executa a função initialize, que serve como ponto de partida para a configuração inicial do jogo. 
Dentro dessa função, é chamada a addListenerHitBox, responsável por adicionar ouvintes de eventos aos quadrados do tabuleiro, 
permitindo que o jogo detecte quando o jogador tenta acertar o inimigo.

Ao chamar initialize() logo após sua definição, o código garante que, assim que o script for carregado, 
todos os quadrados já estarão preparados para responder aos cliques do usuário. Essa abordagem centraliza a inicialização dos componentes essenciais do jogo, 
facilitando a manutenção e possíveis expansões futuras. */
function initialize() {
  addListenerHitBox();
}

initialize();
