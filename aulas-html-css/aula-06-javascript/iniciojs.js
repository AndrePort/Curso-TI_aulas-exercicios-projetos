//isso é um comentário
/*
*comentário de várias linhas
*/

//declaração de varíaveis
var nome = "André Porto"
//case sensitive = diferencia Maiuscula de Minuscula
console.log("Bem vindo!!! " + nome) // concatenação = junção dos objetos 

console.log("--------------------")
console.log("\nEXEMPLO 01")

var teste = "Será?" // Var variavel global
if(true){
  let teste = "Funcionou" // let variovel de escopo(bloco) só funciona dentro das chaves
  console.log(teste)
}
console.log(teste)

console.log("\n--------------------")
console.log("EXEMPLO 02")
const exemplo2 = 25 // const = constante (valor que nao muda)
console.log(exemplo2 + " - "+typeof(exemplo2))
//exemplo2 = "Ia dar erro"
console.log("\n")
console.log(exemplo2 + " - "+typeof(exemplo2))

if(true){
  const teste2 = "testee"

console.log(teste2)
}