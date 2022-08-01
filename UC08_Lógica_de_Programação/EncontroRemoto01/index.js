// informações lançadas
let peso = 120
let listaDePeca = ['bozina','cambio','farol','fuzil','marcha']
let peca = 'anvfdf'


//código da atividade
if(peso > 100) {
    console.log('Peso Cadastrado')
} else{
    console.log('Peso não autorizado')
}

if(listaDePeca.length < 10){
    listaDePeca.push(peca)
    console.log(listaDePeca)
    console.log('Cadastro incluso na lista')
}else{
    console.log('Quantidade de Peça excedida')
}

if(peca.length){
    console.log('Quantidade de caracteres okay')
}else{
    console.log('Quantidade mínima de 3 carateres não atingida')
}