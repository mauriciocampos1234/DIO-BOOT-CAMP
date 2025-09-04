import { HardSkills } from "./HardSkills"
import { SoftSkills } from "./SoftSkills"

export function Skills() {
    return (
        <>
            <h3>Hard Skills:</h3>
            <HardSkills /> {/* Chamando a função(Componente) HardSkills e no vscode já importa automaticamente */}
            <h3>Soft Skills:</h3>
            <SoftSkills /> {/* Chamando a função(Componente) SoftSkills e no vscode já importa automaticamente */}  
        </>
    )
}