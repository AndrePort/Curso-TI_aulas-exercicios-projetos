const escola = "Cod3r"

console.log(escola.charAt(4)) // função que mostra caracter em posicao determinada(4)
console.log(escola.charAt(5)) // msm coisa porem nao havia letra no indece 5
console.log(escola.charCodeAt(3)) // pega o valor da "TABELA ASCII" localizado no indice '3'
console.log(escola.indexOf('3')) // pega o indice

console.log(escola.substring(1)) // pega do indice 1 até  final
console.log(escola.substring(0, 3)) // vai do indice 0 até o 3, mas noa imprime o numero final(3)

console.log('Escola '.concat(escola).concat("!")) // concatena a string "escola" com "!"
console.log('Escola ' + escola + "!")
console.log(escola.replace(3, 'e')) // substitui todos os numeros 3 pela letra "e"

console.log("Ana,Maria,Pedro".split(","))

