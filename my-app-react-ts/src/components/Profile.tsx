// Criando uma função através da criação de uma constante usando arrow function (Função JS)
// Usamos o React.FC (Function Component do React) para tipar o componente, TypeScript
import { Skills } from './Skills' // Importando o componente Skills (Criada Nomeada) para ter um feedback visual na página
const Profile: React.FC = () => { 
    return ( 
        <> 
            <img
            src="https://avatars.githubusercontent.com/u/156216039?s=400&u=a561cd10419c790fea921ddb891995ef7fac9119&v=4" 
            alt="Foto do Maurício" 
        />
            
            <h3>Maurício Campos</h3> 
            <p><b>Cargo atual: </b>Engenheiro Computacional | Full Stack</p>
            <Skills /> {/* Chamando a função Skills */}
        </>
    )
}

export default Profile; // Aqui chamamos a Exportação Padrão




// Exportação Nomeada dupla, tripla, etc...
//export function Profile() { //TIRAMOS A PALAVRA DEFAULT para se tornar Exportação nomeada e importamos no App.tsx de outro jeito
    //return ( 
        //<> 
            
            //<img 
            //src="https://avatars.githubusercontent.com/u/156216039?s=400&u=a561cd10419c790fea921ddb891995ef7fac9119&v=4" 
            //alt="Foto do Maurício" 
            ///>
            
            //<h3>Maurício Campos</h3> 
            //<p>Engenheiro Computacional | Full Stack</p> 
        //</>
    //)
//}

// Criando outra função chamado JOB (Trabalho)
//export function Job() {
    //return (
        //<>
            //<p>Empresa GFT(Brazil)</p>
        //</>
    //)
//}

//Exportação padrão
/*
export default function Profile() { // Depois de function(Função) o nome tem que ser o mesmo criado do arquivo
    return ( // return(Retorne) com o conteúdo que deve ser renderizado na página(Transformar em representação visual que os (usuários irão ver) o código)
        <> 
            <img src="https://avatars.githubusercontent.com/u/156216039?s=400&u=a561cd10419c790fea921ddb891995ef7fac9119&v=4" alt="Foto do Maurício" />
            <h3>Maurício Campos</h3>
            <p>Engenheiro Computacional | Full Stack</p>
        </>
    )
}
    */
//<div> Quando há mais de um elemento(No exemplo abaixo que foi um img, um h3 e um p), tem que colocar dentro de uma div, 
// mas a div pode atrapalhar na estilização(CSS) da página, então usa-se <> </> (Fragment) 
// que é um elemento vazio que não aparece na página, mas agrupa os elementos filhos

// Agora o React entende que é vários elementos se tornam um só no componente
// Dentro do return só pode ter um elemento pai
// Sempre que criar um novo componente, tem que exportar(Padrão) ele
// Para exportar, tem que colocar export default antes do function
// Para usar o componente em outro arquivo, tem que importar ele
// Para importar, tem que colocar import NomeDoComponente from 'caminho do arquivo'
// Exemplo: import Profile from './components/Profile' (caminho relativo do arquivo)
// Depois é só usar o componente como uma tag HTML: <Profile />
// Obs: O nome do componente tem que começar com letra maiúscula
// Obs: O nome do arquivo tem que ser o mesmo do componente
// Obs: O arquivo tem que ter a extensão .tsx (TypeScript + JSX)
// JSX: JavaScript XML (Sintaxe que permite escrever HTML dentro do JavaScript)
// TSX: TypeScript XML (Sintaxe que permite escrever HTML dentro do TypeScript)
// JSX e TSX são usados para criar componentes em React
