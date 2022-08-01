// // Codificação de um sistema de Contagem e classificação.
// A EMPRESA SAVINIS, FOCADA NO DESENVOLVIMENTO DE SOFTWARE DE ALTA PERFORMANCE, CONTRATOU VOCÊ PARA REALIZAR A PROGRAMAÇÃO DE UM SISTEMA DE CONTROLE DE ALUNOS DE UMA ESCOLA. O SISTEMA DEVERÁ FUNCIONAR DA SEGUINTE FORMA:
// CONSIDERE A QUANTIDADE DE ALINOS PRESENTES NA SALA, PERCORRA DO ZERO ATÉ O NÚMERO TOTAL DE ALUNOS E RETORNAR OS SEGUINTES RESULTADOS:

// SE O NÚMERO FOR PAR, ESCREVA "PAR" E O NÚMERO CORRESPONDENTE.
// SE O NÚMERO FOR ÍMPAR, ESCREVA ÍMPAR E O NÚMERO CORRESPONDENTE.
// SE O NÚMERO FOR "ZERO", ESCREVA ZERO E O NÚMERO CORRESPONDENTE.

let numeroDeAlunos = 10;

for(let contador = 0; contador < numeroDeAlunos; contador++){
    console.log(contador)

    if (contador == 0){
        console.log('classificado o zero')
    }
        if(contador % 2 ==0) {
            console.log('numero par')
        }else{
            console.log('numero impar')
        }
}