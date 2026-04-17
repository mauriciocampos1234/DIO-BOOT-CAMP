# Lê a linha de entrada e separa os valores
entrada = input().strip().split()
valor_total = float(entrada[0])
percentual_desconto = int(entrada[1])

# TODO: Calcule o valor final do pedido após aplicar o desconto percentual
valor_final = valor_total * (1 - percentual_desconto / 100)

# Imprima o valor final com duas casas decimais
print(f"{valor_final:.2f}")
