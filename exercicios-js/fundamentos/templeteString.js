const nome = 'Rebeca'
const concatenacao = 'Olá' + nome + '!'
const template = `
    Olá
    ${nome}!`
console.log(concatenacao, template)

// espressôes...
console.log(`1 + 1 = ${1 + 1}`) // no template string, vc pode SIMPLIFICAR seu texto
                                // com a Interpolação de Expressões e com as multi-linhas

const up = texto => texto.toUpperCase()
console.log(`Ei... ${up('cuidado')}!`)

