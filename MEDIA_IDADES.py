
soma = 0
quantidade = 0

print("Digite as idades: ")
idade = int(input())

while idade >= 0:
    soma = soma + idade
    quantidade = quantidade + 1
    idade = int(input())

if quantidade < 0 or quantidade == 0:
    print("IMPOSSIVEL CALCULAR")
else:
    media = soma / quantidade
    print(f"MEDIA = {media:.2f}")