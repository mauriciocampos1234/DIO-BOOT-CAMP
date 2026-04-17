# Recebe a entrada do usuário (valor e prioridade)
entrada = input().strip()
valor_str, prioridade = entrada.split()
valor = int(valor_str)

# TODO: Implemente a lógica condicional para decidir entre "aprovado", "revisao" ou "rejeitado" conforme as regras do desafio.
if prioridade == "baixa":
    print("rejeitado")
elif prioridade == "alta" and valor > 1000:
    print("revisao")
else:
    print("aprovado")
