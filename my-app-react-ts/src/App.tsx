import './App.css'
import Profile from './components/Profile' // Importando o componente Profile de forma padrão
// Se tem mais de um componente dentro do mesmo componente, separar por vírgula dentro da chaves{ }
function App() {

  return (
    <>
      <Profile /> {/* Chamando a função(Componente) Profile */}
    </>
  )
}

export default App


// Importação Padrão
//import './App.css'
//import Profile from './components/Profile' // Importando o função Profile de forma padrão
//function App() {
  // Variáveis de ambiente
  // Mostrar (No inspecionar do console do devtools) variáveis de ambientes só no modo de desenvolvimento)
  // no modo de produção não aparecerá
  /*
  if (import.meta.env.DEV) {
    console.log("MODE:", import.meta.env.MODE); // Modo de execução (desenvolvimento ou produção)
    console.log("BASE_URL:", import.meta.env.BASE_URL); // URL base do projeto
    console.log("PROD:", import.meta.env.PROD); // true se estiver em modo produção
    console.log("DEV:", import.meta.env.DEV); // true se estiver em modo desenvolvimento
    console.log("SSR:", import.meta.env.SSR); // Indica se o aplicativo está rodando no servidor e do lado do cliente
  }
  */

  // Variável de ambiente personalizada
  //console.log(import.meta.env.VITE_API_URL); // Acessando a variável de ambiente personalizada
  //console.log(import.meta.env.DB_PASSWORD); // Acessando a variável de ambiente personalizada

  //return (
//  <>
      //<Profile /> {/* Usando a função Profile */}
    //</>
  //)
//}

//export default App
