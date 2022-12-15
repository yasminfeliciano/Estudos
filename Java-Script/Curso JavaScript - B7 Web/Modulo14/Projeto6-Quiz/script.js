//Initial Data
let currentQuestion = 0;
let correctAnswers = 0;

showQuestion();

//Events
document.querySelector('.scoreArea button').addEventListener('click', resetEvent);

//Functions
function showQuestion(){
    if(questions[currentQuestion]){
        let q = questions[currentQuestion];

        let pct = Math.floor((currentQuestion / questions.length) * 100);

        document.querySelector('.progress--bar').style.width = `${pct}%`;

        document.querySelector('.scoreArea').style.display = 'none';
        document.querySelector('.questionArea').style.display = 'block';

        document.querySelector('.question').innerHTML = q.question;
        document.querySelector('.options').innerHTML = '';
        
        //Fazer as questões aparecerem
        //Primeira forma, porém consome mais processamento, mais lento.
        /*
        for(let i in q.options){
           document.querySelector('.options').innerHTML += `<div>${q.options[i]}</div>`;
        }
        */

        //Segunda forma com um único carregamento, mais rápido.
        let optionsHTML = '';
        for(let i in q.options){
            optionsHTML += `<div data-op="${i}" class="option"><span>${[parseInt(i)+1]}</span> ${q.options[i]}</div>`;
        }

        document.querySelector('.options').innerHTML = optionsHTML;

        document.querySelectorAll('.options .option').forEach(item => {
            item.addEventListener('click', optionClickEvent);
        });
    }
    else{
        //acabaram as questões
        finishQuiz();
    }
}

function optionClickEvent(e){
    let clickedOption = parseInt(e.target.getAttribute('data-op'));
    
    if(questions[currentQuestion].answer === clickedOption){
        correctAnswers++;
    }

    currentQuestion++;

    showQuestion();
}

function finishQuiz(){
    let points = Math.floor((correctAnswers / questions.length) * 100);

    if(points<30){
        document.querySelector('.scoreText1').innerHTML = 'Tá ruim hein?!';
        document.querySelector('.scorePct').style.color = "#f00";
    }
    else if(points>=30 && points<70){
        document.querySelector('.scoreText1').innerHTML = 'Muito bom!';
        document.querySelector('.scorePct').style.color = "#ff0";
    }
    else if(points>=70){
        document.querySelector('.scoreText1').innerHTML = 'Parabéns!!!';
        document.querySelector('.scorePct').style.color = "#0d630d";
    }

    document.querySelector('.scorePct').innerHTML = `Acertou ${points}%`;
    document.querySelector('.scoreText2').innerHTML = `Você respondeu ${questions.length} questões e acertou ${correctAnswers}.`;

    document.querySelector('.scoreArea').style.display = 'block';
    document.querySelector('.questionArea').style.display = 'none';
    document.querySelector('.progress--bar').style.width = '100%';
}

function resetEvent(){
    correctAnswers = 0;
    currentQuestion = 0;
    showQuestion();
}